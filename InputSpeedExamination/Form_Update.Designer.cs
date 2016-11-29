namespace InputSpeedExamination
{
    partial class Form_Update
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialProcessBar1 = new MaterialSkin.Controls.MaterialProcessBar();
            this.ProgressBar_Download = new MaterialSkin.Controls.MaterialProgressBar();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("微软雅黑", 26F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 73);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(264, 46);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "materialLabel1";
            // 
            // materialProcessBar1
            // 
            this.materialProcessBar1.Depth = 0;
            this.materialProcessBar1.Interval = 10;
            this.materialProcessBar1.LengthValue = 10;
            this.materialProcessBar1.Location = new System.Drawing.Point(12, 122);
            this.materialProcessBar1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProcessBar1.Name = "materialProcessBar1";
            this.materialProcessBar1.Processing = false;
            this.materialProcessBar1.Size = new System.Drawing.Size(612, 5);
            this.materialProcessBar1.StepValue = 5;
            this.materialProcessBar1.TabIndex = 1;
            // 
            // ProgressBar_Download
            // 
            this.ProgressBar_Download.Depth = 0;
            this.ProgressBar_Download.Location = new System.Drawing.Point(12, 199);
            this.ProgressBar_Download.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProgressBar_Download.Name = "ProgressBar_Download";
            this.ProgressBar_Download.Size = new System.Drawing.Size(612, 5);
            this.ProgressBar_Download.TabIndex = 2;
            // 
            // Form_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(636, 418);
            this.Controls.Add(this.ProgressBar_Download);
            this.Controls.Add(this.materialProcessBar1);
            this.Controls.Add(this.materialLabel1);
            this.Name = "Form_Update";
            this.Text = "检查更新";
            this.Load += new System.EventHandler(this.Form_Update_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialProcessBar materialProcessBar1;
        private MaterialSkin.Controls.MaterialProgressBar ProgressBar_Download;
    }
}