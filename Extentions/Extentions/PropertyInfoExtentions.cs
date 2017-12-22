using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

// ReSharper disable once CheckNamespace
namespace System
{
    public static class PropertyInfoExtentions
    {
        /// <summary>
        /// 处理设置进去的值
        /// </summary>
        /// <param name="p"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static object DealSetValue(this PropertyInfo p, object obj)
        {
            if (obj == null) return null;
            object result = null;
            if (p.PropertyType == typeof(int))
            {
                try
                {
                    result = Convert.ToInt32(obj);
                }
                catch
                {
                    result = default(int);
                }
            }
            else if (p.PropertyType == typeof(float))
            {
                result = Convert.ToSingle(obj);
            }
            else if (p.PropertyType == typeof(decimal))
            {
                result = Convert.ToDecimal(obj);
            }
            else if (p.PropertyType == typeof(long))
            {
                result = Convert.ToInt64(obj);
            }
            else if (p.PropertyType == typeof(bool))
            {
                result = Convert.ToBoolean(obj);
            }
            else if (p.PropertyType == typeof(string))
            {
                result = Convert.ToString(obj);
            }
            else if (p.PropertyType == typeof(DateTime))
            {
                result = Convert.ToDateTime(obj);
            }
            else if (p.PropertyType.BaseType == typeof(Enum))//枚举
            {
                result = Convert.ToInt32(obj);
            }

            #region 带?的

            else if (p.PropertyType == typeof(int?))
            {
                result = obj == null ? (object)null : Convert.ToInt32(obj);
            }
            else if (p.PropertyType == typeof(float?))
            {
                result = obj == null ? (object)null : Convert.ToSingle(obj);
            }
            else if (p.PropertyType == typeof(decimal?))
            {
                result = obj == null ? (object)null : Convert.ToDecimal(obj);
            }
            else if (p.PropertyType == typeof(long?))
            {
                result = obj == null ? (object)null : Convert.ToInt64(obj);
            }
            else if (p.PropertyType == typeof(bool?))
            {
                result = obj == null ? (object)null : Convert.ToBoolean(obj);
            }
            else if (p.PropertyType == typeof(DateTime?))
            {
                result = obj == null ? (object)null : Convert.ToDateTime(obj);
            }

            #endregion

            #region 不常用的

            else if (p.PropertyType == typeof(byte[]))
            {
                result = (byte[])(obj);
            }
            else if (p.PropertyType == typeof(short))
            {
                result = Convert.ToInt16(obj);
            }
            else if (p.PropertyType == typeof(double))
            {
                result = Convert.ToDouble(obj);
            }
            else if (p.PropertyType == typeof(long))
            {
                result = Convert.ToInt64(obj);
            }

            else if (p.PropertyType == typeof(short?))
            {
                result = obj == null ? (object)null : Convert.ToInt16(obj);
            }
            else if (p.PropertyType == typeof(double?))
            {
                result = obj == null ? (object)null : Convert.ToDouble(obj);
            }
            else if (p.PropertyType == typeof(long?))
            {
                result = obj == null ? (object)null : Convert.ToInt64(obj);
            }

            #endregion

            return result;
        }
    }
}
