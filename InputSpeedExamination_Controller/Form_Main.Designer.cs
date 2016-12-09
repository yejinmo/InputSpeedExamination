namespace InputSpeedExamination_Controller
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
            this.TabControl_Main = new System.Windows.Forms.TabControl();
            this.TabPage_Content = new System.Windows.Forms.TabPage();
            this.TabPage_Batch = new System.Windows.Forms.TabPage();
            this.TabPage_Stats = new System.Windows.Forms.TabPage();
            this.TabControl_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl_Main
            // 
            this.TabControl_Main.Controls.Add(this.TabPage_Content);
            this.TabControl_Main.Controls.Add(this.TabPage_Batch);
            this.TabControl_Main.Controls.Add(this.TabPage_Stats);
            this.TabControl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl_Main.Location = new System.Drawing.Point(0, 0);
            this.TabControl_Main.Name = "TabControl_Main";
            this.TabControl_Main.SelectedIndex = 0;
            this.TabControl_Main.Size = new System.Drawing.Size(944, 633);
            this.TabControl_Main.TabIndex = 0;
            // 
            // TabPage_Content
            // 
            this.TabPage_Content.BackColor = System.Drawing.Color.Transparent;
            this.TabPage_Content.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Content.Name = "TabPage_Content";
            this.TabPage_Content.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Content.Size = new System.Drawing.Size(936, 607);
            this.TabPage_Content.TabIndex = 0;
            this.TabPage_Content.Text = "内容";
            // 
            // TabPage_Batch
            // 
            this.TabPage_Batch.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Batch.Name = "TabPage_Batch";
            this.TabPage_Batch.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Batch.Size = new System.Drawing.Size(936, 607);
            this.TabPage_Batch.TabIndex = 1;
            this.TabPage_Batch.Text = "考场";
            this.TabPage_Batch.UseVisualStyleBackColor = true;
            // 
            // TabPage_Stats
            // 
            this.TabPage_Stats.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Stats.Name = "TabPage_Stats";
            this.TabPage_Stats.Size = new System.Drawing.Size(936, 607);
            this.TabPage_Stats.TabIndex = 2;
            this.TabPage_Stats.Text = "状态";
            this.TabPage_Stats.UseVisualStyleBackColor = true;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 633);
            this.Controls.Add(this.TabControl_Main);
            this.Name = "Form_Main";
            this.Text = "控制端";
            this.TabControl_Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl_Main;
        private System.Windows.Forms.TabPage TabPage_Content;
        private System.Windows.Forms.TabPage TabPage_Batch;
        private System.Windows.Forms.TabPage TabPage_Stats;
    }
}

