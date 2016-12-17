namespace Update
{
    partial class Form_Update
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
            this.Label_Tip = new System.Windows.Forms.Label();
            this.ProcessBar_Update = new Update.MaterialProcessBar();
            this.Label_Retry = new System.Windows.Forms.Label();
            this.Label_Close = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label_Tip
            // 
            this.Label_Tip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Tip.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Tip.Location = new System.Drawing.Point(16, 11);
            this.Label_Tip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Tip.Name = "Label_Tip";
            this.Label_Tip.Size = new System.Drawing.Size(840, 52);
            this.Label_Tip.TabIndex = 0;
            this.Label_Tip.Text = "检查更新中";
            this.Label_Tip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProcessBar_Update
            // 
            this.ProcessBar_Update.Depth = 0;
            this.ProcessBar_Update.Interval = 10;
            this.ProcessBar_Update.IsPercent = false;
            this.ProcessBar_Update.LengthValue = 300;
            this.ProcessBar_Update.Location = new System.Drawing.Point(16, 75);
            this.ProcessBar_Update.Margin = new System.Windows.Forms.Padding(4);
            this.ProcessBar_Update.Name = "ProcessBar_Update";
            this.ProcessBar_Update.PercentValue = 0.5D;
            this.ProcessBar_Update.Processing = true;
            this.ProcessBar_Update.Size = new System.Drawing.Size(840, 5);
            this.ProcessBar_Update.StepValue = 7;
            this.ProcessBar_Update.TabIndex = 1;
            // 
            // Label_Retry
            // 
            this.Label_Retry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Retry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Retry.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Retry.Location = new System.Drawing.Point(16, 11);
            this.Label_Retry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Retry.Name = "Label_Retry";
            this.Label_Retry.Size = new System.Drawing.Size(116, 52);
            this.Label_Retry.TabIndex = 2;
            this.Label_Retry.Text = "重试";
            this.Label_Retry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_Retry.Visible = false;
            this.Label_Retry.Click += new System.EventHandler(this.Label_Retry_Click);
            // 
            // Label_Close
            // 
            this.Label_Close.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Close.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Close.Location = new System.Drawing.Point(743, 11);
            this.Label_Close.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Close.Name = "Label_Close";
            this.Label_Close.Size = new System.Drawing.Size(116, 52);
            this.Label_Close.TabIndex = 3;
            this.Label_Close.Text = "关闭";
            this.Label_Close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_Close.Visible = false;
            this.Label_Close.Click += new System.EventHandler(this.Label_Close_Click);
            // 
            // Form_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(872, 92);
            this.Controls.Add(this.Label_Close);
            this.Controls.Add(this.Label_Retry);
            this.Controls.Add(this.ProcessBar_Update);
            this.Controls.Add(this.Label_Tip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "检查更新";
            this.Load += new System.EventHandler(this.Form_Update_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label_Tip;
        private MaterialProcessBar ProcessBar_Update;
        private System.Windows.Forms.Label Label_Retry;
        private System.Windows.Forms.Label Label_Close;
    }
}

