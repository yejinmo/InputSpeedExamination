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
            this.materialProcessBar1 = new Update.MaterialProcessBar();
            this.SuspendLayout();
            // 
            // Label_Tip
            // 
            this.Label_Tip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Tip.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Tip.Location = new System.Drawing.Point(12, 143);
            this.Label_Tip.Name = "Label_Tip";
            this.Label_Tip.Size = new System.Drawing.Size(539, 42);
            this.Label_Tip.TabIndex = 0;
            this.Label_Tip.Text = "检查更新中";
            this.Label_Tip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialProcessBar1
            // 
            this.materialProcessBar1.Depth = 0;
            this.materialProcessBar1.Interval = 10;
            this.materialProcessBar1.IsPercent = false;
            this.materialProcessBar1.LengthValue = 300;
            this.materialProcessBar1.Location = new System.Drawing.Point(12, 130);
            this.materialProcessBar1.Name = "materialProcessBar1";
            this.materialProcessBar1.PercentValue = 0.5D;
            this.materialProcessBar1.Processing = true;
            this.materialProcessBar1.Size = new System.Drawing.Size(539, 5);
            this.materialProcessBar1.StepValue = 7;
            this.materialProcessBar1.TabIndex = 1;
            // 
            // Form_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(563, 194);
            this.Controls.Add(this.materialProcessBar1);
            this.Controls.Add(this.Label_Tip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "检查更新";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_Update_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label_Tip;
        private MaterialProcessBar materialProcessBar1;
    }
}

