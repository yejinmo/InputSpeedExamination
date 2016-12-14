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
    public partial class Form_UpdateContent : Form
    {

        string ID = string.Empty;
        string USERNAME = string.Empty;
        string PASSWORD = string.Empty;

        public Form_UpdateContent(string id, string md5, string title, string content, string u, string p)
        { 
            USERNAME = u;
            PASSWORD = p;
            InitializeComponent();
            ID = id;
            Text_Content.Text = content;
            Text_Title.Text = title;
            Text = string.Format("编辑内容 [ID:{0}, MD5:{1}]", id, md5);
        }

        private void Button_Edit_Click(object sender, EventArgs e)
        {
            Thread ThreadEdit = new Thread(new ThreadStart(Edit));
            ThreadEdit.Start();
        }

        private void Edit()
        {
            try
            {
                string title = string.Empty;
                string content = string.Empty;
                Invoke((EventHandler)delegate
                {
                    title = Text_Title.Text;
                    content = Text_Content.Text;
                    Enabled = false;
                });
                string res = new ServiceReference.ControllerServiceSoapClient().UpdateContent(ID, title, content, USERNAME, PASSWORD);
                Invoke((EventHandler)delegate
                {
                    if (res == "ok")
                    {
                        MessageBox.Show(this, "内容编辑成功", "提示");
                    }
                    else
                    {
                        MessageBox.Show(this, "内容编辑失败\n\n" + res, "错误");
                    }
                });
            }
            catch (Exception e)
            {
                Invoke((EventHandler)delegate
                {
                    MessageBox.Show(this, "内容编辑失败\n\n" + e.Message, "错误");
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
            Text_Content.Text = string.Empty;
            Text_Title.Text = string.Empty;
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_UpdateContent_Load(object sender, EventArgs e)
        {

        }

        private void Text_Content_TextChanged(object sender, EventArgs e)
        {
            GroupBox_Content.Text = string.Format("内容[长度:{0}]", Text_Content.Text.Length);
        }
    }
}
