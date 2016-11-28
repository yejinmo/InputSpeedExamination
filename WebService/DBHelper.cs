﻿using System;
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
        public SortedList<string, string> GetAllDepartment()
        {
            SortedList<string, string> list = new SortedList<string, string>();
            try
            {
                string sql = "SELECT [String], [ID] FROM [Table_Department]";
                SqlCommand cmd = new SqlCommand(sql, Conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(reader[0].ToString(), reader[1].ToString());
                }
                reader.Close();
                cmd.Dispose();
            }
            catch
            {

            }
            return list;
        }

        public SortedList<string, string> GetMajorByDepartment(string DepartmentID)
        {
            SortedList<string, string> res = new SortedList<string, string>();
            try
            {
                string sql = string.Format("SELECT [String], [ID] FROM [Table_Major] WHERE DepartmentID = {0}", DepartmentID);
                SqlCommand cmd = new SqlCommand(sql, Conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    res.Add(reader[0].ToString(), reader[1].ToString());
                }
                reader.Close();
                cmd.Dispose();
            }
            catch
            {

            }
            return res;
        }

    }
}