﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace InputSpeedExamination
{
    public class DataBase
    {
        private string DatabasePath;
        private string DatabaseRootPath;
        private SQLiteConnection CONN;

        public DataBase()
        {
            try
            {
                DatabasePath = "Data Source =" + Environment.CurrentDirectory + "/Data/Data.db";
                DatabaseRootPath = Environment.CurrentDirectory + "/Data";
                if (!Directory.Exists(DatabaseRootPath))
                {
                    DirectoryInfo directoryInfo = new DirectoryInfo(DatabaseRootPath);
                    directoryInfo.Create();
                }

                CONN = new SQLiteConnection(DatabasePath);
                CONN.Open();

                string SQL_CreateContentTable = @"CREATE TABLE IF NOT EXISTS ContentTable(
	Title nvarchar(20), 
	Text nvarchar(4000),
    Length_Value nvarchar(20),
    MD5_Value nvarchar(20),
	ID integer AUTO_INCREMENT,
	primary key (id)
	);";

                SQLiteCommand cmd = new SQLiteCommand(SQL_CreateContentTable, CONN);
                cmd.ExecuteNonQuery();

                string SQL_CreateOnlineContentTable = @"CREATE TABLE IF NOT EXISTS OnlineContentTable(
	Title nvarchar(20), 
	Text nvarchar(4000),
    Length_Value nvarchar(20),
    MD5_Value nvarchar(20),
	ID integer AUTO_INCREMENT,
	primary key (id)
	);";

                cmd = new SQLiteCommand(SQL_CreateOnlineContentTable, CONN);
                cmd.ExecuteNonQuery();

            }
            catch
            {

            }
            finally
            {
                CONN.Close();
            }
        }

        /// <summary>
        /// 插入一条新输入文本内容
        /// </summary>
        /// <param name="title">标题</param>
        /// <param name="text">文本内容</param>
        public bool InsertNewContent(string title, string text)
        {
            try
            {
                string textMD5 = GetMD5Hash(text);
                text = text.Replace("'", "''");
                CONN.Open();
                string sql_check = string.Format(@"SELECT * FROM ContentTable WHERE [MD5_Value] = '{0}'", textMD5);
                var cmd_check = new SQLiteCommand(sql_check, CONN);
                var sdr_check = cmd_check.ExecuteReader();
                if (sdr_check.HasRows)
                {
                    sdr_check.Close();
                    return false;
                }
                sdr_check.Close();
                string sql = string.Format
                    (@"INSERT INTO ContentTable ([Title], [Text], [Length_Value], [MD5_Value]) VALUES ('{0}', '{1}', '{2}', '{3}')",
                    title, text, text.Length.ToString(), textMD5);
                SQLiteCommand cmd = new SQLiteCommand(sql, CONN);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                CONN.Close();
            }
        }

        /// <summary>
        /// 插入一条新在线测试输入文本内容
        /// </summary>
        /// <param name="title">标题</param>
        /// <param name="text">文本内容</param>
        public bool InsertNewOnlineContent(string title, string text)
        {
            try
            {
                string textMD5 = GetMD5Hash(text);
                text = text.Replace("'", "''");
                CONN.Open();
                string sql_check = string.Format(@"SELECT * FROM [OnlineContentTable] WHERE [MD5_Value] = '{0}'", textMD5);
                var cmd_check = new SQLiteCommand(sql_check, CONN);
                var sdr_check = cmd_check.ExecuteReader();
                if (sdr_check.HasRows)
                {
                    sdr_check.Close();
                    return false;
                }
                sdr_check.Close();
                string sql = string.Format
                    (@"INSERT INTO [OnlineContentTable] ([Title], [Text], [Length_Value], [MD5_Value]) VALUES ('{0}', '{1}', '{2}', '{3}')",
                    title, text, text.Length.ToString(), textMD5);
                SQLiteCommand cmd = new SQLiteCommand(sql, CONN);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                CONN.Close();
            }
        }

        /// <summary>
        /// 清空在线试题库的缓存
        /// </summary>
        /// <returns></returns>
        public bool ClearOnlineContent()
        {
            try
            {
                CONN.Open();
                string sql = "DELETE FROM [OnlineContentTable]";
                SQLiteCommand cmd = new SQLiteCommand(sql, CONN);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                CONN.Close();
            }
        }

        /// <summary>
        /// 获取全部内容
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllContent(bool OnlineCache = false)
        {
            try
            {
                string TABLENAME = OnlineCache ? "OnlineContentTable" : "ContentTable";
                CONN.Open();

                var res = new DataSet();

                string sql = string.Format("SELECT [Title], [Text], [Length_Value], [MD5_Value] FROM [{0}]", TABLENAME);
                SQLiteDataAdapter sda = new SQLiteDataAdapter(sql, CONN);
                sda.Fill(res, TABLENAME);
                sda.Dispose();

                return res.Tables[0];
            }
            catch
            {
                return null;
            }
            finally
            {
                CONN.Close();
            }
        }

        /// <summary>
        /// 根据关键词获取指定内容
        /// </summary>
        /// <param name="Keyword"></param>
        /// <returns></returns>
        public DataTable GetContentByKeyword(string Keyword, bool OnlineCache = false)
        {
            try
            {
                string TABLENAME = OnlineCache ? "OnlineContentTable" : "ContentTable";

                CONN.Open();
                var ds = new DataSet();
                string sql = string.Format(
                    "SELECT [Title], [Text], [Length_Value], [MD5_Value] FROM [{0}] WHERE Title LIKE '%{1}%' OR Text LIKE '%{2}%'",
                    TABLENAME, Keyword, Keyword);
                SQLiteDataAdapter sda = new SQLiteDataAdapter(sql, CONN);
                sda.Fill(ds, "ContentTable");
                sda.Dispose();

                return ds.Tables[0];
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                CONN.Close();
            }
        }

        /// <summary>
        /// 根据MD5值获取内容
        /// </summary>
        /// <param name="MD5"></param>
        /// <returns></returns>
        public string GetContentByMD5(string MD5)
        {
            try
            {
                CONN.Open();
                string res = string.Empty;
                string sql = string.Format("SELECT [Text] FROM ContentTable WHERE [MD5_Value] = '{0}'", MD5);
                var cmd = new SQLiteCommand(sql, CONN);
                var sda = cmd.ExecuteReader();
                if (!sda.Read())
                {
                    sda.Close();
                    return string.Empty;
                }
                else
                {
                    return sda["Text"].ToString();
                }
            }
            catch
            {
                return string.Empty;
            }
            finally
            {
                CONN.Close();
            }
        }

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
