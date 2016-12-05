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

        public string HeartBeat(string Number, string GUID, string UpdateTime,string IPAddress)
        {
            string sql_update = string.Format("UPDATE [Table_UserOnLineInfo] SET [UpdateTime] = '{0}'", UpdateTime);
            string sql_check_online = string.Format("SELECT * FROM [Table_UserOnLineInfo] WHERE [GUID] = '{0}' AND [Number] = '{1}'",
                GUID, Number);
            string sql_insert = string.Format(
                "INSERT INTO [Table_UserOnLineInfo] ([Number], [GUID], [UpdateTime], [IPAddress]) VALUES ('{0}', '{1}', '{2}', '{3}')"
                , Number, GUID, UpdateTime, IPAddress);
            return "";
        }

        /// <summary>
        /// 更新或插入教务信息
        /// </summary>
        /// <param name="str">教务信息字符串</param>
        /// <param name="password">教务密码</param>
        /// <returns></returns>
        public bool UpdateUserInfo(string str, string password)
        {
            var res_array = str.Split(',');
            if (res_array.Length != 5)
                return false;
            try
            {
                string sql_update = string.Format(
"UPDATE [Table_UserInfo] SET [Department] = '{0}', [Major] = '{1}', [Class] = '{2}', [Name] = '{3}', [Password] = '{4}'"
                    , res_array[0], res_array[1], res_array[2], res_array[3], password);
                string sql_insert = string.Format(
"INSERT INTO [Table_UserInfo] ([Department], [Major], [Class], [Name], [Number], [Password]) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')"
                    , res_array[0], res_array[1], res_array[2], res_array[3], res_array[4], password);
                string sql_check = string.Format("SELECT * FROM [Table_UserInfo] WHERE [Number] = '{0}'", res_array[4]);
                SqlCommand cmd = new SqlCommand(sql_check, Conn);
                if (cmd.ExecuteNonQuery() <= 0)
                {
                    cmd = new SqlCommand(sql_insert, Conn);
                    return (cmd.ExecuteNonQuery() == 0 ? false : true);
                }
                else
                {
                    cmd = new SqlCommand(sql_update, Conn);
                    return (cmd.ExecuteNonQuery() == 0 ? false : true);
                }
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 判断内容MD5是否存在
        /// </summary>
        /// <param name="ContentMD5"></param>
        /// <returns></returns>
        public bool CheckContentMD5(string ContentMD5)
        {
            string sql_check = string.Format("SELECT * FROM [Table_Content] WHERE [MD5] = '{0}'", ContentMD5);
            if (new SqlCommand(sql_check, Conn).ExecuteNonQuery() > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 插入一条新的GUID
        /// </summary>
        /// <param name="Number"></param>
        /// <param name="Department"></param>
        /// <param name="Major"></param>
        /// <param name="Class"></param>
        /// <param name="Name"></param>
        /// <param name="ContentMD5"></param>
        /// <param name="ContentTitle"></param>
        /// <param name="IPAddress"></param>
        /// <param name="GUID"></param>
        /// <param name="BeginTime"></param>
        /// <returns></returns>
        public bool InsertExaminationGUID(string Number, string Department, string Major, string Class,
            string Name, string ContentMD5, string ContentTitle, string IPAddress, string GUID, string BeginTime)
        {
            try
            {
                string Stats = "开始";
                string sql_insert = string.Format(
    "INSERT INTO [Table_ExaminationStats] ([Number], [Department], [Major], [Class], [Name], [ContentMD5], [ContentTitle], [IPAddress], [GUID], [BeginTime], [Stats]) " +
    "VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}')"
                    , Number, Department, Major, Class, Name, ContentMD5, ContentTitle, IPAddress, GUID, BeginTime, Stats);
                if (new SqlCommand(sql_insert, Conn).ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

    }
}