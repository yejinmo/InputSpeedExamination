using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Services;

namespace WebService
{
    /// <summary>
    /// ControllerService 的摘要说明
    /// </summary>
    [WebService(Namespace = "WebService")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class ControllerService : System.Web.Services.WebService
    {
        public bool CheckLogin(string username, string password)
        {
            if (username.Equals("admin") && password.Equals("123456"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [WebMethod(Description = "登录验证")]
        public bool Login(string username, string password)
        {
            return CheckLogin(username, password);
        }

        [WebMethod(Description = "获取指定考场状态表")]
        public DataSet GetStats(string BatchID, string RoomID, string username, string password)
        {
            if (!CheckLogin(username, password))
                return null;
            return new DBHelper().GetStats(BatchID, RoomID);
        }

        [WebMethod(Description = "获取考场列表")]
        public DataSet GetExamRoomList(string username, string password)
        {
            if (!CheckLogin(username, password))
                return null;
            return new DBHelper().GetExamRoomList();
        }

        [WebMethod(Description = "创建新考场")]
        public string CreateNewExamRoom(string RoomTitle, string IncludeIP, string username, string password)
        {
            if (!CheckLogin(username, password))
                return "身份验证失败";
            return new DBHelper().CreateNewExamRoom(RoomTitle, IncludeIP);
        }

        [WebMethod(Description = "编辑考场")]
        public string EditExamRoom(string RoomID, string RoomTitle, string IncludeIP, string username, string password)
        {
            if (!CheckLogin(username, password))
                return "身份验证失败";
            return new DBHelper().EditExamRoom(RoomID, RoomTitle, IncludeIP);
        }

        [WebMethod(Description = "删除指定考场")]
        public bool DeleteExamRoom(string RoomID, string username, string password)
        {
            if (!CheckLogin(username, password))
                return false;

            return new DBHelper().DeleteExamRoom(RoomID);
        }

        [WebMethod(Description = "获取全部内容")]
        public DataSet GetAllContent(string username, string password)
        {
            if (!CheckLogin(username, password))
                return null;
            return new DBHelper().GetAllContent();
        }

        [WebMethod(Description = "添加新内容")]
        public string CreateNewContent(string Title, string Content, string username, string password)
        {
            if (!CheckLogin(username, password))
                return "身份验证失败";
            return new DBHelper().CreateNewContent(Title, Content);
        }

        [WebMethod(Description = "更新内容")]
        public string UpdateContent(string ContentID, string Title, string Content, string username, string password)
        {
            if (!CheckLogin(username, password))
                return "身份验证失败";
            return new DBHelper().UpdateContent(ContentID, Title, Content);
        }

        [WebMethod(Description = "删除指定内容")]
        public bool DeleteContent(string ContentID, string username, string password)
        {
            if (!CheckLogin(username, password))
                return false;
            return new DBHelper().DeleteContent(ContentID);
        }

        [WebMethod(Description = "根据内容ID获取内容")]
        public DataSet GetContentByPaperID(string IncludePaper, string username, string password)
        {
            if (!CheckLogin(username, password))
                return null;
            return new DBHelper().GetContentByPaperID(IncludePaper);
        }

        [WebMethod(Description = "根据批次ID获取内容")]
        public DataSet GetContentByBatchID(string BatchID, string username, string password)
        {
            if (!CheckLogin(username, password))
                return null;
            return new DBHelper().GetContentByBatchID(BatchID);
        }

        [WebMethod(Description = "获取批次列表")]
        public DataSet GetBatchList(string username, string password)
        {
            if (!CheckLogin(username, password))
                return null;
            return new DBHelper().GetBatchList();
        }

        [WebMethod(Description = "创建新批次")]
        public string CreateNewBatch(string Title, string Remark, string IncludePaper, string username, string password)
        {
            if (!CheckLogin(username, password))
                return "身份验证失败";
            return new DBHelper().CreateNewBatch(Title, Remark, IncludePaper);
        }

        [WebMethod(Description = "开启一个批次")]
        public string StartBatch(string BatchID, string username, string password)
        {
            if (!CheckLogin(username, password))
                return "身份验证失败";
            return new DBHelper().StartBatch(BatchID);
        }

        [WebMethod(Description = "终止一个批次")]
        public string StopBatch(string BatchID, string username, string password)
        {
            if (!CheckLogin(username, password))
                return "身份验证失败";
            return new DBHelper().StopBatch(BatchID);
        }

        [WebMethod(Description = "删除一个批次")]
        public string DeleteBatch(string BatchID, string username, string password)
        {
            if (!CheckLogin(username, password))
                return "身份验证失败";
            return new DBHelper().DeleteBatch(BatchID);
        }

        [WebMethod(Description = "编辑一个批次")]
        public string EditBatch(string BatchID, string Title, string Remark, string IncludePaper, string username, string password)
        {
            if (!CheckLogin(username, password))
                return "身份验证失败";
            return new DBHelper().EditBatch(BatchID, Title, Remark, IncludePaper);
        }

        [WebMethod(Description = "配置更新")]
        public string UpdateConfig(string username, string password)
        {
            try
            {
                if (!CheckLogin(username, password))
                    return "身份验证失败";

                new DBHelper().ClearUpdateRule();
                ListFiles(@"D:\WebService\update\");
                return "ok";
            }
            catch
            {
                return "error";
            }
        }


        /// <summary>
        /// 文件目录循环遍历
        /// </summary>
        /// <param name="info"></param>
        private void ListFiles(string folderFullName)
        {
            DirectoryInfo dir = new DirectoryInfo(folderFullName);
            // 子目录不空，则优先遍历所有的子目录，再遍历每个子目录中的文件  
            DirectoryInfo[] subDir = dir.GetDirectories();
            foreach (DirectoryInfo sub in subDir)
            {
                ListFiles(sub.FullName); // 先遍历当前目录的子目录  
            }
            // 遍历当前目录的文件  
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo f in files)
            {
                if (f.Name.ToLower() == "update.exe" || f.Name.ToLower() == "update.exe.config" || f.Name.ToLower() == "web.config")
                    continue;
                new DBHelper().InsertUpdateRule(
                        CutRootPath(f.FullName),
                        "http://keyboard.hcs.ac.cn/update/" + CutRootPath(f.FullName),
                        GetMD5HashFromFile(f.FullName));
            }
        }

        /// <summary>
        /// 获取服务器文件路径
        /// </summary>
        /// <param name="FullFileName"></param>
        /// <returns></returns>
        private string CutRootPath(string FullFileName)
        {
            return FullFileName.Substring(@"D:\WebService\update\".Length).Replace(@"\", @"/");
        }

        /// <summary>
        /// 获取文件MD5
        /// </summary>
        /// <param name="FileName"></param>
        /// <returns></returns>
        private string GetMD5HashFromFile(string FileName)
        {
            try
            {
                FileStream file = new FileStream(FileName, FileMode.Open);
                System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
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
                return "";
            }
        }

    }
}
