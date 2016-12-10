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
using System.Net;
using System.Security.Cryptography;
using System.Text;

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

        #region Client

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

        /// <summary>
        /// 根据系ID获取全部专业
        /// </summary>
        /// <param name="DepartmentID"></param>
        /// <returns></returns>
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
                var res = cmd.ExecuteReader();
                if (res.Read())
                {
                    res.Close();
                    cmd = new SqlCommand(sql_update, Conn);
                    return (cmd.ExecuteNonQuery() == 0 ? false : true);
                }
                else
                {
                    res.Close();
                    cmd = new SqlCommand(sql_insert, Conn);
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
            try
            {
                string sql_check = string.Format("SELECT * FROM [Table_Content] WHERE [MD5] = '{0}'", ContentMD5);
                var sdr = new SqlCommand(sql_check, Conn).ExecuteReader();
                if (sdr.Read())
                {
                    sdr.Close();
                    return true;
                }
                else
                {
                    sdr.Close();
                    return false;
                }
            }
            catch
            {
                return false;
            }
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

        /// <summary>
        /// 更新测试状态
        /// </summary>
        /// <param name="GUID"></param>
        /// <param name="Stats"></param>
        /// <param name="Speed"></param>
        /// <param name="Process"></param>
        /// <param name="CorrectPercent"></param>
        /// <param name="IPAddress"></param>
        /// <returns></returns>
        public bool UpdateExaminationStats(string GUID, string Stats, string Speed, string Process, string CorrectPercent, string IPAddress)
        {
            try
            {
                string sql_update = string.Format(
"UPDATE [Table_ExaminationStats] SET [Stats] = '{0}', [Speed] = '{1}', [Process] = '{2}', [CorrectPercent] = '{3}', [IPAddress] = '{4}' WHERE [GUID] = '{5}'"
, Stats, Speed, Process, CorrectPercent, IPAddress, GUID);
                int res = new SqlCommand(sql_update, Conn).ExecuteNonQuery();
                if (res > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 根据客户机IP获取考场ID
        /// </summary>
        /// <param name="IPAddress"></param>
        /// <returns></returns>
        public string GetBatchID(string IPAddress)
        {
            try
            {
                string sql = string.Format("SELECT [ID] FROM [Table_Batch] WHERE [IncludeIP] LIKE '{0}'", IPAddress);
                SqlCommand cmd = new SqlCommand(sql, Conn);
                var sdr = cmd.ExecuteReader();
                if (!sdr.Read())
                    return "1";
                return sdr[0].ToString();
            }
            catch
            {
                return "1";
            }
        }

        #endregion

        #region Server

        /// <summary>
        /// 根据考场ID获取状态
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public DataSet GetStats(string ID)
        {
            DataSet ds = new DataSet();
            try
            {
                string sql = string.Format("SELECT * FROM [Table_Stats] WHERE [BatchID] = '{0}'", ID);
                SqlDataAdapter sda = new SqlDataAdapter(sql, Conn);
                sda.Fill(ds);
                sda.Dispose();
                return ds;
            }
            catch
            {
                return ds;
            }
        }

        /// <summary>
        /// 获取考场列表
        /// </summary>
        /// <returns></returns>
        public DataSet GetBatchList()
        {
            DataSet ds = new DataSet();
            try
            {
                string sql = "SELECT * FROM [Table_Batch]";
                SqlDataAdapter sda = new SqlDataAdapter(sql, Conn);
                sda.Fill(ds);
                sda.Dispose();
                return ds;
            }
            catch
            {
                return ds;
            }
        }

        /// <summary>
        /// 创建新考场
        /// </summary>
        /// <param name="BatchTitle"></param>
        /// <param name="IncludeIP"></param>
        /// <param name="IncludePaper"></param>
        /// <returns></returns>
        public string CreateNewBatch(string BatchTitle, string IncludeIP, string IncludePaper)
        {
            try
            {
                var IncludeIP_array = IncludeIP.Split(',');
                foreach (var ip in IncludeIP_array)
                {
                    IPAddress temp;
                    if (!IPAddress.TryParse(ip, out temp))
                        return string.Format("IP地址 {0} 不合法", ip);
                }
                var IncludePaper_array = IncludePaper.Split(',');
                foreach (var id in IncludePaper_array)
                {
                    int temp;
                    if (int.TryParse(id, out temp))
                        return string.Format("内容ID {0} 不合法", id);
                }
                string sql = string.Format(
                    "INSERT INTO [Table_Batch] ([BatchTitle], [IncludeIP], [IncludePaper]) VALUES ('{0}', '{1}', '{2}')",
                    BatchTitle, IncludeIP, IncludePaper);
                new SqlCommand(sql, Conn).ExecuteNonQuery();
                return "ok";
            }
            catch(Exception e)
            {
                return e.Message;
            }
        }

        /// <summary>
        /// 编辑考场
        /// </summary>
        /// <param name="BatchID"></param>
        /// <param name="BatchTitle"></param>
        /// <param name="IncludeIP"></param>
        /// <param name="IncludePaper"></param>
        /// <returns></returns>
        public string UpdateBatch(string BatchID, string BatchTitle, string IncludeIP, string IncludePaper)
        {
            try
            {
                var IncludeIP_array = IncludeIP.Split(',');
                foreach (var ip in IncludeIP_array)
                {
                    IPAddress temp;
                    if (!IPAddress.TryParse(ip, out temp))
                        return string.Format("IP地址 {0} 不合法", ip);
                }
                var IncludePaper_array = IncludePaper.Split(',');
                foreach (var id in IncludePaper_array)
                {
                    int temp;
                    if (!int.TryParse(id, out temp))
                        return string.Format("内容ID {0} 不合法", id);
                }
                int temp_id;
                if(!int.TryParse(BatchID,out temp_id))
                    return string.Format("ID {0} 不合法", BatchID);
                string sql = string.Format(
                    "UPDATE [Table_Batch] SET [BatchTitle] = '{0}', [IncludeIP] = '{1}', [IncludePaper] = '{2}' WHERE [ID] = {}",
                    BatchTitle, IncludeIP, IncludePaper, BatchID);
                new SqlCommand(sql, Conn).ExecuteNonQuery();
                return "ok";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        /// <summary>
        /// 删除指定考场
        /// </summary>
        /// <param name="BatchID"></param>
        /// <returns></returns>
        public bool DeleteBatch(string BatchID)
        {
            try
            {
                int batchID;
                if (!int.TryParse(BatchID, out batchID))
                    return false;
                if (batchID == 1)
                    return false;
                string sql = string.Format("DELETE [Table_Batch] WHERE [ID] = '{0}'", BatchID);
                new SqlCommand(sql, Conn).ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 获取全部内容
        /// </summary>
        /// <returns></returns>
        public DataSet GetAllContent()
        {
            DataSet ds = new DataSet();
            try
            {
                string sql = "SELECT * FROM [Table_Content]";
                SqlDataAdapter sda = new SqlDataAdapter(sql, Conn);
                sda.Fill(ds);
                sda.Dispose();
                return ds;
            }
            catch
            {
                return ds;
            }
        }

        /// <summary>
        /// 添加新内容
        /// </summary>
        /// <param name="Title"></param>
        /// <param name="Content"></param>
        /// <returns></returns>
        public string CreateNewContent(string Title, string Content)
        {
            try
            {
                string MD5_str = GetMD5Hash(Content);
                string sql_check = string.Format("SELECT * FROM [Table_Content] WHERE [MD5] = '{0}'", MD5_str);
                string sql = string.Format(
                    "INSERT INTO [Table_Content] ([Title], [String], [MD5]) VALUES ('{0}', '{1}', '{2}')",
                    Title, Content, MD5_str);
                SqlCommand cmd = new SqlCommand(sql_check, Conn);
                var sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    sdr.Close();
                    return "已包含相同内容";
                }
                sdr.Close();
                cmd = new SqlCommand(sql, Conn);
                cmd.ExecuteNonQuery();
                return "ok";
            }
            catch(Exception e)
            {
                return e.Message;
            }
        }

        /// <summary>
        /// 更新内容
        /// </summary>
        /// <param name="ContentID"></param>
        /// <param name="Title"></param>
        /// <param name="Content"></param>
        /// <returns></returns>
        public string UpdateContent(string ContentID, string Title, string Content)
        {
            try
            {
                string MD5_str = GetMD5Hash(Content);
                string sql = string.Format("UPDATE [Table_Content] SET [Title] = '{0}', [String] = '{1}', [MD5] = '{2}' WHERE [ID] = '{3}'",
                    Title, Content, MD5_str, ContentID);
                string sql_check = string.Format("SELECT * FROM [Table_Content] WHERE [MD5] = '{0}'", MD5_str);
                SqlCommand cmd = new SqlCommand(sql_check, Conn);
                var sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    if (sdr["MD5"].ToString() == MD5_str)
                    {
                        sdr.Close();
                        return "已包含相同内容";
                    }
                }
                sdr.Close();
                cmd = new SqlCommand(sql, Conn);
                cmd.ExecuteNonQuery();
                return "ok";
            }
            catch(Exception e)
            {
                return e.Message;
            }
        }

        /// <summary>
        /// 删除指定内容
        /// </summary>
        /// <param name="ContentID"></param>
        /// <returns></returns>
        public bool DeleteContent(string ContentID)
        {
            try
            {
                string sql = string.Format("DELETE [Table_Content] WHERE [ID] = '{0}'", ContentID);
                new SqlCommand(sql, Conn).ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 根据考场号获取内容
        /// </summary>
        /// <param name="IncludePaper"></param>
        /// <returns></returns>
        public DataSet GetContentByBatchID(string IncludePaper)
        {
            DataSet ds = new DataSet();
            try
            {
                var IncludePaper_array = IncludePaper.Split(',');
                string sql = string.Format("SELECT * FROM [Table_Content] WHERE [ID] = ''");
                foreach (var id in IncludePaper_array)
                {
                    int temp;
                    if (!int.TryParse(id, out temp))
                        return null;
                    string sql_append = string.Format(" OR [ID] = '{0}'", id);
                    sql += sql_append;
                }
                SqlDataAdapter sda = new SqlDataAdapter(sql, Conn);
                sda.Fill(ds);
                sda.Dispose();
                return ds;
            }
            catch
            {
                return ds;
            }
        }

        #endregion

        /// <summary>
        /// 返回字符串小写形式的MD5值
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private string GetMD5Hash(string input)
        {
            if (input == null)
            {
                return null;
            }
            MD5 md5Hash = MD5.Create();

            // 将输入字符串转换为字节数组并计算哈希数据  
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // 创建一个 Stringbuilder 来收集字节并创建字符串  
            StringBuilder sBuilder = new StringBuilder();

            // 循环遍历哈希数据的每一个字节并格式化为十六进制字符串  
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // 返回十六进制字符串  
            return sBuilder.ToString().ToLower();
        }

    }
}