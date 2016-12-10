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
            this.TabPage_Batch = new System.Windows.Forms.TabPage();
            this.TabPage_Stats = new System.Windows.Forms.TabPage();
            this.TabControl_Main.SuspendLayout();
            this.TabPage_Content.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl_Main
            // 
            this.TabControl_Main.Controls.Add(this.TabPage_Content);
            this.TabControl_Main.Controls.Add(this.TabPage_Batch);
            this.TabControl_Main.Controls.Add(this.TabPage_Stats);
            this.TabControl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl_Main.Location = new System.Drawing.Point(0, 0);
            this.TabControl_Main.Name = "TabControl_Main";
            this.TabControl_Main.SelectedIndex = 0;
            this.TabControl_Main.Size = new System.Drawing.Size(862, 618);
            this.TabControl_Main.TabIndex = 0;
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
            this.TabPage_Content.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.TabPage_Content.Size = new System.Drawing.Size(854, 592);
            this.TabPage_Content.TabIndex = 0;
            this.TabPage_Content.Text = "内容";
            // 
            // Button_RefreshContent
            // 
            this.Button_RefreshContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_RefreshContent.Location = new System.Drawing.Point(561, 549);
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
            this.Button_UpdateContent.Text = "修改";
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
            // 
            // ColumnHeader_Content_Title
            // 
            this.ColumnHeader_Content_Title.Text = "标题";
            // 
            // ColumnHeader_Content_Content
            // 
            this.ColumnHeader_Content_Content.Text = "内容";
            // 
            // ColumnHeader_Content_MD5
            // 
            this.ColumnHeader_Content_MD5.Text = "MD5值";
            // 
            // TabPage_Batch
            // 
            this.TabPage_Batch.Location = new System.Drawing.Point(4, 25);
            this.TabPage_Batch.Name = "TabPage_Batch";
            this.TabPage_Batch.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.TabPage_Batch.Size = new System.Drawing.Size(854, 589);
            this.TabPage_Batch.TabIndex = 1;
            this.TabPage_Batch.Text = "考场";
            this.TabPage_Batch.UseVisualStyleBackColor = true;
            // 
            // TabPage_Stats
            // 
            this.TabPage_Stats.Location = new System.Drawing.Point(4, 25);
            this.TabPage_Stats.Name = "TabPage_Stats";
            this.TabPage_Stats.Size = new System.Drawing.Size(854, 589);
            this.TabPage_Stats.TabIndex = 2;
            this.TabPage_Stats.Text = "状态";
            this.TabPage_Stats.UseVisualStyleBackColor = true;
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
            this.TabControl_Main.ResumeLayout(false);
            this.TabPage_Content.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl_Main;
        private System.Windows.Forms.TabPage TabPage_Content;
        private System.Windows.Forms.TabPage TabPage_Batch;
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
    }
}

