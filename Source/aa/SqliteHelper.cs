using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;

namespace aa
{
    public class SqliteHelper
    {
        private static string dbFilename = "data.db";
        private static SQLiteConnectionStringBuilder consBuilder = null;

        static SqliteHelper()
        {
            consBuilder = new SQLiteConnectionStringBuilder();
            consBuilder.DataSource = dbFilename;
        }

        /// <summary>
        /// 执行查询
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataTable GetDataTable(string sql)
        {
            DataSet DS = new DataSet();
            using (SQLiteConnection con = new SQLiteConnection())
            {
                con.ConnectionString = consBuilder.ToString();
                //CONNStr.Password = "admin";//设置密码，SQLite ADO.NET实现了数据库密码保护  (似乎与SqliteManager有冲突)
                SQLiteCommand CMD = new SQLiteCommand(sql, con);
                SQLiteDataAdapter DA = new SQLiteDataAdapter();
                DA.SelectCommand = CMD;
                DA.Fill(DS);
            }
            if (DS.Tables.Count > 0)
            {
                return DS.Tables[0];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 执行SQL语句
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static bool ExcuteSQL(string sql)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection())
                {
                    con.ConnectionString = consBuilder.ToString();
                    con.Open();
                    //CONNStr.Password = "admin";//设置密码，SQLite ADO.NET实现了数据库密码保护  (似乎与SqliteManager有冲突)
                    SQLiteCommand CMD = new SQLiteCommand(sql, con);
                    if (CMD.ExecuteNonQuery() > 0)
                    {
                        con.Close();
                        return true;
                    }
                    else
                    {
                        con.Close();
                        return false;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 执行SQL语句
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static bool ExcuteSQL(string sql,SQLiteParameter[] parameters)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection())
                {
                    con.ConnectionString = consBuilder.ToString();
                    //CONNStr.Password = "admin";//设置密码，SQLite ADO.NET实现了数据库密码保护  (似乎与SqliteManager有冲突)
                    con.Open();
                    SQLiteCommand CMD = new SQLiteCommand(sql, con);
                    CMD.Parameters.AddRange(parameters);
                    if (CMD.ExecuteNonQuery() > 0)
                    {
                        con.Close();
                        return true;
                    }
                    else
                    {
                        con.Close();
                        return false;
                    }
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
