using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Extentions
{
    internal class TblStruct
    {
        public string TblName { get; set; }

        public List<ColStruct> ListCol
        {
            get;
            set;
        }

        /// <summary>
        /// 得到查询的列
        /// </summary>
        /// <returns></returns>
        public string SqlSearchCol
        {
            get
            {
                string result = string.Empty;
                foreach (var item in ListCol)
                {
                    if (item.NotSearch) continue;
                    result += item.ColName + ",";
                }
                if (result.Length > 0) result = result.Remove(result.Length - 1);
                return result;
            }
        }

        public string PrimaryKey
        {
            get
            {
                var primaryKey = ListCol.FirstOrDefault(m => m.PrimaryKey == true);
                if (primaryKey == null) return string.Empty;
                return primaryKey.ColName;
            }
        }

        public string ClassPrimaryKey
        {
            get
            {
                var primaryKey = ListCol.FirstOrDefault(m => m.PrimaryKey == true);
                if (primaryKey == null) return string.Empty;
                return primaryKey.ClassColName;
            }
        }

        /// <summary>
        /// 类型(true是数字类型不需要加单引号)
        /// </summary>
        public bool TypePrimaryKey
        {
            get
            {
                var primaryKey = ListCol.FirstOrDefault(m => m.PrimaryKey == true);
                if (primaryKey == null) return true;
                var result = NotNeedAdd(primaryKey.ColType);
                return result;
            }
        }

        public bool Identity
        {
            get
            {
                var primaryKey = ListCol.FirstOrDefault(m => m.PrimaryKey == true);
                if (primaryKey == null) return true;
                return primaryKey.Identity;
            }
        }

        public string OnlyPrimary
        {
            get
            {
                var onlyPrimary = ListCol.FirstOrDefault(m => m.OnlyPrimary == true);
                if (onlyPrimary == null)
                {
                    return PrimaryKey;
                }
                return onlyPrimary.ColName;
            }
        }

        public string ClassOnlyPrimary
        {
            get
            {
                var onlyPrimary = ListCol.FirstOrDefault(m => m.OnlyPrimary == true);
                if (onlyPrimary == null)
                {
                    return ClassPrimaryKey;
                }
                return onlyPrimary.ClassColName;
            }
        }

        public bool TypeOnlyPrimary
        {
            get
            {
                var onlyPrimary = ListCol.FirstOrDefault(m => m.OnlyPrimary == true);
                if (onlyPrimary == null)
                {
                    return TypePrimaryKey;
                }
                var result = NotNeedAdd(onlyPrimary.ColType);
                return result;
            }
        }

        /// <summary>
        /// 不加单引号的,数字类型的
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private static bool NotNeedAdd(Type type)
        {
            var listType = new List<Type>()
            {
                typeof (int),
                typeof (int?),
                typeof (long),
                typeof (long?),
                typeof (float),
                typeof (float?),
                typeof (double),
                typeof (double?),
                typeof (decimal),
                typeof (decimal?)
            };
            var result = listType.Contains(type);
            if (result == false)
            {
                //再次判断枚举
                if (type.BaseType == typeof(Enum))
                {
                    return true;
                }
            }
            return result;
        }
    }

    /// <summary>
    /// 列
    /// </summary>
    internal class ColStruct
    {
        /// <summary>
        /// 数据库的对应名
        /// </summary>
        public string ColName { get; set; }

        public Type ColType { get; set; }

        /// <summary>
        /// 类对象里的对象属性名
        /// </summary>
        public string ClassColName { get; set; }

        public bool NotSearch { get; set; }

        public bool NotUpdate { get; set; }

        /// <summary>
        /// 不新增
        /// </summary>
        public bool NotAdd { get; set; }

        /// <summary>
        /// 主键
        /// </summary>
        public bool PrimaryKey { get; set; }

        /// <summary>
        /// 是否是自增列
        /// 是的话,新增成功,则是select @@identity获取
        /// 否的话,就是设置值进去,然后新增的
        /// </summary>
        public bool Identity { get; set; }

        /// <summary>
        /// 唯一键
        /// </summary>
        public bool OnlyPrimary { get; set; }

    }
}
