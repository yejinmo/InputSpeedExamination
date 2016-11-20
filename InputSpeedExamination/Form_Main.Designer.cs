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
            this.FlatButton_Select_OnLine = new MaterialSkin.Controls.MaterialFlatButton();
            this.FlatButton_Select_OffLine = new MaterialSkin.Controls.MaterialFlatButton();
            this.WebView_Select_BG = new System.Windows.Forms.WebBrowser();
            this.TabPage_Examination = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
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
            this.Timer_Clocks = new System.Windows.Forms.Timer(this.components);
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.materialRaisedButton2);
            this.panel1.Controls.Add(this.materialRaisedButton1);
            this.panel1.Controls.Add(this.Examination_Lable_1);
            this.panel1.Controls.Add(this.Examination_TextLine_5);
            this.panel1.Controls.Add(this.Examination_TextLine_1);
            this.panel1.Controls.Add(this.Examination_TextLine_4);
            this.panel1.Controls.Add(this.Examination_Lable_2);
            this.panel1.Controls.Add(this.Examination_TextLine_3);
            this.panel1.Controls.Add(this.Examination_Lable_3);
            this.panel1.Controls.Add(this.Examination_TextLine_2);
            this.panel1.Controls.Add(this.Examination_Lable_4);
            this.panel1.Controls.Add(this.Examination_Lable_5);
            this.panel1.Location = new System.Drawing.Point(34, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1091, 691);
            this.panel1.TabIndex = 10;
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(913, 632);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(174, 56);
            this.materialRaisedButton2.TabIndex = 11;
            this.materialRaisedButton2.Text = "下一页";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(733, 632);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(174, 56);
            this.materialRaisedButton1.TabIndex = 10;
            this.materialRaisedButton1.Text = "上一页";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
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
            this.Examination_Lable_1.Location = new System.Drawing.Point(4, 6);
            this.Examination_Lable_1.Margin = new System.Windows.Forms.Padding(2);
            this.Examination_Lable_1.MouseState = MaterialSkin.MouseState.HOVER;
            this.Examination_Lable_1.Name = "Examination_Lable_1";
            this.Examination_Lable_1.Size = new System.Drawing.Size(1085, 50);
            this.Examination_Lable_1.TabIndex = 1;
            this.Examination_Lable_1.TextFieldString = "";
            this.Examination_Lable_1.TextString = "123   一二三abc   ";
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
            this.Examination_TextLine_5.Location = new System.Drawing.Point(10, 496);
            this.Examination_TextLine_5.Margin = new System.Windows.Forms.Padding(2);
            this.Examination_TextLine_5.MaxLength = 32767;
            this.Examination_TextLine_5.MouseState = MaterialSkin.MouseState.HOVER;
            this.Examination_TextLine_5.Name = "Examination_TextLine_5";
            this.Examination_TextLine_5.PasswordChar = '\0';
            this.Examination_TextLine_5.ReadOlay = false;
            this.Examination_TextLine_5.SelectedText = "";
            this.Examination_TextLine_5.SelectionLength = 0;
            this.Examination_TextLine_5.SelectionStart = 0;
            this.Examination_TextLine_5.Size = new System.Drawing.Size(1079, 51);
            this.Examination_TextLine_5.TabIndex = 9;
            this.Examination_TextLine_5.TabStop = false;
            this.Examination_TextLine_5.UseSystemPasswordChar = false;
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
            this.Examination_Lable_5.Location = new System.Drawing.Point(4, 442);
            this.Examination_Lable_5.Margin = new System.Windows.Forms.Padding(2);
            this.Examination_Lable_5.MouseState = MaterialSkin.MouseState.HOVER;
            this.Examination_Lable_5.Name = "Examination_Lable_5";
            this.Examination_Lable_5.Size = new System.Drawing.Size(1085, 50);
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
            this.Examination_TextLine_1.Location = new System.Drawing.Point(10, 60);
            this.Examination_TextLine_1.Margin = new System.Windows.Forms.Padding(2);
            this.Examination_TextLine_1.MaxLength = 0;
            this.Examination_TextLine_1.MouseState = MaterialSkin.MouseState.HOVER;
            this.Examination_TextLine_1.Name = "Examination_TextLine_1";
            this.Examination_TextLine_1.PasswordChar = '\0';
            this.Examination_TextLine_1.ReadOlay = false;
            this.Examination_TextLine_1.SelectedText = "";
            this.Examination_TextLine_1.SelectionLength = 0;
            this.Examination_TextLine_1.SelectionStart = 0;
            this.Examination_TextLine_1.Size = new System.Drawing.Size(1079, 51);
            this.Examination_TextLine_1.TabIndex = 0;
            this.Examination_TextLine_1.TabStop = false;
            this.Examination_TextLine_1.UseSystemPasswordChar = false;
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
            this.Examination_TextLine_4.Location = new System.Drawing.Point(10, 387);
            this.Examination_TextLine_4.Margin = new System.Windows.Forms.Padding(2);
            this.Examination_TextLine_4.MaxLength = 32767;
            this.Examination_TextLine_4.MouseState = MaterialSkin.MouseState.HOVER;
            this.Examination_TextLine_4.Name = "Examination_TextLine_4";
            this.Examination_TextLine_4.PasswordChar = '\0';
            this.Examination_TextLine_4.ReadOlay = false;
            this.Examination_TextLine_4.SelectedText = "";
            this.Examination_TextLine_4.SelectionLength = 0;
            this.Examination_TextLine_4.SelectionStart = 0;
            this.Examination_TextLine_4.Size = new System.Drawing.Size(1079, 51);
            this.Examination_TextLine_4.TabIndex = 8;
            this.Examination_TextLine_4.TabStop = false;
            this.Examination_TextLine_4.UseSystemPasswordChar = false;
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
            this.Examination_Lable_4.Location = new System.Drawing.Point(4, 333);
            this.Examination_Lable_4.Margin = new System.Windows.Forms.Padding(2);
            this.Examination_Lable_4.MouseState = MaterialSkin.MouseState.HOVER;
            this.Examination_Lable_4.Name = "Examination_Lable_4";
            this.Examination_Lable_4.Size = new System.Drawing.Size(1085, 50);
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
            this.Examination_Lable_2.Location = new System.Drawing.Point(4, 115);
            this.Examination_Lable_2.Margin = new System.Windows.Forms.Padding(2);
            this.Examination_Lable_2.MouseState = MaterialSkin.MouseState.HOVER;
            this.Examination_Lable_2.Name = "Examination_Lable_2";
            this.Examination_Lable_2.Size = new System.Drawing.Size(1085, 50);
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
            this.Examination_TextLine_3.Location = new System.Drawing.Point(10, 278);
            this.Examination_TextLine_3.Margin = new System.Windows.Forms.Padding(2);
            this.Examination_TextLine_3.MaxLength = 32767;
            this.Examination_TextLine_3.MouseState = MaterialSkin.MouseState.HOVER;
            this.Examination_TextLine_3.Name = "Examination_TextLine_3";
            this.Examination_TextLine_3.PasswordChar = '\0';
            this.Examination_TextLine_3.ReadOlay = false;
            this.Examination_TextLine_3.SelectedText = "";
            this.Examination_TextLine_3.SelectionLength = 0;
            this.Examination_TextLine_3.SelectionStart = 0;
            this.Examination_TextLine_3.Size = new System.Drawing.Size(1079, 51);
            this.Examination_TextLine_3.TabIndex = 7;
            this.Examination_TextLine_3.TabStop = false;
            this.Examination_TextLine_3.UseSystemPasswordChar = false;
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
            this.Examination_Lable_3.Location = new System.Drawing.Point(4, 224);
            this.Examination_Lable_3.Margin = new System.Windows.Forms.Padding(2);
            this.Examination_Lable_3.MouseState = MaterialSkin.MouseState.HOVER;
            this.Examination_Lable_3.Name = "Examination_Lable_3";
            this.Examination_Lable_3.Size = new System.Drawing.Size(1085, 50);
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
            this.Examination_TextLine_2.Location = new System.Drawing.Point(10, 169);
            this.Examination_TextLine_2.Margin = new System.Windows.Forms.Padding(2);
            this.Examination_TextLine_2.MaxLength = 32767;
            this.Examination_TextLine_2.MouseState = MaterialSkin.MouseState.HOVER;
            this.Examination_TextLine_2.Name = "Examination_TextLine_2";
            this.Examination_TextLine_2.PasswordChar = '\0';
            this.Examination_TextLine_2.ReadOlay = false;
            this.Examination_TextLine_2.SelectedText = "";
            this.Examination_TextLine_2.SelectionLength = 0;
            this.Examination_TextLine_2.SelectionStart = 0;
            this.Examination_TextLine_2.Size = new System.Drawing.Size(1079, 51);
            this.Examination_TextLine_2.TabIndex = 6;
            this.Examination_TextLine_2.TabStop = false;
            this.Examination_TextLine_2.UseSystemPasswordChar = false;
            this.Examination_TextLine_2.TextChanged += new System.EventHandler(this.Examination_TextLine_2_TextChanged);
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
            this.ClientSize = new System.Drawing.Size(1169, 816);
            this.Controls.Add(this.TabControl_Main);
            this.MinimumSize = new System.Drawing.Size(600, 480);
            this.Name = "Form_Main";
            this.Text = "键盘录入测试";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer Timer_Clocks;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
    }
}

