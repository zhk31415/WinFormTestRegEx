using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Extentions
{
    /// <summary>
    /// 修改的时候,不进行修改的字段标识
    /// 比如,修改登录用户信息的时候,不会去修改他的密码信息
    /// </summary>
    public class NotUpdateAttribute : System.Attribute
    {
    }
}
