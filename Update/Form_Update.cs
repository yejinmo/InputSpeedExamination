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
            return !CheckFileExist(FileLocalPath) && !CheckFileMD5(FileLocalPath, ServerMD5);
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

        /// <summary>        
        /// 下载文件        
        /// </summary>        
        private bool DownloadFile(string ServerFilePath, string LocalFilePath, ProgressBar prog = null, Label label1 = null)
        {
            float percent = 0;
            try
            {
                HttpWebRequest Myrq = (HttpWebRequest)WebRequest.Create(ServerFilePath);
                HttpWebResponse myrp = (HttpWebResponse)Myrq.GetResponse();
                long totalBytes = myrp.ContentLength;
                if (prog != null)
                {
                    prog.Maximum = (int)totalBytes;
                }
                Stream st = myrp.GetResponseStream();
                Stream so = new FileStream(LocalFilePath, FileMode.Create);
                long totalDownloadedByte = 0;
                byte[] by = new byte[1024];
                int osize = st.Read(by, 0, (int)by.Length);
                while (osize > 0)
                {
                    totalDownloadedByte = osize + totalDownloadedByte;
                    Application.DoEvents();
                    so.Write(by, 0, osize);
                    if (prog != null)
                    {
                        prog.Value = (int)totalDownloadedByte;
                    }
                    osize = st.Read(by, 0, (int)by.Length);

                    percent = (float)totalDownloadedByte / (float)totalBytes * 100;
                    label1.Text = "当前补丁下载进度" + percent.ToString() + "%";
                    Application.DoEvents();
                }
                so.Close();
                st.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

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
            if (ds.Tables[0].Columns.Count != 3)
                return false;
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                string LocalFilePath = Application.StartupPath + "\\" + row[0].ToString();
                string ServerFilePath = row[1].ToString();
                string ServerFileMD5 = row[2].ToString();
                if (CheckFileNeedUpdate(LocalFilePath, ServerFileMD5))
                    if (DownloadFile(ServerFilePath, LocalFilePath))
                        return false;
            }
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
            var ds = new ServiceReference.HelloServerSoapClient().GetUpdateList();
            Update(ds);
        }

        #endregion

    }
}
