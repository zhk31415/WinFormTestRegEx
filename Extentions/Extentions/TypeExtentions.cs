using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Extentions;

// ReSharper disable once CheckNamespace
namespace System
{
    public static class TypeExtentions
    {
        private static object _sycn = new object();

        /// <summary>
        /// 数据结构集合缓存
        /// </summary>
        private static Dictionary<string, TblStruct> _dic = new Dictionary<string, TblStruct>();

        /// <summary>
        /// 得到实体对应数据库关系
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        internal static TblStruct GetTblStruct(this Type type)
        {
            lock (_sycn)
            {
                var key = type.FullName;
                if (_dic.ContainsKey(key)) return _dic[key];
                //完善TblStruct
                TblStruct st = new TblStruct();
                var objs = type.GetCustomAttributes(typeof(TblNameAttribute), false);
                string tblName = objs.Length == 0 ? type.Name : ((TblNameAttribute)objs[0]).TblName;
                st.TblName = tblName;
                st.ListCol = new List<ColStruct>();
                var ps = type.GetProperties();
                bool hasPrimaryKey = false;
                foreach (var item in ps)
                {
                    ColStruct col = new ColStruct();
                    col.ClassColName = item.Name;
                    objs = item.GetCustomAttributes(typeof(ColNameAttribute), false);
                    col.ColName = objs.Length == 0 ? item.Name : ((ColNameAttribute)objs[0]).ColName;
                    col.ColType = item.PropertyType;

                    objs = item.GetCustomAttributes(typeof(NotDataBaseAttribute), false);
                    bool notDataBase = objs.Length > 0;
                    if (notDataBase)
                    {
                        col.NotSearch = col.NotUpdate = col.NotSearch = true;
                    }
                    else
                    {
                        objs = item.GetCustomAttributes(typeof(NotSearchAttribute), false);
                        col.NotSearch = objs.Length > 0;

                        objs = item.GetCustomAttributes(typeof(NotUpdateAttribute), false);
                        col.NotUpdate = objs.Length > 0;

                        objs = item.GetCustomAttributes(typeof(NotAddAttribute), false);
                        col.NotAdd = objs.Length > 0;
                    }

                    objs = item.GetCustomAttributes(typeof(OnlyPrimaryAttribute), false);
                    col.OnlyPrimary = objs.Length > 0;

                    objs = item.GetCustomAttributes(typeof(PrimaryKeyAttribute), false);
                    col.PrimaryKey = objs.Length > 0;
                    if (col.PrimaryKey)
                    {
                        col.Identity = ((PrimaryKeyAttribute)(objs[0])).IsIdentity;
                        hasPrimaryKey = true;
                    }
                    st.ListCol.Add(col);
                }
                if (hasPrimaryKey == false)
                {
                    var col = st.ListCol.FirstOrDefault(m => m.ColName.ToLower() == "id" || m.ColName.ToLower() == (m.ColName + "id").ToLower());
                    if (col != null)
                    {
                        col.PrimaryKey = true;
                        col.Identity = true;
                    }
                    else
                    {
                        throw new Exception(st.TblName + " 没有主键");
                    }
                }
                _dic.Add(key, st);
                return st;
            }
        }
    }
}
