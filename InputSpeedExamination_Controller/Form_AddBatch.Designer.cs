namespace InputSpeedExamination_Controller
{
    partial class Form_AddBatch
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
            this.Text_Remark = new System.Windows.Forms.TextBox();
            this.Button_Clear = new System.Windows.Forms.Button();
            this.Text_Title = new System.Windows.Forms.TextBox();
            this.Button_Add = new System.Windows.Forms.Button();
            this.Button_Close = new System.Windows.Forms.Button();
            this.GroupBox_Content = new System.Windows.Forms.GroupBox();
            this.GroupBox_Title = new System.Windows.Forms.GroupBox();
            this.GroupBox_IncludePaper = new System.Windows.Forms.GroupBox();
            this.Button_ClearItem = new System.Windows.Forms.Button();
            this.Button_RemoveItem = new System.Windows.Forms.Button();
            this.Button_AddItem = new System.Windows.Forms.Button();
            this.ListView_SelectContent = new System.Windows.Forms.ListView();
            this.ListView_AllContent = new System.Windows.Forms.ListView();
            this.ColumnHeader_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader_Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader_Content = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._ColumnHeader_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._ColumnHeader_Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._ColumnHeader_Content = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GroupBox_Content.SuspendLayout();
            this.GroupBox_Title.SuspendLayout();
            this.GroupBox_IncludePaper.SuspendLayout();
            this.SuspendLayout();
            // 
            // Text_Remark
            // 
            this.Text_Remark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Text_Remark.Location = new System.Drawing.Point(3, 17);
            this.Text_Remark.Multiline = true;
            this.Text_Remark.Name = "Text_Remark";
            this.Text_Remark.Size = new System.Drawing.Size(174, 461);
            this.Text_Remark.TabIndex = 0;
            // 
            // Button_Clear
            // 
            this.Button_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Clear.Location = new System.Drawing.Point(760, 543);
            this.Button_Clear.Name = "Button_Clear";
            this.Button_Clear.Size = new System.Drawing.Size(180, 37);
            this.Button_Clear.TabIndex = 10;
            this.Button_Clear.Text = "清空";
            this.Button_Clear.UseVisualStyleBackColor = true;
            this.Button_Clear.Click += new System.EventHandler(this.Button_Clear_Click);
            // 
            // Text_Title
            // 
            this.Text_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Text_Title.Location = new System.Drawing.Point(3, 17);
            this.Text_Title.Name = "Text_Title";
            this.Text_Title.Size = new System.Drawing.Size(922, 21);
            this.Text_Title.TabIndex = 0;
            // 
            // Button_Add
            // 
            this.Button_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Add.Location = new System.Drawing.Point(760, 586);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(180, 37);
            this.Button_Add.TabIndex = 9;
            this.Button_Add.Text = "添加";
            this.Button_Add.UseVisualStyleBackColor = true;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // Button_Close
            // 
            this.Button_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Close.Location = new System.Drawing.Point(760, 630);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(180, 37);
            this.Button_Close.TabIndex = 8;
            this.Button_Close.Text = "关闭";
            this.Button_Close.UseVisualStyleBackColor = true;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // GroupBox_Content
            // 
            this.GroupBox_Content.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_Content.Controls.Add(this.Text_Remark);
            this.GroupBox_Content.Location = new System.Drawing.Point(760, 56);
            this.GroupBox_Content.Name = "GroupBox_Content";
            this.GroupBox_Content.Size = new System.Drawing.Size(180, 481);
            this.GroupBox_Content.TabIndex = 7;
            this.GroupBox_Content.TabStop = false;
            this.GroupBox_Content.Text = "备注";
            // 
            // GroupBox_Title
            // 
            this.GroupBox_Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_Title.Controls.Add(this.Text_Title);
            this.GroupBox_Title.Location = new System.Drawing.Point(12, 12);
            this.GroupBox_Title.Name = "GroupBox_Title";
            this.GroupBox_Title.Size = new System.Drawing.Size(928, 41);
            this.GroupBox_Title.TabIndex = 6;
            this.GroupBox_Title.TabStop = false;
            this.GroupBox_Title.Text = "标题";
            // 
            // GroupBox_IncludePaper
            // 
            this.GroupBox_IncludePaper.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_IncludePaper.Controls.Add(this.Button_ClearItem);
            this.GroupBox_IncludePaper.Controls.Add(this.Button_RemoveItem);
            this.GroupBox_IncludePaper.Controls.Add(this.Button_AddItem);
            this.GroupBox_IncludePaper.Controls.Add(this.ListView_SelectContent);
            this.GroupBox_IncludePaper.Controls.Add(this.ListView_AllContent);
            this.GroupBox_IncludePaper.Location = new System.Drawing.Point(12, 56);
            this.GroupBox_IncludePaper.Name = "GroupBox_IncludePaper";
            this.GroupBox_IncludePaper.Size = new System.Drawing.Size(742, 611);
            this.GroupBox_IncludePaper.TabIndex = 11;
            this.GroupBox_IncludePaper.TabStop = false;
            this.GroupBox_IncludePaper.Text = "包含的测试内容";
            // 
            // Button_ClearItem
            // 
            this.Button_ClearItem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Button_ClearItem.Location = new System.Drawing.Point(303, 305);
            this.Button_ClearItem.Name = "Button_ClearItem";
            this.Button_ClearItem.Size = new System.Drawing.Size(127, 37);
            this.Button_ClearItem.TabIndex = 13;
            this.Button_ClearItem.Text = ">>清空<<";
            this.Button_ClearItem.UseVisualStyleBackColor = true;
            this.Button_ClearItem.Click += new System.EventHandler(this.Button_ClearItem_Click);
            // 
            // Button_RemoveItem
            // 
            this.Button_RemoveItem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Button_RemoveItem.Location = new System.Drawing.Point(303, 348);
            this.Button_RemoveItem.Name = "Button_RemoveItem";
            this.Button_RemoveItem.Size = new System.Drawing.Size(127, 37);
            this.Button_RemoveItem.TabIndex = 12;
            this.Button_RemoveItem.Text = "<<移除<<";
            this.Button_RemoveItem.UseVisualStyleBackColor = true;
            this.Button_RemoveItem.Click += new System.EventHandler(this.Button_RemoveItem_Click);
            // 
            // Button_AddItem
            // 
            this.Button_AddItem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Button_AddItem.Location = new System.Drawing.Point(303, 262);
            this.Button_AddItem.Name = "Button_AddItem";
            this.Button_AddItem.Size = new System.Drawing.Size(127, 37);
            this.Button_AddItem.TabIndex = 11;
            this.Button_AddItem.Text = ">>添加>>";
            this.Button_AddItem.UseVisualStyleBackColor = true;
            this.Button_AddItem.Click += new System.EventHandler(this.Button_AddItem_Click);
            // 
            // ListView_SelectContent
            // 
            this.ListView_SelectContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListView_SelectContent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._ColumnHeader_ID,
            this._ColumnHeader_Title,
            this._ColumnHeader_Content});
            this.ListView_SelectContent.FullRowSelect = true;
            this.ListView_SelectContent.HideSelection = false;
            this.ListView_SelectContent.Location = new System.Drawing.Point(436, 20);
            this.ListView_SelectContent.Name = "ListView_SelectContent";
            this.ListView_SelectContent.Size = new System.Drawing.Size(300, 585);
            this.ListView_SelectContent.TabIndex = 1;
            this.ListView_SelectContent.UseCompatibleStateImageBehavior = false;
            this.ListView_SelectContent.View = System.Windows.Forms.View.Details;
            // 
            // ListView_AllContent
            // 
            this.ListView_AllContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListView_AllContent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader_ID,
            this.ColumnHeader_Title,
            this.ColumnHeader_Content});
            this.ListView_AllContent.FullRowSelect = true;
            this.ListView_AllContent.HideSelection = false;
            this.ListView_AllContent.Location = new System.Drawing.Point(6, 20);
            this.ListView_AllContent.Name = "ListView_AllContent";
            this.ListView_AllContent.Size = new System.Drawing.Size(291, 585);
            this.ListView_AllContent.TabIndex = 0;
            this.ListView_AllContent.UseCompatibleStateImageBehavior = false;
            this.ListView_AllContent.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader_ID
            // 
            this.ColumnHeader_ID.Text = "ID";
            // 
            // ColumnHeader_Title
            // 
            this.ColumnHeader_Title.Text = "标题";
            // 
            // ColumnHeader_Content
            // 
            this.ColumnHeader_Content.Text = "内容";
            // 
            // _ColumnHeader_ID
            // 
            this._ColumnHeader_ID.Text = "ID";
            // 
            // _ColumnHeader_Title
            // 
            this._ColumnHeader_Title.Text = "标题";
            // 
            // _ColumnHeader_Content
            // 
            this._ColumnHeader_Content.Text = "内容";
            // 
            // Form_AddBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 679);
            this.Controls.Add(this.GroupBox_IncludePaper);
            this.Controls.Add(this.Button_Clear);
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.Button_Close);
            this.Controls.Add(this.GroupBox_Content);
            this.Controls.Add(this.GroupBox_Title);
            this.Name = "Form_AddBatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加批次";
            this.Load += new System.EventHandler(this.Form_AddBatch_Load);
            this.GroupBox_Content.ResumeLayout(false);
            this.GroupBox_Content.PerformLayout();
            this.GroupBox_Title.ResumeLayout(false);
            this.GroupBox_Title.PerformLayout();
            this.GroupBox_IncludePaper.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Text_Remark;
        private System.Windows.Forms.Button Button_Clear;
        private System.Windows.Forms.TextBox Text_Title;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.Button Button_Close;
        private System.Windows.Forms.GroupBox GroupBox_Content;
        private System.Windows.Forms.GroupBox GroupBox_Title;
        private System.Windows.Forms.GroupBox GroupBox_IncludePaper;
        private System.Windows.Forms.ListView ListView_SelectContent;
        private System.Windows.Forms.ListView ListView_AllContent;
        private System.Windows.Forms.Button Button_AddItem;
        private System.Windows.Forms.Button Button_RemoveItem;
        private System.Windows.Forms.Button Button_ClearItem;
        private System.Windows.Forms.ColumnHeader ColumnHeader_ID;
        private System.Windows.Forms.ColumnHeader ColumnHeader_Title;
        private System.Windows.Forms.ColumnHeader ColumnHeader_Content;
        private System.Windows.Forms.ColumnHeader _ColumnHeader_ID;
        private System.Windows.Forms.ColumnHeader _ColumnHeader_Title;
        private System.Windows.Forms.ColumnHeader _ColumnHeader_Content;
    }
}