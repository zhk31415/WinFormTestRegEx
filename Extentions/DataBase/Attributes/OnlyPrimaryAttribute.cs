using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Extentions
{
    /// <summary>
    /// 表名唯一键或外键的标识特性 
    /// 修改的额外方法(UpdateByOnly)时使用,做为update的条件
    /// 单查询的额外方法(GetModelByOnly)时使用,做为where的条件
    /// </summary>
    public class OnlyPrimaryAttribute : System.Attribute
    {
    }
}
