using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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

        [WebMethod(Description = "获取指定考场状态表")]
        public DataSet GetStats(string BatchID,string RoomID)
        {
            return new DBHelper().GetStats(BatchID, RoomID);
        }

        [WebMethod(Description = "获取考场列表")]
        public DataSet GetExamRoomList()
        {
            return new DBHelper().GetExamRoomList();
        }

        [WebMethod(Description = "创建新考场")]
        public string CreateNewExamRoom(string RoomTitle, string IncludeIP)
        {
            return new DBHelper().CreateNewExamRoom(RoomTitle, IncludeIP);
        }

        [WebMethod(Description = "编辑考场")]
        public string EditExamRoom(string RoomID, string RoomTitle, string IncludeIP)
        {
            return new DBHelper().EditExamRoom(RoomID, RoomTitle, IncludeIP);
        }

        [WebMethod(Description = "删除指定考场")]
        public bool DeleteExamRoom(string RoomID)
        {
            return new DBHelper().DeleteExamRoom(RoomID);
        }

        [WebMethod(Description = "获取全部内容")]
        public DataSet GetAllContent()
        {
            return new DBHelper().GetAllContent();
        }

        [WebMethod(Description = "添加新内容")]
        public string CreateNewContent(string Title, string Content)
        {
            return new DBHelper().CreateNewContent(Title, Content);
        }

        [WebMethod(Description = "更新内容")]
        public string UpdateContent(string ContentID, string Title, string Content)
        {
            return new DBHelper().UpdateContent(ContentID, Title, Content);
        }

        [WebMethod(Description = "删除指定内容")]
        public bool DeleteContent(string ContentID)
        {
            return new DBHelper().DeleteContent(ContentID);
        }

        [WebMethod(Description = "根据内容ID获取内容")]
        public DataSet GetContentByPaperID(string IncludePaper)
        {
            return new DBHelper().GetContentByPaperID(IncludePaper);
        }

        [WebMethod(Description = "根据批次ID获取内容")]
        public DataSet GetContentByBatchID(string BatchID)
        {
            return new DBHelper().GetContentByBatchID(BatchID);
        }

        [WebMethod(Description = "创建新批次")]
        public string CreateNewBatch(string Title, string Remark, string IncludePaper)
        {
            return new DBHelper().CreateNewBatch(Title, Remark, IncludePaper);
        }

        [WebMethod(Description = "开启一个批次")]
        public string StartBatch(string BatchID)
        {
            return new DBHelper().StartBatch(BatchID);
        }

        [WebMethod(Description = "终止一个批次")]
        public string StopBatch(string BatchID)
        {
            return new DBHelper().StopBatch(BatchID);
        }

        [WebMethod(Description = "删除一个批次")]
        public string DeleteBatch(string BatchID)
        {
            return new DBHelper().DeleteBatch(BatchID);
        }

        [WebMethod(Description = "编辑一个批次")]
        public string EditBatch(string BatchID, string Title, string Remark, string IncludePaper)
        {
            return new DBHelper().EditBatch(BatchID, Title, Remark, IncludePaper);
        }

    }
}
