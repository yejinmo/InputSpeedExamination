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
    public partial class Form_AddContent : Form
    {
        public Form_AddContent()
        {
            InitializeComponent();
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            Thread ThreadAddContent = new Thread(new ThreadStart(AddContent));
            ThreadAddContent.Start();
        }

        private void AddContent()
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
                string res = new ServiceReference.ControllerServiceSoapClient().CreateNewContent(title, content);
                Invoke((EventHandler)delegate
                {
                    if (res == "ok")
                    {
                        MessageBox.Show(this, "内容添加成功", "提示");
                    }
                    else
                    {
                        MessageBox.Show(this, "内容添加失败\n\n" + res, "错误");
                    }
                });
            }
            catch(Exception e)
            {
                Invoke((EventHandler)delegate
                {
                    MessageBox.Show(this, "内容添加失败\n\n" + e.Message, "错误");
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
    }
}
