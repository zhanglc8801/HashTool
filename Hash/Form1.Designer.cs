namespace Hash
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            Btn_browse = new Button();
            Btn_clear = new Button();
            Btn_copy = new Button();
            Btn_save = new Button();
            Btn_stop = new Button();
            label1 = new Label();
            label2 = new Label();
            progressBar1 = new ProgressBar();
            progressBar2 = new ProgressBar();
            chkBox_fullPath = new CheckBox();
            chkBox_time = new CheckBox();
            chkBox_md5 = new CheckBox();
            chkBox_sha1 = new CheckBox();
            chkBox_sha256 = new CheckBox();
            chkBox_crc32 = new CheckBox();
            chkBox_fileSize = new CheckBox();
            lblStatus = new Label();
            chkBox_uppercase = new CheckBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.AllowDrop = true;
            textBox1.BackColor = SystemColors.Window;
            textBox1.Location = new Point(12, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(926, 450);
            textBox1.TabIndex = 0;
            textBox1.DragDrop += textBox1_DragDrop;
            textBox1.DragEnter += textBox1_DragEnter;
            // 
            // Btn_browse
            // 
            Btn_browse.Location = new Point(12, 475);
            Btn_browse.Name = "Btn_browse";
            Btn_browse.Size = new Size(112, 34);
            Btn_browse.TabIndex = 1;
            Btn_browse.Text = "浏览(&B)";
            Btn_browse.UseVisualStyleBackColor = true;
            Btn_browse.Click += Btn_browse_Click;
            // 
            // Btn_clear
            // 
            Btn_clear.Location = new Point(130, 475);
            Btn_clear.Name = "Btn_clear";
            Btn_clear.Size = new Size(112, 34);
            Btn_clear.TabIndex = 2;
            Btn_clear.Text = "清除(&L)";
            Btn_clear.UseVisualStyleBackColor = true;
            Btn_clear.Click += Btn_clear_Click;
            // 
            // Btn_copy
            // 
            Btn_copy.Location = new Point(248, 475);
            Btn_copy.Name = "Btn_copy";
            Btn_copy.Size = new Size(112, 34);
            Btn_copy.TabIndex = 3;
            Btn_copy.Text = "复制(&C)";
            Btn_copy.UseVisualStyleBackColor = true;
            Btn_copy.Click += Btn_copy_Click;
            // 
            // Btn_save
            // 
            Btn_save.Location = new Point(366, 475);
            Btn_save.Name = "Btn_save";
            Btn_save.Size = new Size(112, 34);
            Btn_save.TabIndex = 4;
            Btn_save.Text = "保存(&S)";
            Btn_save.UseVisualStyleBackColor = true;
            Btn_save.Click += Btn_save_Click;
            // 
            // Btn_stop
            // 
            Btn_stop.Location = new Point(484, 475);
            Btn_stop.Name = "Btn_stop";
            Btn_stop.Size = new Size(112, 34);
            Btn_stop.TabIndex = 5;
            Btn_stop.Text = "停止(&T)";
            Btn_stop.UseVisualStyleBackColor = true;
            Btn_stop.Click += Btn_stop_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 538);
            label1.Name = "label1";
            label1.Size = new Size(64, 24);
            label1.TabIndex = 6;
            label1.Text = "进度：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 566);
            label2.Name = "label2";
            label2.Size = new Size(64, 24);
            label2.TabIndex = 7;
            label2.Text = "完成：";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(73, 542);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(520, 17);
            progressBar1.TabIndex = 8;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(73, 571);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(520, 17);
            progressBar2.TabIndex = 9;
            // 
            // chkBox_fullPath
            // 
            chkBox_fullPath.AutoSize = true;
            chkBox_fullPath.Checked = true;
            chkBox_fullPath.CheckState = CheckState.Checked;
            chkBox_fullPath.Location = new Point(702, 468);
            chkBox_fullPath.Name = "chkBox_fullPath";
            chkBox_fullPath.Size = new Size(108, 28);
            chkBox_fullPath.TabIndex = 10;
            chkBox_fullPath.Text = "完整路径";
            chkBox_fullPath.UseVisualStyleBackColor = true;
            // 
            // chkBox_time
            // 
            chkBox_time.AutoSize = true;
            chkBox_time.Checked = true;
            chkBox_time.CheckState = CheckState.Checked;
            chkBox_time.Location = new Point(702, 501);
            chkBox_time.Name = "chkBox_time";
            chkBox_time.Size = new Size(108, 28);
            chkBox_time.TabIndex = 11;
            chkBox_time.Text = "修改时间";
            chkBox_time.UseVisualStyleBackColor = true;
            // 
            // chkBox_md5
            // 
            chkBox_md5.AutoSize = true;
            chkBox_md5.Checked = true;
            chkBox_md5.CheckState = CheckState.Checked;
            chkBox_md5.Location = new Point(832, 468);
            chkBox_md5.Name = "chkBox_md5";
            chkBox_md5.Size = new Size(79, 28);
            chkBox_md5.TabIndex = 12;
            chkBox_md5.Text = "MD5";
            chkBox_md5.UseVisualStyleBackColor = true;
            // 
            // chkBox_sha1
            // 
            chkBox_sha1.AutoSize = true;
            chkBox_sha1.Checked = true;
            chkBox_sha1.CheckState = CheckState.Checked;
            chkBox_sha1.Location = new Point(832, 502);
            chkBox_sha1.Name = "chkBox_sha1";
            chkBox_sha1.Size = new Size(84, 28);
            chkBox_sha1.TabIndex = 13;
            chkBox_sha1.Text = "SHA1";
            chkBox_sha1.UseVisualStyleBackColor = true;
            // 
            // chkBox_sha256
            // 
            chkBox_sha256.AutoSize = true;
            chkBox_sha256.Checked = true;
            chkBox_sha256.CheckState = CheckState.Checked;
            chkBox_sha256.Location = new Point(832, 536);
            chkBox_sha256.Name = "chkBox_sha256";
            chkBox_sha256.Size = new Size(106, 28);
            chkBox_sha256.TabIndex = 14;
            chkBox_sha256.Text = "SHA256";
            chkBox_sha256.UseVisualStyleBackColor = true;
            // 
            // chkBox_crc32
            // 
            chkBox_crc32.AutoSize = true;
            chkBox_crc32.Checked = true;
            chkBox_crc32.CheckState = CheckState.Checked;
            chkBox_crc32.Location = new Point(832, 570);
            chkBox_crc32.Name = "chkBox_crc32";
            chkBox_crc32.Size = new Size(94, 28);
            chkBox_crc32.TabIndex = 15;
            chkBox_crc32.Text = "CRC32";
            chkBox_crc32.UseVisualStyleBackColor = true;
            // 
            // chkBox_fileSize
            // 
            chkBox_fileSize.AutoSize = true;
            chkBox_fileSize.Checked = true;
            chkBox_fileSize.CheckState = CheckState.Checked;
            chkBox_fileSize.Location = new Point(702, 536);
            chkBox_fileSize.Name = "chkBox_fileSize";
            chkBox_fileSize.Size = new Size(108, 28);
            chkBox_fileSize.TabIndex = 16;
            chkBox_fileSize.Text = "文件大小";
            chkBox_fileSize.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(12, 511);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(85, 24);
            lblStatus.TabIndex = 17;
            lblStatus.Text = "lblStatus";
            // 
            // chkBox_uppercase
            // 
            chkBox_uppercase.AutoSize = true;
            chkBox_uppercase.Checked = true;
            chkBox_uppercase.CheckState = CheckState.Checked;
            chkBox_uppercase.Location = new Point(702, 568);
            chkBox_uppercase.Name = "chkBox_uppercase";
            chkBox_uppercase.Size = new Size(108, 28);
            chkBox_uppercase.TabIndex = 18;
            chkBox_uppercase.Text = "大写显示";
            chkBox_uppercase.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 607);
            Controls.Add(chkBox_uppercase);
            Controls.Add(lblStatus);
            Controls.Add(chkBox_fileSize);
            Controls.Add(chkBox_crc32);
            Controls.Add(chkBox_sha256);
            Controls.Add(chkBox_sha1);
            Controls.Add(chkBox_md5);
            Controls.Add(chkBox_time);
            Controls.Add(chkBox_fullPath);
            Controls.Add(progressBar2);
            Controls.Add(progressBar1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Btn_stop);
            Controls.Add(Btn_save);
            Controls.Add(Btn_copy);
            Controls.Add(Btn_clear);
            Controls.Add(Btn_browse);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hash";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button Btn_browse;
        private Button Btn_clear;
        private Button Btn_copy;
        private Button Btn_save;
        private Button Btn_stop;
        private Label label1;
        private Label label2;
        private ProgressBar progressBar1;
        private ProgressBar progressBar2;
        private CheckBox chkBox_fullPath;
        private CheckBox chkBox_time;
        private CheckBox chkBox_md5;
        private CheckBox chkBox_sha1;
        private CheckBox chkBox_sha256;
        private CheckBox chkBox_crc32;
        private CheckBox chkBox_fileSize;
        private Label lblStatus;
        private CheckBox chkBox_uppercase;
    }
}
