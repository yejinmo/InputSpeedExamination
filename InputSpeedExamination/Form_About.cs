using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InputSpeedExamination
{
    public partial class Form_About : MaterialForm
    {
        public Form_About()
        {
            InitializeComponent();
        }

        private void Form_About_Load(object sender, EventArgs e)
        {
            Web_Main.Navigate("http://keyboard.hcs.ac.cn/about");
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Web_Main_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Web_Main.Visible = true;
            ProcessBar_Load.Visible = false;
        }
    }
}
