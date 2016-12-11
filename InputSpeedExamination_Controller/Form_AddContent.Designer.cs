namespace InputSpeedExamination_Controller
{
    partial class Form_AddContent
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
            this.Text_Title = new System.Windows.Forms.TextBox();
            this.GroupBox_Title = new System.Windows.Forms.GroupBox();
            this.Text_Content = new System.Windows.Forms.TextBox();
            this.GroupBox_Content = new System.Windows.Forms.GroupBox();
            this.Button_Close = new System.Windows.Forms.Button();
            this.Button_Add = new System.Windows.Forms.Button();
            this.GroupBox_Title.SuspendLayout();
            this.GroupBox_Content.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_Clear
            // 
            this.Button_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Clear.Location = new System.Drawing.Point(316, 515);
            this.Button_Clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button_Clear.Name = "Button_Clear";
            this.Button_Clear.Size = new System.Drawing.Size(240, 46);
            this.Button_Clear.TabIndex = 5;
            this.Button_Clear.Text = "清空";
            this.Button_Clear.UseVisualStyleBackColor = true;
            this.Button_Clear.Click += new System.EventHandler(this.Button_Clear_Click);
            // 
            // Text_Title
            // 
            this.Text_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Text_Title.Location = new System.Drawing.Point(4, 22);
            this.Text_Title.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Text_Title.Name = "Text_Title";
            this.Text_Title.Size = new System.Drawing.Size(780, 25);
            this.Text_Title.TabIndex = 0;
            // 
            // GroupBox_Title
            // 
            this.GroupBox_Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_Title.Controls.Add(this.Text_Title);
            this.GroupBox_Title.Location = new System.Drawing.Point(16, 15);
            this.GroupBox_Title.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox_Title.Name = "GroupBox_Title";
            this.GroupBox_Title.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox_Title.Size = new System.Drawing.Size(788, 51);
            this.GroupBox_Title.TabIndex = 0;
            this.GroupBox_Title.TabStop = false;
            this.GroupBox_Title.Text = "标题";
            // 
            // Text_Content
            // 
            this.Text_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Text_Content.Location = new System.Drawing.Point(4, 22);
            this.Text_Content.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Text_Content.Multiline = true;
            this.Text_Content.Name = "Text_Content";
            this.Text_Content.Size = new System.Drawing.Size(780, 412);
            this.Text_Content.TabIndex = 0;
            // 
            // GroupBox_Content
            // 
            this.GroupBox_Content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_Content.Controls.Add(this.Text_Content);
            this.GroupBox_Content.Location = new System.Drawing.Point(16, 70);
            this.GroupBox_Content.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox_Content.Name = "GroupBox_Content";
            this.GroupBox_Content.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox_Content.Size = new System.Drawing.Size(788, 438);
            this.GroupBox_Content.TabIndex = 1;
            this.GroupBox_Content.TabStop = false;
            this.GroupBox_Content.Text = "内容";
            // 
            // Button_Close
            // 
            this.Button_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_Close.Location = new System.Drawing.Point(16, 515);
            this.Button_Close.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(240, 46);
            this.Button_Close.TabIndex = 3;
            this.Button_Close.Text = "关闭";
            this.Button_Close.UseVisualStyleBackColor = true;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // Button_Add
            // 
            this.Button_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Add.Location = new System.Drawing.Point(564, 515);
            this.Button_Add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(240, 46);
            this.Button_Add.TabIndex = 4;
            this.Button_Add.Text = "添加";
            this.Button_Add.UseVisualStyleBackColor = true;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // Form_AddContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 576);
            this.Controls.Add(this.Button_Clear);
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.Button_Close);
            this.Controls.Add(this.GroupBox_Content);
            this.Controls.Add(this.GroupBox_Title);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_AddContent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加内容";
            this.GroupBox_Title.ResumeLayout(false);
            this.GroupBox_Title.PerformLayout();
            this.GroupBox_Content.ResumeLayout(false);
            this.GroupBox_Content.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_Clear;
        private System.Windows.Forms.TextBox Text_Title;
        private System.Windows.Forms.GroupBox GroupBox_Title;
        private System.Windows.Forms.TextBox Text_Content;
        private System.Windows.Forms.GroupBox GroupBox_Content;
        private System.Windows.Forms.Button Button_Close;
        private System.Windows.Forms.Button Button_Add;
    }
}