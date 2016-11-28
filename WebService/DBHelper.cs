using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;

namespace WebService
{
    public class DBHelper : IDisposable
    {

        public static SqlConnection Conn;  

        private string ConServerStr = @"Data Source=keyboard.hcs.ac.cn;Initial Catalog=master;Persist Security Info=True;User ID=sa;Password=jsjxh-2008";

        public DBHelper()
        {
            if (Conn == null)
            {
                Conn = new SqlConnection();
                Conn.ConnectionString = ConServerStr;
                Conn.Open();
            }
        }

        public void Dispose()
        {
            if (Conn != null)
            {
                Conn.Close();
                Conn = null;
            }
        }

        /// <summary>
        /// 获取全部系
        /// </summary>
        /// <returns></returns>
        public DataSet GetAllDepartment()
        {
            DataSet ds = new DataSet();
            try
            {
                string sql = "SELECT [String], [ID] FROM [Table_Department]";
                SqlDataAdapter sda = new SqlDataAdapter(sql, Conn);
                sda.Fill(ds);
                sda.Dispose();
            }
            catch
            {

            }
            return ds;
        }

        public DataSet GetMajorByDepartment(string DepartmentID)
        {
            DataSet ds = new DataSet();
            try
            {
                string sql = string.Format("SELECT [String], [ID] FROM [Table_Major] WHERE DepartmentID = {0}", DepartmentID);
                SqlDataAdapter sda = new SqlDataAdapter(sql, Conn);
                sda.Fill(ds);
                sda.Dispose();
            }
            catch
            {

            }
            return ds;
        }

    }
}