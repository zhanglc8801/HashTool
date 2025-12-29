using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HashTool
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource cts = null;

        public Form1()
        {
            InitializeComponent();
            lblStatus.Text = "";
        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private async void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            var files = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (files == null || files.Length == 0) return;
            await ProgressHash(files);
        }

        private async void Btn_browse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = "所有文件|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    await ProgressHash(openFileDialog.FileNames);
                }
            }
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void Btn_copy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                Clipboard.SetText(textBox1.Text);
                lblStatus.Text = "Hash内容已复制到剪贴板中。";
            }
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "文本文件|*.txt|所有文件|*.*",
                FileName = "Hash.txt"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, textBox1.Text);
            }
        }

        private void Btn_stop_Click(object sender, EventArgs e)
        {
            cts?.Cancel();
        }

        private async Task ProgressHash(string[] files)
        {
            int totalFiles = files.Length;
            progressBar1.Value = 0;
            progressBar2.Value = 0;
            cts = new CancellationTokenSource();
            var token = cts.Token;
            try
            {
                for (int i = 0; i < totalFiles; i++)
                {
                    int fileIndex = i;
                    string file = files[i];
                    UpdateFileProgress(0);
                    string fileName = Path.GetFileName(file);
                    if (fileName.Length > 50)
                        fileName = fileName.Substring(0, 50) + "...";
                    lblStatus.Text = $"正在计算：{fileName}";
                    var result = await Task.Run(() =>
                        ComputeFileHashesWithProgress(
                            file,
                            percent =>
                            {
                                UpdateFileProgress(percent);
                                int overallPercent = (int)(((fileIndex + percent / 100.0) / totalFiles) * 100);
                                UpdateOverallProgress(overallPercent);
                            },
                            token
                        ),
                        token
                    );

                    FileInfo fi = new FileInfo(file);

                    if (chkBox_fullPath.Checked)
                        textBox1.Text += $"文件：{fi.FullName}\r\n";
                    else
                        textBox1.Text += $"文件：{fi.Name}\r\n";

                    if (chkBox_fileSize.Checked)
                        textBox1.Text += $"文件大小：{fi.Length:N0} 字节 ({fi.Length / 1024.0 / 1024.0:F2} MB)\r\n";

                    if (chkBox_time.Checked)
                        textBox1.Text += $"最后修改时间：{fi.LastWriteTime:yyyy-MM-dd HH:mm:ss}\r\n";

                    foreach (var kv in result)
                        textBox1.Text += $"{kv.Key}：{kv.Value}\r\n";

                    textBox1.Text += "\r\n";
                    UpdateFileProgress(100);
                }

                lblStatus.Text = "全部计算完成！";
                progressBar1.Value = 100;
                progressBar2.Value = 100;
            }
            catch (OperationCanceledException)
            {
                lblStatus.Text = "Hash计算已取消!";
            }
            finally
            {
                cts.Dispose();
                cts = null;
            }
        }

        private Dictionary<string, string> ComputeFileHashesWithProgress(string filePath,Action<int> progressCallback,CancellationToken token)
        {
            const int bufferSize = 1024 * 1024;
            byte[] buffer = new byte[bufferSize];

            FileInfo fi = new FileInfo(filePath);
            long totalLength = fi.Length;
            long totalRead = 0;

            var algorithms = new Dictionary<string, HashAlgorithm>();

            if (chkBox_md5.Checked) algorithms["MD5"] = MD5.Create();
            if (chkBox_sha1.Checked) algorithms["SHA1"] = SHA1.Create();
            if (chkBox_sha256.Checked) algorithms["SHA256"] = SHA256.Create();

            CRC32 crc32 = new CRC32();

            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                int bytesRead;
                while ((bytesRead = fs.Read(buffer, 0, buffer.Length)) > 0)
                {
                    token.ThrowIfCancellationRequested();

                    foreach (var algo in algorithms.Values)
                        algo.TransformBlock(buffer, 0, bytesRead, null, 0);

                    if (chkBox_crc32.Checked)
                        crc32.Update(buffer, 0, bytesRead);
                    totalRead += bytesRead;
                    int percent = totalLength == 0 ? 100 : (int)((totalRead * 100) / totalLength);
                    progressCallback?.Invoke(percent);
                }

                foreach (var algo in algorithms.Values)
                    algo.TransformFinalBlock(Array.Empty<byte>(), 0, 0);
            }

            var result = new Dictionary<string, string>();

            foreach (var kv in algorithms)
            {
                string hash = BitConverter.ToString(kv.Value.Hash).Replace("-", "");
                result[kv.Key] = chkBox_uppercase.Checked ? hash.ToUpperInvariant(): hash.ToLowerInvariant();
                kv.Value.Dispose();
            }

            if (chkBox_crc32.Checked)
            {
                result["CRC32"] = chkBox_uppercase.Checked ? crc32.HashString.ToUpperInvariant(): crc32.HashString.ToLowerInvariant();
            }
            return result;
        }

        private void UpdateFileProgress(int percent)
        {
            if (progressBar1.InvokeRequired)
                progressBar1.Invoke(new Action<int>(UpdateFileProgress), percent);
            else
                progressBar1.Value = Math.Min(percent, 100);
        }

        private void UpdateOverallProgress(int percent)
        {
            if (progressBar2.InvokeRequired)
                progressBar2.Invoke(new Action<int>(UpdateOverallProgress), percent);
            else
                progressBar2.Value = Math.Min(percent, 100);
        }
    }
}
