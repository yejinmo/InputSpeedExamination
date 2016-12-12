namespace InputSpeedExamination_Controller
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
            this.TabControl_Main = new System.Windows.Forms.TabControl();
            this.TabPage_Content = new System.Windows.Forms.TabPage();
            this.Button_RefreshContent = new System.Windows.Forms.Button();
            this.Button_DeleteContent = new System.Windows.Forms.Button();
            this.Button_UpdateContent = new System.Windows.Forms.Button();
            this.Button_AddContent = new System.Windows.Forms.Button();
            this.ListView_AllContent = new System.Windows.Forms.ListView();
            this.ColumnHeader_Content_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader_Content_Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader_Content_Content = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader_Content_MD5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TabPage_ExamRoom = new System.Windows.Forms.TabPage();
            this.Button_RefreshExamRoom = new System.Windows.Forms.Button();
            this.Button_DeleteExamRoom = new System.Windows.Forms.Button();
            this.Button_EditExamRoom = new System.Windows.Forms.Button();
            this.Button_AddExamRoom = new System.Windows.Forms.Button();
            this.ListView_ExamRoom_IPList = new System.Windows.Forms.ListView();
            this.ColumnHeader_ExamRoomIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListView_ExamRoom = new System.Windows.Forms.ListView();
            this.ColumnHeader_ExamRoomID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader_ExamRoomTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TabPage_Batch = new System.Windows.Forms.TabPage();
            this.Button_Batch_Stop = new System.Windows.Forms.Button();
            this.Button_Batch_Start = new System.Windows.Forms.Button();
            this.Button_Batch_Refresh = new System.Windows.Forms.Button();
            this.Button_Batch_Delete = new System.Windows.Forms.Button();
            this.Button_Batch_Add = new System.Windows.Forms.Button();
            this.ListView_Batch_IncludePaperList = new System.Windows.Forms.ListView();
            this.ColumnHeader_IncludePaper_Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader_IncludePaper_Preview = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader_IncludePaper_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListView_BatchList = new System.Windows.Forms.ListView();
            this.ColumnHeader_BatchID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader_BatchTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader_BatchStats = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader_BatchStartTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader_BatchFinishTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader_BatchRemark = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TabPage_Stats = new System.Windows.Forms.TabPage();
            this.ListView_Stats = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.GroupBox_ExamRoom = new System.Windows.Forms.GroupBox();
            this.GroupBox_Batch = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.GroupBox_Stats = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.TabControl_Main.SuspendLayout();
            this.TabPage_Content.SuspendLayout();
            this.TabPage_ExamRoom.SuspendLayout();
            this.TabPage_Batch.SuspendLayout();
            this.TabPage_Stats.SuspendLayout();
            this.GroupBox_ExamRoom.SuspendLayout();
            this.GroupBox_Batch.SuspendLayout();
            this.GroupBox_Stats.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl_Main
            // 
            this.TabControl_Main.Controls.Add(this.TabPage_Content);
            this.TabControl_Main.Controls.Add(this.TabPage_ExamRoom);
            this.TabControl_Main.Controls.Add(this.TabPage_Batch);
            this.TabControl_Main.Controls.Add(this.TabPage_Stats);
            this.TabControl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl_Main.Location = new System.Drawing.Point(0, 0);
            this.TabControl_Main.Name = "TabControl_Main";
            this.TabControl_Main.SelectedIndex = 0;
            this.TabControl_Main.Size = new System.Drawing.Size(862, 618);
            this.TabControl_Main.TabIndex = 0;
            this.TabControl_Main.SelectedIndexChanged += new System.EventHandler(this.TabControl_Main_SelectedIndexChanged);
            // 
            // TabPage_Content
            // 
            this.TabPage_Content.BackColor = System.Drawing.Color.Transparent;
            this.TabPage_Content.Controls.Add(this.Button_RefreshContent);
            this.TabPage_Content.Controls.Add(this.Button_DeleteContent);
            this.TabPage_Content.Controls.Add(this.Button_UpdateContent);
            this.TabPage_Content.Controls.Add(this.Button_AddContent);
            this.TabPage_Content.Controls.Add(this.ListView_AllContent);
            this.TabPage_Content.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Content.Name = "TabPage_Content";
            this.TabPage_Content.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Content.Size = new System.Drawing.Size(854, 592);
            this.TabPage_Content.TabIndex = 0;
            this.TabPage_Content.Text = "内容";
            // 
            // Button_RefreshContent
            // 
            this.Button_RefreshContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_RefreshContent.Location = new System.Drawing.Point(561, 547);
            this.Button_RefreshContent.Name = "Button_RefreshContent";
            this.Button_RefreshContent.Size = new System.Drawing.Size(180, 37);
            this.Button_RefreshContent.TabIndex = 4;
            this.Button_RefreshContent.Text = "刷新";
            this.Button_RefreshContent.UseVisualStyleBackColor = true;
            this.Button_RefreshContent.Click += new System.EventHandler(this.Button_RefreshContent_Click);
            // 
            // Button_DeleteContent
            // 
            this.Button_DeleteContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_DeleteContent.Location = new System.Drawing.Point(375, 547);
            this.Button_DeleteContent.Name = "Button_DeleteContent";
            this.Button_DeleteContent.Size = new System.Drawing.Size(180, 37);
            this.Button_DeleteContent.TabIndex = 3;
            this.Button_DeleteContent.Text = "删除";
            this.Button_DeleteContent.UseVisualStyleBackColor = true;
            this.Button_DeleteContent.Click += new System.EventHandler(this.Button_DeleteContent_Click);
            // 
            // Button_UpdateContent
            // 
            this.Button_UpdateContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_UpdateContent.Location = new System.Drawing.Point(189, 547);
            this.Button_UpdateContent.Name = "Button_UpdateContent";
            this.Button_UpdateContent.Size = new System.Drawing.Size(180, 37);
            this.Button_UpdateContent.TabIndex = 2;
            this.Button_UpdateContent.Text = "编辑";
            this.Button_UpdateContent.UseVisualStyleBackColor = true;
            this.Button_UpdateContent.Click += new System.EventHandler(this.Button_UpdateContent_Click);
            // 
            // Button_AddContent
            // 
            this.Button_AddContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_AddContent.Location = new System.Drawing.Point(3, 547);
            this.Button_AddContent.Name = "Button_AddContent";
            this.Button_AddContent.Size = new System.Drawing.Size(180, 37);
            this.Button_AddContent.TabIndex = 1;
            this.Button_AddContent.Text = "添加";
            this.Button_AddContent.UseVisualStyleBackColor = true;
            this.Button_AddContent.Click += new System.EventHandler(this.Button_AddContent_Click);
            // 
            // ListView_AllContent
            // 
            this.ListView_AllContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListView_AllContent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader_Content_ID,
            this.ColumnHeader_Content_Title,
            this.ColumnHeader_Content_Content,
            this.ColumnHeader_Content_MD5});
            this.ListView_AllContent.FullRowSelect = true;
            this.ListView_AllContent.HideSelection = false;
            this.ListView_AllContent.Location = new System.Drawing.Point(3, 3);
            this.ListView_AllContent.MultiSelect = false;
            this.ListView_AllContent.Name = "ListView_AllContent";
            this.ListView_AllContent.Size = new System.Drawing.Size(848, 538);
            this.ListView_AllContent.TabIndex = 0;
            this.ListView_AllContent.UseCompatibleStateImageBehavior = false;
            this.ListView_AllContent.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader_Content_ID
            // 
            this.ColumnHeader_Content_ID.Text = "ID";
            this.ColumnHeader_Content_ID.Width = 80;
            // 
            // ColumnHeader_Content_Title
            // 
            this.ColumnHeader_Content_Title.Text = "标题";
            this.ColumnHeader_Content_Title.Width = 179;
            // 
            // ColumnHeader_Content_Content
            // 
            this.ColumnHeader_Content_Content.Text = "内容";
            this.ColumnHeader_Content_Content.Width = 203;
            // 
            // ColumnHeader_Content_MD5
            // 
            this.ColumnHeader_Content_MD5.Text = "MD5值";
            this.ColumnHeader_Content_MD5.Width = 325;
            // 
            // TabPage_ExamRoom
            // 
            this.TabPage_ExamRoom.Controls.Add(this.Button_RefreshExamRoom);
            this.TabPage_ExamRoom.Controls.Add(this.Button_DeleteExamRoom);
            this.TabPage_ExamRoom.Controls.Add(this.Button_EditExamRoom);
            this.TabPage_ExamRoom.Controls.Add(this.Button_AddExamRoom);
            this.TabPage_ExamRoom.Controls.Add(this.ListView_ExamRoom_IPList);
            this.TabPage_ExamRoom.Controls.Add(this.ListView_ExamRoom);
            this.TabPage_ExamRoom.Location = new System.Drawing.Point(4, 22);
            this.TabPage_ExamRoom.Name = "TabPage_ExamRoom";
            this.TabPage_ExamRoom.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_ExamRoom.Size = new System.Drawing.Size(854, 592);
            this.TabPage_ExamRoom.TabIndex = 1;
            this.TabPage_ExamRoom.Text = "考场";
            this.TabPage_ExamRoom.UseVisualStyleBackColor = true;
            // 
            // Button_RefreshExamRoom
            // 
            this.Button_RefreshExamRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_RefreshExamRoom.Location = new System.Drawing.Point(561, 547);
            this.Button_RefreshExamRoom.Name = "Button_RefreshExamRoom";
            this.Button_RefreshExamRoom.Size = new System.Drawing.Size(180, 37);
            this.Button_RefreshExamRoom.TabIndex = 7;
            this.Button_RefreshExamRoom.Text = "刷新";
            this.Button_RefreshExamRoom.UseVisualStyleBackColor = true;
            this.Button_RefreshExamRoom.Click += new System.EventHandler(this.Button_RefreshExamRoom_Click);
            // 
            // Button_DeleteExamRoom
            // 
            this.Button_DeleteExamRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_DeleteExamRoom.Location = new System.Drawing.Point(375, 547);
            this.Button_DeleteExamRoom.Name = "Button_DeleteExamRoom";
            this.Button_DeleteExamRoom.Size = new System.Drawing.Size(180, 37);
            this.Button_DeleteExamRoom.TabIndex = 6;
            this.Button_DeleteExamRoom.Text = "删除";
            this.Button_DeleteExamRoom.UseVisualStyleBackColor = true;
            this.Button_DeleteExamRoom.Click += new System.EventHandler(this.Button_DeleteExamRoom_Click);
            // 
            // Button_EditExamRoom
            // 
            this.Button_EditExamRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_EditExamRoom.Location = new System.Drawing.Point(189, 547);
            this.Button_EditExamRoom.Name = "Button_EditExamRoom";
            this.Button_EditExamRoom.Size = new System.Drawing.Size(180, 37);
            this.Button_EditExamRoom.TabIndex = 5;
            this.Button_EditExamRoom.Text = "编辑";
            this.Button_EditExamRoom.UseVisualStyleBackColor = true;
            this.Button_EditExamRoom.Click += new System.EventHandler(this.Button_EditExamRoom_Click);
            // 
            // Button_AddExamRoom
            // 
            this.Button_AddExamRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_AddExamRoom.Location = new System.Drawing.Point(3, 547);
            this.Button_AddExamRoom.Name = "Button_AddExamRoom";
            this.Button_AddExamRoom.Size = new System.Drawing.Size(180, 37);
            this.Button_AddExamRoom.TabIndex = 3;
            this.Button_AddExamRoom.Text = "添加";
            this.Button_AddExamRoom.UseVisualStyleBackColor = true;
            this.Button_AddExamRoom.Click += new System.EventHandler(this.Button_AddExamRoom_Click);
            // 
            // ListView_ExamRoom_IPList
            // 
            this.ListView_ExamRoom_IPList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListView_ExamRoom_IPList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader_ExamRoomIP});
            this.ListView_ExamRoom_IPList.FullRowSelect = true;
            this.ListView_ExamRoom_IPList.HideSelection = false;
            this.ListView_ExamRoom_IPList.Location = new System.Drawing.Point(600, 3);
            this.ListView_ExamRoom_IPList.MultiSelect = false;
            this.ListView_ExamRoom_IPList.Name = "ListView_ExamRoom_IPList";
            this.ListView_ExamRoom_IPList.Size = new System.Drawing.Size(246, 538);
            this.ListView_ExamRoom_IPList.TabIndex = 2;
            this.ListView_ExamRoom_IPList.UseCompatibleStateImageBehavior = false;
            this.ListView_ExamRoom_IPList.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader_ExamRoomIP
            // 
            this.ColumnHeader_ExamRoomIP.Text = "包含IP";
            this.ColumnHeader_ExamRoomIP.Width = 150;
            // 
            // ListView_ExamRoom
            // 
            this.ListView_ExamRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListView_ExamRoom.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader_ExamRoomID,
            this.ColumnHeader_ExamRoomTitle});
            this.ListView_ExamRoom.FullRowSelect = true;
            this.ListView_ExamRoom.HideSelection = false;
            this.ListView_ExamRoom.Location = new System.Drawing.Point(3, 3);
            this.ListView_ExamRoom.MultiSelect = false;
            this.ListView_ExamRoom.Name = "ListView_ExamRoom";
            this.ListView_ExamRoom.Size = new System.Drawing.Size(591, 538);
            this.ListView_ExamRoom.TabIndex = 1;
            this.ListView_ExamRoom.UseCompatibleStateImageBehavior = false;
            this.ListView_ExamRoom.View = System.Windows.Forms.View.Details;
            this.ListView_ExamRoom.Click += new System.EventHandler(this.ListView_ExamRoom_Click);
            // 
            // ColumnHeader_ExamRoomID
            // 
            this.ColumnHeader_ExamRoomID.Text = "ID";
            // 
            // ColumnHeader_ExamRoomTitle
            // 
            this.ColumnHeader_ExamRoomTitle.Text = "标题";
            this.ColumnHeader_ExamRoomTitle.Width = 275;
            // 
            // TabPage_Batch
            // 
            this.TabPage_Batch.Controls.Add(this.Button_Batch_Stop);
            this.TabPage_Batch.Controls.Add(this.Button_Batch_Start);
            this.TabPage_Batch.Controls.Add(this.Button_Batch_Refresh);
            this.TabPage_Batch.Controls.Add(this.Button_Batch_Delete);
            this.TabPage_Batch.Controls.Add(this.Button_Batch_Add);
            this.TabPage_Batch.Controls.Add(this.ListView_Batch_IncludePaperList);
            this.TabPage_Batch.Controls.Add(this.ListView_BatchList);
            this.TabPage_Batch.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Batch.Name = "TabPage_Batch";
            this.TabPage_Batch.Size = new System.Drawing.Size(854, 592);
            this.TabPage_Batch.TabIndex = 3;
            this.TabPage_Batch.Text = "批次";
            this.TabPage_Batch.UseVisualStyleBackColor = true;
            // 
            // Button_Batch_Stop
            // 
            this.Button_Batch_Stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_Batch_Stop.Location = new System.Drawing.Point(189, 504);
            this.Button_Batch_Stop.Name = "Button_Batch_Stop";
            this.Button_Batch_Stop.Size = new System.Drawing.Size(180, 37);
            this.Button_Batch_Stop.TabIndex = 15;
            this.Button_Batch_Stop.Text = "关闭选中批次";
            this.Button_Batch_Stop.UseVisualStyleBackColor = true;
            this.Button_Batch_Stop.Click += new System.EventHandler(this.Button_Batch_Stop_Click);
            // 
            // Button_Batch_Start
            // 
            this.Button_Batch_Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_Batch_Start.Location = new System.Drawing.Point(3, 504);
            this.Button_Batch_Start.Name = "Button_Batch_Start";
            this.Button_Batch_Start.Size = new System.Drawing.Size(180, 37);
            this.Button_Batch_Start.TabIndex = 14;
            this.Button_Batch_Start.Text = "开启选中批次";
            this.Button_Batch_Start.UseVisualStyleBackColor = true;
            this.Button_Batch_Start.Click += new System.EventHandler(this.Button_Batch_Start_Click);
            // 
            // Button_Batch_Refresh
            // 
            this.Button_Batch_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_Batch_Refresh.Location = new System.Drawing.Point(375, 547);
            this.Button_Batch_Refresh.Name = "Button_Batch_Refresh";
            this.Button_Batch_Refresh.Size = new System.Drawing.Size(180, 37);
            this.Button_Batch_Refresh.TabIndex = 13;
            this.Button_Batch_Refresh.Text = "刷新";
            this.Button_Batch_Refresh.UseVisualStyleBackColor = true;
            this.Button_Batch_Refresh.Click += new System.EventHandler(this.Button_Batch_Refresh_Click);
            // 
            // Button_Batch_Delete
            // 
            this.Button_Batch_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_Batch_Delete.Location = new System.Drawing.Point(189, 547);
            this.Button_Batch_Delete.Name = "Button_Batch_Delete";
            this.Button_Batch_Delete.Size = new System.Drawing.Size(180, 37);
            this.Button_Batch_Delete.TabIndex = 12;
            this.Button_Batch_Delete.Text = "删除";
            this.Button_Batch_Delete.UseVisualStyleBackColor = true;
            this.Button_Batch_Delete.Click += new System.EventHandler(this.Button_Batch_Delete_Click);
            // 
            // Button_Batch_Add
            // 
            this.Button_Batch_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_Batch_Add.Location = new System.Drawing.Point(3, 547);
            this.Button_Batch_Add.Name = "Button_Batch_Add";
            this.Button_Batch_Add.Size = new System.Drawing.Size(180, 37);
            this.Button_Batch_Add.TabIndex = 10;
            this.Button_Batch_Add.Text = "添加";
            this.Button_Batch_Add.UseVisualStyleBackColor = true;
            this.Button_Batch_Add.Click += new System.EventHandler(this.Button_Batch_Add_Click);
            // 
            // ListView_Batch_IncludePaperList
            // 
            this.ListView_Batch_IncludePaperList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListView_Batch_IncludePaperList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader_IncludePaper_ID,
            this.ColumnHeader_IncludePaper_Title,
            this.ColumnHeader_IncludePaper_Preview});
            this.ListView_Batch_IncludePaperList.FullRowSelect = true;
            this.ListView_Batch_IncludePaperList.HideSelection = false;
            this.ListView_Batch_IncludePaperList.Location = new System.Drawing.Point(421, 3);
            this.ListView_Batch_IncludePaperList.MultiSelect = false;
            this.ListView_Batch_IncludePaperList.Name = "ListView_Batch_IncludePaperList";
            this.ListView_Batch_IncludePaperList.Size = new System.Drawing.Size(430, 495);
            this.ListView_Batch_IncludePaperList.TabIndex = 9;
            this.ListView_Batch_IncludePaperList.UseCompatibleStateImageBehavior = false;
            this.ListView_Batch_IncludePaperList.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader_IncludePaper_Title
            // 
            this.ColumnHeader_IncludePaper_Title.Text = "标题";
            this.ColumnHeader_IncludePaper_Title.Width = 100;
            // 
            // ColumnHeader_IncludePaper_Preview
            // 
            this.ColumnHeader_IncludePaper_Preview.Text = "内容";
            // 
            // ColumnHeader_IncludePaper_ID
            // 
            this.ColumnHeader_IncludePaper_ID.Text = "ID";
            // 
            // ListView_BatchList
            // 
            this.ListView_BatchList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListView_BatchList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader_BatchID,
            this.ColumnHeader_BatchTitle,
            this.ColumnHeader_BatchStats,
            this.ColumnHeader_BatchStartTime,
            this.ColumnHeader_BatchFinishTime,
            this.ColumnHeader_BatchRemark});
            this.ListView_BatchList.FullRowSelect = true;
            this.ListView_BatchList.HideSelection = false;
            this.ListView_BatchList.Location = new System.Drawing.Point(3, 3);
            this.ListView_BatchList.MultiSelect = false;
            this.ListView_BatchList.Name = "ListView_BatchList";
            this.ListView_BatchList.Size = new System.Drawing.Size(412, 495);
            this.ListView_BatchList.TabIndex = 8;
            this.ListView_BatchList.UseCompatibleStateImageBehavior = false;
            this.ListView_BatchList.View = System.Windows.Forms.View.Details;
            this.ListView_BatchList.Click += new System.EventHandler(this.ListView_BatchList_Click);
            // 
            // ColumnHeader_BatchID
            // 
            this.ColumnHeader_BatchID.Text = "ID";
            // 
            // ColumnHeader_BatchTitle
            // 
            this.ColumnHeader_BatchTitle.Text = "标题";
            this.ColumnHeader_BatchTitle.Width = 100;
            // 
            // ColumnHeader_BatchStats
            // 
            this.ColumnHeader_BatchStats.Text = "状态";
            this.ColumnHeader_BatchStats.Width = 100;
            // 
            // ColumnHeader_BatchStartTime
            // 
            this.ColumnHeader_BatchStartTime.Text = "开启时间";
            this.ColumnHeader_BatchStartTime.Width = 100;
            // 
            // ColumnHeader_BatchFinishTime
            // 
            this.ColumnHeader_BatchFinishTime.Text = "关闭时间";
            this.ColumnHeader_BatchFinishTime.Width = 100;
            // 
            // ColumnHeader_BatchRemark
            // 
            this.ColumnHeader_BatchRemark.Text = "备注";
            this.ColumnHeader_BatchRemark.Width = 100;
            // 
            // TabPage_Stats
            // 
            this.TabPage_Stats.Controls.Add(this.GroupBox_Stats);
            this.TabPage_Stats.Controls.Add(this.GroupBox_Batch);
            this.TabPage_Stats.Controls.Add(this.GroupBox_ExamRoom);
            this.TabPage_Stats.Controls.Add(this.ListView_Stats);
            this.TabPage_Stats.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Stats.Name = "TabPage_Stats";
            this.TabPage_Stats.Size = new System.Drawing.Size(854, 592);
            this.TabPage_Stats.TabIndex = 2;
            this.TabPage_Stats.Text = "状态";
            this.TabPage_Stats.UseVisualStyleBackColor = true;
            // 
            // ListView_Stats
            // 
            this.ListView_Stats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListView_Stats.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.ListView_Stats.FullRowSelect = true;
            this.ListView_Stats.HideSelection = false;
            this.ListView_Stats.Location = new System.Drawing.Point(3, 52);
            this.ListView_Stats.MultiSelect = false;
            this.ListView_Stats.Name = "ListView_Stats";
            this.ListView_Stats.Size = new System.Drawing.Size(848, 532);
            this.ListView_Stats.TabIndex = 1;
            this.ListView_Stats.UseCompatibleStateImageBehavior = false;
            this.ListView_Stats.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "标题";
            this.columnHeader2.Width = 179;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "内容";
            this.columnHeader3.Width = 203;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "MD5值";
            this.columnHeader4.Width = 325;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(194, 20);
            this.comboBox1.TabIndex = 2;
            // 
            // GroupBox_ExamRoom
            // 
            this.GroupBox_ExamRoom.Controls.Add(this.comboBox1);
            this.GroupBox_ExamRoom.Location = new System.Drawing.Point(3, 3);
            this.GroupBox_ExamRoom.Name = "GroupBox_ExamRoom";
            this.GroupBox_ExamRoom.Size = new System.Drawing.Size(200, 43);
            this.GroupBox_ExamRoom.TabIndex = 3;
            this.GroupBox_ExamRoom.TabStop = false;
            this.GroupBox_ExamRoom.Text = "考场";
            // 
            // GroupBox_Batch
            // 
            this.GroupBox_Batch.Controls.Add(this.comboBox2);
            this.GroupBox_Batch.Location = new System.Drawing.Point(209, 3);
            this.GroupBox_Batch.Name = "GroupBox_Batch";
            this.GroupBox_Batch.Size = new System.Drawing.Size(200, 43);
            this.GroupBox_Batch.TabIndex = 4;
            this.GroupBox_Batch.TabStop = false;
            this.GroupBox_Batch.Text = "批次";
            // 
            // comboBox2
            // 
            this.comboBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(3, 17);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(194, 20);
            this.comboBox2.TabIndex = 2;
            // 
            // GroupBox_Stats
            // 
            this.GroupBox_Stats.Controls.Add(this.comboBox3);
            this.GroupBox_Stats.Location = new System.Drawing.Point(415, 3);
            this.GroupBox_Stats.Name = "GroupBox_Stats";
            this.GroupBox_Stats.Size = new System.Drawing.Size(200, 43);
            this.GroupBox_Stats.TabIndex = 5;
            this.GroupBox_Stats.TabStop = false;
            this.GroupBox_Stats.Text = "状态";
            // 
            // comboBox3
            // 
            this.comboBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(3, 17);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(194, 20);
            this.comboBox3.TabIndex = 2;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 618);
            this.Controls.Add(this.TabControl_Main);
            this.Font = new System.Drawing.Font("宋体", 9F);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "控制端";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.TabControl_Main.ResumeLayout(false);
            this.TabPage_Content.ResumeLayout(false);
            this.TabPage_ExamRoom.ResumeLayout(false);
            this.TabPage_Batch.ResumeLayout(false);
            this.TabPage_Stats.ResumeLayout(false);
            this.GroupBox_ExamRoom.ResumeLayout(false);
            this.GroupBox_Batch.ResumeLayout(false);
            this.GroupBox_Stats.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl_Main;
        private System.Windows.Forms.TabPage TabPage_Content;
        private System.Windows.Forms.TabPage TabPage_ExamRoom;
        private System.Windows.Forms.TabPage TabPage_Stats;
        private System.Windows.Forms.ListView ListView_AllContent;
        private System.Windows.Forms.Button Button_AddContent;
        private System.Windows.Forms.Button Button_RefreshContent;
        private System.Windows.Forms.Button Button_DeleteContent;
        private System.Windows.Forms.Button Button_UpdateContent;
        private System.Windows.Forms.ColumnHeader ColumnHeader_Content_ID;
        private System.Windows.Forms.ColumnHeader ColumnHeader_Content_Title;
        private System.Windows.Forms.ColumnHeader ColumnHeader_Content_Content;
        private System.Windows.Forms.ColumnHeader ColumnHeader_Content_MD5;
        private System.Windows.Forms.ListView ListView_ExamRoom;
        private System.Windows.Forms.ColumnHeader ColumnHeader_ExamRoomID;
        private System.Windows.Forms.ColumnHeader ColumnHeader_ExamRoomTitle;
        private System.Windows.Forms.ListView ListView_ExamRoom_IPList;
        private System.Windows.Forms.ColumnHeader ColumnHeader_ExamRoomIP;
        private System.Windows.Forms.Button Button_AddExamRoom;
        private System.Windows.Forms.Button Button_RefreshExamRoom;
        private System.Windows.Forms.Button Button_DeleteExamRoom;
        private System.Windows.Forms.Button Button_EditExamRoom;
        private System.Windows.Forms.TabPage TabPage_Batch;
        private System.Windows.Forms.Button Button_Batch_Refresh;
        private System.Windows.Forms.Button Button_Batch_Delete;
        private System.Windows.Forms.Button Button_Batch_Add;
        private System.Windows.Forms.ListView ListView_Batch_IncludePaperList;
        private System.Windows.Forms.ColumnHeader ColumnHeader_IncludePaper_Title;
        private System.Windows.Forms.ListView ListView_BatchList;
        private System.Windows.Forms.ColumnHeader ColumnHeader_BatchID;
        private System.Windows.Forms.ColumnHeader ColumnHeader_BatchTitle;
        private System.Windows.Forms.ColumnHeader ColumnHeader_BatchStats;
        private System.Windows.Forms.ColumnHeader ColumnHeader_BatchStartTime;
        private System.Windows.Forms.ColumnHeader ColumnHeader_BatchFinishTime;
        private System.Windows.Forms.ColumnHeader ColumnHeader_BatchRemark;
        private System.Windows.Forms.ColumnHeader ColumnHeader_IncludePaper_Preview;
        private System.Windows.Forms.ColumnHeader ColumnHeader_IncludePaper_ID;
        private System.Windows.Forms.Button Button_Batch_Start;
        private System.Windows.Forms.Button Button_Batch_Stop;
        private System.Windows.Forms.ListView ListView_Stats;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox GroupBox_ExamRoom;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox GroupBox_Batch;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox GroupBox_Stats;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}

