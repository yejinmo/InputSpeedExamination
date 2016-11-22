﻿namespace InputSpeedExamination
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
            this.FlatButton_Select_OnLine = new MaterialSkin.Controls.MaterialFlatButton();
            this.FlatButton_Select_OffLine = new MaterialSkin.Controls.MaterialFlatButton();
            this.WebView_Select_BG = new System.Windows.Forms.WebBrowser();
            this.TabPage_Examination = new System.Windows.Forms.TabPage();
            this.Panel_Input_Main = new System.Windows.Forms.Panel();
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
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Timer_Clocks = new System.Windows.Forms.Timer(this.components);
            this.TabControl_Main.SuspendLayout();
            this.TabPage_Select.SuspendLayout();
            this.TabPage_Examination.SuspendLayout();
            this.Panel_Input_Main.SuspendLayout();
            this.TabPage_Start.SuspendLayout();
            this.Panel_Start.SuspendLayout();
            this.TabPage_SelectText.SuspendLayout();
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
            this.TabControl_Main.Depth = 0;
            this.TabControl_Main.Location = new System.Drawing.Point(1, 66);
            this.TabControl_Main.Margin = new System.Windows.Forms.Padding(1);
            this.TabControl_Main.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabControl_Main.Name = "TabControl_Main";
            this.TabControl_Main.SelectedIndex = 0;
            this.TabControl_Main.Size = new System.Drawing.Size(1053, 709);
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
            this.TabPage_Select.Size = new System.Drawing.Size(1045, 683);
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
            this.WebView_Select_BG.Size = new System.Drawing.Size(1039, 677);
            this.WebView_Select_BG.TabIndex = 2;
            // 
            // TabPage_Examination
            // 
            this.TabPage_Examination.BackColor = System.Drawing.Color.White;
            this.TabPage_Examination.Controls.Add(this.Panel_Input_Main);
            this.TabPage_Examination.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Examination.Name = "TabPage_Examination";
            this.TabPage_Examination.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Examination.Size = new System.Drawing.Size(1045, 683);
            this.TabPage_Examination.TabIndex = 1;
            this.TabPage_Examination.Text = "tabPage2";
            // 
            // Panel_Input_Main
            // 
            this.Panel_Input_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.Panel_Input_Main.Location = new System.Drawing.Point(34, 11);
            this.Panel_Input_Main.Margin = new System.Windows.Forms.Padding(30);
            this.Panel_Input_Main.Name = "Panel_Input_Main";
            this.Panel_Input_Main.Size = new System.Drawing.Size(981, 651);
            this.Panel_Input_Main.TabIndex = 10;
            // 
            // Button_Pause_Continue
            // 
            this.Button_Pause_Continue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Pause_Continue.Depth = 0;
            this.Button_Pause_Continue.Location = new System.Drawing.Point(849, 592);
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
            this.Label_Stats_Time.Location = new System.Drawing.Point(4, 592);
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
            this.Button_Next_Page.Location = new System.Drawing.Point(714, 592);
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
            this.Button_Previous_Page.Location = new System.Drawing.Point(579, 592);
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
            this.Examination_Lable_1.Size = new System.Drawing.Size(967, 50);
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
            this.Examination_TextLine_5.Size = new System.Drawing.Size(967, 51);
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
            this.Examination_Lable_5.Size = new System.Drawing.Size(967, 50);
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
            this.Examination_TextLine_1.Size = new System.Drawing.Size(967, 51);
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
            this.Examination_TextLine_4.Size = new System.Drawing.Size(967, 51);
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
            this.Examination_Lable_4.Size = new System.Drawing.Size(967, 50);
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
            this.Examination_Lable_2.Size = new System.Drawing.Size(967, 50);
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
            this.Examination_TextLine_3.Size = new System.Drawing.Size(967, 51);
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
            this.Examination_Lable_3.Size = new System.Drawing.Size(967, 50);
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
            this.Examination_TextLine_2.Size = new System.Drawing.Size(967, 51);
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
            this.TabPage_Start.Size = new System.Drawing.Size(1045, 683);
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
            this.TabPage_SelectText.Controls.Add(this.materialListView1);
            this.TabPage_SelectText.Location = new System.Drawing.Point(4, 22);
            this.TabPage_SelectText.Name = "TabPage_SelectText";
            this.TabPage_SelectText.Size = new System.Drawing.Size(1045, 683);
            this.TabPage_SelectText.TabIndex = 3;
            this.TabPage_SelectText.Text = "TabPage_SelectText";
            this.TabPage_SelectText.UseVisualStyleBackColor = true;
            // 
            // materialListView1
            // 
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1});
            this.materialListView1.Depth = 0;
            this.materialListView1.Font = new System.Drawing.Font("微软雅黑", 16F);
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.materialListView1.Location = new System.Drawing.Point(199, 96);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(287, 413);
            this.materialListView1.TabIndex = 0;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "类别";
            // 
            // Timer_Clocks
            // 
            this.Timer_Clocks.Interval = 1000;
            this.Timer_Clocks.Tick += new System.EventHandler(this.Timer_Clocks_Tick);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 776);
            this.Controls.Add(this.TabControl_Main);
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
            this.TabPage_Examination.ResumeLayout(false);
            this.Panel_Input_Main.ResumeLayout(false);
            this.Panel_Input_Main.PerformLayout();
            this.TabPage_Start.ResumeLayout(false);
            this.Panel_Start.ResumeLayout(false);
            this.TabPage_SelectText.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl TabControl_Main;
        private System.Windows.Forms.TabPage TabPage_Select;
        private System.Windows.Forms.TabPage TabPage_Examination;
        private MaterialSkin.Controls.MaterialFlatButton FlatButton_Select_OffLine;
        private MaterialSkin.Controls.MaterialFlatButton FlatButton_Select_OnLine;
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
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private System.Windows.Forms.ColumnHeader ColumnHeader1;
    }
}

