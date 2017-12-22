using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ReSharper disable once CheckNamespace
namespace System
{
    public static class EnumExstentions
    {
        /// <summary>
        /// 得到枚举所有值的集合
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static Dictionary<int, string> ToDic(this Enum e)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            var values = Enum.GetValues(e.GetType());
            var list = values.Cast<int>().OrderBy(m => m).ToList();
            foreach (var val in list)
            {
                var name = Enum.GetName(e.GetType(), val);
                dic.Add(val, name);
            }
            return dic;
        }
    }
}
