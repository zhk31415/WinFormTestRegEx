using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Extentions;

// ReSharper disable once CheckNamespace
namespace System
{
    public class DbEntityAccess
    {
        /// <summary>
        /// 得到List集合
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sqlWhere">sqlWhere统一以and开头</param>
        /// <returns></returns>
        public static List<T> GetList<T>(string sqlWhere = null) where T : new()
        {
            DealSqlWhere(ref sqlWhere);
            var type = typeof(T);
            TblStruct st = type.GetTblStruct();
            string sql = "select " + st.SqlSearchCol + " from " + st.TblName + " where " + sqlWhere;
            return GetListBySql<T>(sql);
        }

        /// <summary>
        /// 得到List集合 只支持有序的字段(max,min函数支持的字段)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sqlWhere"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="orderBy">默认是主键(不是代码写的默认值"")</param>
        /// <param name="desc"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        public static List<T> GetListByPage<T>(ref int totalCount, string sqlWhere = "", int page = 1, int pageSize = 20,
            string orderBy = "",
            bool desc = true) where T : new()
        {
            DealSqlWhere(ref sqlWhere);
            var type = typeof(T);
            TblStruct st = type.GetTblStruct();
            if (string.IsNullOrEmpty(orderBy)) orderBy = st.PrimaryKey;
            var skipCount = (pageSize * (page - 1));

            var maxMin = string.Empty;
            if (skipCount > 0)
            {
                //string sqlServerIsNull = "ISNULL(" + (desc ? "MIN" : "MAX") + "(" + orderBy + "),0)";
                string oracleIsNull = "iif(IsNull(" + (desc ? "MIN" : "MAX") + "(" + orderBy + ")), 0, " +
                                      (desc ? "MIN" : "MAX") + "(" + orderBy + "))";
                maxMin = " and " + orderBy + (desc ? "<" : ">") +
                         "(select " + oracleIsNull + " from (select top " +
                         skipCount + " " + orderBy + " from " + st.TblName + " order by " + orderBy + (desc ? " desc" : " asc") + "))";
            }
            string sql = "select top " + pageSize + " " + st.SqlSearchCol + " from " + st.TblName +
                         " where " + sqlWhere + maxMin + " order by " + orderBy + (desc ? " desc" : " asc");
            if (totalCount == -1)
            {
                totalCount = 0;
            }
            else
            {
                string sqlTotalCount = "select COUNT(1) from " + st.TblName + " where " + sqlWhere;
                var obj = DbHelperAccess.GetScalar(sqlTotalCount);
                if (obj == null) totalCount = 0;
                else totalCount = Convert.ToInt32(obj);
            }
            return GetListBySql<T>(sql);
        }

        public static List<T> GetListByPage<T>(string sqlWhere = "", int page = 1, int pageSize = 20, string orderBy = "Id",
            bool desc = false) where T : new()
        {
            int totalCount = -1;//原来的参数小于0,则不计算总条数
            var list = GetListByPage<T>(ref totalCount, sqlWhere, page, pageSize, orderBy, desc);
            return list;
        }

        /// <summary>
        /// 得到单对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id">主键</param>
        /// <returns></returns>
        public static T GetModel<T>(object id) where T : new()
        {
            var type = typeof(T);
            TblStruct st = type.GetTblStruct();
            string sql = "select top 1 " + st.SqlSearchCol + " from " + st.TblName + " where " + st.PrimaryKey + "=" +
                         (st.TypePrimaryKey ? id : ("'" + id + "'"));
            var list = GetListBySql<T>(sql);
            if (list.Count > 0) return list[0];
            return default(T);
        }

        /// <summary>
        /// 得到单对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="only">唯一键</param>
        /// <returns></returns>
        public static T GetModelByOnly<T>(object only) where T : new()
        {
            var type = typeof(T);
            TblStruct st = type.GetTblStruct();
            string sql = "select top 1 " + st.SqlSearchCol + " from " + st.TblName + " where " + st.OnlyPrimary + "=" +
                         (st.TypeOnlyPrimary ? only : ("'" + only + "'"));
            var list = GetListBySql<T>(sql);
            if (list.Count > 0) return list[0];
            return default(T);
        }

        private static object _sycn = new object();

