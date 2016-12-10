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
        public Form_Main()
        {
            InitializeComponent();
        }

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
                var ds = new ServiceReference.ControllerServiceSoapClient().GetAllContent();
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
            catch(Exception e)
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
            Form_AddContent frm = new Form_AddContent();
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
                ListView_AllContent.SelectedItems[0].SubItems[2].Text
                );
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
                var res = new ServiceReference.ControllerServiceSoapClient().DeleteContent(id);
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

    }
}
