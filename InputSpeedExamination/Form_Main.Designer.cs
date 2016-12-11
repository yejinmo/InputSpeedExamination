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
            this.components = new System.ComponentModel.Container();
            this.TabControl_Main = new MaterialSkin.Controls.MaterialTabControl();
            this.TabPage_Select = new System.Windows.Forms.TabPage();
            this.Panel_Login = new System.Windows.Forms.Panel();
            this.ProcessBar_Login = new MaterialSkin.Controls.MaterialProcessBar();
            this.Label_Login_Tip = new System.Windows.Forms.Label();
            this.TextField_PassWord = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TextField_UserName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.FlatButton_Select_Login = new MaterialSkin.Controls.MaterialFlatButton();
            this.FlatButton_Select_OffLine = new MaterialSkin.Controls.MaterialFlatButton();
            this.WebView_Select_BG = new System.Windows.Forms.WebBrowser();
            this.TabPage_Examination = new System.Windows.Forms.TabPage();
            this.Panel_Input_Main = new System.Windows.Forms.Panel();
            this.Button_Back = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Button_Pause_Continue = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Label_Stats_Time = new MaterialSkin.Controls.MaterialLabel();
            this.Button_Next_Page = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Button_Previous_Page = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Examination_Lable_1 = new MaterialSkin.Controls.MaterialLabel_Examination();
            this.Examination_TextLine_5 = new MaterialSkin.Controls.MaterialSingleLineTextField_Examination();
            this.Examination_Lable_5 = new MaterialSkin.Controls.MaterialLabel_Examination();
            this.Examination_TextLine_1 = new MaterialSkin.Controls.MaterialSingleLineTextField_Examination();
            this.Examination_TextLine_4 = new MaterialSkin.Controls.MaterialSingleLineTextField_Examination();
            this.Examination_Lable_4 = new MaterialSkin.Controls.MaterialLabel_Examination();
            this.Examination_Lable_2 = new MaterialSkin.Controls.MaterialLabel_Examination();
            this.Examination_TextLine_3 = new MaterialSkin.Controls.MaterialSingleLineTextField_Examination();
            this.Examination_Lable_3 = new MaterialSkin.Controls.MaterialLabel_Examination();
            this.Examination_TextLine_2 = new MaterialSkin.Controls.MaterialSingleLineTextField_Examination();
            this.TabPage_Start = new System.Windows.Forms.TabPage();
            this.Panel_Start = new System.Windows.Forms.Panel();
            this.ProcessBar_Start = new MaterialSkin.Controls.MaterialProcessBar();
            this.Button_Start = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TabPage_SelectText = new System.Windows.Forms.TabPage();
            this.Button_SelectText_Import = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Button_SelectText_Begin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Button_SelectText_Return = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Text_SearchExamination = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ListView_ExaminationList = new MaterialSkin.Controls.MaterialListView();
            this.ColumnHeader_ExaminationList_Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader_ExaminationList_Length = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader_ExaminationList_Preview = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader_ExaminationList_MD5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProcessBar_SearchExamination = new MaterialSkin.Controls.MaterialProcessBar();
            this.TabPage_Result = new System.Windows.Forms.TabPage();
            this.Timer_Clocks = new System.Windows.Forms.Timer(this.components);
            this.Timer_SearchExamination = new System.Windows.Forms.Timer(this.components);
            this.Label_UserName = new System.Windows.Forms.Label();
            this.LinkLabel_LoginOrOut = new System.Windows.Forms.LinkLabel();
            this.Timer_UpdateStats = new System.Windows.Forms.Timer(this.components);
            this.TabPage_Main = new System.Windows.Forms.TabPage();
            this.PictureBox_UserImage = new System.Windows.Forms.PictureBox();
            this.Label_Main_Welcome = new MaterialSkin.Controls.MaterialLabel();
            this.Label_Main_Department = new MaterialSkin.Controls.MaterialLabel();
            this.Label_Main_Major = new MaterialSkin.Controls.MaterialLabel();
            this.Label_Main_Class = new MaterialSkin.Controls.MaterialLabel();
            this.TabControl_Main.SuspendLayout();
            this.TabPage_Select.SuspendLayout();
            this.Panel_Login.SuspendLayout();
            this.TabPage_Examination.SuspendLayout();
            this.Panel_Input_Main.SuspendLayout();
            this.TabPage_Start.SuspendLayout();
            this.Panel_Start.SuspendLayout();
            this.TabPage_SelectText.SuspendLayout();
            this.TabPage_Result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_UserImage)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl_Main
            // 
            this.TabControl_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl_Main.Controls.Add(this.TabPage_Select);
            this.TabControl_Main.Controls.Add(this.TabPage_Examination);
            this.TabControl_Main.Controls.Add(this.TabPage_Start);
            this.TabControl_Main.Controls.Add(this.TabPage_SelectText);
            this.TabControl_Main.Controls.Add(this.TabPage_Result);
            this.TabControl_Main.Controls.Add(this.TabPage_Main);
            this.TabControl_Main.Depth = 0;
            this.TabControl_Main.Location = new System.Drawing.Point(1, 66);
            this.TabControl_Main.Margin = new System.Windows.Forms.Padding(1);
            this.TabControl_Main.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabControl_Main.Name = "TabControl_Main";
            this.TabControl_Main.SelectedIndex = 0;
            this.TabControl_Main.Size = new System.Drawing.Size(1213, 713);
            this.TabControl_Main.TabIndex = 0;
            // 
            // TabPage_Select
            // 
            this.TabPage_Select.BackColor = System.Drawing.Color.White;
            this.TabPage_Select.Controls.Add(this.Panel_Login);
            this.TabPage_Select.Controls.Add(this.WebView_Select_BG);
            this.TabPage_Select.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Select.Name = "TabPage_Select";
            this.TabPage_Select.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Select.Size = new System.Drawing.Size(1205, 687);
            this.TabPage_Select.TabIndex = 0;
            this.TabPage_Select.Text = "tabPage1";
            // 
            // Panel_Login
            // 
            this.Panel_Login.BackColor = System.Drawing.Color.White;
            this.Panel_Login.Controls.Add(this.ProcessBar_Login);
            this.Panel_Login.Controls.Add(this.Label_Login_Tip);
            this.Panel_Login.Controls.Add(this.TextField_PassWord);
            this.Panel_Login.Controls.Add(this.TextField_UserName);
            this.Panel_Login.Controls.Add(this.FlatButton_Select_Login);
            this.Panel_Login.Controls.Add(this.FlatButton_Select_OffLine);
            this.Panel_Login.Location = new System.Drawing.Point(375, 129);
            this.Panel_Login.Name = "Panel_Login";
            this.Panel_Login.Size = new System.Drawing.Size(400, 204);
            this.Panel_Login.TabIndex = 3;
            // 
            // ProcessBar_Login
            // 
            this.ProcessBar_Login.Depth = 0;
            this.ProcessBar_Login.Interval = 15;
            this.ProcessBar_Login.LengthValue = 200;
            this.ProcessBar_Login.Location = new System.Drawing.Point(5, 126);
            this.ProcessBar_Login.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProcessBar_Login.Name = "ProcessBar_Login";
            this.ProcessBar_Login.Processing = true;
            this.ProcessBar_Login.Size = new System.Drawing.Size(392, 5);
            this.ProcessBar_Login.StepValue = 10;
            this.ProcessBar_Login.TabIndex = 7;
            this.ProcessBar_Login.Visible = false;
            // 
            // Label_Login_Tip
            // 
            this.Label_Login_Tip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Login_Tip.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Login_Tip.ForeColor = System.Drawing.Color.Black;
            this.Label_Login_Tip.Location = new System.Drawing.Point(3, 3);
            this.Label_Login_Tip.Margin = new System.Windows.Forms.Padding(3);
            this.Label_Login_Tip.Name = "Label_Login_Tip";
            this.Label_Login_Tip.Size = new System.Drawing.Size(394, 31);
            this.Label_Login_Tip.TabIndex = 6;
            this.Label_Login_Tip.Text = "使用教务系统账号登录";
            this.Label_Login_Tip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextField_PassWord
            // 
            this.TextField_PassWord.Depth = 0;
            this.TextField_PassWord.ErrorModeColor = System.Drawing.Color.Red;
            this.TextField_PassWord.ErrorModeString = "";
            this.TextField_PassWord.FollowLabel = null;
            this.TextField_PassWord.FollowLabelColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextField_PassWord.FollowLabeloldColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.TextField_PassWord.ForeColor = System.Drawing.Color.Black;
            this.TextField_PassWord.Hint = "密码";
            this.TextField_PassWord.IsErrorMode = false;
            this.TextField_PassWord.Location = new System.Drawing.Point(5, 83);
            this.TextField_PassWord.MaxLength = 32767;
            this.TextField_PassWord.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextField_PassWord.Name = "TextField_PassWord";
            this.TextField_PassWord.PasswordChar = '\0';
            this.TextField_PassWord.ReadOlay = false;
            this.TextField_PassWord.SelectedText = "";
            this.TextField_PassWord.SelectionLength = 0;
            this.TextField_PassWord.SelectionStart = 0;
            this.TextField_PassWord.Size = new System.Drawing.Size(392, 37);
            this.TextField_PassWord.TabIndex = 5;
            this.TextField_PassWord.TabStop = false;
            this.TextField_PassWord.UseSystemPasswordChar = true;
            this.TextField_PassWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextField_PassWord_KeyDown);
            // 
            // TextField_UserName
            // 
            this.TextField_UserName.Depth = 0;
            this.TextField_UserName.ErrorModeColor = System.Drawing.Color.Red;
            this.TextField_UserName.ErrorModeString = "";
            this.TextField_UserName.FollowLabel = null;
            this.TextField_UserName.FollowLabelColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextField_UserName.FollowLabeloldColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.TextField_UserName.ForeColor = System.Drawing.Color.Black;
            this.TextField_UserName.Hint = "用户名";
            this.TextField_UserName.IsErrorMode = false;
            this.TextField_UserName.Location = new System.Drawing.Point(5, 40);
            this.TextField_UserName.MaxLength = 32767;
            this.TextField_UserName.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextField_UserName.Name = "TextField_UserName";
            this.TextField_UserName.PasswordChar = '\0';
            this.TextField_UserName.ReadOlay = false;
            this.TextField_UserName.SelectedText = "";
            this.TextField_UserName.SelectionLength = 0;
            this.TextField_UserName.SelectionStart = 0;
            this.TextField_UserName.Size = new System.Drawing.Size(392, 37);
            this.TextField_UserName.TabIndex = 4;
            this.TextField_UserName.TabStop = false;
            this.TextField_UserName.UseSystemPasswordChar = false;
            this.TextField_UserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextField_UserName_KeyDown);
            // 
            // FlatButton_Select_Login
            // 
            this.FlatButton_Select_Login.Depth = 0;
            this.FlatButton_Select_Login.Location = new System.Drawing.Point(204, 140);
            this.FlatButton_Select_Login.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.FlatButton_Select_Login.MouseState = MaterialSkin.MouseState.HOVER;
            this.FlatButton_Select_Login.Name = "FlatButton_Select_Login";
            this.FlatButton_Select_Login.Primary = false;
            this.FlatButton_Select_Login.Size = new System.Drawing.Size(192, 58);
            this.FlatButton_Select_Login.TabIndex = 3;
            this.FlatButton_Select_Login.Text = "登录";
            this.FlatButton_Select_Login.UseVisualStyleBackColor = true;
            this.FlatButton_Select_Login.Click += new System.EventHandler(this.FlatButton_Select_Login_Click);
            // 
            // FlatButton_Select_OffLine
            // 
            this.FlatButton_Select_OffLine.Depth = 0;
            this.FlatButton_Select_OffLine.Location = new System.Drawing.Point(5, 140);
            this.FlatButton_Select_OffLine.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.FlatButton_Select_OffLine.MouseState = MaterialSkin.MouseState.HOVER;
            this.FlatButton_Select_OffLine.Name = "FlatButton_Select_OffLine";
            this.FlatButton_Select_OffLine.Primary = false;
            this.FlatButton_Select_OffLine.Size = new System.Drawing.Size(192, 58);
            this.FlatButton_Select_OffLine.TabIndex = 2;
            this.FlatButton_Select_OffLine.Text = "离线模式";
            this.FlatButton_Select_OffLine.UseVisualStyleBackColor = true;
            this.FlatButton_Select_OffLine.Click += new System.EventHandler(this.FlatButton_Select_OffLine_Click);
            // 
            // WebView_Select_BG
            // 
            this.WebView_Select_BG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebView_Select_BG.Location = new System.Drawing.Point(3, 3);
            this.WebView_Select_BG.Margin = new System.Windows.Forms.Padding(0);
            this.WebView_Select_BG.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebView_Select_BG.Name = "WebView_Select_BG";
            this.WebView_Select_BG.Size = new System.Drawing.Size(1199, 681);
            this.WebView_Select_BG.TabIndex = 2;
            // 
            // TabPage_Examination
            // 
            this.TabPage_Examination.BackColor = System.Drawing.Color.White;
            this.TabPage_Examination.Controls.Add(this.Panel_Input_Main);
            this.TabPage_Examination.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Examination.Name = "TabPage_Examination";
            this.TabPage_Examination.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Examination.Size = new System.Drawing.Size(1205, 687);
            this.TabPage_Examination.TabIndex = 1;
            this.TabPage_Examination.Text = "tabPage2";
            // 
            // Panel_Input_Main
            // 
            this.Panel_Input_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Input_Main.Controls.Add(this.Button_Back);
            this.Panel_Input_Main.Controls.Add(this.Button_Pause_Continue);
            this.Panel_Input_Main.Controls.Add(this.Label_Stats_Time);
            this.Panel_Input_Main.Controls.Add(this.Button_Next_Page);
            this.Panel_Input_Main.Controls.Add(this.Button_Previous_Page);
            this.Panel_Input_Main.Controls.Add(this.Examination_Lable_1);
            this.Panel_Input_Main.Controls.Add(this.Examination_TextLine_5);
            this.Panel_Input_Main.Controls.Add(this.Examination_TextLine_1);
            this.Panel_Input_Main.Controls.Add(this.Examination_TextLine_4);
            this.Panel_Input_Main.Controls.Add(this.Examination_Lable_2);
            this.Panel_Input_Main.Controls.Add(this.Examination_TextLine_3);
            this.Panel_Input_Main.Controls.Add(this.Examination_Lable_3);
            this.Panel_Input_Main.Controls.Add(this.Examination_TextLine_2);
            this.Panel_Input_Main.Controls.Add(this.Examination_Lable_4);
            this.Panel_Input_Main.Controls.Add(this.Examination_Lable_5);
            this.Panel_Input_Main.Location = new System.Drawing.Point(30, 5);
            this.Panel_Input_Main.Margin = new System.Windows.Forms.Padding(30);
            this.Panel_Input_Main.Name = "Panel_Input_Main";
            this.Panel_Input_Main.Size = new System.Drawing.Size(1145, 682);
            this.Panel_Input_Main.TabIndex = 10;
            // 
            // Button_Back
            // 
            this.Button_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Back.Depth = 0;
            this.Button_Back.Location = new System.Drawing.Point(608, 622);
            this.Button_Back.MouseState = MaterialSkin.MouseState.HOVER;
            this.Button_Back.Name = "Button_Back";
            this.Button_Back.Primary = true;
            this.Button_Back.Size = new System.Drawing.Size(129, 56);
            this.Button_Back.TabIndex = 15;
            this.Button_Back.Text = "退出";
            this.Button_Back.UseVisualStyleBackColor = true;
            this.Button_Back.Click += new System.EventHandler(this.Button_Back_Click);
            // 
            // Button_Pause_Continue
            // 
            this.Button_Pause_Continue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Pause_Continue.Depth = 0;
            this.Button_Pause_Continue.Location = new System.Drawing.Point(1013, 622);
            this.Button_Pause_Continue.MouseState = MaterialSkin.MouseState.HOVER;
            this.Button_Pause_Continue.Name = "Button_Pause_Continue";
            this.Button_Pause_Continue.Primary = true;
            this.Button_Pause_Continue.Size = new System.Drawing.Size(129, 56);
            this.Button_Pause_Continue.TabIndex = 14;
            this.Button_Pause_Continue.Text = "暂停";
            this.Button_Pause_Continue.UseVisualStyleBackColor = true;
            this.Button_Pause_Continue.Click += new System.EventHandler(this.Button_Pause_Continue_Click);
            // 
            // Label_Stats_Time
            // 
            this.Label_Stats_Time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label_Stats_Time.AutoSize = true;
            this.Label_Stats_Time.Depth = 0;
            this.Label_Stats_Time.Font = new System.Drawing.Font("微软雅黑", 26F);
            this.Label_Stats_Time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label_Stats_Time.Location = new System.Drawing.Point(3, 632);
            this.Label_Stats_Time.MouseState = MaterialSkin.MouseState.HOVER;
            this.Label_Stats_Time.Name = "Label_Stats_Time";
            this.Label_Stats_Time.Size = new System.Drawing.Size(505, 46);
            this.Label_Stats_Time.TabIndex = 12;
            this.Label_Stats_Time.Tag = "时间：{0:00}:{1:00} 正确率：{2} 速度：{3}字/分 进度：{4} ";
            this.Label_Stats_Time.Text = "时间： 正确率： 速度： 进度：";
            // 
            // Button_Next_Page
            // 
            this.Button_Next_Page.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Next_Page.Depth = 0;
            this.Button_Next_Page.Location = new System.Drawing.Point(878, 622);
            this.Button_Next_Page.MouseState = MaterialSkin.MouseState.HOVER;
            this.Button_Next_Page.Name = "Button_Next_Page";
            this.Button_Next_Page.Primary = true;
            this.Button_Next_Page.Size = new System.Drawing.Size(129, 56);
            this.Button_Next_Page.TabIndex = 11;
            this.Button_Next_Page.Text = "下一页";
            this.Button_Next_Page.UseVisualStyleBackColor = true;
            this.Button_Next_Page.Click += new System.EventHandler(this.Button_Next_Page_Click);
            // 
            // Button_Previous_Page
            // 
            this.Button_Previous_Page.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Previous_Page.Depth = 0;
            this.Button_Previous_Page.Location = new System.Drawing.Point(743, 622);
            this.Button_Previous_Page.MouseState = MaterialSkin.MouseState.HOVER;
            this.Button_Previous_Page.Name = "Button_Previous_Page";
            this.Button_Previous_Page.Primary = true;
            this.Button_Previous_Page.Size = new System.Drawing.Size(129, 56);
            this.Button_Previous_Page.TabIndex = 10;
            this.Button_Previous_Page.Text = "上一页";
            this.Button_Previous_Page.UseVisualStyleBackColor = true;
            this.Button_Previous_Page.Click += new System.EventHandler(this.Button_Previous_Page_Click);
            // 
            // Examination_Lable_1
            // 
            this.Examination_Lable_1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Examination_Lable_1.CorrectForeColor = System.Drawing.Color.DimGray;
            this.Examination_Lable_1.Depth = 0;
            this.Examination_Lable_1.DrawNextCharHint = false;
            this.Examination_Lable_1.ErrorForeColor = System.Drawing.Color.Red;
            this.Examination_Lable_1.Font = new System.Drawing.Font("微软雅黑", 26F);
            this.Examination_Lable_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Examination_Lable_1.Location = new System.Drawing.Point(3, 6);
            this.Examination_Lable_1.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.Examination_Lable_1.MouseState = MaterialSkin.MouseState.HOVER;
            this.Examination_Lable_1.Name = "Examination_Lable_1";
            this.Examination_Lable_1.Size = new System.Drawing.Size(1131, 50);
            this.Examination_Lable_1.TabIndex = 1;
            this.Examination_Lable_1.TextFieldString = "123   一二三abc   123   一二三abc   123   一二三abc   ";
            this.Examination_Lable_1.TextString = "123   一二三abc   123   一二三abc   123   一二三abc   ";
            // 
            // Examination_TextLine_5
            // 
            this.Examination_TextLine_5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Examination_TextLine_5.BindingLabel = this.Examination_Lable_5;
            this.Examination_TextLine_5.CorrectForeColor = System.Drawing.Color.Black;
            this.Examination_TextLine_5.Depth = 0;
            this.Examination_TextLine_5.ErrorForeColor = System.Drawing.Color.Red;
            this.Examination_TextLine_5.ErrorModeColor = System.Drawing.Color.Red;
            this.Examination_TextLine_5.ErrorModeString = "";
            this.Examination_TextLine_5.FollowLabel = null;
            this.Examination_TextLine_5.FollowLabelColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Examination_TextLine_5.FollowLabeloldColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Examination_TextLine_5.ForeColor = System.Drawing.Color.Black;
            this.Examination_TextLine_5.Hint = "";
            this.Examination_TextLine_5.IsErrorMode = false;
            this.Examination_TextLine_5.Location = new System.Drawing.Point(9, 496);
            this.Examination_TextLine_5.Margin = new System.Windows.Forms.Padding(2);
            this.Examination_TextLine_5.MaxLength = 32767;
            this.Examination_TextLine_5.MouseState = MaterialSkin.MouseState.HOVER;
            this.Examination_TextLine_5.Name = "Examination_TextLine_5";
            this.Examination_TextLine_5.PasswordChar = '\0';
            this.Examination_TextLine_5.ReadOlay = false;
            this.Examination_TextLine_5.SelectedText = "";
            this.Examination_TextLine_5.SelectionLength = 0;
            this.Examination_TextLine_5.SelectionStart = 0;
            this.Examination_TextLine_5.Size = new System.Drawing.Size(1131, 51);
            this.Examination_TextLine_5.TabIndex = 9;
            this.Examination_TextLine_5.TabStop = false;
            this.Examination_TextLine_5.UseSystemPasswordChar = false;
            this.Examination_TextLine_5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Examination_TextLine_5_KeyDown);
            this.Examination_TextLine_5.TextChanged += new System.EventHandler(this.Examination_TextLine_5_TextChanged);
            // 
            // Examination_Lable_5
            // 
            this.Examination_Lable_5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Examination_Lable_5.CorrectForeColor = System.Drawing.Color.DimGray;
            this.Examination_Lable_5.Depth = 0;
            this.Examination_Lable_5.DrawNextCharHint = false;
            this.Examination_Lable_5.ErrorForeColor = System.Drawing.Color.Red;
            this.Examination_Lable_5.Font = new System.Drawing.Font("微软雅黑", 26F);
            this.Examination_Lable_5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Examination_Lable_5.Location = new System.Drawing.Point(3, 442);
            this.Examination_Lable_5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Examination_Lable_5.MouseState = MaterialSkin.MouseState.HOVER;
            this.Examination_Lable_5.Name = "Examination_Lable_5";
            this.Examination_Lable_5.Size = new System.Drawing.Size(1131, 50);
            this.Examination_Lable_5.TabIndex = 5;
            this.Examination_Lable_5.TextFieldString = "";
            this.Examination_Lable_5.TextString = "";
            // 
            // Examination_TextLine_1
            // 
            this.Examination_TextLine_1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Examination_TextLine_1.BindingLabel = this.Examination_Lable_1;
            this.Examination_TextLine_1.CorrectForeColor = System.Drawing.Color.Black;
            this.Examination_TextLine_1.Depth = 0;
            this.Examination_TextLine_1.ErrorForeColor = System.Drawing.Color.Red;
            this.Examination_TextLine_1.ErrorModeColor = System.Drawing.Color.Red;
            this.Examination_TextLine_1.ErrorModeString = "";
            this.Examination_TextLine_1.FollowLabel = null;
            this.Examination_TextLine_1.FollowLabelColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Examination_TextLine_1.FollowLabeloldColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Examination_TextLine_1.ForeColor = System.Drawing.Color.Black;
            this.Examination_TextLine_1.Hint = "";
            this.Examination_TextLine_1.IsErrorMode = false;
            this.Examination_TextLine_1.Location = new System.Drawing.Point(9, 60);
            this.Examination_TextLine_1.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.Examination_TextLine_1.MaxLength = 45;
            this.Examination_TextLine_1.MouseState = MaterialSkin.MouseState.HOVER;
            this.Examination_TextLine_1.Name = "Examination_TextLine_1";
            this.Examination_TextLine_1.PasswordChar = '\0';
            this.Examination_TextLine_1.ReadOlay = false;
            this.Examination_TextLine_1.SelectedText = "";
            this.Examination_TextLine_1.SelectionLength = 0;
            this.Examination_TextLine_1.SelectionStart = 0;
            this.Examination_TextLine_1.Size = new System.Drawing.Size(1131, 51);
            this.Examination_TextLine_1.TabIndex = 0;
            this.Examination_TextLine_1.TabStop = false;
            this.Examination_TextLine_1.Text = "123   一二三abc   123   一二三abc   123   一二三abc   ";
            this.Examination_TextLine_1.UseSystemPasswordChar = false;
            this.Examination_TextLine_1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Examination_TextLine_1_KeyDown);
            this.Examination_TextLine_1.TextChanged += new System.EventHandler(this.Examination_TextLine_1_TextChanged);
            // 
            // Examination_TextLine_4
            // 
            this.Examination_TextLine_4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Examination_TextLine_4.BindingLabel = this.Examination_Lable_4;
            this.Examination_TextLine_4.CorrectForeColor = System.Drawing.Color.Black;
            this.Examination_TextLine_4.Depth = 0;
            this.Examination_TextLine_4.ErrorForeColor = System.Drawing.Color.Red;
            this.Examination_TextLine_4.ErrorModeColor = System.Drawing.Color.Red;
            this.Examination_TextLine_4.ErrorModeString = "";
            this.Examination_TextLine_4.FollowLabel = null;
            this.Examination_TextLine_4.FollowLabelColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Examination_TextLine_4.FollowLabeloldColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Examination_TextLine_4.ForeColor = System.Drawing.Color.Black;
            this.Examination_TextLine_4.Hint = "";
            this.Examination_TextLine_4.IsErrorMode = false;
            this.Examination_TextLine_4.Location = new System.Drawing.Point(9, 387);
            this.Examination_TextLine_4.Margin = new System.Windows.Forms.Padding(2);
            this.Examination_TextLine_4.MaxLength = 32767;
            this.Examination_TextLine_4.MouseState = MaterialSkin.MouseState.HOVER;
            this.Examination_TextLine_4.Name = "Examination_TextLine_4";
            this.Examination_TextLine_4.PasswordChar = '\0';
            this.Examination_TextLine_4.ReadOlay = false;
            this.Examination_TextLine_4.SelectedText = "";
            this.Examination_TextLine_4.SelectionLength = 0;
            this.Examination_TextLine_4.SelectionStart = 0;
            this.Examination_TextLine_4.Size = new System.Drawing.Size(1131, 51);
            this.Examination_TextLine_4.TabIndex = 8;
            this.Examination_TextLine_4.TabStop = false;
            this.Examination_TextLine_4.UseSystemPasswordChar = false;
            this.Examination_TextLine_4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Examination_TextLine_4_KeyDown);
            this.Examination_TextLine_4.TextChanged += new System.EventHandler(this.Examination_TextLine_4_TextChanged);
            // 
            // Examination_Lable_4
            // 
            this.Examination_Lable_4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Examination_Lable_4.CorrectForeColor = System.Drawing.Color.DimGray;
            this.Examination_Lable_4.Depth = 0;
            this.Examination_Lable_4.DrawNextCharHint = false;
            this.Examination_Lable_4.ErrorForeColor = System.Drawing.Color.Red;
            this.Examination_Lable_4.Font = new System.Drawing.Font("微软雅黑", 26F);
            this.Examination_Lable_4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Examination_Lable_4.Location = new System.Drawing.Point(3, 333);
            this.Examination_Lable_4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Examination_Lable_4.MouseState = MaterialSkin.MouseState.HOVER;
            this.Examination_Lable_4.Name = "Examination_Lable_4";
            this.Examination_Lable_4.Size = new System.Drawing.Size(1131, 50);
            this.Examination_Lable_4.TabIndex = 4;
            this.Examination_Lable_4.TextFieldString = "";
            this.Examination_Lable_4.TextString = "";
            // 
            // Examination_Lable_2
            // 
            this.Examination_Lable_2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Examination_Lable_2.CorrectForeColor = System.Drawing.Color.DimGray;
            this.Examination_Lable_2.Depth = 0;
            this.Examination_Lable_2.DrawNextCharHint = false;
            this.Examination_Lable_2.ErrorForeColor = System.Drawing.Color.Red;
            this.Examination_Lable_2.Font = new System.Drawing.Font("微软雅黑", 26F);
            this.Examination_Lable_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Examination_Lable_2.Location = new System.Drawing.Point(3, 115);
            this.Examination_Lable_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Examination_Lable_2.MouseState = MaterialSkin.MouseState.HOVER;
            this.Examination_Lable_2.Name = "Examination_Lable_2";
            this.Examination_Lable_2.Size = new System.Drawing.Size(1131, 50);
            this.Examination_Lable_2.TabIndex = 2;
            this.Examination_Lable_2.TextFieldString = "";
            this.Examination_Lable_2.TextString = "";
            // 
            // Examination_TextLine_3
            // 
            this.Examination_TextLine_3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Examination_TextLine_3.BindingLabel = this.Examination_Lable_3;
            this.Examination_TextLine_3.CorrectForeColor = System.Drawing.Color.Black;
            this.Examination_TextLine_3.Depth = 0;
            this.Examination_TextLine_3.ErrorForeColor = System.Drawing.Color.Red;
            this.Examination_TextLine_3.ErrorModeColor = System.Drawing.Color.Red;
            this.Examination_TextLine_3.ErrorModeString = "";
            this.Examination_TextLine_3.FollowLabel = null;
            this.Examination_TextLine_3.FollowLabelColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Examination_TextLine_3.FollowLabeloldColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Examination_TextLine_3.ForeColor = System.Drawing.Color.Black;
            this.Examination_TextLine_3.Hint = "";
            this.Examination_TextLine_3.IsErrorMode = false;
            this.Examination_TextLine_3.Location = new System.Drawing.Point(9, 278);
            this.Examination_TextLine_3.Margin = new System.Windows.Forms.Padding(2);
            this.Examination_TextLine_3.MaxLength = 32767;
            this.Examination_TextLine_3.MouseState = MaterialSkin.MouseState.HOVER;
            this.Examination_TextLine_3.Name = "Examination_TextLine_3";
            this.Examination_TextLine_3.PasswordChar = '\0';
            this.Examination_TextLine_3.ReadOlay = false;
            this.Examination_TextLine_3.SelectedText = "";
            this.Examination_TextLine_3.SelectionLength = 0;
            this.Examination_TextLine_3.SelectionStart = 0;
            this.Examination_TextLine_3.Size = new System.Drawing.Size(1131, 51);
            this.Examination_TextLine_3.TabIndex = 7;
            this.Examination_TextLine_3.TabStop = false;
            this.Examination_TextLine_3.UseSystemPasswordChar = false;
            this.Examination_TextLine_3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Examination_TextLine_3_KeyDown);
            this.Examination_TextLine_3.TextChanged += new System.EventHandler(this.Examination_TextLine_3_TextChanged);
            // 
            // Examination_Lable_3
            // 
            this.Examination_Lable_3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Examination_Lable_3.CorrectForeColor = System.Drawing.Color.DimGray;
            this.Examination_Lable_3.Depth = 0;
            this.Examination_Lable_3.DrawNextCharHint = false;
            this.Examination_Lable_3.ErrorForeColor = System.Drawing.Color.Red;
            this.Examination_Lable_3.Font = new System.Drawing.Font("微软雅黑", 26F);
            this.Examination_Lable_3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Examination_Lable_3.Location = new System.Drawing.Point(3, 224);
            this.Examination_Lable_3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Examination_Lable_3.MouseState = MaterialSkin.MouseState.HOVER;
            this.Examination_Lable_3.Name = "Examination_Lable_3";
            this.Examination_Lable_3.Size = new System.Drawing.Size(1131, 50);
            this.Examination_Lable_3.TabIndex = 3;
            this.Examination_Lable_3.TextFieldString = "";
            this.Examination_Lable_3.TextString = "";
            // 
            // Examination_TextLine_2
            // 
            this.Examination_TextLine_2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Examination_TextLine_2.BindingLabel = this.Examination_Lable_2;
            this.Examination_TextLine_2.CorrectForeColor = System.Drawing.Color.Black;
            this.Examination_TextLine_2.Depth = 0;
            this.Examination_TextLine_2.ErrorForeColor = System.Drawing.Color.Red;
            this.Examination_TextLine_2.ErrorModeColor = System.Drawing.Color.Red;
            this.Examination_TextLine_2.ErrorModeString = "";
            this.Examination_TextLine_2.FollowLabel = null;
            this.Examination_TextLine_2.FollowLabelColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Examination_TextLine_2.FollowLabeloldColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Examination_TextLine_2.ForeColor = System.Drawing.Color.Black;
            this.Examination_TextLine_2.Hint = "";
            this.Examination_TextLine_2.IsErrorMode = false;
            this.Examination_TextLine_2.Location = new System.Drawing.Point(9, 169);
            this.Examination_TextLine_2.Margin = new System.Windows.Forms.Padding(2);
            this.Examination_TextLine_2.MaxLength = 32767;
            this.Examination_TextLine_2.MouseState = MaterialSkin.MouseState.HOVER;
            this.Examination_TextLine_2.Name = "Examination_TextLine_2";
            this.Examination_TextLine_2.PasswordChar = '\0';
            this.Examination_TextLine_2.ReadOlay = false;
            this.Examination_TextLine_2.SelectedText = "";
            this.Examination_TextLine_2.SelectionLength = 0;
            this.Examination_TextLine_2.SelectionStart = 0;
            this.Examination_TextLine_2.Size = new System.Drawing.Size(1131, 51);
            this.Examination_TextLine_2.TabIndex = 6;
            this.Examination_TextLine_2.TabStop = false;
            this.Examination_TextLine_2.UseSystemPasswordChar = false;
            this.Examination_TextLine_2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Examination_TextLine_2_KeyDown);
            this.Examination_TextLine_2.TextChanged += new System.EventHandler(this.Examination_TextLine_2_TextChanged);
            // 
            // TabPage_Start
            // 
            this.TabPage_Start.Controls.Add(this.Panel_Start);
            this.TabPage_Start.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Start.Name = "TabPage_Start";
            this.TabPage_Start.Size = new System.Drawing.Size(1205, 687);
            this.TabPage_Start.TabIndex = 2;
            this.TabPage_Start.Text = "TabPage_Start";
            this.TabPage_Start.UseVisualStyleBackColor = true;
            // 
            // Panel_Start
            // 
            this.Panel_Start.Controls.Add(this.ProcessBar_Start);
            this.Panel_Start.Controls.Add(this.Button_Start);
            this.Panel_Start.Location = new System.Drawing.Point(435, 270);
            this.Panel_Start.Name = "Panel_Start";
            this.Panel_Start.Size = new System.Drawing.Size(211, 75);
            this.Panel_Start.TabIndex = 16;
            // 
            // ProcessBar_Start
            // 
            this.ProcessBar_Start.Depth = 0;
            this.ProcessBar_Start.Interval = 10;
            this.ProcessBar_Start.LengthValue = 75;
            this.ProcessBar_Start.Location = new System.Drawing.Point(3, 65);
            this.ProcessBar_Start.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProcessBar_Start.Name = "ProcessBar_Start";
            this.ProcessBar_Start.Processing = true;
            this.ProcessBar_Start.Size = new System.Drawing.Size(204, 5);
            this.ProcessBar_Start.StepValue = 7;
            this.ProcessBar_Start.TabIndex = 17;
            this.ProcessBar_Start.Visible = false;
            // 
            // Button_Start
            // 
            this.Button_Start.Depth = 0;
            this.Button_Start.Location = new System.Drawing.Point(3, 3);
            this.Button_Start.MouseState = MaterialSkin.MouseState.HOVER;
            this.Button_Start.Name = "Button_Start";
            this.Button_Start.Primary = true;
            this.Button_Start.Size = new System.Drawing.Size(204, 56);
            this.Button_Start.TabIndex = 16;
            this.Button_Start.Text = "开始";
            this.Button_Start.UseVisualStyleBackColor = true;
            this.Button_Start.Click += new System.EventHandler(this.Button_Start_Click);
            // 
            // TabPage_SelectText
            // 
            this.TabPage_SelectText.BackColor = System.Drawing.Color.White;
            this.TabPage_SelectText.Controls.Add(this.Button_SelectText_Import);
            this.TabPage_SelectText.Controls.Add(this.Button_SelectText_Begin);
            this.TabPage_SelectText.Controls.Add(this.Button_SelectText_Return);
            this.TabPage_SelectText.Controls.Add(this.Text_SearchExamination);
            this.TabPage_SelectText.Controls.Add(this.ListView_ExaminationList);
            this.TabPage_SelectText.Controls.Add(this.ProcessBar_SearchExamination);
            this.TabPage_SelectText.Location = new System.Drawing.Point(4, 22);
            this.TabPage_SelectText.Name = "TabPage_SelectText";
            this.TabPage_SelectText.Size = new System.Drawing.Size(1205, 687);
            this.TabPage_SelectText.TabIndex = 3;
            this.TabPage_SelectText.Text = "TabPage_SelectText";
            // 
            // Button_SelectText_Import
            // 
            this.Button_SelectText_Import.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_SelectText_Import.Depth = 0;
            this.Button_SelectText_Import.Location = new System.Drawing.Point(844, 628);
            this.Button_SelectText_Import.MouseState = MaterialSkin.MouseState.HOVER;
            this.Button_SelectText_Import.Name = "Button_SelectText_Import";
            this.Button_SelectText_Import.Primary = true;
            this.Button_SelectText_Import.Size = new System.Drawing.Size(173, 56);
            this.Button_SelectText_Import.TabIndex = 13;
            this.Button_SelectText_Import.Text = "导入文件";
            this.Button_SelectText_Import.UseVisualStyleBackColor = true;
            this.Button_SelectText_Import.Click += new System.EventHandler(this.Button_SelectText_Import_Click);
            // 
            // Button_SelectText_Begin
            // 
            this.Button_SelectText_Begin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_SelectText_Begin.Depth = 0;
            this.Button_SelectText_Begin.Location = new System.Drawing.Point(1023, 628);
            this.Button_SelectText_Begin.MouseState = MaterialSkin.MouseState.HOVER;
            this.Button_SelectText_Begin.Name = "Button_SelectText_Begin";
            this.Button_SelectText_Begin.Primary = true;
            this.Button_SelectText_Begin.Size = new System.Drawing.Size(173, 56);
            this.Button_SelectText_Begin.TabIndex = 12;
            this.Button_SelectText_Begin.Text = "开始";
            this.Button_SelectText_Begin.UseVisualStyleBackColor = true;
            this.Button_SelectText_Begin.Click += new System.EventHandler(this.Button_SelectText_Begin_Click);
            // 
            // Button_SelectText_Return
            // 
            this.Button_SelectText_Return.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_SelectText_Return.Depth = 0;
            this.Button_SelectText_Return.Location = new System.Drawing.Point(7, 628);
            this.Button_SelectText_Return.MouseState = MaterialSkin.MouseState.HOVER;
            this.Button_SelectText_Return.Name = "Button_SelectText_Return";
            this.Button_SelectText_Return.Primary = true;
            this.Button_SelectText_Return.Size = new System.Drawing.Size(173, 56);
            this.Button_SelectText_Return.TabIndex = 11;
            this.Button_SelectText_Return.Text = "返回";
            this.Button_SelectText_Return.UseVisualStyleBackColor = true;
            this.Button_SelectText_Return.Click += new System.EventHandler(this.Button_SelectText_Return_Click);
            // 
            // Text_SearchExamination
            // 
            this.Text_SearchExamination.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Text_SearchExamination.Depth = 0;
            this.Text_SearchExamination.ErrorModeColor = System.Drawing.Color.Red;
            this.Text_SearchExamination.ErrorModeString = "";
            this.Text_SearchExamination.FollowLabel = null;
            this.Text_SearchExamination.FollowLabelColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Text_SearchExamination.FollowLabeloldColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Text_SearchExamination.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Text_SearchExamination.ForeColor = System.Drawing.Color.Black;
            this.Text_SearchExamination.Hint = "在此键入搜索内容";
            this.Text_SearchExamination.IsErrorMode = false;
            this.Text_SearchExamination.Location = new System.Drawing.Point(7, 3);
            this.Text_SearchExamination.MaxLength = 32767;
            this.Text_SearchExamination.MouseState = MaterialSkin.MouseState.HOVER;
            this.Text_SearchExamination.Name = "Text_SearchExamination";
            this.Text_SearchExamination.PasswordChar = '\0';
            this.Text_SearchExamination.ReadOlay = false;
            this.Text_SearchExamination.SelectedText = "";
            this.Text_SearchExamination.SelectionLength = 0;
            this.Text_SearchExamination.SelectionStart = 0;
            this.Text_SearchExamination.Size = new System.Drawing.Size(1191, 37);
            this.Text_SearchExamination.TabIndex = 1;
            this.Text_SearchExamination.TabStop = false;
            this.Text_SearchExamination.UseSystemPasswordChar = false;
            this.Text_SearchExamination.TextChanged += new System.EventHandler(this.Text_SearchExamination_TextChanged);
            // 
            // ListView_ExaminationList
            // 
            this.ListView_ExaminationList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListView_ExaminationList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListView_ExaminationList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader_ExaminationList_Title,
            this.ColumnHeader_ExaminationList_Length,
            this.ColumnHeader_ExaminationList_Preview,
            this.ColumnHeader_ExaminationList_MD5});
            this.ListView_ExaminationList.Depth = 0;
            this.ListView_ExaminationList.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.ListView_ExaminationList.FullRowSelect = true;
            this.ListView_ExaminationList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListView_ExaminationList.Location = new System.Drawing.Point(7, 48);
            this.ListView_ExaminationList.Margin = new System.Windows.Forms.Padding(5);
            this.ListView_ExaminationList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ListView_ExaminationList.MouseState = MaterialSkin.MouseState.OUT;
            this.ListView_ExaminationList.Name = "ListView_ExaminationList";
            this.ListView_ExaminationList.OwnerDraw = true;
            this.ListView_ExaminationList.Size = new System.Drawing.Size(1189, 572);
            this.ListView_ExaminationList.TabIndex = 0;
            this.ListView_ExaminationList.UseCompatibleStateImageBehavior = false;
            this.ListView_ExaminationList.View = System.Windows.Forms.View.Details;
            this.ListView_ExaminationList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListView_ExaminationList_MouseDoubleClick);
            this.ListView_ExaminationList.Resize += new System.EventHandler(this.ListView_ExaminationList_Resize);
            // 
            // ColumnHeader_ExaminationList_Title
            // 
            this.ColumnHeader_ExaminationList_Title.Text = "标题";
            this.ColumnHeader_ExaminationList_Title.Width = 300;
            // 
            // ColumnHeader_ExaminationList_Length
            // 
            this.ColumnHeader_ExaminationList_Length.Text = "字数";
            this.ColumnHeader_ExaminationList_Length.Width = 100;
            // 
            // ColumnHeader_ExaminationList_Preview
            // 
            this.ColumnHeader_ExaminationList_Preview.Text = "内容预览";
            this.ColumnHeader_ExaminationList_Preview.Width = 300;
            // 
            // ColumnHeader_ExaminationList_MD5
            // 
            this.ColumnHeader_ExaminationList_MD5.Text = "MD5";
            this.ColumnHeader_ExaminationList_MD5.Width = 0;
            // 
            // ProcessBar_SearchExamination
            // 
            this.ProcessBar_SearchExamination.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProcessBar_SearchExamination.Depth = 0;
            this.ProcessBar_SearchExamination.Interval = 10;
            this.ProcessBar_SearchExamination.LengthValue = 500;
            this.ProcessBar_SearchExamination.Location = new System.Drawing.Point(7, 40);
            this.ProcessBar_SearchExamination.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProcessBar_SearchExamination.Name = "ProcessBar_SearchExamination";
            this.ProcessBar_SearchExamination.Processing = true;
            this.ProcessBar_SearchExamination.Size = new System.Drawing.Size(1191, 5);
            this.ProcessBar_SearchExamination.StepValue = 20;
            this.ProcessBar_SearchExamination.TabIndex = 2;
            this.ProcessBar_SearchExamination.Visible = false;
            // 
            // TabPage_Result
            // 
            this.TabPage_Result.BackColor = System.Drawing.Color.White;
            this.TabPage_Result.Controls.Add(this.Label_Main_Class);
            this.TabPage_Result.Controls.Add(this.Label_Main_Major);
            this.TabPage_Result.Controls.Add(this.Label_Main_Department);
            this.TabPage_Result.Controls.Add(this.Label_Main_Welcome);
            this.TabPage_Result.Controls.Add(this.PictureBox_UserImage);
            this.TabPage_Result.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Result.Name = "TabPage_Result";
            this.TabPage_Result.Size = new System.Drawing.Size(1205, 687);
            this.TabPage_Result.TabIndex = 4;
            this.TabPage_Result.Text = "TabPage_Result";
            // 
            // Timer_Clocks
            // 
            this.Timer_Clocks.Interval = 1000;
            this.Timer_Clocks.Tick += new System.EventHandler(this.Timer_Clocks_Tick);
            // 
            // Timer_SearchExamination
            // 
            this.Timer_SearchExamination.Interval = 500;
            this.Timer_SearchExamination.Tick += new System.EventHandler(this.Timer_SearchExamination_Tick);
            // 
            // Label_UserName
            // 
            this.Label_UserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_UserName.AutoSize = true;
            this.Label_UserName.BackColor = System.Drawing.Color.Transparent;
            this.Label_UserName.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_UserName.ForeColor = System.Drawing.Color.White;
            this.Label_UserName.Location = new System.Drawing.Point(962, 32);
            this.Label_UserName.Name = "Label_UserName";
            this.Label_UserName.Size = new System.Drawing.Size(185, 25);
            this.Label_UserName.TabIndex = 1;
            this.Label_UserName.Tag = "以作为 {0} - {1} 登录";
            this.Label_UserName.Text = "以作为 {0} - {1} 登录";
            // 
            // LinkLabel_LoginOrOut
            // 
            this.LinkLabel_LoginOrOut.ActiveLinkColor = System.Drawing.Color.White;
            this.LinkLabel_LoginOrOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LinkLabel_LoginOrOut.AutoSize = true;
            this.LinkLabel_LoginOrOut.BackColor = System.Drawing.Color.Transparent;
            this.LinkLabel_LoginOrOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LinkLabel_LoginOrOut.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LinkLabel_LoginOrOut.ForeColor = System.Drawing.Color.White;
            this.LinkLabel_LoginOrOut.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.LinkLabel_LoginOrOut.LinkColor = System.Drawing.Color.White;
            this.LinkLabel_LoginOrOut.Location = new System.Drawing.Point(1153, 32);
            this.LinkLabel_LoginOrOut.Name = "LinkLabel_LoginOrOut";
            this.LinkLabel_LoginOrOut.Size = new System.Drawing.Size(50, 25);
            this.LinkLabel_LoginOrOut.TabIndex = 2;
            this.LinkLabel_LoginOrOut.TabStop = true;
            this.LinkLabel_LoginOrOut.Text = "注销";
            this.LinkLabel_LoginOrOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_LoginOrOut_LinkClicked);
            // 
            // Timer_UpdateStats
            // 
            this.Timer_UpdateStats.Interval = 5000;
            this.Timer_UpdateStats.Tick += new System.EventHandler(this.Timer_UpdateStats_Tick);
            // 
            // TabPage_Main
            // 
            this.TabPage_Main.BackColor = System.Drawing.Color.White;
            this.TabPage_Main.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Main.Name = "TabPage_Main";
            this.TabPage_Main.Size = new System.Drawing.Size(1205, 687);
            this.TabPage_Main.TabIndex = 5;
            this.TabPage_Main.Text = "TabPage_Main";
            // 
            // PictureBox_UserImage
            // 
            this.PictureBox_UserImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox_UserImage.Image = global::InputSpeedExamination.Properties.Resources.avatar;
            this.PictureBox_UserImage.Location = new System.Drawing.Point(298, 69);
            this.PictureBox_UserImage.Name = "PictureBox_UserImage";
            this.PictureBox_UserImage.Size = new System.Drawing.Size(150, 210);
            this.PictureBox_UserImage.TabIndex = 0;
            this.PictureBox_UserImage.TabStop = false;
            // 
            // Label_Main_Welcome
            // 
            this.Label_Main_Welcome.AutoSize = true;
            this.Label_Main_Welcome.Depth = 0;
            this.Label_Main_Welcome.Font = new System.Drawing.Font("微软雅黑", 26F);
            this.Label_Main_Welcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label_Main_Welcome.Location = new System.Drawing.Point(601, 69);
            this.Label_Main_Welcome.Margin = new System.Windows.Forms.Padding(150, 0, 3, 0);
            this.Label_Main_Welcome.MouseState = MaterialSkin.MouseState.HOVER;
            this.Label_Main_Welcome.Name = "Label_Main_Welcome";
            this.Label_Main_Welcome.Size = new System.Drawing.Size(170, 46);
            this.Label_Main_Welcome.TabIndex = 1;
            this.Label_Main_Welcome.Text = "欢迎，{0}";
            // 
            // Label_Main_Department
            // 
            this.Label_Main_Department.AutoSize = true;
            this.Label_Main_Department.Depth = 0;
            this.Label_Main_Department.Font = new System.Drawing.Font("微软雅黑", 26F);
            this.Label_Main_Department.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label_Main_Department.Location = new System.Drawing.Point(601, 115);
            this.Label_Main_Department.Margin = new System.Windows.Forms.Padding(150, 0, 3, 0);
            this.Label_Main_Department.MouseState = MaterialSkin.MouseState.HOVER;
            this.Label_Main_Department.Name = "Label_Main_Department";
            this.Label_Main_Department.Size = new System.Drawing.Size(100, 46);
            this.Label_Main_Department.TabIndex = 2;
            this.Label_Main_Department.Text = "{0}系";
            // 
            // Label_Main_Major
            // 
            this.Label_Main_Major.AutoSize = true;
            this.Label_Main_Major.Depth = 0;
            this.Label_Main_Major.Font = new System.Drawing.Font("微软雅黑", 26F);
            this.Label_Main_Major.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label_Main_Major.Location = new System.Drawing.Point(601, 161);
            this.Label_Main_Major.Margin = new System.Windows.Forms.Padding(150, 0, 3, 0);
            this.Label_Main_Major.MouseState = MaterialSkin.MouseState.HOVER;
            this.Label_Main_Major.Name = "Label_Main_Major";
            this.Label_Main_Major.Size = new System.Drawing.Size(135, 46);
            this.Label_Main_Major.TabIndex = 3;
            this.Label_Main_Major.Text = "{0}专业";
            // 
            // Label_Main_Class
            // 
            this.Label_Main_Class.AutoSize = true;
            this.Label_Main_Class.Depth = 0;
            this.Label_Main_Class.Font = new System.Drawing.Font("微软雅黑", 26F);
            this.Label_Main_Class.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label_Main_Class.Location = new System.Drawing.Point(601, 207);
            this.Label_Main_Class.Margin = new System.Windows.Forms.Padding(150, 0, 3, 0);
            this.Label_Main_Class.MouseState = MaterialSkin.MouseState.HOVER;
            this.Label_Main_Class.Name = "Label_Main_Class";
            this.Label_Main_Class.Size = new System.Drawing.Size(100, 46);
            this.Label_Main_Class.TabIndex = 4;
            this.Label_Main_Class.Text = "{0}班";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 780);
            this.Controls.Add(this.LinkLabel_LoginOrOut);
            this.Controls.Add(this.Label_UserName);
            this.Controls.Add(this.TabControl_Main);
            this.Font = new System.Drawing.Font("宋体", 9F);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 480);
            this.Name = "Form_Main";
            this.Sizable = false;
            this.Text = "键盘录入测试";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.ResizeBegin += new System.EventHandler(this.Form_Main_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.Form_Main_ResizeEnd);
            this.Resize += new System.EventHandler(this.Form_Main_Resize);
            this.TabControl_Main.ResumeLayout(false);
            this.TabPage_Select.ResumeLayout(false);
            this.Panel_Login.ResumeLayout(false);
            this.TabPage_Examination.ResumeLayout(false);
            this.Panel_Input_Main.ResumeLayout(false);
            this.Panel_Input_Main.PerformLayout();
            this.TabPage_Start.ResumeLayout(false);
            this.Panel_Start.ResumeLayout(false);
            this.TabPage_SelectText.ResumeLayout(false);
            this.TabPage_Result.ResumeLayout(false);
            this.TabPage_Result.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_UserImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl TabControl_Main;
        private System.Windows.Forms.TabPage TabPage_Select;
        private System.Windows.Forms.TabPage TabPage_Examination;
        private System.Windows.Forms.WebBrowser WebView_Select_BG;
        private MaterialSkin.Controls.MaterialLabel_Examination Examination_Lable_1;
        private MaterialSkin.Controls.MaterialSingleLineTextField_Examination Examination_TextLine_1;
        private MaterialSkin.Controls.MaterialLabel_Examination Examination_Lable_5;
        private MaterialSkin.Controls.MaterialLabel_Examination Examination_Lable_4;
        private MaterialSkin.Controls.MaterialLabel_Examination Examination_Lable_3;
        private MaterialSkin.Controls.MaterialLabel_Examination Examination_Lable_2;
        private MaterialSkin.Controls.MaterialSingleLineTextField_Examination Examination_TextLine_5;
        private MaterialSkin.Controls.MaterialSingleLineTextField_Examination Examination_TextLine_4;
        private MaterialSkin.Controls.MaterialSingleLineTextField_Examination Examination_TextLine_3;
        private MaterialSkin.Controls.MaterialSingleLineTextField_Examination Examination_TextLine_2;
        private System.Windows.Forms.Panel Panel_Input_Main;
        private System.Windows.Forms.Timer Timer_Clocks;
        private MaterialSkin.Controls.MaterialRaisedButton Button_Next_Page;
        private MaterialSkin.Controls.MaterialRaisedButton Button_Previous_Page;
        private MaterialSkin.Controls.MaterialLabel Label_Stats_Time;
        private MaterialSkin.Controls.MaterialRaisedButton Button_Pause_Continue;
        private System.Windows.Forms.TabPage TabPage_Start;
        private System.Windows.Forms.Panel Panel_Start;
        private MaterialSkin.Controls.MaterialProcessBar ProcessBar_Start;
        private MaterialSkin.Controls.MaterialRaisedButton Button_Start;
        private System.Windows.Forms.TabPage TabPage_SelectText;
        private MaterialSkin.Controls.MaterialListView ListView_ExaminationList;
        private System.Windows.Forms.ColumnHeader ColumnHeader_ExaminationList_Title;
        private System.Windows.Forms.ColumnHeader ColumnHeader_ExaminationList_Length;
        private System.Windows.Forms.ColumnHeader ColumnHeader_ExaminationList_Preview;
        private MaterialSkin.Controls.MaterialSingleLineTextField Text_SearchExamination;
        private MaterialSkin.Controls.MaterialProcessBar ProcessBar_SearchExamination;
        private System.Windows.Forms.Timer Timer_SearchExamination;
        private MaterialSkin.Controls.MaterialRaisedButton Button_SelectText_Return;
        private MaterialSkin.Controls.MaterialRaisedButton Button_SelectText_Begin;
        private MaterialSkin.Controls.MaterialRaisedButton Button_SelectText_Import;
        private System.Windows.Forms.ColumnHeader ColumnHeader_ExaminationList_MD5;
        private MaterialSkin.Controls.MaterialRaisedButton Button_Back;
        private System.Windows.Forms.TabPage TabPage_Result;
        private System.Windows.Forms.Panel Panel_Login;
        private MaterialSkin.Controls.MaterialFlatButton FlatButton_Select_Login;
        private MaterialSkin.Controls.MaterialFlatButton FlatButton_Select_OffLine;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextField_PassWord;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextField_UserName;
        private System.Windows.Forms.Label Label_Login_Tip;
        private MaterialSkin.Controls.MaterialProcessBar ProcessBar_Login;
        private System.Windows.Forms.Label Label_UserName;
        private System.Windows.Forms.LinkLabel LinkLabel_LoginOrOut;
        private System.Windows.Forms.Timer Timer_UpdateStats;
        private System.Windows.Forms.TabPage TabPage_Main;
        private System.Windows.Forms.PictureBox PictureBox_UserImage;
        private MaterialSkin.Controls.MaterialLabel Label_Main_Welcome;
        private MaterialSkin.Controls.MaterialLabel Label_Main_Department;
        private MaterialSkin.Controls.MaterialLabel Label_Main_Class;
        private MaterialSkin.Controls.MaterialLabel Label_Main_Major;
    }
}

