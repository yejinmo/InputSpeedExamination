namespace InputSpeedExamination_Controller
{
    partial class Form_Login
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
            this.Text_Username = new System.Windows.Forms.TextBox();
            this.Text_Password = new System.Windows.Forms.TextBox();
            this.Button_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Text_Username
            // 
            this.Text_Username.Location = new System.Drawing.Point(48, 33);
            this.Text_Username.Name = "Text_Username";
            this.Text_Username.Size = new System.Drawing.Size(350, 21);
            this.Text_Username.TabIndex = 0;
            // 
            // Text_Password
            // 
            this.Text_Password.Location = new System.Drawing.Point(48, 72);
            this.Text_Password.Name = "Text_Password";
            this.Text_Password.Size = new System.Drawing.Size(350, 21);
            this.Text_Password.TabIndex = 1;
            this.Text_Password.UseSystemPasswordChar = true;
            // 
            // Button_Login
            // 
            this.Button_Login.Location = new System.Drawing.Point(48, 110);
            this.Button_Login.Name = "Button_Login";
            this.Button_Login.Size = new System.Drawing.Size(350, 44);
            this.Button_Login.TabIndex = 2;
            this.Button_Login.Text = "登录";
            this.Button_Login.UseVisualStyleBackColor = true;
            this.Button_Login.Click += new System.EventHandler(this.Button_Login_Click);
            // 
            // Form_Login
            // 
            this.AcceptButton = this.Button_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 166);
            this.Controls.Add(this.Button_Login);
            this.Controls.Add(this.Text_Password);
            this.Controls.Add(this.Text_Username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "键盘录入管理端";
            this.Load += new System.EventHandler(this.Form_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Text_Username;
        private System.Windows.Forms.TextBox Text_Password;
        private System.Windows.Forms.Button Button_Login;
    }
}