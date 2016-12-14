namespace InputSpeedExamination_Controller
{
    partial class Form_UpdateContent
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
            this.Button_Clear = new System.Windows.Forms.Button();
            this.Text_Content = new System.Windows.Forms.TextBox();
            this.Button_Edit = new System.Windows.Forms.Button();
            this.Button_Close = new System.Windows.Forms.Button();
            this.GroupBox_Content = new System.Windows.Forms.GroupBox();
            this.GroupBox_Title = new System.Windows.Forms.GroupBox();
            this.Text_Title = new System.Windows.Forms.TextBox();
            this.GroupBox_Content.SuspendLayout();
            this.GroupBox_Title.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_Clear
            // 
            this.Button_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Clear.Location = new System.Drawing.Point(237, 412);
            this.Button_Clear.Name = "Button_Clear";
            this.Button_Clear.Size = new System.Drawing.Size(180, 37);
            this.Button_Clear.TabIndex = 10;
            this.Button_Clear.Text = "清空";
            this.Button_Clear.UseVisualStyleBackColor = true;
            this.Button_Clear.Click += new System.EventHandler(this.Button_Clear_Click);
            // 
            // Text_Content
            // 
            this.Text_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Text_Content.Location = new System.Drawing.Point(3, 17);
            this.Text_Content.Multiline = true;
            this.Text_Content.Name = "Text_Content";
            this.Text_Content.Size = new System.Drawing.Size(585, 330);
            this.Text_Content.TabIndex = 0;
            this.Text_Content.TextChanged += new System.EventHandler(this.Text_Content_TextChanged);
            // 
            // Button_Edit
            // 
            this.Button_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Edit.Location = new System.Drawing.Point(423, 412);
            this.Button_Edit.Name = "Button_Edit";
            this.Button_Edit.Size = new System.Drawing.Size(180, 37);
            this.Button_Edit.TabIndex = 9;
            this.Button_Edit.Text = "提交";
            this.Button_Edit.UseVisualStyleBackColor = true;
            this.Button_Edit.Click += new System.EventHandler(this.Button_Edit_Click);
            // 
            // Button_Close
            // 
            this.Button_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_Close.Location = new System.Drawing.Point(12, 412);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(180, 37);
            this.Button_Close.TabIndex = 8;
            this.Button_Close.Text = "关闭";
            this.Button_Close.UseVisualStyleBackColor = true;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // GroupBox_Content
            // 
            this.GroupBox_Content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_Content.Controls.Add(this.Text_Content);
            this.GroupBox_Content.Location = new System.Drawing.Point(12, 56);
            this.GroupBox_Content.Name = "GroupBox_Content";
            this.GroupBox_Content.Size = new System.Drawing.Size(591, 350);
            this.GroupBox_Content.TabIndex = 7;
            this.GroupBox_Content.TabStop = false;
            this.GroupBox_Content.Text = "内容";
            // 
            // GroupBox_Title
            // 
            this.GroupBox_Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_Title.Controls.Add(this.Text_Title);
            this.GroupBox_Title.Location = new System.Drawing.Point(12, 12);
            this.GroupBox_Title.Name = "GroupBox_Title";
            this.GroupBox_Title.Size = new System.Drawing.Size(591, 41);
            this.GroupBox_Title.TabIndex = 6;
            this.GroupBox_Title.TabStop = false;
            this.GroupBox_Title.Text = "标题";
            // 
            // Text_Title
            // 
            this.Text_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Text_Title.Location = new System.Drawing.Point(3, 17);
            this.Text_Title.Name = "Text_Title";
            this.Text_Title.Size = new System.Drawing.Size(585, 21);
            this.Text_Title.TabIndex = 0;
            // 
            // Form_UpdateContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 461);
            this.Controls.Add(this.Button_Clear);
            this.Controls.Add(this.Button_Edit);
            this.Controls.Add(this.Button_Close);
            this.Controls.Add(this.GroupBox_Content);
            this.Controls.Add(this.GroupBox_Title);
            this.Name = "Form_UpdateContent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑内容";
            this.Load += new System.EventHandler(this.Form_UpdateContent_Load);
            this.GroupBox_Content.ResumeLayout(false);
            this.GroupBox_Content.PerformLayout();
            this.GroupBox_Title.ResumeLayout(false);
            this.GroupBox_Title.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_Clear;
        private System.Windows.Forms.TextBox Text_Content;
        private System.Windows.Forms.Button Button_Edit;
        private System.Windows.Forms.Button Button_Close;
        private System.Windows.Forms.GroupBox GroupBox_Content;
        private System.Windows.Forms.GroupBox GroupBox_Title;
        private System.Windows.Forms.TextBox Text_Title;
    }
}