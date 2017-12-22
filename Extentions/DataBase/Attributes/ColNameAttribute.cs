using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Extentions
{
    /// <summary>
    /// 列名特性  没有默认就是属性名
    /// </summary>
    public class ColNameAttribute : System.Attribute
    {
        public string ColName { get; set; }

        public ColNameAttribute(string colName)
        {
            ColName = colName;
        }
    }
}
