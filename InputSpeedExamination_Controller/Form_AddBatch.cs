using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace InputSpeedExamination_Controller
{
    public partial class Form_AddBatch : Form
    {
        string USERNAME = string.Empty;
        string PASSWORD = string.Empty;

        public Form_AddBatch(string u,string p)
        {
            USERNAME = u;
            PASSWORD = p;
            InitializeComponent();
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            Thread ThreadAddBatch = new Thread(new ThreadStart(AddBatch));
            ThreadAddBatch.Start();
        }

        private void AddBatch()
        {
            try
            {
                string title = string.Empty;
                string remark = string.Empty;
                string includePaper = string.Empty;
                Invoke((EventHandler)delegate
                {
                    Enabled = false;
                    title = Text_Title.Text;
                    remark = Text_Remark.Text;
                    foreach (ListViewItem lvi in ListView_SelectContent.Items)
                    {
                        if (includePaper.IndexOf(lvi.Text) >= 0)
                            continue;
                        includePaper += lvi.Text + ",";
                    }
                    if (includePaper.EndsWith(","))
                        includePaper = includePaper.Substring(0, includePaper.Length - 1);
                });
                var res = new ServiceReference.ControllerServiceSoapClient().CreateNewBatch(title, remark, includePaper, USERNAME, PASSWORD);
                Invoke((EventHandler)delegate
                {
                    if (res == "ok")
                        MessageBox.Show(this, "批次添加成功", "提示");
                    else
                        MessageBox.Show(this, "批次添加失败\n\n" + res, "提示");
                });
            }
            catch (Exception e)
            {
                Invoke((EventHandler)delegate
                {
                    MessageBox.Show(this, "批次添加失败\n\n" + e.Message, "错误");
                });
            }
            finally
            {
                Invoke((EventHandler)delegate
                {
                    Enabled = true; 
                });
            }
        }

        private void Button_Clear_Click(object sender, EventArgs e)
        {
            ListView_SelectContent.Items.Clear();
            ListView_AllContent.Items.Clear();
            Text_Remark.Text = string.Empty;
            Text_Title.Text = string.Empty;
            Thread ThreadGetAllContent = new Thread(new ThreadStart(GetAllContent));
            ThreadGetAllContent.Start();
        }

        private void GetAllContent()
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

        private void Button_AddItem_Click(object sender, EventArgs e)
        {
            if (ListView_AllContent.SelectedItems.Count != 1)
                return;
            var lvi = ListView_AllContent.SelectedItems[0];
            ListView_AllContent.Items.Remove(lvi);
            ListView_SelectContent.Items.Add(lvi);
        }

        private void Button_ClearItem_Click(object sender, EventArgs e)
        {
            ListView_SelectContent.Items.Clear();
            ListView_AllContent.Items.Clear();
            Thread ThreadGetAllContent = new Thread(new ThreadStart(GetAllContent));
            ThreadGetAllContent.Start();
        }

        private void Button_RemoveItem_Click(object sender, EventArgs e)
        {
            if (ListView_SelectContent.SelectedItems.Count != 1)
                return;
            var lvi = ListView_SelectContent.SelectedItems[0];
            ListView_SelectContent.Items.Remove(lvi);
            ListView_AllContent.Items.Add(lvi);
        }

        private void Form_AddBatch_Load(object sender, EventArgs e)
        {
            Thread ThreadGetAllContent = new Thread(new ThreadStart(GetAllContent));
            ThreadGetAllContent.Start();
        }
    }
}
