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
        public DataSet GetStats(string ID)
        {
            return new DBHelper().GetStats(ID);
        }

        [WebMethod(Description = "获取考场列表")]
        public DataSet GetBatchList()
        {
            return new DBHelper().GetBatchList();
        }

        [WebMethod(Description = "创建新考场")]
        public string CreateNewBatch(string BatchTitle, string IncludeIP, string IncludePaper)
        {
            return new DBHelper().CreateNewBatch(BatchTitle, IncludeIP, IncludePaper);
        }

        [WebMethod(Description = "编辑考场")]
        public string UpdateBatch(string BatchID, string BatchTitle, string IncludeIP, string IncludePaper)
        {
            return new DBHelper().UpdateBatch(BatchID, BatchTitle, IncludeIP, IncludePaper);
        }

        [WebMethod(Description = "删除指定考场")]
        public bool DeleteBatch(string BatchID)
        {
            return new DBHelper().DeleteBatch(BatchID);
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

        [WebMethod(Description = "根据考场号获取内容")]
        public DataSet GetContentByBatchID(string IncludePaper)
        {
            return new DBHelper().GetContentByBatchID(IncludePaper);
        }

    }
}
