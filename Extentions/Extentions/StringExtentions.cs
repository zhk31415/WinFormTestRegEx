using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// ReSharper disable once CheckNamespace
namespace System
{
    public static class StringExtentions
    {
        /// <summary>
        /// 屏蔽sql语句
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static string SqlClear(this string val)
        {
            if (string.IsNullOrEmpty(val)) return string.Empty;
            val = val.Replace("'", "''");
            return val;
        }

        /// <summary>
        /// 换行符
        /// </summary>
        public const string HuanHang = "\r\n";
    }
}
