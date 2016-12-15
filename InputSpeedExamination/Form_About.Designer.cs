namespace InputSpeedExamination
{
    partial class Form_About
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
            this.Button_Close = new MaterialSkin.Controls.MaterialFlatButton();
            this.Web_Main = new System.Windows.Forms.WebBrowser();
            this.ProcessBar_Load = new MaterialSkin.Controls.MaterialProcessBar();
            this.SuspendLayout();
            // 
            // Button_Close
            // 
            this.Button_Close.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Close.Depth = 0;
            this.Button_Close.Location = new System.Drawing.Point(9, 537);
            this.Button_Close.Margin = new System.Windows.Forms.Padding(0);
            this.Button_Close.MouseState = MaterialSkin.MouseState.HOVER;
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Primary = false;
            this.Button_Close.Size = new System.Drawing.Size(782, 54);
            this.Button_Close.TabIndex = 0;
            this.Button_Close.Text = "关闭";
            this.Button_Close.UseVisualStyleBackColor = true;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // Web_Main
            // 
            this.Web_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Web_Main.Location = new System.Drawing.Point(9, 66);
            this.Web_Main.Margin = new System.Windows.Forms.Padding(0);
            this.Web_Main.MinimumSize = new System.Drawing.Size(20, 20);
            this.Web_Main.Name = "Web_Main";
            this.Web_Main.Size = new System.Drawing.Size(782, 471);
            this.Web_Main.TabIndex = 1;
            this.Web_Main.Visible = false;
            this.Web_Main.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.Web_Main_DocumentCompleted);
            // 
            // ProcessBar_Load
            // 
            this.ProcessBar_Load.Depth = 0;
            this.ProcessBar_Load.Interval = 10;
            this.ProcessBar_Load.LengthValue = 300;
            this.ProcessBar_Load.Location = new System.Drawing.Point(12, 310);
            this.ProcessBar_Load.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProcessBar_Load.Name = "ProcessBar_Load";
            this.ProcessBar_Load.Processing = true;
            this.ProcessBar_Load.Size = new System.Drawing.Size(776, 5);
            this.ProcessBar_Load.StepValue = 7;
            this.ProcessBar_Load.TabIndex = 2;
            // 
            // Form_About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.ProcessBar_Load);
            this.Controls.Add(this.Web_Main);
            this.Controls.Add(this.Button_Close);
            this.Name = "Form_About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "关于";
            this.Load += new System.EventHandler(this.Form_About_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton Button_Close;
        private System.Windows.Forms.WebBrowser Web_Main;
        private MaterialSkin.Controls.MaterialProcessBar ProcessBar_Load;
    }
}