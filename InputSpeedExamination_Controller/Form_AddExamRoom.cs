using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputSpeedExamination_Controller
{
    public partial class Form_AddExamRoom : Form
    {
        string USERNAME = string.Empty;
        string PASSWORD = string.Empty;

        public Form_AddExamRoom(string u, string p)
        {
            InitializeComponent();
            USERNAME = u;
            PASSWORD = p;
        }

        private void Button_AddIPs_Click(object sender, EventArgs e)
        {
            string StartIp = "";
            string EndIp = "";
            StartIp = Text_IPStart.Text;
            EndIp = Text_IPEnd.Text;
            IPAddress temp;
            if (!IPAddress.TryParse(StartIp, out temp) || !IPAddress.TryParse(EndIp, out temp))
            {
                MessageBox.Show(this, "IP地址不合法", "提示");
                return;
            }
            uint iStartip = ipTint(StartIp);
            uint iEndIp = ipTint(EndIp);
            if (iEndIp >= iStartip)
                for (uint ip = iStartip; ip <= iEndIp; ip++)
                    ListView_ExamRoom_IPList.Items.Add(intTip(ip));
            else
                MessageBox.Show(this, "起始IP比终止IP大", "提示");
        }

        private void Button_Clear_Click(object sender, EventArgs e)
        {
            Text_Title.Text = "";
            ListView_ExamRoom_IPList.Items.Clear();
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            Thread ThreadAddExamRoom = new Thread(new ThreadStart(AddExamRoom));
            ThreadAddExamRoom.Start();
        }

        private void AddExamRoom()
        {
            try
            {
                string title = string.Empty;
                string includeIP = string.Empty;
                Invoke((EventHandler)delegate
                {
                    Enabled = false;
                    title = Text_Title.Text;
                    foreach (ListViewItem lvi in ListView_ExamRoom_IPList.Items)
                    {
                        if (includeIP.IndexOf(lvi.Text) >= 0)
                            continue;
                        includeIP += lvi.Text + ",";
                    }
                    if (includeIP.EndsWith(","))
                        includeIP = includeIP.Substring(0, includeIP.Length - 1);
                });
                var res = new ServiceReference.ControllerServiceSoapClient().CreateNewExamRoom(title, includeIP, USERNAME, PASSWORD);
                Invoke((EventHandler)delegate
                {
                    if (res == "ok")
                        MessageBox.Show(this, "考场添加成功", "提示");
                    else
                        MessageBox.Show(this, "考场添加失败\n\n" + res, "提示");
                });
            }
            catch (Exception e)
            {
                Invoke((EventHandler)delegate
                {
                    MessageBox.Show(this, "考场添加失败\n\n" + e.Message, "错误");
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

        private void BUtton_AddIP_Click(object sender, EventArgs e)
        {
            string Ip = Text_SingleIP.Text;
            IPAddress temp;
            if (!IPAddress.TryParse(Ip, out temp))
            {
                MessageBox.Show(this, "IP地址不合法", "提示");
                return;
            }
            else
            {
                ListView_ExamRoom_IPList.Items.Add(Ip);
            }
        }

        public uint ipTint(string ipStr)
        {
            string[] ip = ipStr.Split('.');
            uint ipcode = 0xFFFFFF00 | byte.Parse(ip[3]);
            ipcode = ipcode & 0xFFFF00FF | (uint.Parse(ip[2]) << 0x8);
            ipcode = ipcode & 0xFF00FFFF | (uint.Parse(ip[1]) << 0xF);
            ipcode = ipcode & 0x00FFFFFF | (uint.Parse(ip[0]) << 0x18);
            return ipcode;
        }
        public string intTip(uint ipcode)
        {
            byte a = (byte)((ipcode & 0xFF000000) >> 0x18);
            byte b = (byte)((ipcode & 0x00FF0000) >> 0xF);
            byte c = (byte)((ipcode & 0x0000FF00) >> 0x8);
            byte d = (byte)(ipcode & 0x000000FF);
            string ipStr = string.Format("{0}.{1}.{2}.{3}", a, b, c, d);
            return ipStr;
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            if (ListView_ExamRoom_IPList.SelectedItems.Count != 1)
            {
                MessageBox.Show(this, "请选中一项", "提示");
                return;
            }
            else
            {
                ListView_ExamRoom_IPList.Items.Remove(ListView_ExamRoom_IPList.SelectedItems[0]);
            }
        }
    }
}
