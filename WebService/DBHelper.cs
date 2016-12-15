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
                return ds;
            }
            catch
            {
                return ds;
            }
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
"UPDATE [Table_UserInfo] SET [Department] = '{0}', [Major] = '{1}', [Class] = '{2}', [Name] = '{3}', [Password] = '{4}' WHERE [Number] = '{5}'"
                    , res_array[0], res_array[1], res_array[2], res_array[3], password, res_array[4]);
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
                    cmd.ExecuteNonQuery();
                    return true;
                }
                else
                {
                    res.Close();
                    cmd = new SqlCommand(sql_insert, Conn);
                    cmd.ExecuteNonQuery();
                    return true;
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
            string Name, string ContentMD5, string ContentTitle, string IPAddress, string GUID, string BeginTime, string BatchID, string RoomID)
        {
            try
            {
                string Stats = "开始";
                string sql_insert = string.Format(
    "INSERT INTO [Table_ExaminationStats] ([Number], [Department], [Major], [Class], [Name], [ContentMD5], [ContentTitle], [IPAddress], [GUID], [BeginTime], [Stats], [BatchID], [RoomID]) " +
    "VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}')"
                    , Number, Department, Major, Class, Name, ContentMD5, ContentTitle, IPAddress, GUID, BeginTime, Stats, BatchID, RoomID);
                new SqlCommand(sql_insert, Conn).ExecuteNonQuery();
                    return true;
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
                string sql_check = string.Format("SELECT * FROM [Table_ExaminationStats] WHERE [GUID] = '{0}' AND NOT [Stats] = '完成'", GUID);
                var sdr = new SqlCommand(sql_check, Conn).ExecuteReader();
                if (sdr.Read())
                    sdr.Close();
                else
                {
                    sdr.Close();
                    return false;
                }
                string sql_update = string.Format(
"UPDATE [Table_ExaminationStats] SET [Stats] = '{0}', [Speed] = '{1}', [Process] = '{2}', [CorrectPercent] = '{3}', [IPAddress] = '{4}' WHERE [GUID] = '{5}'"
, Stats, Speed, Process, CorrectPercent, IPAddress, GUID);
                new SqlCommand(sql_update, Conn).ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 获取批次号
        /// </summary>
        /// <returns></returns>
        public string GetBatchID()
        {
            try
            {
                string sql = string.Format("SELECT [ID] FROM [Table_Batch] WHERE [IsOpen] = '{0}'", 1);
                SqlCommand cmd = new SqlCommand(sql, Conn);
                var sdr = cmd.ExecuteReader();
                if (!sdr.Read())
                {
                    sdr.Close();
                    return "";
                }
                var res = sdr[0].ToString();
                sdr.Close();
                return res;
            }
            catch
            {
                return "error";
            }
        }

        /// <summary>
        /// 获取批次标题
        /// </summary>
        /// <returns></returns>
        public string GetBatchTitle()
        {
            try
            {
                string sql = string.Format("SELECT [Title] FROM [Table_Batch] WHERE [IsOpen] = '{0}'", 1);
                SqlCommand cmd = new SqlCommand(sql, Conn);
                var sdr = cmd.ExecuteReader();
                if (!sdr.Read())
                {
                    sdr.Close();
                    return "";
                }
                var res = sdr[0].ToString();
                sdr.Close();
                return res;
            }
            catch
            {
                return "error";
            }
        }

        /// <summary>
        /// 根据客户机IP获取考场ID
        /// </summary>
        /// <param name="IPAddress"></param>
        /// <returns></returns>
        public string GetExamRoomID(string IPAddress)
        {
            try
            {
                string sql = string.Format("SELECT [ID] FROM [Table_ExamRoom] WHERE [IncludeIP] LIKE '%{0}%'", IPAddress);
                SqlCommand cmd = new SqlCommand(sql, Conn);
                var sdr = cmd.ExecuteReader();
                if (!sdr.Read())
                {
                    sdr.Close();
                    return "1";
                }
                var res = sdr[0].ToString();
                sdr.Close();
                return res;
            }
            catch
            {
                return "error";
            }
        }

        /// <summary>
        /// 根据客户机IP获取考场标题
        /// </summary>
        /// <param name="IPAddress"></param>
        /// <returns></returns>
        public string GetExamRoomTitle(string IPAddress)
        {
            try
            {
                string sql = string.Format("SELECT [RoomTitle] FROM [Table_ExamRoom] WHERE [IncludeIP] LIKE '%{0}%'", IPAddress);
                SqlCommand cmd = new SqlCommand(sql, Conn);
                var sdr = cmd.ExecuteReader();
                if (!sdr.Read())
                {
                    sdr.Close();
                    return "默认考场";
                }
                var res = sdr[0].ToString();
                sdr.Close();
                return res;
            }
            catch
            {
                return "error";
            }
        }

        /// <summary>
        /// 提交最终成绩
        /// </summary>
        /// <returns></returns>
        public string UpdateFinallyScore(string GUID, string Speed, string Process, string CorrectPercent, string IPAddress)
        {
            try
            {
                double dSpeed = 0;
                double dCorrectPercent = 0;
                if (!(double.TryParse(Speed, out dSpeed) && double.TryParse(CorrectPercent, out dCorrectPercent)))
                    return "成绩参数错误";
                double finalScore = dSpeed * dCorrectPercent;
                string sql_update = string.Format(
"UPDATE [Table_ExaminationStats] SET [Stats] = '{0}', [Speed] = '{1}', [Process] = '{2}', [CorrectPercent] = '{3}', [IPAddress] = '{4}', [FinishTime] = '{5}', [FinalScore] = '{6}' WHERE [GUID] = '{7}' AND NOT [Stats] = '完成'"
, "完成", Speed, Process, CorrectPercent, IPAddress, GetNowDateTime(), finalScore, GUID);
                new SqlCommand(sql_update, Conn).ExecuteNonQuery();
                    return "ok";
            }
            catch
            {
                return "服务器写入成绩时发生错误";
            }
        }

        /// <summary>
        /// 获取线上排名
        /// </summary>
        /// <param name="GUID"></param>
        /// <returns></returns>
        public string GetOnlineRank(string GUID)
        {
            try
            {
                string md5 = string.Empty;
                string sql_get_md5 = string.Format(
                    "SELECT * FROM [Table_ExaminationStats] WHERE [GUID] = '{0}'", GUID);
                var sdr = new SqlCommand(sql_get_md5, Conn).ExecuteReader();
                if (sdr.Read())
                {
                    md5 = sdr["ContentMD5"].ToString();
                    sdr.Close();
                }
                else
                {
                    sdr.Close();
                    return "guid error";
                }
                int RANK = 0;
                string sql_get_rank = string.Format(
"SELECT [RANK] FROM (SELECT RANK() OVER(ORDER BY [FinalScore] DESC) [RANK], [GUID] FROM [Table_ExaminationStats] WHERE [ContentMD5] = '{0}') [Table_Rank] WHERE [GUID] = '{1}'"
, md5, GUID);
                sdr = new SqlCommand(sql_get_rank, Conn).ExecuteReader();
                if (sdr.Read())
                {
                    string res = sdr["RANK"].ToString();
                    sdr.Close();
                    if (!int.TryParse(res, out RANK))
                        return "rank error";
                }
                else
                {
                    sdr.Close();
                    return "md5 error";
                }
                int COUNT = 0;
                string sql_get_count = string.Format(
    "SELECT COUNT(*) AS [Count] FROM [Table_ExaminationStats] WHERE [ContentMD5] = '{0}'", md5);
                sdr = new SqlCommand(sql_get_count, Conn).ExecuteReader();
                if (sdr.Read())
                {
                    string res = sdr["Count"].ToString();
                    sdr.Close();
                    if (!int.TryParse(res, out COUNT) || COUNT == 0)
                        return "count error";
                    return ((COUNT - RANK) / (double)(COUNT - 1)).ToString();
                }
                else
                {
                    sdr.Close();
                    return "count error";
                }
            }
            catch
            {
                return "error";
            }
        }

        /// <summary>
        /// 获取更新列表
        /// </summary>
        /// <returns></returns>
        public DataSet GetUpdateList()
        {
            DataSet ds = new DataSet();
            try
            {
                string sql = string.Format("SELECT * FROM [Table_Update]");
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

        #region Server

        /// <summary>
        /// 根据考场号及批次号获取状态
        /// </summary>
        /// <param name="BatchID"></param>
        /// <param name="RoomID"></param>
        /// <returns></returns>
        public DataSet GetStats(string BatchID, string RoomID)
        {
            DataSet ds = new DataSet();
            try
            {
                string sql = string.Format("SELECT * FROM [Table_Stats] WHERE [BatchID] = '{0}' AND [RoomID] = '{1}'", BatchID, RoomID);
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
        public DataSet GetExamRoomList()
        {
            DataSet ds = new DataSet();
            try
            {
                string sql = "SELECT * FROM [Table_ExamRoom]";
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
        /// <param name="Title"></param>
        /// <param name="IncludeIP"></param>
        /// <returns></returns>
        public string CreateNewExamRoom(string Title, string IncludeIP)
        {
            try
            {
                var IncludeIP_array = IncludeIP.Split(',');
                foreach (var ip in IncludeIP_array)
                {
                    if (string.IsNullOrEmpty(ip))
                        return "IP地址不能为空";
                    IPAddress temp;
                    if (!IPAddress.TryParse(ip, out temp))
                        return string.Format("IP地址 {0} 不合法", ip);
                    string sql_check = string.Format("SELECT * FROM [Table_ExamRoom] WHERE [IncludeIP] LIKE '%{0}%'", ip);
                    var sdr = new SqlCommand(sql_check, Conn).ExecuteReader();
                    if (sdr.Read())
                    {
                        string roomTilte = sdr["RoomTitle"].ToString();
                        sdr.Close();
                        return ip + " 已存在于考场 " + roomTilte;
                    }
                    sdr.Close();
                }
                string sql = string.Format(
                    "INSERT INTO [Table_ExamRoom] ([RoomTitle], [IncludeIP]) VALUES ('{0}', '{1}')",
                    Title, IncludeIP);
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
        /// <param name="RoomID"></param>
        /// <param name="Title"></param>
        /// <param name="IncludeIP"></param>
        /// <returns></returns>
        public string EditExamRoom(string RoomID, string Title, string IncludeIP)
        {
            try
            {
                int temp_id;
                if (!int.TryParse(RoomID, out temp_id))
                    return string.Format("ID {0} 不合法", RoomID);
                if (temp_id == 1)
                    return "不能修改默认考场";
                var IncludeIP_array = IncludeIP.Split(',');
                foreach (var ip in IncludeIP_array)
                {
                    if (string.IsNullOrEmpty(ip))
                        return "IP地址不能为空";
                    IPAddress temp;
                    if (!IPAddress.TryParse(ip, out temp))
                        return string.Format("IP地址 {0} 不合法", ip);
                    string sql_check = string.Format("SELECT * FROM [Table_ExamRoom] WHERE [IncludeIP] LIKE '%{0}%' AND NOT [ID] = '{1}'", ip, RoomID);
                    var sdr = new SqlCommand(sql_check, Conn).ExecuteReader();
                    if (sdr.Read())
                    {
                        string roomTilte = sdr["RoomTitle"].ToString();
                        sdr.Close();
                        return ip + " 已存在于考场 " + roomTilte;
                    }
                    sdr.Close();
                }
                string sql = string.Format(
                    "UPDATE [Table_ExamRoom] SET [RoomTitle] = '{0}', [IncludeIP] = '{1}' WHERE [ID] = '{2}'",
                    Title, IncludeIP, RoomID);
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
        /// <param name="RoomID"></param>
        /// <returns></returns>
        public bool DeleteExamRoom(string RoomID)
        {
            try
            {
                int roomID;
                if (!int.TryParse(RoomID, out roomID))
                    return false;
                if (roomID == 1)
                    return false;
                string sql = string.Format("DELETE [Table_ExamRoom] WHERE [ID] = '{0}'", roomID);
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
        /// 根据内容ID获取内容
        /// </summary>
        /// <param name="IncludePaper"></param>
        /// <returns></returns>
        public DataSet GetContentByPaperID(string IncludePaper)
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

        /// <summary>
        /// 根据批次ID获取内容ID
        /// </summary>
        /// <param name="BatchID"></param>
        /// <returns></returns>
        public DataSet GetContentByBatchID(string BatchID)
        {
            DataSet ds = new DataSet();
            try
            {
                string sql_getIncludePaper = string.Format("SELECT [IncludePaper] FROM [Table_Batch] WHERE [ID] = '{0}'", BatchID);
                SqlCommand cmd = new SqlCommand(sql_getIncludePaper, Conn);
                var sdr = cmd.ExecuteReader();
                if (!sdr.Read())
                {
                    sdr.Close();
                    return ds;
                }
                string IncludePaper = sdr[0].ToString();
                sdr.Close();
                return GetContentByPaperID(IncludePaper);
            }
            catch
            {
                return ds;
            }
        }

        /// <summary>
        /// 获取批次列表
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
        /// 创建新批次
        /// </summary>
        /// <param name="Title"></param>
        /// <param name="Remark"></param>
        /// <param name="IncludePaper"></param>
        /// <returns></returns>
        public string CreateNewBatch(string Title, string Remark, string IncludePaper)
        {
            try
            {
                string sql = string.Format(
"INSERT INTO [Table_Batch] ([Title], [IsOpen], [IncludePaper], [Remark], [BeginTime], [FinishTime]) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
                    Title, "-1", IncludePaper, Remark, "-", "-");
                SqlCommand cmd = new SqlCommand(sql, Conn);
                cmd.ExecuteNonQuery();
                return "ok";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        
        /// <summary>
        /// 开启一个批次
        /// </summary>
        /// <param name="BatchID"></param>
        /// <returns></returns>
        public string StartBatch(string BatchID)
        {
            try
            {
                string sql_check = string.Format("SELECT * FROM [Table_Batch] WHERE [IsOpen] = '1'");
                var sdr = new SqlCommand(sql_check, Conn).ExecuteReader();
                if (sdr.Read())
                {
                    string res = sdr["Title"].ToString() + "[ID:" + sdr["ID"].ToString() + "] 处于开启状态\n\n不能同时启动";
                    sdr.Close();
                    return res;
                }
                sdr.Close();

                string sql_check2 = string.Format("SELECT * FROM [Table_Batch] WHERE [IsOpen] = '-1' AND [ID] = '{0}'", BatchID);
                sdr = new SqlCommand(sql_check2, Conn).ExecuteReader();
                if (!sdr.Read())
                {
                    string res = "[ID:" + BatchID + "] 已使用过\n\n不能再次开启";
                    sdr.Close();
                    return res;
                }
                sdr.Close();

                string sql = string.Format("UPDATE [Table_Batch] SET [IsOpen] = '1', [BeginTime] = '{0}' WHERE [ID] = '{1}'", GetNowDateTime(), BatchID);
                new SqlCommand(sql, Conn).ExecuteNonQuery();
                return "ok";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        /// <summary>
        /// 终止一个批次
        /// </summary>
        /// <param name="BatchID"></param>
        /// <returns></returns>
        public string StopBatch(string BatchID)
        {
            try
            {
                string sql_check = string.Format("SELECT * FROM [Table_Batch] WHERE ([IsOpen] = '0' OR [IsOpen] = '-1') AND [ID] = '{0}'", BatchID);
                var sdr = new SqlCommand(sql_check, Conn).ExecuteReader();
                if (sdr.Read())
                {
                    string res = sdr["Title"].ToString() + "[ID:" + sdr["ID"].ToString() + "] 处于未开启状态\n\n不能停止";
                    sdr.Close();
                    return res;
                }
                sdr.Close();
                string sql = string.Format("UPDATE [Table_Batch] SET [IsOpen] = '0', [FinishTime] = '{0}' WHERE [ID] = '{1}' AND [IsOpen] = '1'",
                    GetNowDateTime(), BatchID);
                new SqlCommand(sql, Conn).ExecuteNonQuery();
                return "ok";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        /// <summary>
        /// 删除一个批次
        /// </summary>
        /// <param name="BatchID"></param>
        /// <returns></returns>
        public string DeleteBatch(string BatchID)
        {
            try
            {
                string sql_check = string.Format("SELECT * FROM [Table_Batch] WHERE ([IsOpen] = '0' OR [IsOpen] = '1') AND [ID] = '{0}'", BatchID);
                var sdr = new SqlCommand(sql_check, Conn).ExecuteReader();
                if (sdr.Read())
                {
                    string res = sdr["Title"].ToString() + "[ID:" + sdr["ID"].ToString() + "] 处于开启状态或使用过\n\n不能删除";
                    sdr.Close();
                    return res;
                }
                sdr.Close();
                string sql = string.Format("DELETE [Table_Batch] WHERE [ID] = '{0}' AND [IsOpen] = '-1'", BatchID);
                new SqlCommand(sql, Conn).ExecuteNonQuery();
                return "ok";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        /// <summary>
        /// 编辑一个批次
        /// </summary>
        /// <param name="BatchID"></param>
        /// <param name="Title"></param>
        /// <param name="Remark"></param>
        /// <param name="IncludePaper"></param>
        /// <returns></returns>
        public string EditBatch(string BatchID, string Title, string Remark, string IncludePaper)
        {
            try
            {
                string sql_check = string.Format("SELECT * FROM [Table_Batch] WHERE ([IsOpen] = '0' OR [IsOpen] = '1') AND [ID] = '{0}'", BatchID);
                var sdr = new SqlCommand(sql_check, Conn).ExecuteReader();
                if (sdr.Read())
                {
                    string res = sdr["Title"].ToString() + "[ID:" + sdr["ID"].ToString() + "] 处于开启状态或使用过\n\n不能编辑";
                    sdr.Close();
                    return res;
                }
                sdr.Close();
                string sql = string.Format(
                "UPDATE [Table_Batch] SET [Title] = '{0}', [Remark] = '{1}', [IncludePaper] = '{2}' WHERE [ID] = '{3}' AND [IsOpen] = '-1'",
                Title, Remark, IncludePaper, BatchID);
                new SqlCommand(sql, Conn).ExecuteNonQuery();
                return "ok";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        /// <summary>
        /// 重置更新信息
        /// </summary>
        /// <returns></returns>
        public bool ClearUpdateRule()
        {
            try
            {
                string sql = "TRUNCATE TABLE [Table_Update]";
                new SqlCommand(sql, Conn).ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 插入一条更新记录
        /// </summary>
        /// <param name="ClientPath"></param>
        /// <param name="ServerPath"></param>
        /// <param name="ServerMD5"></param>
        /// <returns></returns>
        public bool InsertUpdateRule(string ClientPath, string ServerPath, string ServerMD5)
        {
            try
            {
                string sql = string.Format(
"INSERT INTO [Table_Update] ([ClientPath], [ServerPath], [ServerMD5]) VALUES ('{0}', '{1}', '{2}')", ClientPath, ServerPath, ServerMD5);
                new SqlCommand(sql, Conn).ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
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

            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString().ToLower();
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