namespace InputSpeedExamination
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
            this.TabControl_Main = new MaterialSkin.Controls.MaterialTabControl();
            this.TabPage_Select = new System.Windows.Forms.TabPage();
            this.FlatButton_Select_OnLine = new MaterialSkin.Controls.MaterialFlatButton();
            this.FlatButton_Select_OffLine = new MaterialSkin.Controls.MaterialFlatButton();
            this.WebView_Select_BG = new System.Windows.Forms.WebBrowser();
            this.TabPage_Examination = new System.Windows.Forms.TabPage();
            this.materialSingleLineTextField_Examination5 = new MaterialSkin.Controls.MaterialSingleLineTextField_Examination();
            this.materialLabel_Examination5 = new MaterialSkin.Controls.MaterialLabel_Examination();
            this.materialSingleLineTextField_Examination4 = new MaterialSkin.Controls.MaterialSingleLineTextField_Examination();
            this.materialLabel_Examination4 = new MaterialSkin.Controls.MaterialLabel_Examination();
            this.materialSingleLineTextField_Examination3 = new MaterialSkin.Controls.MaterialSingleLineTextField_Examination();
            this.materialLabel_Examination3 = new MaterialSkin.Controls.MaterialLabel_Examination();
            this.materialSingleLineTextField_Examination2 = new MaterialSkin.Controls.MaterialSingleLineTextField_Examination();
            this.materialLabel_Examination2 = new MaterialSkin.Controls.MaterialLabel_Examination();
            this.materialLabel_Examination1 = new MaterialSkin.Controls.MaterialLabel_Examination();
            this.materialSingleLineTextField_Examination1 = new MaterialSkin.Controls.MaterialSingleLineTextField_Examination();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TabControl_Main.SuspendLayout();
            this.TabPage_Select.SuspendLayout();
            this.TabPage_Examination.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl_Main
            // 
            this.TabControl_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl_Main.Controls.Add(this.TabPage_Select);
            this.TabControl_Main.Controls.Add(this.TabPage_Examination);
            this.TabControl_Main.Depth = 0;
            this.TabControl_Main.Location = new System.Drawing.Point(1, 66);
            this.TabControl_Main.Margin = new System.Windows.Forms.Padding(1);
            this.TabControl_Main.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabControl_Main.Name = "TabControl_Main";
            this.TabControl_Main.SelectedIndex = 0;
            this.TabControl_Main.Size = new System.Drawing.Size(1167, 749);
            this.TabControl_Main.TabIndex = 0;
            // 
            // TabPage_Select
            // 
            this.TabPage_Select.BackColor = System.Drawing.Color.White;
            this.TabPage_Select.Controls.Add(this.FlatButton_Select_OnLine);
            this.TabPage_Select.Controls.Add(this.FlatButton_Select_OffLine);
            this.TabPage_Select.Controls.Add(this.WebView_Select_BG);
            this.TabPage_Select.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Select.Name = "TabPage_Select";
            this.TabPage_Select.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Select.Size = new System.Drawing.Size(1159, 723);
            this.TabPage_Select.TabIndex = 0;
            this.TabPage_Select.Text = "tabPage1";
            // 
            // FlatButton_Select_OnLine
            // 
            this.FlatButton_Select_OnLine.Depth = 0;
            this.FlatButton_Select_OnLine.Location = new System.Drawing.Point(335, 273);
            this.FlatButton_Select_OnLine.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.FlatButton_Select_OnLine.MouseState = MaterialSkin.MouseState.HOVER;
            this.FlatButton_Select_OnLine.Name = "FlatButton_Select_OnLine";
            this.FlatButton_Select_OnLine.Primary = false;
            this.FlatButton_Select_OnLine.Size = new System.Drawing.Size(222, 58);
            this.FlatButton_Select_OnLine.TabIndex = 1;
            this.FlatButton_Select_OnLine.Text = "在线测试模式";
            this.FlatButton_Select_OnLine.UseVisualStyleBackColor = true;
            // 
            // FlatButton_Select_OffLine
            // 
            this.FlatButton_Select_OffLine.Depth = 0;
            this.FlatButton_Select_OffLine.Location = new System.Drawing.Point(335, 162);
            this.FlatButton_Select_OffLine.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.FlatButton_Select_OffLine.MouseState = MaterialSkin.MouseState.HOVER;
            this.FlatButton_Select_OffLine.Name = "FlatButton_Select_OffLine";
            this.FlatButton_Select_OffLine.Primary = false;
            this.FlatButton_Select_OffLine.Size = new System.Drawing.Size(222, 58);
            this.FlatButton_Select_OffLine.TabIndex = 0;
            this.FlatButton_Select_OffLine.Text = "自由练习模式";
            this.FlatButton_Select_OffLine.UseVisualStyleBackColor = true;
            this.FlatButton_Select_OffLine.Click += new System.EventHandler(this.FlatButton_Select_OffLine_Click);
            this.FlatButton_Select_OffLine.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FlatButton_Select_OffLine_MouseMove);
            // 
            // WebView_Select_BG
            // 
            this.WebView_Select_BG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebView_Select_BG.Location = new System.Drawing.Point(3, 3);
            this.WebView_Select_BG.Margin = new System.Windows.Forms.Padding(0);
            this.WebView_Select_BG.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebView_Select_BG.Name = "WebView_Select_BG";
            this.WebView_Select_BG.Size = new System.Drawing.Size(1153, 717);
            this.WebView_Select_BG.TabIndex = 2;
            // 
            // TabPage_Examination
            // 
            this.TabPage_Examination.BackColor = System.Drawing.Color.White;
            this.TabPage_Examination.Controls.Add(this.panel1);
            this.TabPage_Examination.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Examination.Name = "TabPage_Examination";
            this.TabPage_Examination.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Examination.Size = new System.Drawing.Size(1159, 723);
            this.TabPage_Examination.TabIndex = 1;
            this.TabPage_Examination.Text = "tabPage2";
            // 
            // materialSingleLineTextField_Examination5
            // 
            this.materialSingleLineTextField_Examination5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialSingleLineTextField_Examination5.BindingLabel = this.materialLabel_Examination5;
            this.materialSingleLineTextField_Examination5.CorrectForeColor = System.Drawing.Color.Black;
            this.materialSingleLineTextField_Examination5.Depth = 0;
            this.materialSingleLineTextField_Examination5.ErrorForeColor = System.Drawing.Color.Red;
            this.materialSingleLineTextField_Examination5.ErrorModeColor = System.Drawing.Color.Red;
            this.materialSingleLineTextField_Examination5.ErrorModeString = "";
            this.materialSingleLineTextField_Examination5.FollowLabel = null;
            this.materialSingleLineTextField_Examination5.FollowLabelColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialSingleLineTextField_Examination5.FollowLabeloldColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.materialSingleLineTextField_Examination5.ForeColor = System.Drawing.Color.Black;
            this.materialSingleLineTextField_Examination5.Hint = "";
            this.materialSingleLineTextField_Examination5.IsErrorMode = false;
            this.materialSingleLineTextField_Examination5.Location = new System.Drawing.Point(10, 534);
            this.materialSingleLineTextField_Examination5.Margin = new System.Windows.Forms.Padding(2);
            this.materialSingleLineTextField_Examination5.MaxLength = 32767;
            this.materialSingleLineTextField_Examination5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField_Examination5.Name = "materialSingleLineTextField_Examination5";
            this.materialSingleLineTextField_Examination5.PasswordChar = '\0';
            this.materialSingleLineTextField_Examination5.ReadOlay = false;
            this.materialSingleLineTextField_Examination5.SelectedText = "";
            this.materialSingleLineTextField_Examination5.SelectionLength = 0;
            this.materialSingleLineTextField_Examination5.SelectionStart = 0;
            this.materialSingleLineTextField_Examination5.Size = new System.Drawing.Size(1079, 51);
            this.materialSingleLineTextField_Examination5.TabIndex = 9;
            this.materialSingleLineTextField_Examination5.TabStop = false;
            this.materialSingleLineTextField_Examination5.UseSystemPasswordChar = false;
            // 
            // materialLabel_Examination5
            // 
            this.materialLabel_Examination5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel_Examination5.CorrectForeColor = System.Drawing.Color.DimGray;
            this.materialLabel_Examination5.Depth = 0;
            this.materialLabel_Examination5.ErrorForeColor = System.Drawing.Color.Red;
            this.materialLabel_Examination5.Font = new System.Drawing.Font("微软雅黑", 26F);
            this.materialLabel_Examination5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel_Examination5.Location = new System.Drawing.Point(4, 480);
            this.materialLabel_Examination5.Margin = new System.Windows.Forms.Padding(2);
            this.materialLabel_Examination5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel_Examination5.Name = "materialLabel_Examination5";
            this.materialLabel_Examination5.Size = new System.Drawing.Size(1085, 50);
            this.materialLabel_Examination5.TabIndex = 5;
            this.materialLabel_Examination5.TextFieldString = "";
            this.materialLabel_Examination5.TextString = "";
            // 
            // materialSingleLineTextField_Examination4
            // 
            this.materialSingleLineTextField_Examination4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialSingleLineTextField_Examination4.BindingLabel = this.materialLabel_Examination4;
            this.materialSingleLineTextField_Examination4.CorrectForeColor = System.Drawing.Color.Black;
            this.materialSingleLineTextField_Examination4.Depth = 0;
            this.materialSingleLineTextField_Examination4.ErrorForeColor = System.Drawing.Color.Red;
            this.materialSingleLineTextField_Examination4.ErrorModeColor = System.Drawing.Color.Red;
            this.materialSingleLineTextField_Examination4.ErrorModeString = "";
            this.materialSingleLineTextField_Examination4.FollowLabel = null;
            this.materialSingleLineTextField_Examination4.FollowLabelColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialSingleLineTextField_Examination4.FollowLabeloldColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.materialSingleLineTextField_Examination4.ForeColor = System.Drawing.Color.Black;
            this.materialSingleLineTextField_Examination4.Hint = "";
            this.materialSingleLineTextField_Examination4.IsErrorMode = false;
            this.materialSingleLineTextField_Examination4.Location = new System.Drawing.Point(10, 425);
            this.materialSingleLineTextField_Examination4.Margin = new System.Windows.Forms.Padding(2);
            this.materialSingleLineTextField_Examination4.MaxLength = 32767;
            this.materialSingleLineTextField_Examination4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField_Examination4.Name = "materialSingleLineTextField_Examination4";
            this.materialSingleLineTextField_Examination4.PasswordChar = '\0';
            this.materialSingleLineTextField_Examination4.ReadOlay = false;
            this.materialSingleLineTextField_Examination4.SelectedText = "";
            this.materialSingleLineTextField_Examination4.SelectionLength = 0;
            this.materialSingleLineTextField_Examination4.SelectionStart = 0;
            this.materialSingleLineTextField_Examination4.Size = new System.Drawing.Size(1079, 51);
            this.materialSingleLineTextField_Examination4.TabIndex = 8;
            this.materialSingleLineTextField_Examination4.TabStop = false;
            this.materialSingleLineTextField_Examination4.UseSystemPasswordChar = false;
            // 
            // materialLabel_Examination4
            // 
            this.materialLabel_Examination4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel_Examination4.CorrectForeColor = System.Drawing.Color.DimGray;
            this.materialLabel_Examination4.Depth = 0;
            this.materialLabel_Examination4.ErrorForeColor = System.Drawing.Color.Red;
            this.materialLabel_Examination4.Font = new System.Drawing.Font("微软雅黑", 26F);
            this.materialLabel_Examination4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel_Examination4.Location = new System.Drawing.Point(4, 371);
            this.materialLabel_Examination4.Margin = new System.Windows.Forms.Padding(2);
            this.materialLabel_Examination4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel_Examination4.Name = "materialLabel_Examination4";
            this.materialLabel_Examination4.Size = new System.Drawing.Size(1085, 50);
            this.materialLabel_Examination4.TabIndex = 4;
            this.materialLabel_Examination4.TextFieldString = "";
            this.materialLabel_Examination4.TextString = "";
            // 
            // materialSingleLineTextField_Examination3
            // 
            this.materialSingleLineTextField_Examination3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialSingleLineTextField_Examination3.BindingLabel = this.materialLabel_Examination3;
            this.materialSingleLineTextField_Examination3.CorrectForeColor = System.Drawing.Color.Black;
            this.materialSingleLineTextField_Examination3.Depth = 0;
            this.materialSingleLineTextField_Examination3.ErrorForeColor = System.Drawing.Color.Red;
            this.materialSingleLineTextField_Examination3.ErrorModeColor = System.Drawing.Color.Red;
            this.materialSingleLineTextField_Examination3.ErrorModeString = "";
            this.materialSingleLineTextField_Examination3.FollowLabel = null;
            this.materialSingleLineTextField_Examination3.FollowLabelColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialSingleLineTextField_Examination3.FollowLabeloldColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.materialSingleLineTextField_Examination3.ForeColor = System.Drawing.Color.Black;
            this.materialSingleLineTextField_Examination3.Hint = "";
            this.materialSingleLineTextField_Examination3.IsErrorMode = false;
            this.materialSingleLineTextField_Examination3.Location = new System.Drawing.Point(10, 316);
            this.materialSingleLineTextField_Examination3.Margin = new System.Windows.Forms.Padding(2);
            this.materialSingleLineTextField_Examination3.MaxLength = 32767;
            this.materialSingleLineTextField_Examination3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField_Examination3.Name = "materialSingleLineTextField_Examination3";
            this.materialSingleLineTextField_Examination3.PasswordChar = '\0';
            this.materialSingleLineTextField_Examination3.ReadOlay = false;
            this.materialSingleLineTextField_Examination3.SelectedText = "";
            this.materialSingleLineTextField_Examination3.SelectionLength = 0;
            this.materialSingleLineTextField_Examination3.SelectionStart = 0;
            this.materialSingleLineTextField_Examination3.Size = new System.Drawing.Size(1079, 51);
            this.materialSingleLineTextField_Examination3.TabIndex = 7;
            this.materialSingleLineTextField_Examination3.TabStop = false;
            this.materialSingleLineTextField_Examination3.UseSystemPasswordChar = false;
            // 
            // materialLabel_Examination3
            // 
            this.materialLabel_Examination3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel_Examination3.CorrectForeColor = System.Drawing.Color.DimGray;
            this.materialLabel_Examination3.Depth = 0;
            this.materialLabel_Examination3.ErrorForeColor = System.Drawing.Color.Red;
            this.materialLabel_Examination3.Font = new System.Drawing.Font("微软雅黑", 26F);
            this.materialLabel_Examination3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel_Examination3.Location = new System.Drawing.Point(4, 262);
            this.materialLabel_Examination3.Margin = new System.Windows.Forms.Padding(2);
            this.materialLabel_Examination3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel_Examination3.Name = "materialLabel_Examination3";
            this.materialLabel_Examination3.Size = new System.Drawing.Size(1085, 50);
            this.materialLabel_Examination3.TabIndex = 3;
            this.materialLabel_Examination3.TextFieldString = "";
            this.materialLabel_Examination3.TextString = "";
            // 
            // materialSingleLineTextField_Examination2
            // 
            this.materialSingleLineTextField_Examination2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialSingleLineTextField_Examination2.BindingLabel = this.materialLabel_Examination2;
            this.materialSingleLineTextField_Examination2.CorrectForeColor = System.Drawing.Color.Black;
            this.materialSingleLineTextField_Examination2.Depth = 0;
            this.materialSingleLineTextField_Examination2.ErrorForeColor = System.Drawing.Color.Red;
            this.materialSingleLineTextField_Examination2.ErrorModeColor = System.Drawing.Color.Red;
            this.materialSingleLineTextField_Examination2.ErrorModeString = "";
            this.materialSingleLineTextField_Examination2.FollowLabel = null;
            this.materialSingleLineTextField_Examination2.FollowLabelColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialSingleLineTextField_Examination2.FollowLabeloldColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.materialSingleLineTextField_Examination2.ForeColor = System.Drawing.Color.Black;
            this.materialSingleLineTextField_Examination2.Hint = "";
            this.materialSingleLineTextField_Examination2.IsErrorMode = false;
            this.materialSingleLineTextField_Examination2.Location = new System.Drawing.Point(10, 207);
            this.materialSingleLineTextField_Examination2.Margin = new System.Windows.Forms.Padding(2);
            this.materialSingleLineTextField_Examination2.MaxLength = 32767;
            this.materialSingleLineTextField_Examination2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField_Examination2.Name = "materialSingleLineTextField_Examination2";
            this.materialSingleLineTextField_Examination2.PasswordChar = '\0';
            this.materialSingleLineTextField_Examination2.ReadOlay = false;
            this.materialSingleLineTextField_Examination2.SelectedText = "";
            this.materialSingleLineTextField_Examination2.SelectionLength = 0;
            this.materialSingleLineTextField_Examination2.SelectionStart = 0;
            this.materialSingleLineTextField_Examination2.Size = new System.Drawing.Size(1079, 51);
            this.materialSingleLineTextField_Examination2.TabIndex = 6;
            this.materialSingleLineTextField_Examination2.TabStop = false;
            this.materialSingleLineTextField_Examination2.UseSystemPasswordChar = false;
            // 
            // materialLabel_Examination2
            // 
            this.materialLabel_Examination2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel_Examination2.CorrectForeColor = System.Drawing.Color.DimGray;
            this.materialLabel_Examination2.Depth = 0;
            this.materialLabel_Examination2.ErrorForeColor = System.Drawing.Color.Red;
            this.materialLabel_Examination2.Font = new System.Drawing.Font("微软雅黑", 26F);
            this.materialLabel_Examination2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel_Examination2.Location = new System.Drawing.Point(4, 153);
            this.materialLabel_Examination2.Margin = new System.Windows.Forms.Padding(2);
            this.materialLabel_Examination2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel_Examination2.Name = "materialLabel_Examination2";
            this.materialLabel_Examination2.Size = new System.Drawing.Size(1085, 50);
            this.materialLabel_Examination2.TabIndex = 2;
            this.materialLabel_Examination2.TextFieldString = "";
            this.materialLabel_Examination2.TextString = "";
            // 
            // materialLabel_Examination1
            // 
            this.materialLabel_Examination1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel_Examination1.CorrectForeColor = System.Drawing.Color.DimGray;
            this.materialLabel_Examination1.Depth = 0;
            this.materialLabel_Examination1.ErrorForeColor = System.Drawing.Color.Red;
            this.materialLabel_Examination1.Font = new System.Drawing.Font("微软雅黑", 26F);
            this.materialLabel_Examination1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel_Examination1.Location = new System.Drawing.Point(4, 44);
            this.materialLabel_Examination1.Margin = new System.Windows.Forms.Padding(2);
            this.materialLabel_Examination1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel_Examination1.Name = "materialLabel_Examination1";
            this.materialLabel_Examination1.Size = new System.Drawing.Size(1085, 50);
            this.materialLabel_Examination1.TabIndex = 1;
            this.materialLabel_Examination1.TextFieldString = "";
            this.materialLabel_Examination1.TextString = "123   一二三abc   ";
            // 
            // materialSingleLineTextField_Examination1
            // 
            this.materialSingleLineTextField_Examination1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialSingleLineTextField_Examination1.BindingLabel = this.materialLabel_Examination1;
            this.materialSingleLineTextField_Examination1.CorrectForeColor = System.Drawing.Color.Black;
            this.materialSingleLineTextField_Examination1.Depth = 0;
            this.materialSingleLineTextField_Examination1.ErrorForeColor = System.Drawing.Color.Red;
            this.materialSingleLineTextField_Examination1.ErrorModeColor = System.Drawing.Color.Red;
            this.materialSingleLineTextField_Examination1.ErrorModeString = "";
            this.materialSingleLineTextField_Examination1.FollowLabel = null;
            this.materialSingleLineTextField_Examination1.FollowLabelColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialSingleLineTextField_Examination1.FollowLabeloldColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.materialSingleLineTextField_Examination1.ForeColor = System.Drawing.Color.Black;
            this.materialSingleLineTextField_Examination1.Hint = "";
            this.materialSingleLineTextField_Examination1.IsErrorMode = false;
            this.materialSingleLineTextField_Examination1.Location = new System.Drawing.Point(10, 98);
            this.materialSingleLineTextField_Examination1.Margin = new System.Windows.Forms.Padding(2);
            this.materialSingleLineTextField_Examination1.MaxLength = 0;
            this.materialSingleLineTextField_Examination1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField_Examination1.Name = "materialSingleLineTextField_Examination1";
            this.materialSingleLineTextField_Examination1.PasswordChar = '\0';
            this.materialSingleLineTextField_Examination1.ReadOlay = false;
            this.materialSingleLineTextField_Examination1.SelectedText = "";
            this.materialSingleLineTextField_Examination1.SelectionLength = 0;
            this.materialSingleLineTextField_Examination1.SelectionStart = 0;
            this.materialSingleLineTextField_Examination1.Size = new System.Drawing.Size(1079, 51);
            this.materialSingleLineTextField_Examination1.TabIndex = 0;
            this.materialSingleLineTextField_Examination1.TabStop = false;
            this.materialSingleLineTextField_Examination1.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.materialLabel_Examination1);
            this.panel1.Controls.Add(this.materialSingleLineTextField_Examination5);
            this.panel1.Controls.Add(this.materialSingleLineTextField_Examination1);
            this.panel1.Controls.Add(this.materialSingleLineTextField_Examination4);
            this.panel1.Controls.Add(this.materialLabel_Examination2);
            this.panel1.Controls.Add(this.materialSingleLineTextField_Examination3);
            this.panel1.Controls.Add(this.materialLabel_Examination3);
            this.panel1.Controls.Add(this.materialSingleLineTextField_Examination2);
            this.panel1.Controls.Add(this.materialLabel_Examination4);
            this.panel1.Controls.Add(this.materialLabel_Examination5);
            this.panel1.Location = new System.Drawing.Point(34, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1091, 655);
            this.panel1.TabIndex = 10;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 816);
            this.Controls.Add(this.TabControl_Main);
            this.MinimumSize = new System.Drawing.Size(600, 480);
            this.Name = "Form_Main";
            this.Text = "键盘录入测试";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.ResizeBegin += new System.EventHandler(this.Form_Main_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.Form_Main_ResizeEnd);
            this.Resize += new System.EventHandler(this.Form_Main_Resize);
            this.TabControl_Main.ResumeLayout(false);
            this.TabPage_Select.ResumeLayout(false);
            this.TabPage_Examination.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl TabControl_Main;
        private System.Windows.Forms.TabPage TabPage_Select;
        private System.Windows.Forms.TabPage TabPage_Examination;
        private MaterialSkin.Controls.MaterialFlatButton FlatButton_Select_OffLine;
        private MaterialSkin.Controls.MaterialFlatButton FlatButton_Select_OnLine;
        private System.Windows.Forms.WebBrowser WebView_Select_BG;
        private MaterialSkin.Controls.MaterialLabel_Examination materialLabel_Examination1;
        private MaterialSkin.Controls.MaterialSingleLineTextField_Examination materialSingleLineTextField_Examination1;
        private MaterialSkin.Controls.MaterialLabel_Examination materialLabel_Examination5;
        private MaterialSkin.Controls.MaterialLabel_Examination materialLabel_Examination4;
        private MaterialSkin.Controls.MaterialLabel_Examination materialLabel_Examination3;
        private MaterialSkin.Controls.MaterialLabel_Examination materialLabel_Examination2;
        private MaterialSkin.Controls.MaterialSingleLineTextField_Examination materialSingleLineTextField_Examination5;
        private MaterialSkin.Controls.MaterialSingleLineTextField_Examination materialSingleLineTextField_Examination4;
        private MaterialSkin.Controls.MaterialSingleLineTextField_Examination materialSingleLineTextField_Examination3;
        private MaterialSkin.Controls.MaterialSingleLineTextField_Examination materialSingleLineTextField_Examination2;
        private System.Windows.Forms.Panel panel1;
    }
}

