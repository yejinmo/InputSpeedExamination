using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputSpeedExamination_Controller
{
    public partial class Form_Main : Form
    {

        string USERNAME = string.Empty;
        string PASSWORD = string.Empty;

        #region UI

        public Form_Main(string u, string p)
        {
            InitializeComponent();
            USERNAME = u;
            PASSWORD = p;
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            Thread ThreadRefreshContent = new Thread(new ThreadStart(RefreshContent));
            ThreadRefreshContent.Start();
        }

        private void TabControl_Main_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControl_Main.SelectedTab == TabPage_Content)
            {
                Thread ThreadRefreshContent = new Thread(new ThreadStart(RefreshContent));
                ThreadRefreshContent.Start();
                return;
            }
            if (TabControl_Main.SelectedTab == TabPage_ExamRoom)
            {
                Thread ThreadRefreshExamRoom = new Thread(new ThreadStart(RefreshExamRoom));
                ThreadRefreshExamRoom.Start();
                return;
            }
            if (TabControl_Main.SelectedTab == TabPage_Batch)
            {
                Thread ThreadRefreshBatch = new Thread(new ThreadStart(RefreshBatch));
                ThreadRefreshBatch.Start();
                return;
            }
        }

        #endregion

        #region 内容

        private void Button_RefreshContent_Click(object sender, EventArgs e)
        {
            Thread ThreadRefreshContent = new Thread(new ThreadStart(RefreshContent));
            ThreadRefreshContent.Start();
        }

        private void RefreshContent()
        {
            try
            {
                Invoke((EventHandler)delegate
                {
                    Enabled = false;
                    ListView_AllContent.SuspendLayout();
                    ListView_AllContent.Items.Clear();
                });
                var ds = new ServiceReference.ControllerServiceSoapClient().GetAllContent(USERNAME, PASSWORD);
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    string id = dr["ID"].ToString();
                    string title = dr["Title"].ToString();
                    string content = dr["String"].ToString();
                    string md5 = dr["MD5"].ToString();
                    Invoke((EventHandler)delegate
                    {
                        ListViewItem lvi = new ListViewItem(id);
                        lvi.SubItems.Add(title);
                        lvi.SubItems.Add(content);
                        lvi.SubItems.Add(md5);
                        ListView_AllContent.Items.Add(lvi);
                    });
                }
            }
            catch (Exception e)
            {
                Invoke((EventHandler)delegate
                {
                    MessageBox.Show(this, "内容刷新失败\n\n" + e.Message, "错误");
                });
            }
            finally
            {
                Invoke((EventHandler)delegate
                {
                    Enabled = true;
                    ListView_AllContent.ResumeLayout();
                });
            }
        }

        private void Button_AddContent_Click(object sender, EventArgs e)
        {
            Form_AddContent frm = new Form_AddContent(USERNAME, PASSWORD);
            frm.ShowDialog();
            Button_RefreshContent.PerformClick();
        }

        private void Button_UpdateContent_Click(object sender, EventArgs e)
        {
            if (ListView_AllContent.SelectedItems.Count != 1)
            {
                MessageBox.Show(this, "请选中一项", "提示");
                return;
            }
            Form_UpdateContent frm = new Form_UpdateContent(
                ListView_AllContent.SelectedItems[0].SubItems[0].Text,
                ListView_AllContent.SelectedItems[0].SubItems[3].Text,
                ListView_AllContent.SelectedItems[0].SubItems[1].Text,
                ListView_AllContent.SelectedItems[0].SubItems[2].Text,
                USERNAME, PASSWORD);
            frm.ShowDialog();
            Button_RefreshContent.PerformClick();
        }

        private void Button_DeleteContent_Click(object sender, EventArgs e)
        {
            if (ListView_AllContent.SelectedItems.Count != 1)
            {
                MessageBox.Show(this, "请选中一项", "提示");
                return;
            }
            Thread ThreadDeleteContent = new Thread(new ThreadStart(DeleteContent));
            ThreadDeleteContent.Start();
        }

        private void DeleteContent()
        {
            try
            {
                string id = string.Empty;
                bool needreturn = false;
                Invoke((EventHandler)delegate
                {
                    Enabled = false;
                    id = ListView_AllContent.SelectedItems[0].SubItems[0].Text;
                    DialogResult dr = MessageBox.Show(
                        string.Format("确定要删除？\n\nID:{0}\n标题:{1}", id, ListView_AllContent.SelectedItems[0].SubItems[1].Text),
                        "删除确认", MessageBoxButtons.YesNo);
                    if (dr != DialogResult.Yes)
                        needreturn = true;
                });
                if (needreturn)
                    return;
                var res = new ServiceReference.ControllerServiceSoapClient().DeleteContent(id, USERNAME, PASSWORD);
                Invoke((EventHandler)delegate
                {
                    if (res)
                        MessageBox.Show(this, "删除成功", "提示");
                    else
                        MessageBox.Show(this, "删除失败", "提示");
                });
            }
            catch (Exception e)
            {
                Invoke((EventHandler)delegate
                {
                    MessageBox.Show(this, "内容删除失败\n\n" + e.Message, "错误");
                });
            }
            finally
            {
                Invoke((EventHandler)delegate
                {
                    Enabled = true;
                    Button_RefreshContent.PerformClick();
                });
            }
        }

        #endregion

        #region 考场

        private void Button_RefreshExamRoom_Click(object sender, EventArgs e)
        {
            Thread ThreadRefreshExamRoom = new Thread(new ThreadStart(RefreshExamRoom));
            ThreadRefreshExamRoom.Start();
        }

        private void RefreshExamRoom()
        {
            try
            {
                Invoke((EventHandler)delegate
                {
                    Enabled = false;
                    ListView_ExamRoom.SuspendLayout();
                    ListView_ExamRoom.Items.Clear();
                    ListView_ExamRoom_IPList.Items.Clear();
                });
                var ds = new ServiceReference.ControllerServiceSoapClient().GetExamRoomList(USERNAME, PASSWORD);
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    string id = dr["ID"].ToString();
                    string title = dr["RoomTitle"].ToString();
                    string IncludeIP = dr["IncludeIP"].ToString();
                    Invoke((EventHandler)delegate
                    {
                        ListViewItem lvi = new ListViewItem(id);
                        lvi.SubItems.Add(title);
                        lvi.SubItems.Add(IncludeIP);
                        ListView_ExamRoom.Items.Add(lvi);
                    });
                }
            }
            catch (Exception e)
            {
                Invoke((EventHandler)delegate
                {
                    MessageBox.Show(this, "内容刷新失败\n\n" + e.Message, "错误");
                });
            }
            finally
            {
                Invoke((EventHandler)delegate
                {
                    Enabled = true;
                    ListView_ExamRoom.ResumeLayout();
                });
            }
        }

        private void ListView_ExamRoom_Click(object sender, EventArgs e)
        {
            if (ListView_ExamRoom.SelectedItems.Count == 1)
                ListExamRoomIPList(ListView_ExamRoom.SelectedItems[0].SubItems[2].Text);
        }

        private void ListExamRoomIPList(string IncludeIP)
        {
            ListView_ExamRoom_IPList.Items.Clear();
            var IncludeIP_array = IncludeIP.Split(',');
            foreach (var ip in IncludeIP_array)
            {
                ListView_ExamRoom_IPList.Items.Add(ip);
            }
        }

        private void Button_DeleteExamRoom_Click(object sender, EventArgs e)
        {
            if (ListView_ExamRoom.SelectedItems.Count != 1)
            {
                MessageBox.Show(this, "请选中一项", "提示");
                return;
            }
            Thread ThreadDeleteExamRoom = new Thread(new ThreadStart(DeleteExamRoom));
            ThreadDeleteExamRoom.Start();
        }

        private void DeleteExamRoom()
        {
            try
            {
                string id = string.Empty;
                bool needreturn = false;
                Invoke((EventHandler)delegate
                {
                    Enabled = false;
                    id = ListView_ExamRoom.SelectedItems[0].SubItems[0].Text;
                    DialogResult dr = MessageBox.Show(
                        string.Format("确定要删除？\n\nID:{0}\n标题:{1}", id, ListView_ExamRoom.SelectedItems[0].SubItems[1].Text),
                        "删除确认", MessageBoxButtons.YesNo);
                    if (dr != DialogResult.Yes)
                        needreturn = true;
                });
                if (needreturn)
                    return;
                var res = new ServiceReference.ControllerServiceSoapClient().DeleteExamRoom(id, USERNAME, PASSWORD);
                Invoke((EventHandler)delegate
                {
                    if (res)
                        MessageBox.Show(this, "删除成功", "提示");
                    else
                        MessageBox.Show(this, "删除失败", "提示");
                });
            }
            catch (Exception e)
            {
                Invoke((EventHandler)delegate
                {
                    MessageBox.Show(this, "内容删除失败\n\n" + e.Message, "错误");
                });
            }
            finally
            {
                Invoke((EventHandler)delegate
                {
                    Enabled = true;
                    Button_RefreshExamRoom.PerformClick();
                });
            }
        }

        private void Button_AddExamRoom_Click(object sender, EventArgs e)
        {
            new Form_AddExamRoom(USERNAME, PASSWORD).ShowDialog();
            Button_RefreshExamRoom.PerformClick();
        }

        private void Button_EditExamRoom_Click(object sender, EventArgs e)
        {
            if (ListView_ExamRoom.SelectedItems.Count != 1)
            {
                MessageBox.Show(this, "请选中一项", "提示");
                return;
            }
            new Form_EditExamRoom(ListView_ExamRoom.SelectedItems[0].SubItems[0].Text,
                ListView_ExamRoom.SelectedItems[0].SubItems[1].Text,
                ListView_ExamRoom.SelectedItems[0].SubItems[2].Text,
                USERNAME, PASSWORD).ShowDialog();
            Button_RefreshExamRoom.PerformClick();
        }

        #endregion

        #region 批次

        private void Button_Batch_Refresh_Click(object sender, EventArgs e)
        {
            Thread ThreadRefreshBatch = new Thread(new ThreadStart(RefreshBatch));
            ThreadRefreshBatch.Start();
        }

        private void RefreshBatch()
        {
            try
            {
                Invoke((EventHandler)delegate
                {
                    Enabled = false;
                    ListView_BatchList.SuspendLayout();
                    ListView_BatchList.Items.Clear();
                    ListView_Batch_IncludePaperList.Items.Clear();
                });
                var ds = new ServiceReference.ControllerServiceSoapClient().GetBatchList(USERNAME, PASSWORD);
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    string id = dr["ID"].ToString();
                    string title = dr["Title"].ToString();
                    string remark = dr["Remark"].ToString();
                    string isOpen = dr["IsOpen"].ToString();
                    string startTime = dr["BeginTime"].ToString();
                    string finishTime = dr["FinishTime"].ToString();
                    string includePaper = dr["IncludePaper"].ToString();
                    Invoke((EventHandler)delegate
                    {
                        ListViewItem lvi = new ListViewItem(id);
                        lvi.SubItems.Add(title);
                        lvi.SubItems.Add(isOpen == "1" ? "正在进行" : isOpen == "0" ? "已关闭" : "未激活");
                        lvi.SubItems.Add(startTime);
                        lvi.SubItems.Add(finishTime);
                        lvi.SubItems.Add(remark);
                        lvi.SubItems.Add(includePaper);
                        ListView_BatchList.Items.Add(lvi);
                    });
                }
            }
            catch (Exception e)
            {
                Invoke((EventHandler)delegate
                {
                    MessageBox.Show(this, "内容刷新失败\n\n" + e.Message, "错误");
                });
            }
            finally
            {
                Invoke((EventHandler)delegate
                {
                    Enabled = true;
                    ListView_BatchList.ResumeLayout();
                });
            }
        }

        private void ListView_BatchList_Click(object sender, EventArgs e)
        {
            if (ListView_BatchList.SelectedItems.Count != 1)
                return;
            Thread ThreadListIncludePaper = new Thread(new ThreadStart(ListIncludePaper));
            ThreadListIncludePaper.Start();
        }

        private void ListIncludePaper()
        {
            try
            {
                string includePaper = string.Empty;
                Invoke((EventHandler)delegate
                {
                    Enabled = false;
                    includePaper = ListView_BatchList.SelectedItems[0].SubItems[6].Text;
                    ListView_Batch_IncludePaperList.SuspendLayout();
                    ListView_Batch_IncludePaperList.Items.Clear();
                });
                var ds = new ServiceReference.ControllerServiceSoapClient().GetContentByPaperID(includePaper, USERNAME, PASSWORD);
                Invoke((EventHandler)delegate
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        ListViewItem lvi = new ListViewItem(dr["Title"].ToString());
                        lvi.SubItems.Add(dr["String"].ToString());
                        lvi.SubItems.Add(dr["MD5"].ToString());
                        ListView_Batch_IncludePaperList.Items.Add(lvi);
                    }
                });
            }
            catch (Exception e)
            {
                Invoke((EventHandler)delegate
                {
                    MessageBox.Show(this, "内容获取失败\n\n" + e.Message, "错误");
                });
            }
            finally
            {
                Invoke((EventHandler)delegate
                {
                    Enabled = true;
                    ListView_Batch_IncludePaperList.ResumeLayout();
                });
            }
        }

        private void Button_Batch_Delete_Click(object sender, EventArgs e)
        {
            if (ListView_BatchList.SelectedItems.Count != 1)
            {
                MessageBox.Show(this, "请选中一项", "提示");
                return;
            }
            Thread ThreadDeleteBatch = new Thread(new ThreadStart(DeleteBatch));
            ThreadDeleteBatch.Start();
        }

        private void DeleteBatch()
        {
            try
            {
                string id = string.Empty;
                Invoke((EventHandler)delegate
                {
                    Enabled = false;
                    id = ListView_BatchList.SelectedItems[0].SubItems[0].Text;
                });
                var res = new ServiceReference.ControllerServiceSoapClient().DeleteBatch(id, USERNAME, PASSWORD);
                Invoke((EventHandler)delegate
                {
                    if (res == "ok")
                        MessageBox.Show(this, "删除成功", "提示");
                    else
                        MessageBox.Show(this, "删除失败\n\n" + res, "提示");
                });
            }
            catch (Exception e)
            {
                Invoke((EventHandler)delegate
                {
                    MessageBox.Show(this, "删除失败\n\n" + e.Message, "错误");
                });
            }
            finally
            {
                Invoke((EventHandler)delegate
                {
                    Enabled = true;
                    Button_Batch_Refresh.PerformClick();
                });
            }
        }

        private void Button_Batch_Start_Click(object sender, EventArgs e)
        {
            if (ListView_BatchList.SelectedItems.Count != 1)
            {
                MessageBox.Show(this, "请选中一项", "提示");
                return;
            }
            Thread ThreadStartBatch = new Thread(new ThreadStart(StartBatch));
            ThreadStartBatch.Start();
        }

        private void StartBatch()
        {
            try
            {
                string id = string.Empty;
                Invoke((EventHandler)delegate
                {
                    Enabled = false;
                    id = ListView_BatchList.SelectedItems[0].SubItems[0].Text;
                });
                var res = new ServiceReference.ControllerServiceSoapClient().StartBatch(id, USERNAME, PASSWORD);
                Invoke((EventHandler)delegate
                {
                    if (res == "ok")
                        MessageBox.Show(this, "开启成功", "提示");
                    else
                        MessageBox.Show(this, "开启失败\n\n" + res, "提示");
                });
            }
            catch (Exception e)
            {
                Invoke((EventHandler)delegate
                {
                    MessageBox.Show(this, "开启失败\n\n" + e.Message, "错误");
                });
            }
            finally
            {
                Invoke((EventHandler)delegate
                {
                    Enabled = true;
                    Button_Batch_Refresh.PerformClick();
                });
            }
        }

        private void Button_Batch_Stop_Click(object sender, EventArgs e)
        {
            if (ListView_BatchList.SelectedItems.Count != 1)
            {
                MessageBox.Show(this, "请选中一项", "提示");
                return;
            }
            Thread ThreadStopBatch = new Thread(new ThreadStart(StopBatch));
            ThreadStopBatch.Start();
        }

        private void StopBatch()
        {
            try
            {
                string id = string.Empty;
                Invoke((EventHandler)delegate
                {
                    Enabled = false;
                    id = ListView_BatchList.SelectedItems[0].SubItems[0].Text;
                });
                var res = new ServiceReference.ControllerServiceSoapClient().StopBatch(id, USERNAME, PASSWORD);
                Invoke((EventHandler)delegate
                {
                    if (res == "ok")
                        MessageBox.Show(this, "关闭成功", "提示");
                    else
                        MessageBox.Show(this, "关闭失败\n\n" + res, "提示");
                });
            }
            catch (Exception e)
            {
                Invoke((EventHandler)delegate
                {
                    MessageBox.Show(this, "关闭失败\n\n" + e.Message, "错误");
                });
            }
            finally
            {
                Invoke((EventHandler)delegate
                {
                    Enabled = true;
                    Button_Batch_Refresh.PerformClick();
                });
            }
        }

        private void Button_Batch_Add_Click(object sender, EventArgs e)
        {
            new Form_AddBatch().ShowDialog();
            Button_Batch_Refresh.PerformClick();
        }

        #endregion

        #region 状态

        private void LoadStatsData()
        {

        }

        #endregion

    }
}
