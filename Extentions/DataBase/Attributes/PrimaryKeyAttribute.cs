using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Extentions
{
    /// <summary>
    /// 表名主键特性  没有默认找ID和表名ID为主键
    /// </summary>
    public class PrimaryKeyAttribute : System.Attribute
    {
        public bool IsIdentity { get; set; }

        public PrimaryKeyAttribute(bool isIdentity)
        {
            IsIdentity = isIdentity;
        }
    }
}
