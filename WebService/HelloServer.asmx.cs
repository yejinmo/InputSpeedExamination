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

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string SayHello(string data)
        {
            if(data == "Hello Server")
                return "Hello Client";
            else
                return "Error";
        }

        [WebMethod]
        public int GetSum(int a, int b)
        {
            return a + b;
        }



    }
}
