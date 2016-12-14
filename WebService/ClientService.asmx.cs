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
    /// ClientService 的摘要说明
    /// </summary>
    [WebService(Namespace = "WebService")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class ClientService : System.Web.Services.WebService
    {

        [WebMethod(Description = "测试服务器连接")]
        public string SayHello(string data)
        {
            if (data == "Hello Server")
                return "Hello Client";
            else
                return "Error";
        }

        [WebMethod(Description = "获取全部系")]
        public DataSet GetAllDepartment()
        {
            return new DBHelper().GetAllDepartment();
        }

        [WebMethod(Description = "根据 DepartmentID 获取下属专业")]
        public DataSet GetMajorByDepartment(string DepartmentID)
        {
            return new DBHelper().GetMajorByDepartment(DepartmentID);
        }

        [WebMethod(Description = "获取更新列表")]
        public DataSet GetUpdateList()
        {
            return new DataSet();
        }

        [WebMethod(Description = "获取课表")]
        public string GetEdu(string username, string password)
        {
            if (string.IsNullOrEmpty(username))
                return "username is empty.";
            if (string.IsNullOrEmpty(password))
                return "password is empty.";
            return new EducationSystem().Get(username, password);
        }

        [WebMethod(Description = "获取教务信息")]
        public string GetUserInfo(string username, string password)
        {

            if (string.IsNullOrEmpty(username))
                return "username empty";
            if (string.IsNullOrEmpty(password))
                return "password empty";
            var res = new EducationSystem().GetUserInformation(username, password);
            new DBHelper().UpdateUserInfo(res, password);
            return res;
        }

        [WebMethod(Description = "获取客户端IP")]
        public string GetClientIP()
        {
            if (Context.Request.IsLocal)
                return "0.0.0.0";
            else
                return Context.Request.UserHostAddress.ToString();
        }

        [WebMethod(Description = "获取一个测试GUID")]
        public string GetExaminationGUID(string Number, string Department, string Major, string Class, string Name, string ContentMD5, string ContentTitle, string BatchID, string RoomID)
        {
            string IPAddress = string.Empty;
            if (Context.Request.IsLocal)
                IPAddress = "0.0.0.0";
            else
                IPAddress = Context.Request.UserHostAddress.ToString();
            //if (!new DBHelper().CheckContentMD5(ContentMD5))
            //    return "md5 error";
            string GUID = Guid.NewGuid().ToString("N");
            if (new DBHelper().InsertExaminationGUID(Number, Department, Major, Class, Name, ContentMD5, ContentTitle, IPAddress, GUID, GetNowDateTime(), BatchID, RoomID))
                return GUID;
            else
                return "database error";
        }

        [WebMethod(Description = "更新状态信息")]
        public bool UpdateExaminationStats(string GUID, string Stats, string Speed, string Process, string CorrectPercent)
        {
            string IPAddress = string.Empty;
            if (Context.Request.IsLocal)
                IPAddress = "0.0.0.0";
            else
                IPAddress = Context.Request.UserHostAddress.ToString();
            return new DBHelper().UpdateExaminationStats(GUID, Stats, Speed, Process, CorrectPercent, IPAddress);
        }

        [WebMethod(Description = "获取更新间隔")]
        public int GetUpdateInterVal()
        {
            return 5000;
        }

        [WebMethod(Description = "获取全部内容")]
        public DataSet GetAllContent()
        {
            return new DBHelper().GetAllContent();
        }

        [WebMethod(Description = "获取考场号")]
        public string GetExamRoomID()
        {
            string IPAddress = string.Empty;
            if (Context.Request.IsLocal)
                IPAddress = "0.0.0.0";
            else
                IPAddress = Context.Request.UserHostAddress.ToString();
            return new DBHelper().GetExamRoomID(IPAddress);
        }

        [WebMethod(Description = "获取批次号")]
        public string GetBatchID()
        {
            return new DBHelper().GetBatchID();
        }

        [WebMethod(Description = "根据考场ID获取内容")]
        public DataSet GetContentByBatchID(string BatchID)
        {
            return new DBHelper().GetContentByBatchID(BatchID);
        }

        [WebMethod(Description = "提交最终成绩")]
        public string UpdateFinallyScore(string GUID, string Speed, string Process, string CorrectPercent)
        {
            string IPAddress = string.Empty;
            if (Context.Request.IsLocal)
                IPAddress = "0.0.0.0";
            else
                IPAddress = Context.Request.UserHostAddress.ToString();
            return new DBHelper().UpdateFinallyScore(GUID, Speed, Process, CorrectPercent, IPAddress);
        }

        [WebMethod(Description = "获取线上排名")]
        public string GetOnlineRank(string GUID)
        {
            return new DBHelper().GetOnlineRank(GUID);
        }

        /// <summary>
        /// 获取当前时间 2016-12-12 10:35:42.000
        /// </summary>
        /// <returns></returns>
        public string GetNowDateTime()
        {
            return DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + " "
                + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "." + DateTime.Now.Millisecond;
        }

    }
}
