using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Extentions
{
    /// <summary>
    /// 表名特性  没有默认就是类名
    /// </summary>
    public class TblNameAttribute : System.Attribute
    {
        public string TblName { get; set; }

        public TblNameAttribute(string tblName)
        {
            TblName = tblName;
        }
    }
}