        /// <summary>
        /// 主键是自增,则返回主键ID
        /// 不是,则返回影响行数
        /// 默认一般是>0就是成功
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public static int Add<T>(T t)
        {
            lock (_sycn)
            {
                var type = typeof(T);
                var st = type.GetTblStruct();
                string insertCol = string.Empty;
                string values = string.Empty;
                foreach (var item in st.ListCol)
                {
                    if (st.Identity) //自增的主键,主键就不赋值
                    {
                        if (item.PrimaryKey) continue;
                    }
                    if (item.NotAdd) continue;
                    insertCol += item.ColName + ",";
                    var p = type.GetProperty(item.ClassColName);
                    var obj = p.GetValue(t, null);
                    if (obj == null)
                    {
                        values += "NULL,";
                    }
                    else
                    {
                        values += "'" + Convert.ToString(obj).SqlClear() + "',";
                    }
                }
                if (insertCol.Length > 0) insertCol = insertCol.Remove(insertCol.Length - 1);
                if (values.Length > 0) values = values.Remove(values.Length - 1);
                string sql = "insert into " + st.TblName + "(" + insertCol + ") values(" + values + ");";
                if (st.Identity)
                {
                    var count2 = DbHelperAccess.ExecuteCommand(sql);
                    if (count2 > 0)
                    {
                        sql = "select @@identity;";
                        object obj = DbHelperAccess.GetScalar(sql);
                        if (obj == null) return 0;
                        var id = Convert.ToInt32(obj);
                        var p = type.GetProperty(st.ClassPrimaryKey);
                        p.SetValue(t, id, null);
                        return id;
                    }
                    return 0;
                }
                var count = DbHelperAccess.ExecuteCommand(sql);
                return count;
            }
        }

        public static bool Update<T>(T t)
        {
            var type = typeof(T);
            var st = type.GetTblStruct();
            var p = type.GetProperty(st.ClassPrimaryKey);
            var obj = p.GetValue(t, null);
            var key = Convert.ToString(obj).SqlClear();
            string sql = GetUpdateString(t, st.PrimaryKey);
            sql += " where " + st.PrimaryKey + "=" + (st.TypePrimaryKey ? key : ("'" + key + "'"));
            var isSuccess = DbHelperAccess.ExecuteCommand(sql) > 0;
            return isSuccess;
        }

        public static bool UpdateByOnly<T>(T t)
        {
            var type = typeof(T);
            var st = type.GetTblStruct();
            var p = type.GetProperty(st.ClassOnlyPrimary);
            var obj = p.GetValue(t, null);
            var key = Convert.ToString(obj).SqlClear();
            string sql = GetUpdateString(t, st.OnlyPrimary);
            sql += " where " + st.OnlyPrimary + "=" + (st.TypeOnlyPrimary ? key : ("'" + key + "'"));
            var isSuccess = DbHelperAccess.ExecuteCommand(sql) > 0;
            return isSuccess;
        }

        public static bool Delete<T>(object id)
        {
            var type = typeof(T);
            var st = type.GetTblStruct();
            string sql = "delete from " + st.TblName;
            var key = Convert.ToString(id).SqlClear();
            sql += " where " + st.PrimaryKey + "=" + (st.TypePrimaryKey ? key : ("'" + key + "'"));
            var isSuccess = DbHelperAccess.ExecuteCommand(sql) > 0;
            return isSuccess;
        }

        public static bool DeleteByOnly<T>(object only)
        {
            var type = typeof(T);
            var st = type.GetTblStruct();
            string sql = "delete from " + st.TblName;
            var key = Convert.ToString(only).SqlClear();
            sql += " where " + st.OnlyPrimary + "=" + (st.TypeOnlyPrimary ? key : ("'" + key + "'"));
            var isSuccess = DbHelperAccess.ExecuteCommand(sql) > 0;
            return isSuccess;
        }

        #region 得到数据模型的核心方法

        /// <summary>
        /// 核心方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <returns></returns>
        private static List<T> GetListBySql<T>(string sql) where T : new()
        {
            var type = typeof(T);
            var st = type.GetTblStruct();
            var list = new List<T>();
            using (var reader = DbHelperAccess.GetReader(sql))
            {
                //组装数据
                while (reader.Read())
                {
                    var t = new T();
                    foreach (var item in st.ListCol)
                    {
                        if (item.NotSearch) continue;
                        object obj = reader[item.ColName];
                        var p = type.GetProperty(item.ClassColName);
                        if (p != null)
                        {
                            var setValue = p.DealSetValue(obj);
                            p.SetValue(t, setValue, null);
                        }
                    }
                    list.Add(t);
                }
            }
            return list;
        }
        #endregion

        #region 辅助方法

        private static string GetUpdateString<T>(T t, string whereKey)
        {
            var type = typeof(T);
            TblStruct st = type.GetTblStruct();
            string setString = string.Empty;
            foreach (var item in st.ListCol)
            {
                if (item.NotUpdate) continue;
                if (item.ColName == whereKey) continue;
                var p = type.GetProperty(item.ClassColName);
                var obj = p.GetValue(t, null);
                if (obj == null)
                {
                    setString += item.ColName + "=NULL,";
                }
                else
                {
                    setString += item.ColName + "='" + Convert.ToString(obj).Replace("'", "''") + "',";
                }
            }
            if (setString.Length > 0) setString = setString.Remove(setString.Length - 1);
            string sql = "update " + st.TblName + " set " + setString;
            return sql;
        }

        /// <summary>
        /// 处理结尾字符串
        /// </summary>
        /// <param name="sqlWhere"></param>
        private static void DealSqlWhere(ref string sqlWhere)
        {
            if (string.IsNullOrEmpty(sqlWhere))
            {
                sqlWhere = " 1=1";
                return;
            }
            sqlWhere = " 1=1 " + sqlWhere;
        }
        #endregion
    }
}
