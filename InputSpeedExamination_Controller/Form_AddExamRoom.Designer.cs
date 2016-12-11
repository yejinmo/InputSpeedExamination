namespace InputSpeedExamination_Controller
{
    partial class Form_AddExamRoom
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
            this.GroupBox_Title = new System.Windows.Forms.GroupBox();
            this.Text_Title = new System.Windows.Forms.TextBox();
            this.GroupBox_IncludeIP = new System.Windows.Forms.GroupBox();
            this.ListView_ExamRoom_IPList = new System.Windows.Forms.ListView();
            this.ColumnHeader_ExamRoomIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Button_Close = new System.Windows.Forms.Button();
            this.Button_Clear = new System.Windows.Forms.Button();
            this.Button_Add = new System.Windows.Forms.Button();
            this.GroupBox_AddIPs = new System.Windows.Forms.GroupBox();
            this.Button_AddIPs = new System.Windows.Forms.Button();
            this.GroupBox_End = new System.Windows.Forms.GroupBox();
            this.Text_IPEnd = new System.Windows.Forms.TextBox();
            this.GroupBox_Start = new System.Windows.Forms.GroupBox();
            this.Text_IPStart = new System.Windows.Forms.TextBox();
            this.GroupBox_AddIP = new System.Windows.Forms.GroupBox();
            this.BUtton_AddIP = new System.Windows.Forms.Button();
            this.GroupBox_SingleIP = new System.Windows.Forms.GroupBox();
            this.Text_SingleIP = new System.Windows.Forms.TextBox();
            this.Button_Delete = new System.Windows.Forms.Button();
            this.GroupBox_Title.SuspendLayout();
            this.GroupBox_IncludeIP.SuspendLayout();
            this.GroupBox_AddIPs.SuspendLayout();
            this.GroupBox_End.SuspendLayout();
            this.GroupBox_Start.SuspendLayout();
            this.GroupBox_AddIP.SuspendLayout();
            this.GroupBox_SingleIP.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox_Title
            // 
            this.GroupBox_Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_Title.Controls.Add(this.Text_Title);
            this.GroupBox_Title.Location = new System.Drawing.Point(10, 10);
            this.GroupBox_Title.Name = "GroupBox_Title";
            this.GroupBox_Title.Size = new System.Drawing.Size(636, 41);
            this.GroupBox_Title.TabIndex = 1;
            this.GroupBox_Title.TabStop = false;
            this.GroupBox_Title.Text = "标题";
            // 
            // Text_Title
            // 
            this.Text_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Text_Title.Location = new System.Drawing.Point(3, 17);
            this.Text_Title.Name = "Text_Title";
            this.Text_Title.Size = new System.Drawing.Size(630, 21);
            this.Text_Title.TabIndex = 0;
            // 
            // GroupBox_IncludeIP
            // 
            this.GroupBox_IncludeIP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_IncludeIP.Controls.Add(this.ListView_ExamRoom_IPList);
            this.GroupBox_IncludeIP.Location = new System.Drawing.Point(10, 57);
            this.GroupBox_IncludeIP.Margin = new System.Windows.Forms.Padding(2);
            this.GroupBox_IncludeIP.Name = "GroupBox_IncludeIP";
            this.GroupBox_IncludeIP.Padding = new System.Windows.Forms.Padding(2);
            this.GroupBox_IncludeIP.Size = new System.Drawing.Size(451, 456);
            this.GroupBox_IncludeIP.TabIndex = 2;
            this.GroupBox_IncludeIP.TabStop = false;
            this.GroupBox_IncludeIP.Text = "包含IP";
            // 
            // ListView_ExamRoom_IPList
            // 
            this.ListView_ExamRoom_IPList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader_ExamRoomIP});
            this.ListView_ExamRoom_IPList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListView_ExamRoom_IPList.FullRowSelect = true;
            this.ListView_ExamRoom_IPList.HideSelection = false;
            this.ListView_ExamRoom_IPList.Location = new System.Drawing.Point(2, 16);
            this.ListView_ExamRoom_IPList.Margin = new System.Windows.Forms.Padding(2);
            this.ListView_ExamRoom_IPList.MultiSelect = false;
            this.ListView_ExamRoom_IPList.Name = "ListView_ExamRoom_IPList";
            this.ListView_ExamRoom_IPList.Size = new System.Drawing.Size(447, 438);
            this.ListView_ExamRoom_IPList.TabIndex = 3;
            this.ListView_ExamRoom_IPList.UseCompatibleStateImageBehavior = false;
            this.ListView_ExamRoom_IPList.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader_ExamRoomIP
            // 
            this.ColumnHeader_ExamRoomIP.Text = "包含IP";
            this.ColumnHeader_ExamRoomIP.Width = 502;
            // 
            // Button_Close
            // 
            this.Button_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Close.Location = new System.Drawing.Point(466, 476);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(180, 37);
            this.Button_Close.TabIndex = 4;
            this.Button_Close.Text = "关闭";
            this.Button_Close.UseVisualStyleBackColor = true;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // Button_Clear
            // 
            this.Button_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Clear.Location = new System.Drawing.Point(466, 351);
            this.Button_Clear.Name = "Button_Clear";
            this.Button_Clear.Size = new System.Drawing.Size(180, 37);
            this.Button_Clear.TabIndex = 6;
            this.Button_Clear.Text = "清空";
            this.Button_Clear.UseVisualStyleBackColor = true;
            this.Button_Clear.Click += new System.EventHandler(this.Button_Clear_Click);
            // 
            // Button_Add
            // 
            this.Button_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Add.Location = new System.Drawing.Point(466, 394);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(180, 37);
            this.Button_Add.TabIndex = 7;
            this.Button_Add.Text = "添加";
            this.Button_Add.UseVisualStyleBackColor = true;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // GroupBox_AddIPs
            // 
            this.GroupBox_AddIPs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_AddIPs.Controls.Add(this.Button_AddIPs);
            this.GroupBox_AddIPs.Controls.Add(this.GroupBox_End);
            this.GroupBox_AddIPs.Controls.Add(this.GroupBox_Start);
            this.GroupBox_AddIPs.Location = new System.Drawing.Point(463, 57);
            this.GroupBox_AddIPs.Margin = new System.Windows.Forms.Padding(2);
            this.GroupBox_AddIPs.Name = "GroupBox_AddIPs";
            this.GroupBox_AddIPs.Padding = new System.Windows.Forms.Padding(2);
            this.GroupBox_AddIPs.Size = new System.Drawing.Size(183, 142);
            this.GroupBox_AddIPs.TabIndex = 8;
            this.GroupBox_AddIPs.TabStop = false;
            this.GroupBox_AddIPs.Text = "IP段添加";
            // 
            // Button_AddIPs
            // 
            this.Button_AddIPs.Location = new System.Drawing.Point(4, 108);
            this.Button_AddIPs.Margin = new System.Windows.Forms.Padding(2);
            this.Button_AddIPs.Name = "Button_AddIPs";
            this.Button_AddIPs.Size = new System.Drawing.Size(174, 30);
            this.Button_AddIPs.TabIndex = 2;
            this.Button_AddIPs.Text = "添加此范围的IP";
            this.Button_AddIPs.UseVisualStyleBackColor = true;
            this.Button_AddIPs.Click += new System.EventHandler(this.Button_AddIPs_Click);
            // 
            // GroupBox_End
            // 
            this.GroupBox_End.Controls.Add(this.Text_IPEnd);
            this.GroupBox_End.Location = new System.Drawing.Point(4, 62);
            this.GroupBox_End.Margin = new System.Windows.Forms.Padding(2);
            this.GroupBox_End.Name = "GroupBox_End";
            this.GroupBox_End.Padding = new System.Windows.Forms.Padding(2);
            this.GroupBox_End.Size = new System.Drawing.Size(174, 41);
            this.GroupBox_End.TabIndex = 1;
            this.GroupBox_End.TabStop = false;
            this.GroupBox_End.Text = "终止IP";
            // 
            // Text_IPEnd
            // 
            this.Text_IPEnd.Location = new System.Drawing.Point(4, 16);
            this.Text_IPEnd.Margin = new System.Windows.Forms.Padding(2);
            this.Text_IPEnd.Name = "Text_IPEnd";
            this.Text_IPEnd.Size = new System.Drawing.Size(166, 21);
            this.Text_IPEnd.TabIndex = 0;
            // 
            // GroupBox_Start
            // 
            this.GroupBox_Start.Controls.Add(this.Text_IPStart);
            this.GroupBox_Start.Location = new System.Drawing.Point(4, 17);
            this.GroupBox_Start.Margin = new System.Windows.Forms.Padding(2);
            this.GroupBox_Start.Name = "GroupBox_Start";
            this.GroupBox_Start.Padding = new System.Windows.Forms.Padding(2);
            this.GroupBox_Start.Size = new System.Drawing.Size(174, 41);
            this.GroupBox_Start.TabIndex = 0;
            this.GroupBox_Start.TabStop = false;
            this.GroupBox_Start.Text = "起始IP";
            // 
            // Text_IPStart
            // 
            this.Text_IPStart.Location = new System.Drawing.Point(4, 16);
            this.Text_IPStart.Margin = new System.Windows.Forms.Padding(2);
            this.Text_IPStart.Name = "Text_IPStart";
            this.Text_IPStart.Size = new System.Drawing.Size(166, 21);
            this.Text_IPStart.TabIndex = 0;
            // 
            // GroupBox_AddIP
            // 
            this.GroupBox_AddIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_AddIP.Controls.Add(this.BUtton_AddIP);
            this.GroupBox_AddIP.Controls.Add(this.GroupBox_SingleIP);
            this.GroupBox_AddIP.Location = new System.Drawing.Point(463, 204);
            this.GroupBox_AddIP.Margin = new System.Windows.Forms.Padding(2);
            this.GroupBox_AddIP.Name = "GroupBox_AddIP";
            this.GroupBox_AddIP.Padding = new System.Windows.Forms.Padding(2);
            this.GroupBox_AddIP.Size = new System.Drawing.Size(183, 98);
            this.GroupBox_AddIP.TabIndex = 9;
            this.GroupBox_AddIP.TabStop = false;
            this.GroupBox_AddIP.Text = "逐个IP添加";
            // 
            // BUtton_AddIP
            // 
            this.BUtton_AddIP.Location = new System.Drawing.Point(4, 65);
            this.BUtton_AddIP.Margin = new System.Windows.Forms.Padding(2);
            this.BUtton_AddIP.Name = "BUtton_AddIP";
            this.BUtton_AddIP.Size = new System.Drawing.Size(174, 30);
            this.BUtton_AddIP.TabIndex = 2;
            this.BUtton_AddIP.Text = "添加此IP";
            this.BUtton_AddIP.UseVisualStyleBackColor = true;
            this.BUtton_AddIP.Click += new System.EventHandler(this.BUtton_AddIP_Click);
            // 
            // GroupBox_SingleIP
            // 
            this.GroupBox_SingleIP.Controls.Add(this.Text_SingleIP);
            this.GroupBox_SingleIP.Location = new System.Drawing.Point(4, 19);
            this.GroupBox_SingleIP.Margin = new System.Windows.Forms.Padding(2);
            this.GroupBox_SingleIP.Name = "GroupBox_SingleIP";
            this.GroupBox_SingleIP.Padding = new System.Windows.Forms.Padding(2);
            this.GroupBox_SingleIP.Size = new System.Drawing.Size(174, 41);
            this.GroupBox_SingleIP.TabIndex = 1;
            this.GroupBox_SingleIP.TabStop = false;
            this.GroupBox_SingleIP.Text = "IP地址";
            // 
            // Text_SingleIP
            // 
            this.Text_SingleIP.Location = new System.Drawing.Point(4, 16);
            this.Text_SingleIP.Margin = new System.Windows.Forms.Padding(2);
            this.Text_SingleIP.Name = "Text_SingleIP";
            this.Text_SingleIP.Size = new System.Drawing.Size(166, 21);
            this.Text_SingleIP.TabIndex = 0;
            // 
            // Button_Delete
            // 
            this.Button_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Delete.Location = new System.Drawing.Point(466, 308);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(180, 37);
            this.Button_Delete.TabIndex = 10;
            this.Button_Delete.Text = "删除选定项";
            this.Button_Delete.UseVisualStyleBackColor = true;
            this.Button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // Form_AddExamRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 522);
            this.Controls.Add(this.Button_Delete);
            this.Controls.Add(this.GroupBox_AddIP);
            this.Controls.Add(this.GroupBox_AddIPs);
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.Button_Clear);
            this.Controls.Add(this.Button_Close);
            this.Controls.Add(this.GroupBox_IncludeIP);
            this.Controls.Add(this.GroupBox_Title);
            this.Font = new System.Drawing.Font("宋体", 9F);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_AddExamRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加考场";
            this.GroupBox_Title.ResumeLayout(false);
            this.GroupBox_Title.PerformLayout();
            this.GroupBox_IncludeIP.ResumeLayout(false);
            this.GroupBox_AddIPs.ResumeLayout(false);
            this.GroupBox_End.ResumeLayout(false);
            this.GroupBox_End.PerformLayout();
            this.GroupBox_Start.ResumeLayout(false);
            this.GroupBox_Start.PerformLayout();
            this.GroupBox_AddIP.ResumeLayout(false);
            this.GroupBox_SingleIP.ResumeLayout(false);
            this.GroupBox_SingleIP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox_Title;
        private System.Windows.Forms.TextBox Text_Title;
        private System.Windows.Forms.GroupBox GroupBox_IncludeIP;
        private System.Windows.Forms.Button Button_Close;
        private System.Windows.Forms.Button Button_Clear;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.ListView ListView_ExamRoom_IPList;
        private System.Windows.Forms.ColumnHeader ColumnHeader_ExamRoomIP;
        private System.Windows.Forms.GroupBox GroupBox_AddIPs;
        private System.Windows.Forms.GroupBox GroupBox_Start;
        private System.Windows.Forms.TextBox Text_IPStart;
        private System.Windows.Forms.GroupBox GroupBox_End;
        private System.Windows.Forms.TextBox Text_IPEnd;
        private System.Windows.Forms.Button Button_AddIPs;
        private System.Windows.Forms.GroupBox GroupBox_AddIP;
        private System.Windows.Forms.Button BUtton_AddIP;
        private System.Windows.Forms.GroupBox GroupBox_SingleIP;
        private System.Windows.Forms.TextBox Text_SingleIP;
        private System.Windows.Forms.Button Button_Delete;
    }
}