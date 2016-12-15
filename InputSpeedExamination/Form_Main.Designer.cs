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
            this.Button_About = new MaterialSkin.Controls.MaterialFlatButton();
            this.Panel_Login = new System.Windows.Forms.Panel();
            this.ProcessBar_Login = new MaterialSkin.Controls.MaterialProcessBar();
            this.Label_Login_Tip = new System.Windows.Forms.Label();
            this.TextField_PassWord = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TextField_UserName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.FlatButton_Select_Login = new MaterialSkin.Controls.MaterialFlatButton();
            this.FlatButton_Select_OffLine = new MaterialSkin.Controls.MaterialFlatButton();
            this.WebView_Select_BG = new System.Windows.Forms.WebBrowser();
            this.TabPage_Main = new System.Windows.Forms.TabPage();
            this.Panel_Main_UserInformation = new System.Windows.Forms.Panel();
            this.Text_Main_ExamRoom = new MaterialSkin.Controls.MaterialSingleLineTextField_Examination();
            this.Text_Main_Class = new MaterialSkin.Controls.MaterialSingleLineTextField_Examination();
            this.Text_Main_Major = new MaterialSkin.Controls.MaterialSingleLineTextField_Examination();
            this.Text_Main_Department = new MaterialSkin.Controls.MaterialSingleLineTextField_Examination();
            this.PictureBox_UserImage = new System.Windows.Forms.PictureBox();
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
            this.TabPage_Start = new System.Windows.Forms.TabPage();
            this.Panel_Start = new System.Windows.Forms.Panel();
            this.ProcessBar_Start = new MaterialSkin.Controls.MaterialProcessBar();
            this.Button_Start = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TabPage_Examination = new System.Windows.Forms.TabPage();
            this.Panel_Input_Main = new System.Windows.Forms.Panel();
            this.Button_Complete = new MaterialSkin.Controls.MaterialRaisedButton();
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
            this.TabPage_Result = new System.Windows.Forms.TabPage();
            this.Button_Result_Close = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Panel_Result = new System.Windows.Forms.Panel();
            this.Text_Result_FinalScore = new MaterialSkin.Controls.MaterialSingleLineTextField_Examination();
            this.Label_Result_Tip_FianlScore = new MaterialSkin.Controls.MaterialLabel();
            this.Panel_Result_Online = new System.Windows.Forms.Panel();
            this.Progress_Result_Percent = new MaterialSkin.Controls.MaterialProgressBar();
            this.Label_Result_Tip_Percent = new MaterialSkin.Controls.MaterialLabel();
            this.Process_Result_SendResult = new MaterialSkin.Controls.MaterialProcessBar();
            this.Label_Result_Tip_SendResult = new MaterialSkin.Controls.MaterialLabel();
            this.Text_Result_Total = new MaterialSkin.Controls.MaterialSingleLineTextField_Examination();
            this.Text_Result_Time = new MaterialSkin.Controls.MaterialSingleLineTextField_Examination();
            this.Text_Result_CorrectPercent = new MaterialSkin.Controls.MaterialSingleLineTextField_Examination();
            this.Text_Result_Speed = new MaterialSkin.Controls.MaterialSingleLineTextField_Examination();
            this.Label_Result_Tip_Total = new MaterialSkin.Controls.MaterialLabel();
            this.Label_Result_Tip_Time = new MaterialSkin.Controls.MaterialLabel();
            this.Label_Result_Tip_CorrectPercent = new MaterialSkin.Controls.MaterialLabel();
            this.Label_Result_Tip_Speed = new MaterialSkin.Controls.MaterialLabel();
            this.Label_Result_Tip = new MaterialSkin.Controls.MaterialLabel();
            this.Timer_Clocks = new System.Windows.Forms.Timer(this.components);
            this.Timer_SearchExamination = new System.Windows.Forms.Timer(this.components);
            this.Label_UserName = new System.Windows.Forms.Label();
            this.LinkLabel_LoginOrOut = new System.Windows.Forms.LinkLabel();
            this.Timer_UpdateStats = new System.Windows.Forms.Timer(this.components);
            this.Text_Main_Batch = new MaterialSkin.Controls.MaterialSingleLineTextField_Examination();
            this.Button_Main_Back = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Button_Main_Free = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Button_Main_OnlineExam = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Text_Main_Name = new MaterialSkin.Controls.MaterialSingleLineTextField_Examination();
            this.Text_Main_Number = new MaterialSkin.Controls.MaterialSingleLineTextField_Examination();
            this.Label_Main_Tip = new MaterialSkin.Controls.MaterialLabel();
            this.TabControl_Main.SuspendLayout();
            this.TabPage_Select.SuspendLayout();
            this.Panel_Login.SuspendLayout();
            this.TabPage_Main.SuspendLayout();
            this.Panel_Main_UserInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_UserImage)).BeginInit();
            this.TabPage_SelectText.SuspendLayout();
            this.TabPage_Start.SuspendLayout();
            this.Panel_Start.SuspendLayout();
            this.TabPage_Examination.SuspendLayout();
            this.Panel_Input_Main.SuspendLayout();
            this.TabPage_Result.SuspendLayout();
            this.Panel_Result.SuspendLayout();
            this.Panel_Result_Online.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl_Main
            // 
            this.TabControl_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl_Main.Controls.Add(this.TabPage_Select);
            this.TabControl_Main.Controls.Add(this.TabPage_Main);
            this.TabControl_Main.Controls.Add(this.TabPage_SelectText);
            this.TabControl_Main.Controls.Add(this.TabPage_Start);
            this.TabControl_Main.Controls.Add(this.TabPage_Examination);
            this.TabControl_Main.Controls.Add(this.TabPage_Result);
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
            this.TabPage_Select.Controls.Add(this.Button_About);
            this.TabPage_Select.Controls.Add(this.Panel_Login);
            this.TabPage_Select.Controls.Add(this.WebView_Select_BG);
            this.TabPage_Select.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Select.Name = "TabPage_Select";
            this.TabPage_Select.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Select.Size = new System.Drawing.Size(1205, 687);
            this.TabPage_Select.TabIndex = 0;
            this.TabPage_Select.Text = "TabPage_Select";
            // 
            // Button_About
            // 
            this.Button_About.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_About.Depth = 0;
            this.Button_About.Location = new System.Drawing.Point(1111, 645);
            this.Button_About.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Button_About.MouseState = MaterialSkin.MouseState.HOVER;
            this.Button_About.Name = "Button_About";
            this.Button_About.Primary = false;
            this.Button_About.Size = new System.Drawing.Size(87, 36);
            this.Button_About.TabIndex = 4;
            this.Button_About.Text = "关于";
            this.Button_About.UseVisualStyleBackColor = true;
            this.Button_About.Click += new System.EventHandler(this.Button_About_Click);
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
            // TabPage_Main
            // 
            this.TabPage_Main.BackColor = System.Drawing.Color.White;
            this.TabPage_Main.Controls.Add(this.Button_Main_OnlineExam);
            this.TabPage_Main.Controls.Add(this.Button_Main_Free);
            this.TabPage_Main.Controls.Add(this.Button_Main_Back);
            this.TabPage_Main.Controls.Add(this.Panel_Main_UserInformation);
            this.TabPage_Main.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Main.Name = "TabPage_Main";
            this.TabPage_Main.Size = new System.Drawing.Size(1205, 687);
            this.TabPage_Main.TabIndex = 5;
            this.TabPage_Main.Text = "TabPage_Main";
            // 
            // Panel_Main_UserInformation
            // 
            this.Panel_Main_UserInformation.Controls.Add(this.Label_Main_Tip);
            this.Panel_Main_UserInformation.Controls.Add(this.Text_Main_Number);
            this.Panel_Main_UserInformation.Controls.Add(this.Text_Main_Name);
            this.Panel_Main_UserInformation.Controls.Add(this.Text_Main_Batch);
            this.Panel_Main_UserInformation.Controls.Add(this.Text_Main_ExamRoom);
            this.Panel_Main_UserInformation.Controls.Add(this.Text_Main_Class);
            this.Panel_Main_UserInformation.Controls.Add(this.Text_Main_Major);
            this.Panel_Main_UserInformation.Controls.Add(this.Text_Main_Department);
            this.Panel_Main_UserInformation.Controls.Add(this.PictureBox_UserImage);
            this.Panel_Main_UserInformation.Location = new System.Drawing.Point(183, 64);
            this.Panel_Main_UserInformation.Name = "Panel_Main_UserInformation";
            this.Panel_Main_UserInformation.Size = new System.Drawing.Size(899, 399);
            this.Panel_Main_UserInformation.TabIndex = 10;
            // 
            // Text_Main_ExamRoom
            // 
            this.Text_Main_ExamRoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Text_Main_ExamRoom.BindingLabel = null;
            this.Text_Main_ExamRoom.CorrectForeColor = System.Drawing.Color.Black;
            this.Text_Main_ExamRoom.Depth = 0;
            this.Text_Main_ExamRoom.ErrorForeColor = System.Drawing.Color.Red;
            this.Text_Main_ExamRoom.ErrorModeColor = System.Drawing.Color.Red;
            this.Text_Main_ExamRoom.ErrorModeString = "";
            this.Text_Main_ExamRoom.FollowLabel = null;
            this.Text_Main_ExamRoom.FollowLabelColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Text_Main_ExamRoom.FollowLabeloldColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Text_Main_ExamRoom.ForeColor = System.Drawing.Color.Black;
            this.Text_Main_ExamRoom.Hint = "";
            this.Text_Main_ExamRoom.IsErrorMode = false;
            this.Text_Main_ExamRoom.Location = new System.Drawing.Point(231, 271);
            this.Text_Main_ExamRoom.Margin = new System.Windows.Forms.Padding(6);
            this.Text_Main_ExamRoom.MaxLength = 32767;
            this.Text_Main_ExamRoom.MouseState = MaterialSkin.MouseState.HOVER;
            this.Text_Main_ExamRoom.Name = "Text_Main_ExamRoom";
            this.Text_Main_ExamRoom.PasswordChar = '\0';
            this.Text_Main_ExamRoom.ReadOlay = true;
            this.Text_Main_ExamRoom.SelectedText = "";
            this.Text_Main_ExamRoom.SelectionLength = 0;
            this.Text_Main_ExamRoom.SelectionStart = 0;
            this.Text_Main_ExamRoom.Size = new System.Drawing.Size(621, 51);
            this.Text_Main_ExamRoom.TabIndex = 13;
            this.Text_Main_ExamRoom.TabStop = false;
            this.Text_Main_ExamRoom.Text = "104考场";
            this.Text_Main_ExamRoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Text_Main_ExamRoom.UseSystemPasswordChar = false;
            // 
            // Text_Main_Class
            // 
            this.Text_Main_Class.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Text_Main_Class.BindingLabel = null;
            this.Text_Main_Class.CorrectForeColor = System.Drawing.Color.Black;
            this.Text_Main_Class.Depth = 0;
            this.Text_Main_Class.ErrorForeColor = System.Drawing.Color.Red;
            this.Text_Main_Class.ErrorModeColor = System.Drawing.Color.Red;
            this.Text_Main_Class.ErrorModeString = "";
            this.Text_Main_Class.FollowLabel = null;
            this.Text_Main_Class.FollowLabelColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Text_Main_Class.FollowLabeloldColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Text_Main_Class.ForeColor = System.Drawing.Color.Black;
            this.Text_Main_Class.Hint = "";
            this.Text_Main_Class.IsErrorMode = false;
            this.Text_Main_Class.Location = new System.Drawing.Point(231, 208);
            this.Text_Main_Class.Margin = new System.Windows.Forms.Padding(6);
            this.Text_Main_Class.MaxLength = 32767;
            this.Text_Main_Class.MouseState = MaterialSkin.MouseState.HOVER;
            this.Text_Main_Class.Name = "Text_Main_Class";
            this.Text_Main_Class.PasswordChar = '\0';
            this.Text_Main_Class.ReadOlay = true;
            this.Text_Main_Class.SelectedText = "";
            this.Text_Main_Class.SelectionLength = 0;
            this.Text_Main_Class.SelectionStart = 0;
            this.Text_Main_Class.Size = new System.Drawing.Size(621, 51);
            this.Text_Main_Class.TabIndex = 12;
            this.Text_Main_Class.TabStop = false;
            this.Text_Main_Class.Text = "软件1402班";
            this.Text_Main_Class.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Text_Main_Class.UseSystemPasswordChar = false;
            // 
            // Text_Main_Major
            // 
            this.Text_Main_Major.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Text_Main_Major.BindingLabel = null;
            this.Text_Main_Major.CorrectForeColor = System.Drawing.Color.Black;
            this.Text_Main_Major.Depth = 0;
            this.Text_Main_Major.ErrorForeColor = System.Drawing.Color.Red;
            this.Text_Main_Major.ErrorModeColor = System.Drawing.Color.Red;
            this.Text_Main_Major.ErrorModeString = "";
            this.Text_Main_Major.FollowLabel = null;
            this.Text_Main_Major.FollowLabelColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Text_Main_Major.FollowLabeloldColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Text_Main_Major.ForeColor = System.Drawing.Color.Black;
            this.Text_Main_Major.Hint = "";
            this.Text_Main_Major.IsErrorMode = false;
            this.Text_Main_Major.Location = new System.Drawing.Point(231, 145);
            this.Text_Main_Major.Margin = new System.Windows.Forms.Padding(6);
            this.Text_Main_Major.MaxLength = 32767;
            this.Text_Main_Major.MouseState = MaterialSkin.MouseState.HOVER;
            this.Text_Main_Major.Name = "Text_Main_Major";
            this.Text_Main_Major.PasswordChar = '\0';
            this.Text_Main_Major.ReadOlay = true;
            this.Text_Main_Major.SelectedText = "";
            this.Text_Main_Major.SelectionLength = 0;
            this.Text_Main_Major.SelectionStart = 0;
            this.Text_Main_Major.Size = new System.Drawing.Size(621, 51);
            this.Text_Main_Major.TabIndex = 11;
            this.Text_Main_Major.TabStop = false;
            this.Text_Main_Major.Text = "软件工程专业";
            this.Text_Main_Major.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Text_Main_Major.UseSystemPasswordChar = false;
            // 
            // Text_Main_Department
            // 
            this.Text_Main_Department.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Text_Main_Department.BindingLabel = null;
            this.Text_Main_Department.CorrectForeColor = System.Drawing.Color.Black;
            this.Text_Main_Department.Depth = 0;
            this.Text_Main_Department.ErrorForeColor = System.Drawing.Color.Red;
            this.Text_Main_Department.ErrorModeColor = System.Drawing.Color.Red;
            this.Text_Main_Department.ErrorModeString = "";
            this.Text_Main_Department.FollowLabel = null;
            this.Text_Main_Department.FollowLabelColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Text_Main_Department.FollowLabeloldColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Text_Main_Department.ForeColor = System.Drawing.Color.Black;
            this.Text_Main_Department.Hint = "";
            this.Text_Main_Department.IsErrorMode = false;
            this.Text_Main_Department.Location = new System.Drawing.Point(231, 82);
            this.Text_Main_Department.Margin = new System.Windows.Forms.Padding(6);
            this.Text_Main_Department.MaxLength = 32767;
            this.Text_Main_Department.MouseState = MaterialSkin.MouseState.HOVER;
            this.Text_Main_Department.Name = "Text_Main_Department";
            this.Text_Main_Department.PasswordChar = '\0';
            this.Text_Main_Department.ReadOlay = true;
            this.Text_Main_Department.SelectedText = "";
            this.Text_Main_Department.SelectionLength = 0;
            this.Text_Main_Department.SelectionStart = 0;
            this.Text_Main_Department.Size = new System.Drawing.Size(621, 51);
            this.Text_Main_Department.TabIndex = 10;
            this.Text_Main_Department.TabStop = false;
            this.Text_Main_Department.Text = "计算机系";
            this.Text_Main_Department.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Text_Main_Department.UseSystemPasswordChar = false;
            // 
            // PictureBox_UserImage
            // 
            this.PictureBox_UserImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox_UserImage.Image = global::InputSpeedExamination.Properties.Resources.avatar;
            this.PictureBox_UserImage.Location = new System.Drawing.Point(37, 49);
            this.PictureBox_UserImage.Name = "PictureBox_UserImage";
            this.PictureBox_UserImage.Size = new System.Drawing.Size(150, 210);
            this.PictureBox_UserImage.TabIndex = 5;
            this.PictureBox_UserImage.TabStop = false;
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
            this.Button_SelectText_Import.Location = new System.Drawing.Point(846, 624);
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
            this.Button_SelectText_Begin.Location = new System.Drawing.Point(1025, 624);
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
            this.Button_SelectText_Return.Location = new System.Drawing.Point(7, 624);
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
            this.ListView_ExaminationList.Size = new System.Drawing.Size(1189, 568);
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
            // TabPage_Examination
            // 
            this.TabPage_Examination.BackColor = System.Drawing.Color.White;
            this.TabPage_Examination.Controls.Add(this.Panel_Input_Main);
            this.TabPage_Examination.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Examination.Name = "TabPage_Examination";
            this.TabPage_Examination.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Examination.Size = new System.Drawing.Size(1205, 687);
            this.TabPage_Examination.TabIndex = 1;
            this.TabPage_Examination.Text = "TabPage_Examination";
            // 
            // Panel_Input_Main
            // 
            this.Panel_Input_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Input_Main.Controls.Add(this.Button_Complete);
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
            // Button_Complete
            // 
            this.Button_Complete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Complete.Depth = 0;
            this.Button_Complete.Location = new System.Drawing.Point(608, 622);
            this.Button_Complete.MouseState = MaterialSkin.MouseState.HOVER;
            this.Button_Complete.Name = "Button_Complete";
            this.Button_Complete.Primary = true;
            this.Button_Complete.Size = new System.Drawing.Size(129, 56);
            this.Button_Complete.TabIndex = 16;
            this.Button_Complete.Text = "完成";
            this.Button_Complete.UseVisualStyleBackColor = true;
            this.Button_Complete.Visible = false;
            this.Button_Complete.Click += new System.EventHandler(this.Button_Complete_Click);
            // 
            // Button_Back
            // 
            this.Button_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_Back.Depth = 0;
            this.Button_Back.Location = new System.Drawing.Point(9, 622);
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
            this.Label_Stats_Time.Location = new System.Drawing.Point(4, 569);
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
            this.Examination_TextLine_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.Examination_TextLine_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.Examination_TextLine_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.Examination_TextLine_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.Examination_TextLine_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Examination_TextLine_2.UseSystemPasswordChar = false;
            this.Examination_TextLine_2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Examination_TextLine_2_KeyDown);
            this.Examination_TextLine_2.TextChanged += new System.EventHandler(this.Examination_TextLine_2_TextChanged);
            // 
            // TabPage_Result
            // 
            this.TabPage_Result.BackColor = System.Drawing.Color.White;
            this.TabPage_Result.Controls.Add(this.Button_Result_Close);
            this.TabPage_Result.Controls.Add(this.Panel_Result);
            this.TabPage_Result.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Result.Name = "TabPage_Result";
            this.TabPage_Result.Size = new System.Drawing.Size(1205, 687);
            this.TabPage_Result.TabIndex = 4;
            this.TabPage_Result.Text = "TabPage_Result";
            // 
            // Button_Result_Close
            // 
            this.Button_Result_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Result_Close.Depth = 0;
            this.Button_Result_Close.Location = new System.Drawing.Point(994, 624);
            this.Button_Result_Close.MouseState = MaterialSkin.MouseState.HOVER;
            this.Button_Result_Close.Name = "Button_Result_Close";
            this.Button_Result_Close.Primary = true;
            this.Button_Result_Close.Size = new System.Drawing.Size(204, 56);
            this.Button_Result_Close.TabIndex = 17;
            this.Button_Result_Close.Text = "关闭";
            this.Button_Result_Close.UseVisualStyleBackColor = true;
            this.Button_Result_Close.Click += new System.EventHandler(this.Button_Result_Close_Click);
            // 
            // Panel_Result
            // 
            this.Panel_Result.Controls.Add(this.Text_Result_FinalScore);
            this.Panel_Result.Controls.Add(this.Label_Result_Tip_FianlScore);
            this.Panel_Result.Controls.Add(this.Panel_Result_Online);
            this.Panel_Result.Controls.Add(this.Text_Result_Total);
            this.Panel_Result.Controls.Add(this.Text_Result_Time);
            this.Panel_Result.Controls.Add(this.Text_Result_CorrectPercent);
            this.Panel_Result.Controls.Add(this.Text_Result_Speed);
            this.Panel_Result.Controls.Add(this.Label_Result_Tip_Total);
            this.Panel_Result.Controls.Add(this.Label_Result_Tip_Time);
            this.Panel_Result.Controls.Add(this.Label_Result_Tip_CorrectPercent);
            this.Panel_Result.Controls.Add(this.Label_Result_Tip_Speed);
            this.Panel_Result.Controls.Add(this.Label_Result_Tip);
            this.Panel_Result.Location = new System.Drawing.Point(231, 66);
            this.Panel_Result.Name = "Panel_Result";
            this.Panel_Result.Size = new System.Drawing.Size(783, 489);
            this.Panel_Result.TabIndex = 0;
            // 
            // Text_Result_FinalScore
            // 
            this.Text_Result_FinalScore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Text_Result_FinalScore.BindingLabel = null;
            this.Text_Result_FinalScore.CorrectForeColor = System.Drawing.Color.Black;
            this.Text_Result_FinalScore.Depth = 0;
            this.Text_Result_FinalScore.ErrorForeColor = System.Drawing.Color.Red;
            this.Text_Result_FinalScore.ErrorModeColor = System.Drawing.Color.Red;
            this.Text_Result_FinalScore.ErrorModeString = "";
            this.Text_Result_FinalScore.FollowLabel = null;
            this.Text_Result_FinalScore.FollowLabelColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Text_Result_FinalScore.FollowLabeloldColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Text_Result_FinalScore.ForeColor = System.Drawing.Color.Black;
            this.Text_Result_FinalScore.Hint = "";
            this.Text_Result_FinalScore.IsErrorMode = false;
            this.Text_Result_FinalScore.Location = new System.Drawing.Point(213, 296);
            this.Text_Result_FinalScore.Margin = new System.Windows.Forms.Padding(6);
            this.Text_Result_FinalScore.MaxLength = 32767;
            this.Text_Result_FinalScore.MouseState = MaterialSkin.MouseState.HOVER;
            this.Text_Result_FinalScore.Name = "Text_Result_FinalScore";
            this.Text_Result_FinalScore.PasswordChar = '\0';
            this.Text_Result_FinalScore.ReadOlay = true;
            this.Text_Result_FinalScore.SelectedText = "";
            this.Text_Result_FinalScore.SelectionLength = 0;
            this.Text_Result_FinalScore.SelectionStart = 0;
            this.Text_Result_FinalScore.Size = new System.Drawing.Size(564, 51);
            this.Text_Result_FinalScore.TabIndex = 11;
            this.Text_Result_FinalScore.TabStop = false;
            this.Text_Result_FinalScore.Text = "Text";
            this.Text_Result_FinalScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Text_Result_FinalScore.UseSystemPasswordChar = false;
            // 
            // Label_Result_Tip_FianlScore
            // 
            this.Label_Result_Tip_FianlScore.Depth = 0;
            this.Label_Result_Tip_FianlScore.Font = new System.Drawing.Font("微软雅黑", 26F);
            this.Label_Result_Tip_FianlScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label_Result_Tip_FianlScore.Location = new System.Drawing.Point(6, 301);
            this.Label_Result_Tip_FianlScore.Margin = new System.Windows.Forms.Padding(6);
            this.Label_Result_Tip_FianlScore.MouseState = MaterialSkin.MouseState.HOVER;
            this.Label_Result_Tip_FianlScore.Name = "Label_Result_Tip_FianlScore";
            this.Label_Result_Tip_FianlScore.Size = new System.Drawing.Size(195, 46);
            this.Label_Result_Tip_FianlScore.TabIndex = 10;
            this.Label_Result_Tip_FianlScore.Text = "最终成绩：";
            this.Label_Result_Tip_FianlScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Panel_Result_Online
            // 
            this.Panel_Result_Online.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Result_Online.Controls.Add(this.Progress_Result_Percent);
            this.Panel_Result_Online.Controls.Add(this.Label_Result_Tip_Percent);
            this.Panel_Result_Online.Controls.Add(this.Process_Result_SendResult);
            this.Panel_Result_Online.Controls.Add(this.Label_Result_Tip_SendResult);
            this.Panel_Result_Online.Location = new System.Drawing.Point(3, 356);
            this.Panel_Result_Online.Name = "Panel_Result_Online";
            this.Panel_Result_Online.Size = new System.Drawing.Size(777, 129);
            this.Panel_Result_Online.TabIndex = 9;
            // 
            // Progress_Result_Percent
            // 
            this.Progress_Result_Percent.Depth = 0;
            this.Progress_Result_Percent.IsPercent = true;
            this.Progress_Result_Percent.Location = new System.Drawing.Point(3, 119);
            this.Progress_Result_Percent.MouseState = MaterialSkin.MouseState.HOVER;
            this.Progress_Result_Percent.Name = "Progress_Result_Percent";
            this.Progress_Result_Percent.PercentValue = 0.97D;
            this.Progress_Result_Percent.Size = new System.Drawing.Size(768, 5);
            this.Progress_Result_Percent.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.Progress_Result_Percent.TabIndex = 4;
            this.Progress_Result_Percent.Value = 10;
            // 
            // Label_Result_Tip_Percent
            // 
            this.Label_Result_Tip_Percent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Result_Tip_Percent.Depth = 0;
            this.Label_Result_Tip_Percent.Font = new System.Drawing.Font("微软雅黑", 26F);
            this.Label_Result_Tip_Percent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label_Result_Tip_Percent.Location = new System.Drawing.Point(6, 64);
            this.Label_Result_Tip_Percent.Margin = new System.Windows.Forms.Padding(6);
            this.Label_Result_Tip_Percent.MouseState = MaterialSkin.MouseState.HOVER;
            this.Label_Result_Tip_Percent.Name = "Label_Result_Tip_Percent";
            this.Label_Result_Tip_Percent.Size = new System.Drawing.Size(765, 46);
            this.Label_Result_Tip_Percent.TabIndex = 3;
            this.Label_Result_Tip_Percent.Text = "您的成绩击败了全校 {0}% 的人";
            this.Label_Result_Tip_Percent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Process_Result_SendResult
            // 
            this.Process_Result_SendResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Process_Result_SendResult.Depth = 0;
            this.Process_Result_SendResult.Interval = 10;
            this.Process_Result_SendResult.LengthValue = 300;
            this.Process_Result_SendResult.Location = new System.Drawing.Point(3, 56);
            this.Process_Result_SendResult.MouseState = MaterialSkin.MouseState.HOVER;
            this.Process_Result_SendResult.Name = "Process_Result_SendResult";
            this.Process_Result_SendResult.Processing = true;
            this.Process_Result_SendResult.Size = new System.Drawing.Size(768, 5);
            this.Process_Result_SendResult.StepValue = 7;
            this.Process_Result_SendResult.TabIndex = 2;
            // 
            // Label_Result_Tip_SendResult
            // 
            this.Label_Result_Tip_SendResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Result_Tip_SendResult.Depth = 0;
            this.Label_Result_Tip_SendResult.Font = new System.Drawing.Font("微软雅黑", 26F);
            this.Label_Result_Tip_SendResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label_Result_Tip_SendResult.Location = new System.Drawing.Point(6, 6);
            this.Label_Result_Tip_SendResult.Margin = new System.Windows.Forms.Padding(6);
            this.Label_Result_Tip_SendResult.MouseState = MaterialSkin.MouseState.HOVER;
            this.Label_Result_Tip_SendResult.Name = "Label_Result_Tip_SendResult";
            this.Label_Result_Tip_SendResult.Size = new System.Drawing.Size(765, 46);
            this.Label_Result_Tip_SendResult.TabIndex = 1;
            this.Label_Result_Tip_SendResult.Text = "正在将成绩提交至服务器";
            this.Label_Result_Tip_SendResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Text_Result_Total
            // 
            this.Text_Result_Total.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Text_Result_Total.BindingLabel = null;
            this.Text_Result_Total.CorrectForeColor = System.Drawing.Color.Black;
            this.Text_Result_Total.Depth = 0;
            this.Text_Result_Total.ErrorForeColor = System.Drawing.Color.Red;
            this.Text_Result_Total.ErrorModeColor = System.Drawing.Color.Red;
            this.Text_Result_Total.ErrorModeString = "";
            this.Text_Result_Total.FollowLabel = null;
            this.Text_Result_Total.FollowLabelColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Text_Result_Total.FollowLabeloldColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Text_Result_Total.ForeColor = System.Drawing.Color.Black;
            this.Text_Result_Total.Hint = "";
            this.Text_Result_Total.IsErrorMode = false;
            this.Text_Result_Total.Location = new System.Drawing.Point(213, 233);
            this.Text_Result_Total.Margin = new System.Windows.Forms.Padding(6);
            this.Text_Result_Total.MaxLength = 32767;
            this.Text_Result_Total.MouseState = MaterialSkin.MouseState.HOVER;
            this.Text_Result_Total.Name = "Text_Result_Total";
            this.Text_Result_Total.PasswordChar = '\0';
            this.Text_Result_Total.ReadOlay = true;
            this.Text_Result_Total.SelectedText = "";
            this.Text_Result_Total.SelectionLength = 0;
            this.Text_Result_Total.SelectionStart = 0;
            this.Text_Result_Total.Size = new System.Drawing.Size(564, 51);
            this.Text_Result_Total.TabIndex = 8;
            this.Text_Result_Total.TabStop = false;
            this.Text_Result_Total.Text = "Text";
            this.Text_Result_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Text_Result_Total.UseSystemPasswordChar = false;
            // 
            // Text_Result_Time
            // 
            this.Text_Result_Time.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Text_Result_Time.BindingLabel = null;
            this.Text_Result_Time.CorrectForeColor = System.Drawing.Color.Black;
            this.Text_Result_Time.Depth = 0;
            this.Text_Result_Time.ErrorForeColor = System.Drawing.Color.Red;
            this.Text_Result_Time.ErrorModeColor = System.Drawing.Color.Red;
            this.Text_Result_Time.ErrorModeString = "";
            this.Text_Result_Time.FollowLabel = null;
            this.Text_Result_Time.FollowLabelColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Text_Result_Time.FollowLabeloldColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Text_Result_Time.ForeColor = System.Drawing.Color.Black;
            this.Text_Result_Time.Hint = "";
            this.Text_Result_Time.IsErrorMode = false;
            this.Text_Result_Time.Location = new System.Drawing.Point(213, 175);
            this.Text_Result_Time.Margin = new System.Windows.Forms.Padding(6);
            this.Text_Result_Time.MaxLength = 32767;
            this.Text_Result_Time.MouseState = MaterialSkin.MouseState.HOVER;
            this.Text_Result_Time.Name = "Text_Result_Time";
            this.Text_Result_Time.PasswordChar = '\0';
            this.Text_Result_Time.ReadOlay = true;
            this.Text_Result_Time.SelectedText = "";
            this.Text_Result_Time.SelectionLength = 0;
            this.Text_Result_Time.SelectionStart = 0;
            this.Text_Result_Time.Size = new System.Drawing.Size(564, 51);
            this.Text_Result_Time.TabIndex = 7;
            this.Text_Result_Time.TabStop = false;
            this.Text_Result_Time.Text = "Text";
            this.Text_Result_Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Text_Result_Time.UseSystemPasswordChar = false;
            // 
            // Text_Result_CorrectPercent
            // 
            this.Text_Result_CorrectPercent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Text_Result_CorrectPercent.BindingLabel = null;
            this.Text_Result_CorrectPercent.CorrectForeColor = System.Drawing.Color.Black;
            this.Text_Result_CorrectPercent.Depth = 0;
            this.Text_Result_CorrectPercent.ErrorForeColor = System.Drawing.Color.Red;
            this.Text_Result_CorrectPercent.ErrorModeColor = System.Drawing.Color.Red;
            this.Text_Result_CorrectPercent.ErrorModeString = "";
            this.Text_Result_CorrectPercent.FollowLabel = null;
            this.Text_Result_CorrectPercent.FollowLabelColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Text_Result_CorrectPercent.FollowLabeloldColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Text_Result_CorrectPercent.ForeColor = System.Drawing.Color.Black;
            this.Text_Result_CorrectPercent.Hint = "";
            this.Text_Result_CorrectPercent.IsErrorMode = false;
            this.Text_Result_CorrectPercent.Location = new System.Drawing.Point(213, 117);
            this.Text_Result_CorrectPercent.Margin = new System.Windows.Forms.Padding(6);
            this.Text_Result_CorrectPercent.MaxLength = 32767;
            this.Text_Result_CorrectPercent.MouseState = MaterialSkin.MouseState.HOVER;
            this.Text_Result_CorrectPercent.Name = "Text_Result_CorrectPercent";
            this.Text_Result_CorrectPercent.PasswordChar = '\0';
            this.Text_Result_CorrectPercent.ReadOlay = true;
            this.Text_Result_CorrectPercent.SelectedText = "";
            this.Text_Result_CorrectPercent.SelectionLength = 0;
            this.Text_Result_CorrectPercent.SelectionStart = 0;
            this.Text_Result_CorrectPercent.Size = new System.Drawing.Size(564, 51);
            this.Text_Result_CorrectPercent.TabIndex = 6;
            this.Text_Result_CorrectPercent.TabStop = false;
            this.Text_Result_CorrectPercent.Text = "Text";
            this.Text_Result_CorrectPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Text_Result_CorrectPercent.UseSystemPasswordChar = false;
            // 
            // Text_Result_Speed
            // 
            this.Text_Result_Speed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Text_Result_Speed.BindingLabel = null;
            this.Text_Result_Speed.CorrectForeColor = System.Drawing.Color.Black;
            this.Text_Result_Speed.Depth = 0;
            this.Text_Result_Speed.ErrorForeColor = System.Drawing.Color.Red;
            this.Text_Result_Speed.ErrorModeColor = System.Drawing.Color.Red;
            this.Text_Result_Speed.ErrorModeString = "";
            this.Text_Result_Speed.FollowLabel = null;
            this.Text_Result_Speed.FollowLabelColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Text_Result_Speed.FollowLabeloldColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Text_Result_Speed.ForeColor = System.Drawing.Color.Black;
            this.Text_Result_Speed.Hint = "";
            this.Text_Result_Speed.IsErrorMode = false;
            this.Text_Result_Speed.Location = new System.Drawing.Point(213, 59);
            this.Text_Result_Speed.Margin = new System.Windows.Forms.Padding(6);
            this.Text_Result_Speed.MaxLength = 32767;
            this.Text_Result_Speed.MouseState = MaterialSkin.MouseState.HOVER;
            this.Text_Result_Speed.Name = "Text_Result_Speed";
            this.Text_Result_Speed.PasswordChar = '\0';
            this.Text_Result_Speed.ReadOlay = true;
            this.Text_Result_Speed.SelectedText = "";
            this.Text_Result_Speed.SelectionLength = 0;
            this.Text_Result_Speed.SelectionStart = 0;
            this.Text_Result_Speed.Size = new System.Drawing.Size(564, 51);
            this.Text_Result_Speed.TabIndex = 5;
            this.Text_Result_Speed.TabStop = false;
            this.Text_Result_Speed.Text = "Text";
            this.Text_Result_Speed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Text_Result_Speed.UseSystemPasswordChar = false;
            // 
            // Label_Result_Tip_Total
            // 
            this.Label_Result_Tip_Total.Depth = 0;
            this.Label_Result_Tip_Total.Font = new System.Drawing.Font("微软雅黑", 26F);
            this.Label_Result_Tip_Total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label_Result_Tip_Total.Location = new System.Drawing.Point(6, 238);
            this.Label_Result_Tip_Total.Margin = new System.Windows.Forms.Padding(6);
            this.Label_Result_Tip_Total.MouseState = MaterialSkin.MouseState.HOVER;
            this.Label_Result_Tip_Total.Name = "Label_Result_Tip_Total";
            this.Label_Result_Tip_Total.Size = new System.Drawing.Size(195, 46);
            this.Label_Result_Tip_Total.TabIndex = 4;
            this.Label_Result_Tip_Total.Text = "总字数：";
            this.Label_Result_Tip_Total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label_Result_Tip_Time
            // 
            this.Label_Result_Tip_Time.Depth = 0;
            this.Label_Result_Tip_Time.Font = new System.Drawing.Font("微软雅黑", 26F);
            this.Label_Result_Tip_Time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label_Result_Tip_Time.Location = new System.Drawing.Point(6, 180);
            this.Label_Result_Tip_Time.Margin = new System.Windows.Forms.Padding(6);
            this.Label_Result_Tip_Time.MouseState = MaterialSkin.MouseState.HOVER;
            this.Label_Result_Tip_Time.Name = "Label_Result_Tip_Time";
            this.Label_Result_Tip_Time.Size = new System.Drawing.Size(195, 46);
            this.Label_Result_Tip_Time.TabIndex = 3;
            this.Label_Result_Tip_Time.Text = "耗时：";
            this.Label_Result_Tip_Time.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label_Result_Tip_CorrectPercent
            // 
            this.Label_Result_Tip_CorrectPercent.Depth = 0;
            this.Label_Result_Tip_CorrectPercent.Font = new System.Drawing.Font("微软雅黑", 26F);
            this.Label_Result_Tip_CorrectPercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label_Result_Tip_CorrectPercent.Location = new System.Drawing.Point(6, 122);
            this.Label_Result_Tip_CorrectPercent.Margin = new System.Windows.Forms.Padding(6);
            this.Label_Result_Tip_CorrectPercent.MouseState = MaterialSkin.MouseState.HOVER;
            this.Label_Result_Tip_CorrectPercent.Name = "Label_Result_Tip_CorrectPercent";
            this.Label_Result_Tip_CorrectPercent.Size = new System.Drawing.Size(195, 46);
            this.Label_Result_Tip_CorrectPercent.TabIndex = 2;
            this.Label_Result_Tip_CorrectPercent.Text = "正确率：";
            this.Label_Result_Tip_CorrectPercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label_Result_Tip_Speed
            // 
            this.Label_Result_Tip_Speed.Depth = 0;
            this.Label_Result_Tip_Speed.Font = new System.Drawing.Font("微软雅黑", 26F);
            this.Label_Result_Tip_Speed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label_Result_Tip_Speed.Location = new System.Drawing.Point(6, 64);
            this.Label_Result_Tip_Speed.Margin = new System.Windows.Forms.Padding(6);
            this.Label_Result_Tip_Speed.MouseState = MaterialSkin.MouseState.HOVER;
            this.Label_Result_Tip_Speed.Name = "Label_Result_Tip_Speed";
            this.Label_Result_Tip_Speed.Size = new System.Drawing.Size(195, 46);
            this.Label_Result_Tip_Speed.TabIndex = 1;
            this.Label_Result_Tip_Speed.Text = "速度：";
            this.Label_Result_Tip_Speed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label_Result_Tip
            // 
            this.Label_Result_Tip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Result_Tip.Depth = 0;
            this.Label_Result_Tip.Font = new System.Drawing.Font("微软雅黑", 26F);
            this.Label_Result_Tip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label_Result_Tip.Location = new System.Drawing.Point(14, 6);
            this.Label_Result_Tip.Margin = new System.Windows.Forms.Padding(6);
            this.Label_Result_Tip.MouseState = MaterialSkin.MouseState.HOVER;
            this.Label_Result_Tip.Name = "Label_Result_Tip";
            this.Label_Result_Tip.Size = new System.Drawing.Size(763, 46);
            this.Label_Result_Tip.TabIndex = 0;
            this.Label_Result_Tip.Text = "您的成绩如下";
            this.Label_Result_Tip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // Text_Main_Batch
            // 
            this.Text_Main_Batch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Text_Main_Batch.BindingLabel = null;
            this.Text_Main_Batch.CorrectForeColor = System.Drawing.Color.Black;
            this.Text_Main_Batch.Depth = 0;
            this.Text_Main_Batch.ErrorForeColor = System.Drawing.Color.Red;
            this.Text_Main_Batch.ErrorModeColor = System.Drawing.Color.Red;
            this.Text_Main_Batch.ErrorModeString = "";
            this.Text_Main_Batch.FollowLabel = null;
            this.Text_Main_Batch.FollowLabelColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Text_Main_Batch.FollowLabeloldColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Text_Main_Batch.ForeColor = System.Drawing.Color.Black;
            this.Text_Main_Batch.Hint = "";
            this.Text_Main_Batch.IsErrorMode = false;
            this.Text_Main_Batch.Location = new System.Drawing.Point(231, 334);
            this.Text_Main_Batch.Margin = new System.Windows.Forms.Padding(6);
            this.Text_Main_Batch.MaxLength = 32767;
            this.Text_Main_Batch.MouseState = MaterialSkin.MouseState.HOVER;
            this.Text_Main_Batch.Name = "Text_Main_Batch";
            this.Text_Main_Batch.PasswordChar = '\0';
            this.Text_Main_Batch.ReadOlay = true;
            this.Text_Main_Batch.SelectedText = "";
            this.Text_Main_Batch.SelectionLength = 0;
            this.Text_Main_Batch.SelectionStart = 0;
            this.Text_Main_Batch.Size = new System.Drawing.Size(621, 51);
            this.Text_Main_Batch.TabIndex = 14;
            this.Text_Main_Batch.TabStop = false;
            this.Text_Main_Batch.Text = "104考场";
            this.Text_Main_Batch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Text_Main_Batch.UseSystemPasswordChar = false;
            // 
            // Button_Main_Back
            // 
            this.Button_Main_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_Main_Back.Depth = 0;
            this.Button_Main_Back.Location = new System.Drawing.Point(7, 624);
            this.Button_Main_Back.MouseState = MaterialSkin.MouseState.HOVER;
            this.Button_Main_Back.Name = "Button_Main_Back";
            this.Button_Main_Back.Primary = true;
            this.Button_Main_Back.Size = new System.Drawing.Size(173, 56);
            this.Button_Main_Back.TabIndex = 15;
            this.Button_Main_Back.Text = "返回";
            this.Button_Main_Back.UseVisualStyleBackColor = true;
            this.Button_Main_Back.Click += new System.EventHandler(this.Button_Main_Back_Click);
            // 
            // Button_Main_Free
            // 
            this.Button_Main_Free.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Main_Free.Depth = 0;
            this.Button_Main_Free.Location = new System.Drawing.Point(1025, 624);
            this.Button_Main_Free.MouseState = MaterialSkin.MouseState.HOVER;
            this.Button_Main_Free.Name = "Button_Main_Free";
            this.Button_Main_Free.Primary = true;
            this.Button_Main_Free.Size = new System.Drawing.Size(173, 56);
            this.Button_Main_Free.TabIndex = 16;
            this.Button_Main_Free.Text = "自由练习";
            this.Button_Main_Free.UseVisualStyleBackColor = true;
            this.Button_Main_Free.Click += new System.EventHandler(this.Button_Main_Free_Click);
            // 
            // Button_Main_OnlineExam
            // 
            this.Button_Main_OnlineExam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Main_OnlineExam.Depth = 0;
            this.Button_Main_OnlineExam.Location = new System.Drawing.Point(846, 624);
            this.Button_Main_OnlineExam.MouseState = MaterialSkin.MouseState.HOVER;
            this.Button_Main_OnlineExam.Name = "Button_Main_OnlineExam";
            this.Button_Main_OnlineExam.Primary = true;
            this.Button_Main_OnlineExam.Size = new System.Drawing.Size(173, 56);
            this.Button_Main_OnlineExam.TabIndex = 17;
            this.Button_Main_OnlineExam.Text = "在线测试";
            this.Button_Main_OnlineExam.UseVisualStyleBackColor = true;
            this.Button_Main_OnlineExam.Click += new System.EventHandler(this.Button_Main_OnlineExam_Click);
            // 
            // Text_Main_Name
            // 
            this.Text_Main_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Text_Main_Name.BindingLabel = null;
            this.Text_Main_Name.CorrectForeColor = System.Drawing.Color.Black;
            this.Text_Main_Name.Depth = 0;
            this.Text_Main_Name.ErrorForeColor = System.Drawing.Color.Red;
            this.Text_Main_Name.ErrorModeColor = System.Drawing.Color.Red;
            this.Text_Main_Name.ErrorModeString = "";
            this.Text_Main_Name.FollowLabel = null;
            this.Text_Main_Name.FollowLabelColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Text_Main_Name.FollowLabeloldColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Text_Main_Name.ForeColor = System.Drawing.Color.Black;
            this.Text_Main_Name.Hint = "";
            this.Text_Main_Name.IsErrorMode = false;
            this.Text_Main_Name.Location = new System.Drawing.Point(6, 271);
            this.Text_Main_Name.Margin = new System.Windows.Forms.Padding(6);
            this.Text_Main_Name.MaxLength = 32767;
            this.Text_Main_Name.MouseState = MaterialSkin.MouseState.HOVER;
            this.Text_Main_Name.Name = "Text_Main_Name";
            this.Text_Main_Name.PasswordChar = '\0';
            this.Text_Main_Name.ReadOlay = true;
            this.Text_Main_Name.SelectedText = "";
            this.Text_Main_Name.SelectionLength = 0;
            this.Text_Main_Name.SelectionStart = 0;
            this.Text_Main_Name.Size = new System.Drawing.Size(213, 51);
            this.Text_Main_Name.TabIndex = 15;
            this.Text_Main_Name.TabStop = false;
            this.Text_Main_Name.Text = "姓名";
            this.Text_Main_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Text_Main_Name.UseSystemPasswordChar = false;
            // 
            // Text_Main_Number
            // 
            this.Text_Main_Number.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Text_Main_Number.BindingLabel = null;
            this.Text_Main_Number.CorrectForeColor = System.Drawing.Color.Black;
            this.Text_Main_Number.Depth = 0;
            this.Text_Main_Number.ErrorForeColor = System.Drawing.Color.Red;
            this.Text_Main_Number.ErrorModeColor = System.Drawing.Color.Red;
            this.Text_Main_Number.ErrorModeString = "";
            this.Text_Main_Number.FollowLabel = null;
            this.Text_Main_Number.FollowLabelColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Text_Main_Number.FollowLabeloldColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Text_Main_Number.ForeColor = System.Drawing.Color.Black;
            this.Text_Main_Number.Hint = "";
            this.Text_Main_Number.IsErrorMode = false;
            this.Text_Main_Number.Location = new System.Drawing.Point(6, 334);
            this.Text_Main_Number.Margin = new System.Windows.Forms.Padding(6);
            this.Text_Main_Number.MaxLength = 32767;
            this.Text_Main_Number.MouseState = MaterialSkin.MouseState.HOVER;
            this.Text_Main_Number.Name = "Text_Main_Number";
            this.Text_Main_Number.PasswordChar = '\0';
            this.Text_Main_Number.ReadOlay = true;
            this.Text_Main_Number.SelectedText = "";
            this.Text_Main_Number.SelectionLength = 0;
            this.Text_Main_Number.SelectionStart = 0;
            this.Text_Main_Number.Size = new System.Drawing.Size(213, 51);
            this.Text_Main_Number.TabIndex = 16;
            this.Text_Main_Number.TabStop = false;
            this.Text_Main_Number.Text = "学号";
            this.Text_Main_Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Text_Main_Number.UseSystemPasswordChar = false;
            // 
            // Label_Main_Tip
            // 
            this.Label_Main_Tip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Main_Tip.Depth = 0;
            this.Label_Main_Tip.Font = new System.Drawing.Font("微软雅黑", 26F);
            this.Label_Main_Tip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label_Main_Tip.Location = new System.Drawing.Point(231, 24);
            this.Label_Main_Tip.Margin = new System.Windows.Forms.Padding(6);
            this.Label_Main_Tip.MouseState = MaterialSkin.MouseState.HOVER;
            this.Label_Main_Tip.Name = "Label_Main_Tip";
            this.Label_Main_Tip.Size = new System.Drawing.Size(621, 46);
            this.Label_Main_Tip.TabIndex = 17;
            this.Label_Main_Tip.Text = "请核对您的信息";
            this.Label_Main_Tip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.TabPage_Main.ResumeLayout(false);
            this.Panel_Main_UserInformation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_UserImage)).EndInit();
            this.TabPage_SelectText.ResumeLayout(false);
            this.TabPage_Start.ResumeLayout(false);
            this.Panel_Start.ResumeLayout(false);
            this.TabPage_Examination.ResumeLayout(false);
            this.Panel_Input_Main.ResumeLayout(false);
            this.Panel_Input_Main.PerformLayout();
            this.TabPage_Result.ResumeLayout(false);
            this.Panel_Result.ResumeLayout(false);
            this.Panel_Result_Online.ResumeLayout(false);
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
        private System.Windows.Forms.Panel Panel_Result;
        private MaterialSkin.Controls.MaterialLabel Label_Result_Tip;
        private MaterialSkin.Controls.MaterialLabel Label_Result_Tip_Speed;
        private MaterialSkin.Controls.MaterialLabel Label_Result_Tip_CorrectPercent;
        private MaterialSkin.Controls.MaterialLabel Label_Result_Tip_Time;
        private MaterialSkin.Controls.MaterialLabel Label_Result_Tip_Total;
        private MaterialSkin.Controls.MaterialSingleLineTextField_Examination Text_Result_Speed;
        private MaterialSkin.Controls.MaterialSingleLineTextField_Examination Text_Result_Total;
        private MaterialSkin.Controls.MaterialSingleLineTextField_Examination Text_Result_Time;
        private MaterialSkin.Controls.MaterialSingleLineTextField_Examination Text_Result_CorrectPercent;
        private MaterialSkin.Controls.MaterialRaisedButton Button_Result_Close;
        private System.Windows.Forms.Panel Panel_Result_Online;
        private MaterialSkin.Controls.MaterialLabel Label_Result_Tip_SendResult;
        private MaterialSkin.Controls.MaterialProcessBar Process_Result_SendResult;
        private MaterialSkin.Controls.MaterialSingleLineTextField_Examination Text_Result_FinalScore;
        private MaterialSkin.Controls.MaterialLabel Label_Result_Tip_FianlScore;
        private MaterialSkin.Controls.MaterialLabel Label_Result_Tip_Percent;
        private MaterialSkin.Controls.MaterialProgressBar Progress_Result_Percent;
        private MaterialSkin.Controls.MaterialRaisedButton Button_Complete;
        private MaterialSkin.Controls.MaterialFlatButton Button_About;
        private System.Windows.Forms.Panel Panel_Main_UserInformation;
        private MaterialSkin.Controls.MaterialSingleLineTextField_Examination Text_Main_ExamRoom;
        private MaterialSkin.Controls.MaterialSingleLineTextField_Examination Text_Main_Class;
        private MaterialSkin.Controls.MaterialSingleLineTextField_Examination Text_Main_Major;
        private MaterialSkin.Controls.MaterialSingleLineTextField_Examination Text_Main_Department;
        private MaterialSkin.Controls.MaterialRaisedButton Button_Main_Back;
        private MaterialSkin.Controls.MaterialSingleLineTextField_Examination Text_Main_Batch;
        private MaterialSkin.Controls.MaterialRaisedButton Button_Main_Free;
        private MaterialSkin.Controls.MaterialRaisedButton Button_Main_OnlineExam;
        private MaterialSkin.Controls.MaterialSingleLineTextField_Examination Text_Main_Name;
        private MaterialSkin.Controls.MaterialSingleLineTextField_Examination Text_Main_Number;
        private MaterialSkin.Controls.MaterialLabel Label_Main_Tip;
    }
}

