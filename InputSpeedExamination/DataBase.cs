﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

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
        public void InsertNewContent(string title, string text)
        {
            try
            {
                CONN.Open();

                string sql = string.Format
                    ("INSERT INTO ContentTable ([Title], [Text], [Length_Value], [MD5_Value]) VALUES ('{0}', '{1}')",
                    title, text, text.Length.ToString(), GetMD5Hash(text));
                SQLiteCommand cmd = new SQLiteCommand(sql, CONN);
                cmd.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                return;
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
        public DataSet GetAllContent()
        {
            try
            {
                CONN.Open();

                var res = new DataSet();

                string sql = @"SELECT * FROM ContentTable";
                SQLiteDataAdapter sda = new SQLiteDataAdapter(sql, CONN);
                sda.Fill(res, "ContentTable");
                sda.Dispose();

                return res;
            }
            catch (Exception e)
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
        public DataSet GetContentByKeyword(string Keyword)
        {
            try
            {
                CONN.Open();
                var ds = new DataSet();
                string sql = string.Format("SELECT * FROM ContentTable WHERE Title LIKE '{0}' OR Text LIKE '{1}'",
                    Keyword, Keyword);
                SQLiteDataAdapter sda = new SQLiteDataAdapter(sql, CONN);
                sda.Fill(ds, "ContentTable");
                sda.Dispose();

                return ds;
            }
            catch
            {
                return null;
            }
            finally
            {
                CONN.Clone();
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
