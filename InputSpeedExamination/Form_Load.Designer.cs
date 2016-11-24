namespace InputSpeedExamination
{
    partial class Form_Load
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.materialProcessBar1 = new MaterialSkin.Controls.MaterialProcessBar();
            this.Label_Tip = new MaterialSkin.Controls.MaterialLabel();
            this.Timer_Show = new System.Windows.Forms.Timer(this.components);
            this.Timer_Close = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // materialProcessBar1
            // 
            this.materialProcessBar1.Depth = 0;
            this.materialProcessBar1.Interval = 10;
            this.materialProcessBar1.LengthValue = 300;
            this.materialProcessBar1.Location = new System.Drawing.Point(12, 60);
            this.materialProcessBar1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProcessBar1.Name = "materialProcessBar1";
            this.materialProcessBar1.Processing = true;
            this.materialProcessBar1.Size = new System.Drawing.Size(630, 5);
            this.materialProcessBar1.StepValue = 7;
            this.materialProcessBar1.TabIndex = 0;
            // 
            // Label_Tip
            // 
            this.Label_Tip.Depth = 0;
            this.Label_Tip.Font = new System.Drawing.Font("微软雅黑", 26F);
            this.Label_Tip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label_Tip.Location = new System.Drawing.Point(12, 9);
            this.Label_Tip.MouseState = MaterialSkin.MouseState.HOVER;
            this.Label_Tip.Name = "Label_Tip";
            this.Label_Tip.Size = new System.Drawing.Size(630, 46);
            this.Label_Tip.TabIndex = 1;
            this.Label_Tip.Text = "正在载入中 请稍等片刻";
            this.Label_Tip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer_Show
            // 
            this.Timer_Show.Interval = 5;
            this.Timer_Show.Tick += new System.EventHandler(this.Timer_Show_Tick);
            // 
            // Timer_Close
            // 
            this.Timer_Close.Interval = 5;
            this.Timer_Close.Tick += new System.EventHandler(this.Timer_Close_Tick);
            // 
            // Form_Load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(654, 74);
            this.ControlBox = false;
            this.Controls.Add(this.Label_Tip);
            this.Controls.Add(this.materialProcessBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Load";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "启动中";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_Load_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialProcessBar materialProcessBar1;
        private MaterialSkin.Controls.MaterialLabel Label_Tip;
        private System.Windows.Forms.Timer Timer_Show;
        private System.Windows.Forms.Timer Timer_Close;
    }
}