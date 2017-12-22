using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// ReSharper disable once CheckNamespace
namespace System
{
    public static class ListExtentions
    {
        /// <summary>
        /// 屏蔽sql语句
        /// </summary>
        /// <param name="val"></param>
        /// <param name="split"></param>
        /// <returns></returns>
        public static string ToJoin(this List<string> val, string split = ",")
        {
            if (val == null || val.Count == 0) return string.Empty;
            val = val.Where(m => !string.IsNullOrEmpty(m)).ToList();
            string result = string.Empty;
            foreach (string item in val)
            {
                result += item + split;
            }
            if (result.Length > split.Length)
            {
                result = result.Remove(result.Length - split.Length);
            }
            return result;
        }

        /// <summary>
        /// 换行符
        /// </summary>
        public const string HuanHang = "\r\n";
    }
}
