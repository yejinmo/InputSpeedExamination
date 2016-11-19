namespace InputSpeedExamination_Server
{
    partial class Form_Main
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
            this.GroupBoxCount = new System.Windows.Forms.GroupBox();
            this.TextCount = new System.Windows.Forms.TextBox();
            this.ButtonStop = new System.Windows.Forms.Button();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.GroupBoxPort = new System.Windows.Forms.GroupBox();
            this.TextPort = new System.Windows.Forms.TextBox();
            this.GroupBoxIP = new System.Windows.Forms.GroupBox();
            this.TextIP = new System.Windows.Forms.TextBox();
            this.GroupBoxMain = new System.Windows.Forms.GroupBox();
            this.TextMain = new System.Windows.Forms.TextBox();
            this.GroupBoxCount.SuspendLayout();
            this.GroupBoxPort.SuspendLayout();
            this.GroupBoxIP.SuspendLayout();
            this.GroupBoxMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxCount
            // 
            this.GroupBoxCount.Controls.Add(this.TextCount);
            this.GroupBoxCount.Location = new System.Drawing.Point(551, 10);
            this.GroupBoxCount.Name = "GroupBoxCount";
            this.GroupBoxCount.Size = new System.Drawing.Size(105, 43);
            this.GroupBoxCount.TabIndex = 11;
            this.GroupBoxCount.TabStop = false;
            this.GroupBoxCount.Text = "当前连接数";
            // 
            // TextCount
            // 
            this.TextCount.Location = new System.Drawing.Point(0, 20);
            this.TextCount.Name = "TextCount";
            this.TextCount.ReadOnly = true;
            this.TextCount.Size = new System.Drawing.Size(105, 21);
            this.TextCount.TabIndex = 0;
            // 
            // ButtonStop
            // 
            this.ButtonStop.Enabled = false;
            this.ButtonStop.Location = new System.Drawing.Point(440, 10);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Size = new System.Drawing.Size(105, 43);
            this.ButtonStop.TabIndex = 10;
            this.ButtonStop.Text = "停止监听";
            this.ButtonStop.UseVisualStyleBackColor = true;
            // 
            // ButtonStart
            // 
            this.ButtonStart.Enabled = false;
            this.ButtonStart.Location = new System.Drawing.Point(329, 10);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(105, 43);
            this.ButtonStart.TabIndex = 9;
            this.ButtonStart.Text = "开始监听";
            this.ButtonStart.UseVisualStyleBackColor = true;
            // 
            // GroupBoxPort
            // 
            this.GroupBoxPort.Controls.Add(this.TextPort);
            this.GroupBoxPort.Location = new System.Drawing.Point(218, 12);
            this.GroupBoxPort.Name = "GroupBoxPort";
            this.GroupBoxPort.Size = new System.Drawing.Size(105, 43);
            this.GroupBoxPort.TabIndex = 8;
            this.GroupBoxPort.TabStop = false;
            this.GroupBoxPort.Text = "监听端口";
            // 
            // TextPort
            // 
            this.TextPort.Location = new System.Drawing.Point(0, 20);
            this.TextPort.Name = "TextPort";
            this.TextPort.Size = new System.Drawing.Size(105, 21);
            this.TextPort.TabIndex = 0;
            this.TextPort.Text = "3213";
            // 
            // GroupBoxIP
            // 
            this.GroupBoxIP.Controls.Add(this.TextIP);
            this.GroupBoxIP.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxIP.Name = "GroupBoxIP";
            this.GroupBoxIP.Size = new System.Drawing.Size(200, 43);
            this.GroupBoxIP.TabIndex = 7;
            this.GroupBoxIP.TabStop = false;
            this.GroupBoxIP.Text = "监听地址";
            // 
            // TextIP
            // 
            this.TextIP.Location = new System.Drawing.Point(0, 20);
            this.TextIP.Name = "TextIP";
            this.TextIP.Size = new System.Drawing.Size(200, 21);
            this.TextIP.TabIndex = 0;
            this.TextIP.Text = "127.0.0.1";
            // 
            // GroupBoxMain
            // 
            this.GroupBoxMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxMain.Controls.Add(this.TextMain);
            this.GroupBoxMain.Location = new System.Drawing.Point(11, 59);
            this.GroupBoxMain.Name = "GroupBoxMain";
            this.GroupBoxMain.Size = new System.Drawing.Size(837, 430);
            this.GroupBoxMain.TabIndex = 6;
            this.GroupBoxMain.TabStop = false;
            this.GroupBoxMain.Text = "状态信息";
            // 
            // TextMain
            // 
            this.TextMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextMain.Location = new System.Drawing.Point(2, 14);
            this.TextMain.Multiline = true;
            this.TextMain.Name = "TextMain";
            this.TextMain.ReadOnly = true;
            this.TextMain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextMain.Size = new System.Drawing.Size(836, 410);
            this.TextMain.TabIndex = 0;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 501);
            this.Controls.Add(this.GroupBoxCount);
            this.Controls.Add(this.ButtonStop);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.GroupBoxPort);
            this.Controls.Add(this.GroupBoxIP);
            this.Controls.Add(this.GroupBoxMain);
            this.Name = "Form_Main";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.GroupBoxCount.ResumeLayout(false);
            this.GroupBoxCount.PerformLayout();
            this.GroupBoxPort.ResumeLayout(false);
            this.GroupBoxPort.PerformLayout();
            this.GroupBoxIP.ResumeLayout(false);
            this.GroupBoxIP.PerformLayout();
            this.GroupBoxMain.ResumeLayout(false);
            this.GroupBoxMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxCount;
        private System.Windows.Forms.TextBox TextCount;
        private System.Windows.Forms.Button ButtonStop;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.GroupBox GroupBoxPort;
        private System.Windows.Forms.TextBox TextPort;
        private System.Windows.Forms.GroupBox GroupBoxIP;
        private System.Windows.Forms.TextBox TextIP;
        private System.Windows.Forms.GroupBox GroupBoxMain;
        private System.Windows.Forms.TextBox TextMain;
    }
}

