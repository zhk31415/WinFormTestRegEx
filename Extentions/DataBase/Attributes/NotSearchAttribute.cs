using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Extentions
{
    /// <summary>
    /// 查询的时候,不进行查询的字段标识
    /// 比如,查询一个用户信息到界面上的时候,不会去查询出他的密码信息
    /// </summary>
    public class NotSearchAttribute : System.Attribute
    {
    }
}
