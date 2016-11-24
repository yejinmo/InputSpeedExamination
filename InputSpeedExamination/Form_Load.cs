using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace InputSpeedExamination
{
    public partial class Form_Load : Form
    {

        public Form_Load()
        {
            InitializeComponent();
        }

        private void Form_Load_Load(object sender, EventArgs e)
        {
            Opacity = 0;
            Timer_Show.Enabled = true;
        }

        public void KillMe(object o, EventArgs e)
        {
            Label_Tip.Text = "载入成功";
            Timer_Show.Enabled = false;
            Timer_Close.Enabled = true;
        }

        private void Timer_Show_Tick(object sender, EventArgs e)
        {
            if (Opacity >= 0.98)
            {
                Timer_Show.Enabled = false;
                return;
            }
            Opacity = Opacity + 0.02;
        }

        private void Timer_Close_Tick(object sender, EventArgs e)
        {
            if (Opacity <= 0.02)
            {
                Timer_Close.Enabled = false;
                Invoke((EventHandler)delegate
                {
                    Close();
                    Dispose();
                });
                return;
            }
            Opacity = Opacity - 0.02;
        }
    }
}
