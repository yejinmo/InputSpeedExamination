using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
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

                string sql = string.Format("INSERT INTO ContentTable ([Title], [Text]) VALUES ('{0}', '{1}')", title, text);
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

    }
}
