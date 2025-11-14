namespace HashTool
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Btn_browse = new System.Windows.Forms.Button();
            this.Btn_clear = new System.Windows.Forms.Button();
            this.Btn_copy = new System.Windows.Forms.Button();
            this.Btn_save = new System.Windows.Forms.Button();
            this.Btn_stop = new System.Windows.Forms.Button();
            this.chkBox_fullPath = new System.Windows.Forms.CheckBox();
            this.chkBox_time = new System.Windows.Forms.CheckBox();
            this.chkBox_fileSize = new System.Windows.Forms.CheckBox();
            this.chkBox_md5 = new System.Windows.Forms.CheckBox();
            this.chkBox_sha1 = new System.Windows.Forms.CheckBox();
            this.chkBox_sha256 = new System.Windows.Forms.CheckBox();
            this.chkBox_crc32 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(835, 454);
            this.textBox1.TabIndex = 0;
            this.textBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox1_DragDrop);
            this.textBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox1_DragEnter);
            // 
            // Btn_browse
            // 
            this.Btn_browse.Location = new System.Drawing.Point(12, 474);
            this.Btn_browse.Name = "Btn_browse";
            this.Btn_browse.Size = new System.Drawing.Size(87, 35);
            this.Btn_browse.TabIndex = 1;
            this.Btn_browse.Text = "浏览(&B)";
            this.Btn_browse.UseVisualStyleBackColor = true;
            this.Btn_browse.Click += new System.EventHandler(this.Btn_browse_Click);
            // 
            // Btn_clear
            // 
            this.Btn_clear.Location = new System.Drawing.Point(105, 474);
            this.Btn_clear.Name = "Btn_clear";
            this.Btn_clear.Size = new System.Drawing.Size(87, 35);
            this.Btn_clear.TabIndex = 2;
            this.Btn_clear.Text = "清除(&L)";
            this.Btn_clear.UseVisualStyleBackColor = true;
            this.Btn_clear.Click += new System.EventHandler(this.Btn_clear_Click);
            // 
            // Btn_copy
            // 
            this.Btn_copy.Location = new System.Drawing.Point(198, 474);
            this.Btn_copy.Name = "Btn_copy";
            this.Btn_copy.Size = new System.Drawing.Size(87, 35);
            this.Btn_copy.TabIndex = 3;
            this.Btn_copy.Text = "复制(&C)";
            this.Btn_copy.UseVisualStyleBackColor = true;
            this.Btn_copy.Click += new System.EventHandler(this.Btn_copy_Click);
            // 
            // Btn_save
            // 
            this.Btn_save.Location = new System.Drawing.Point(291, 474);
            this.Btn_save.Name = "Btn_save";
            this.Btn_save.Size = new System.Drawing.Size(87, 35);
            this.Btn_save.TabIndex = 4;
            this.Btn_save.Text = "保存(&S)";
            this.Btn_save.UseVisualStyleBackColor = true;
            this.Btn_save.Click += new System.EventHandler(this.Btn_save_Click);
            // 
            // Btn_stop
            // 
            this.Btn_stop.Location = new System.Drawing.Point(384, 474);
            this.Btn_stop.Name = "Btn_stop";
            this.Btn_stop.Size = new System.Drawing.Size(87, 35);
            this.Btn_stop.TabIndex = 5;
            this.Btn_stop.Text = "停止(&T)";
            this.Btn_stop.UseVisualStyleBackColor = true;
            this.Btn_stop.Click += new System.EventHandler(this.Btn_stop_Click);
            // 
            // chkBox_fullPath
            // 
            this.chkBox_fullPath.AutoSize = true;
            this.chkBox_fullPath.Checked = true;
            this.chkBox_fullPath.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBox_fullPath.Location = new System.Drawing.Point(649, 477);
            this.chkBox_fullPath.Name = "chkBox_fullPath";
            this.chkBox_fullPath.Size = new System.Drawing.Size(106, 22);
            this.chkBox_fullPath.TabIndex = 10;
            this.chkBox_fullPath.Text = "完整路径";
            this.chkBox_fullPath.UseVisualStyleBackColor = true;
            // 
            // chkBox_time
            // 
            this.chkBox_time.AutoSize = true;
            this.chkBox_time.Checked = true;
            this.chkBox_time.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBox_time.Location = new System.Drawing.Point(649, 519);
            this.chkBox_time.Name = "chkBox_time";
            this.chkBox_time.Size = new System.Drawing.Size(106, 22);
            this.chkBox_time.TabIndex = 11;
            this.chkBox_time.Text = "修改时间";
            this.chkBox_time.UseVisualStyleBackColor = true;
            // 
            // chkBox_fileSize
            // 
            this.chkBox_fileSize.AutoSize = true;
            this.chkBox_fileSize.Checked = true;
            this.chkBox_fileSize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBox_fileSize.Location = new System.Drawing.Point(649, 563);
            this.chkBox_fileSize.Name = "chkBox_fileSize";
            this.chkBox_fileSize.Size = new System.Drawing.Size(106, 22);
            this.chkBox_fileSize.TabIndex = 12;
            this.chkBox_fileSize.Text = "文件大小";
            this.chkBox_fileSize.UseVisualStyleBackColor = true;
            // 
            // chkBox_md5
            // 
            this.chkBox_md5.AutoSize = true;
            this.chkBox_md5.Checked = true;
            this.chkBox_md5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBox_md5.Location = new System.Drawing.Point(761, 477);
            this.chkBox_md5.Name = "chkBox_md5";
            this.chkBox_md5.Size = new System.Drawing.Size(61, 22);
            this.chkBox_md5.TabIndex = 13;
            this.chkBox_md5.Text = "MD5";
            this.chkBox_md5.UseVisualStyleBackColor = true;
            // 
            // chkBox_sha1
            // 
            this.chkBox_sha1.AutoSize = true;
            this.chkBox_sha1.Checked = true;
            this.chkBox_sha1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBox_sha1.Location = new System.Drawing.Point(761, 505);
            this.chkBox_sha1.Name = "chkBox_sha1";
            this.chkBox_sha1.Size = new System.Drawing.Size(70, 22);
            this.chkBox_sha1.TabIndex = 14;
            this.chkBox_sha1.Text = "SHA1";
            this.chkBox_sha1.UseVisualStyleBackColor = true;
            // 
            // chkBox_sha256
            // 
            this.chkBox_sha256.AutoSize = true;
            this.chkBox_sha256.Checked = true;
            this.chkBox_sha256.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBox_sha256.Location = new System.Drawing.Point(761, 533);
            this.chkBox_sha256.Name = "chkBox_sha256";
            this.chkBox_sha256.Size = new System.Drawing.Size(88, 22);
            this.chkBox_sha256.TabIndex = 15;
            this.chkBox_sha256.Text = "SHA256";
            this.chkBox_sha256.UseVisualStyleBackColor = true;
            // 
            // chkBox_crc32
            // 
            this.chkBox_crc32.AutoSize = true;
            this.chkBox_crc32.Checked = true;
            this.chkBox_crc32.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBox_crc32.Location = new System.Drawing.Point(761, 563);
            this.chkBox_crc32.Name = "chkBox_crc32";
            this.chkBox_crc32.Size = new System.Drawing.Size(79, 22);
            this.chkBox_crc32.TabIndex = 16;
            this.chkBox_crc32.Text = "CRC32";
            this.chkBox_crc32.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 538);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "进度：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 566);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "完成：";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(66, 539);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(567, 18);
            this.progressBar1.TabIndex = 19;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(66, 567);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(567, 18);
            this.progressBar2.TabIndex = 20;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblStatus.Location = new System.Drawing.Point(12, 513);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(89, 18);
            this.lblStatus.TabIndex = 21;
            this.lblStatus.Text = "lblStatus";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 597);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkBox_crc32);
            this.Controls.Add(this.chkBox_sha256);
            this.Controls.Add(this.chkBox_sha1);
            this.Controls.Add(this.chkBox_md5);
            this.Controls.Add(this.chkBox_fileSize);
            this.Controls.Add(this.chkBox_time);
            this.Controls.Add(this.chkBox_fullPath);
            this.Controls.Add(this.Btn_stop);
            this.Controls.Add(this.Btn_save);
            this.Controls.Add(this.Btn_copy);
            this.Controls.Add(this.Btn_clear);
            this.Controls.Add(this.Btn_browse);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HashTool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Btn_browse;
        private System.Windows.Forms.Button Btn_clear;
        private System.Windows.Forms.Button Btn_copy;
        private System.Windows.Forms.Button Btn_save;
        private System.Windows.Forms.Button Btn_stop;
        private System.Windows.Forms.CheckBox chkBox_fullPath;
        private System.Windows.Forms.CheckBox chkBox_time;
        private System.Windows.Forms.CheckBox chkBox_fileSize;
        private System.Windows.Forms.CheckBox chkBox_md5;
        private System.Windows.Forms.CheckBox chkBox_sha1;
        private System.Windows.Forms.CheckBox chkBox_sha256;
        private System.Windows.Forms.CheckBox chkBox_crc32;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label lblStatus;
    }
}

