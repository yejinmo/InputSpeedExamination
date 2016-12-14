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
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {

        }

        private void Button_Login_Click(object sender, EventArgs e)
        {
            if (new ServiceReference.ControllerServiceSoapClient().Login
                (Text_Username.Text, Text_Password.Text))
            {
                Thread ThreadForm = new Thread(new ThreadStart(
                    delegate
                {
                    var frm = new Form_Main(Text_Username.Text, Text_Password.Text);
                    frm.Shown += Frm_Shown;
                    Application.Run(frm);
                }));
                ThreadForm.Start();
            }
            else
            {
                MessageBox.Show(this, "登录失败", "提示");
            }
        }

        private void Frm_Shown(object sender, EventArgs e)
        {
            Invoke((EventHandler)delegate
            {
                Close();
            });
        }
    }
}
