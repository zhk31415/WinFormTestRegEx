using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace Extentions
{
    public class DbHelperAccess
    {
        private static string _connString = string.Empty;

        /// <summary>
        /// 链接字符串
        /// </summary>
        public static string ConnString
        {
            get
            {
                if (string.IsNullOrEmpty(_connString))
                {
                    _connString = System.Configuration.ConfigurationManager.AppSettings["conn"].Replace("{dir}", System.AppDomain.CurrentDomain.BaseDirectory);
                }
                return _connString;
            }
        }

        //引导数据库连接数据库调用Web.Config文件      
        private static OleDbConnection connection;
        //创建连接|DataDirectory|/SchoolDB.mdb  
        public static OleDbConnection Connection
        {
            get
            {
                OleDbConnection myConn = new OleDbConnection(ConnString);
                string connectionString = myConn.ConnectionString;
                if (connection == null)
                {
                    connection = new OleDbConnection(connectionString);
                    //打开连接  
                    connection.Open();
                }
                else if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                else if (connection.State == System.Data.ConnectionState.Broken)
                {
                    connection.Close();
                    connection.Open();
                }
                return connection;
            }
        }

        //（无参）返回执行的行数(删除修改更新)  
        public static int ExecuteCommand(string safeSql)
        {
            OleDbCommand cmd = new OleDbCommand(safeSql, Connection);
            int result = cmd.ExecuteNonQuery();
            return result;
        }

        //（有参）  
        //public static int ExecuteCommand(string sql, params OleDbParameter[] values)
        //{
        //    OleDbCommand cmd = new OleDbCommand(sql, Connection);
        //    cmd.Parameters.AddRange(values);
        //    return cmd.ExecuteNonQuery();
        //}

        //（无参）返回第一行第一列(删除修改更新)  
        public static object GetScalar(string safeSql)
        {
            OleDbCommand cmd = new OleDbCommand(safeSql, Connection);
            return cmd.ExecuteScalar();
        }

        //（有参）
        //public static object GetScalar(string sql, params OleDbParameter[] values)
        //{
        //    OleDbCommand cmd = new OleDbCommand(sql, Connection);
        //    cmd.Parameters.AddRange(values);
        //    return cmd.ExecuteScalar();
        //}

        //返回一个DataReader（查询）  
        public static OleDbDataReader GetReader(string safeSql)
        {
            OleDbCommand cmd = new OleDbCommand(safeSql, Connection);
            OleDbDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            return reader;
        }

        //public static OleDbDataReader GetReader(string sql, params OleDbParameter[] values)
        //{
        //    OleDbCommand cmd = new OleDbCommand(sql, Connection);
        //    cmd.Parameters.AddRange(values);
        //    OleDbDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        //    return reader;
        //}

        //返回一个DataTable  
        //public static DataTable GetDataSet(string safeSql)
        //{
        //    DataSet ds = new DataSet();
        //    OleDbCommand cmd = new OleDbCommand(safeSql, Connection);
        //    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        //    da.Fill(ds);
        //    return ds.Tables[0];
        //}

        //public static DataTable GetDataSet(string sql, params OleDbParameter[] values)
        //{
        //    DataSet ds = new DataSet();
        //    OleDbCommand cmd = new OleDbCommand(sql, Connection);
        //    cmd.Parameters.AddRange(values);
        //    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        //    da.Fill(ds);
        //    return ds.Tables[0];
        //}
    }
}
