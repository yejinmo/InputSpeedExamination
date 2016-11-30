using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using InformationEngine;

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
        public DataSet GetAllDepartment()
        {
            return new DBHelper().GetAllDepartment();
        }

        /// <summary>
        /// 根据 DepartmentID 获取专业
        /// </summary>
        /// <param name="DepartmentID">系别 ID</param>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetMajorByDepartment(string DepartmentID)
        {
            return new DBHelper().GetMajorByDepartment(DepartmentID);
        }

        /// <summary>
        /// 获取更新列表
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public DataSet GetUpdateList()
        {
            return new DataSet();
        }

        [WebMethod]
        public string GetEdu(string username, string password)
        {
            if (string.IsNullOrEmpty(username))
                return "username is empty.";
            if (string.IsNullOrEmpty(password))
                return "password is empty.";
            return new EducationSystem().Get(username, password);
        }

        [WebMethod]
        public string GetUserInfo(string username, string password)
        {
            if (string.IsNullOrEmpty(username))
                return "username empty";
            if (string.IsNullOrEmpty(password))
                return "password empty";
            return new EducationSystem().GetUserInformation(username, password);
        }

    }
}
