using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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
            // 如果拖入的是文件/文件夹，允许复制操作
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            var files = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (files == null || files.Length == 0) return;
            ProgressHash(files);
        }

        private void Btn_browse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = "所有文件|*.*";
                openFileDialog.Title = "选择多个文件";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ProgressHash(openFileDialog.FileNames);
                }
            }
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
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
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "文本文件|*.txt|所有文件|*.*";
            sfd.FileName = "Hash.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(sfd.FileName, textBox1.Text);
            }
        }

        private void Btn_stop_Click(object sender, EventArgs e)
        {
            if (cts != null)
            {
                cts.Cancel();
            }
        }

        private async void ProgressHash(string[] files)
        {
            int totalFiles = files.Length;
            progressBar1.Value = 0;
            progressBar2.Value = 0;
            // 创建新的取消 token
            cts = new CancellationTokenSource();
            var token = cts.Token;
            try
            {
                // 主循环：逐个计算文件
                for (int i = 0; i < totalFiles; i++)
                {
                    string file = files[i];
                    lblStatus.Text = $"正在计算：{Path.GetFileName(file)}";
                    // 后台线程中执行多算法计算
                    var result = await Task.Run(() =>
                        ComputeFileHashesWithProgress(file, UpdateFileProgress, token), token
                    );
                    // 输出结果
                    FileInfo fi = new FileInfo(file);
                    long fileSize = fi.Length; // 字节数
                    DateTime lastWriteTime = fi.LastWriteTime; // 最后修改时间
                    if (chkBox_fullPath.Checked)
                        this.textBox1.Text += $"文件：{Path.GetFullPath(file)}\r\n";
                    else
                        this.textBox1.Text += $"文件：{Path.GetFileName(file)}\r\n";
                    if (chkBox_fullPath.Checked)
                        this.textBox1.Text += $"文件大小：{fileSize:N0} 字节 ({fileSize / 1024.0 / 1024.0:F2} MB)\r\n";
                    if (chkBox_time.Checked)
                        this.textBox1.Text += $"最后修改时间：{lastWriteTime:yyyy-MM-dd HH:mm:ss}\r\n";
                    foreach (var kv in result)
                    {
                        this.textBox1.Text += $"{kv.Key}：{kv.Value}\r\n";
                    }
                    this.textBox1.Text += "\r\n";
                    // 更新总体进度
                    int overallPercent = (int)(((i + 1) * 100.0) / totalFiles);
                    UpdateOverallProgress(overallPercent);
                }
                lblStatus.Text = "全部计算完成！";
                progressBar1.Value = 100;
                progressBar2.Value = 100;
            }
            catch (Exception)
            {
                lblStatus.Text = "Hash计算已取消!";
            }
            finally
            {
                //progressBar1.Value = 0;
                cts.Dispose();
                cts = null;
            }
        }

        /// <summary>
        /// 计算文件的多种哈希（MD5 / SHA1 / SHA256 / CRC32）
        /// </summary>
        private Dictionary<string, string> ComputeFileHashesWithProgress(string filePath, Action<int> progressCallback, CancellationToken token)
        {
            const int bufferSize = 1024 * 1024; // 每次读取 1MB
            byte[] buffer = new byte[bufferSize];
            long totalRead = 0;
            long totalLength = new FileInfo(filePath).Length;

            // 初始化哈希算法集合
            var algorithms = new Dictionary<string, HashAlgorithm>
            {
                { "MD5", MD5.Create() },
                { "SHA1", SHA1.Create() },
                { "SHA256", SHA256.Create() }
            };
            if (!chkBox_md5.Checked)
                algorithms.Remove("MD5");
            if (!chkBox_sha1.Checked)
                algorithms.Remove("SHA1");
            if (!chkBox_sha256.Checked)
                algorithms.Remove("SHA256");

            // CRC32 自定义实现
            CRC32 crc32 = new CRC32();

            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                int bytesRead;
                while ((bytesRead = fs.Read(buffer, 0, buffer.Length)) > 0)
                {
                    // 检查是否请求取消
                    token.ThrowIfCancellationRequested();

                    // 更新标准哈希算法
                    foreach (var algo in algorithms.Values)
                        algo.TransformBlock(buffer, 0, bytesRead, null, 0);

                    // 更新 CRC32
                    if (chkBox_crc32.Checked)
                        crc32.Update(buffer, 0, bytesRead);

                    totalRead += bytesRead;
                    int percent = (int)((totalRead * 100) / totalLength);
                    progressCallback?.Invoke(percent);
                }
                // 完成哈希计算
                foreach (var algo in algorithms.Values)
                    algo.TransformFinalBlock(Array.Empty<byte>(), 0, 0);
            }
            // 汇总结果
            var result = new Dictionary<string, string>();
            foreach (var kv in algorithms)
            {
                result[kv.Key] = BitConverter.ToString(kv.Value.Hash).Replace("-", "").ToUpperInvariant();
                kv.Value.Dispose();
            }
            if (chkBox_crc32.Checked)
                result["CRC32"] = crc32.HashString;
            return result;
        }

        /// <summary>
        /// 更新当前文件进度
        /// </summary>
        private void UpdateFileProgress(int percent)
        {
            if (progressBar1.InvokeRequired)
                progressBar1.Invoke(new Action<int>(UpdateFileProgress), percent);
            else
                progressBar1.Value = Math.Min(percent, 100);
        }

        /// <summary>
        /// 更新总体进度
        /// </summary>
        private void UpdateOverallProgress(int percent)
        {
            if (progressBar2.InvokeRequired)
                progressBar2.Invoke(new Action<int>(UpdateOverallProgress), percent);
            else
                progressBar2.Value = Math.Min(percent, 100);
        }

        
    }
}
