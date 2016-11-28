using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebService
{
    /// <summary>
    /// HelloServer 的摘要说明
    /// </summary>
    [WebService(Namespace = "WebService")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class HelloServer : System.Web.Services.WebService
    {

        /// <summary>
        /// 测试服务器连接
        /// </summary>
        /// <param name="data">参数需为 Hello Server </param>
        /// <returns>连接正常则返回 Hello Client </returns>
        [WebMethod]
        public string SayHello(string data)
        {
            if (data == "Hello Server")
                return "Hello Client";
            else
                return "Error";
        }

        /// <summary>
        /// 获取全部系
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public List<string> GetAllDepartment()
        {
            List<string> res = new List<string>();
            res.Add("计算机科学系");
            res.Add("经济管理系");
            res.Add("机械与电气工程系");
            res.Add("电子信息与控制工程系");
            res.Add("艺术系");
            res.Add("交通运输系");
            res.Add("外语系");
            res.Add("化学工程系");
            res.Add("其他");
            return res;
        }

        /// <summary>
        /// 根据 DepartmentID 获取专业
        /// </summary>
        /// <param name="DepartmentID">系别 ID</param>
        /// <returns></returns>
        [WebMethod]
        public List<string> GetMajorByDepartment(string DepartmentID)
        {
            List<string> res = new List<string>();
            res.Add("");
            return res;
        }

    }
}
