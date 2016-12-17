using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Net;
using System.Threading;
using System.Diagnostics;

namespace Update
{
    public partial class Form_Update : Form
    {

        string[] ARGS;

        #region UI 

        public Form_Update()
        {
            InitializeComponent();
        }

        public Form_Update(string[] args)
        {
            ARGS = args;
            InitializeComponent();
        }

        private void Form_Update_Load(object sender, EventArgs e)
        {
            Thread ThreadCheckUpdate = new Thread(new ThreadStart(CheckUpdate));
            ThreadCheckUpdate.Start();
        }

        #endregion

        #region 更新方法

        /// <summary>
        /// 检查文件是否需要更新
        /// </summary>
        /// <param name="FileLocalPath">文件本地绝对路径</param>
        /// <param name="ServerMD5">服务器MD5值</param>
        /// <returns></returns>
        private bool CheckFileNeedUpdate(string FileLocalPath, string ServerMD5)
        {
            return !CheckFileExist(FileLocalPath) || !CheckFileMD5(FileLocalPath, ServerMD5);
        }

        /// <summary>
        /// 判断文件是否存在
        /// </summary>
        /// <param name="FileLocalPath"></param>
        /// <returns></returns>
        private bool CheckFileExist(string FileLocalPath)
        {
            if (File.Exists(FileLocalPath))
                return true;
            else
                return false;
        }

        /// <summary>
        /// 判断文件MD5值是否一致
        /// </summary>
        /// <param name="FileLocalPath"></param>
        /// <param name="ServerMD5"></param>
        /// <returns></returns>
        private bool CheckFileMD5(string FileLocalPath, string ServerMD5)
        {
            if (GetMD5HashFromFile(FileLocalPath) == ServerMD5)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 获取文件MD5
        /// </summary>
        /// <param name="fileName">文件路径</param>
        /// <returns>小写形势的MD5值</returns>
        private string GetMD5HashFromFile(string fileName)
        {
            try
            {
                FileStream file = new FileStream(fileName, FileMode.Open);
                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] retVal = md5.ComputeHash(file);
                file.Close();

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < retVal.Length; i++)
                {
                    sb.Append(retVal[i].ToString("x2"));
                }
                return sb.ToString().ToLower();
            }
            catch
            {
                return string.Empty;
            }
        }

        //下载进度http下载模式
        public bool DownloadFile(string ServerFilePath, string LocalFilePath, MaterialProcessBar Prog)
        {
            string StrFileName = LocalFilePath;
            string StrUrl = ServerFilePath; //根据实际情况设置
            long lStartPos = 0;
            string strRootFilePath = StrFileName.Substring(0, StrFileName.LastIndexOf("\\"));
            if (!Directory.Exists(strRootFilePath))//如果不存在就创建file文件夹
                Directory.CreateDirectory(strRootFilePath);//创建该文件夹
            System.IO.FileStream fs = new System.IO.FileStream(StrFileName, System.IO.FileMode.Create);
            try
            {
                System.Net.HttpWebRequest Myrq = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(ServerFilePath);
                System.Net.HttpWebResponse myrp = (System.Net.HttpWebResponse)Myrq.GetResponse();
                long totalBytes;
                if (myrp.ContentLength > 0)
                {
                    totalBytes = myrp.ContentLength;
                }
                else
                {
                    totalBytes = lStartPos;
                    return true;
                }
                myrp.Close();
                System.Net.HttpWebRequest request = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(StrUrl);
                if (lStartPos >= 0 && lStartPos < totalBytes)
                {
                    request.AddRange((int)lStartPos); //设置Range值
                    //向服务器请求，获得服务器回应数据流
                    System.IO.Stream ns = request.GetResponse().GetResponseStream();
                    byte[] nbytes = new byte[512];
                    int nReadSize = 0;
                    nReadSize = ns.Read(nbytes, 0, 512);
                    int processv = 0;
                    while (nReadSize > 0)
                    {
                        fs.Write(nbytes, 0, nReadSize);
                        nReadSize = ns.Read(nbytes, 0, 512);
                        processv += nReadSize;
                        Invoke((EventHandler)delegate
                        {
                            Prog.PercentValue = processv / (double)totalBytes;
                            Label_Tip.Text = Tip_String + string.Format("[{0}/{1}]", processv / 1024, totalBytes / 1024);
                        });
                    }
                    fs.Close();
                    ns.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                fs.Close();
                return false;
            }
        }

        string Tip_String = string.Empty;

        /// <summary>
        /// 更新主方法
        /// </summary>
        /// <param name="ds"></param>
        /// <returns></returns>
        private bool Update(DataSet ds)
        {
            if (ds == null)
                return false;
            if (ds.Tables.Count != 1)
                return false;
            if (ds.Tables[0].Columns.Count != 4)
                return false;
            Invoke((EventHandler)delegate
            {
                ProcessBar_Update.IsPercent = true;
                Label_Tip.Text = "正在获取";
            });
            int index = 0;
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                index++;
                Invoke((EventHandler)delegate
                {
                    Tip_String = string.Format("正在获取({0}/{1})", index, ds.Tables[0].Rows.Count);
                    Label_Tip.Text = Tip_String;
                });
                string LocalFilePath = Application.StartupPath + "\\" + row["ClientPath"].ToString().Replace(@"/", @"\");
                string ServerFilePath = row["ServerPath"].ToString();
                string ServerFileMD5 = row["ServerMD5"].ToString();
                if (CheckFileNeedUpdate(LocalFilePath, ServerFileMD5))
                {
                    int TrulyError = 0;
                    while (TrulyError < 3)
                    {
                        if (!DownloadFile(ServerFilePath, LocalFilePath, ProcessBar_Update))
                        {
                            TrulyError++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (TrulyError >= 3)
                    {
                        Invoke((EventHandler)delegate
                        {
                            Label_Tip.Text += "下载失败";
                            Label_Retry.Visible = true;
                            Label_Close.Visible = true;
                        });
                        return false;
                    }
                }
            }
            Invoke((EventHandler)delegate
            {
                Label_Tip.Text = "更新完成";
                UpdateDone();
            });
            return true;
        }

        /// <summary>
        /// 检查更新入口
        /// </summary>
        private void CheckUpdate()
        {
            if (ARGS != null && ARGS.Length != 0)
            {
                
            }
            try
            {
                var ds = new ServiceReference.ClientServiceSoapClient().GetUpdateList();
                Update(ds);
            }
            catch
            {
                UpdateDone();
            }
        }

        #endregion

        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST = 0x84;
            const int HTCLIENT = 0x01;
            const int HTCAPTION = 0x02;
            if (m.Msg == WM_NCHITTEST)
            {
                this.DefWndProc(ref m);
                if (m.Result.ToInt32() == HTCLIENT)
                    m.Result = new IntPtr(HTCAPTION);
                else
                    base.WndProc(ref m);
            }
            else
            {
                base.WndProc(ref m);
            }
        }

        private void UpdateDone()
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "InputSpeedExamination.exe";
                startInfo.Arguments = "updatedone";
                startInfo.WindowStyle = ProcessWindowStyle.Normal;
                Process.Start(startInfo);
            }
            catch
            {
               
            }
            Invoke((EventHandler)delegate
                {
                    Close();
                });
        }

        private void Label_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Label_Retry_Click(object sender, EventArgs e)
        {
            Label_Retry.Visible = false;
            Label_Close.Visible = false;
            Thread ThreadCheckUpdate = new Thread(new ThreadStart(CheckUpdate));
            ThreadCheckUpdate.Start();
        }

    }
}
