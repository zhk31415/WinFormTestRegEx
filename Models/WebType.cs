using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    /// <summary>
    /// 网站类型
    /// </summary>
    public class WebType
    {
        public int Id { get; set; }

        public string TypeName { get; set; }

        public DateTime OpDate { get; set; }

        public string Remark { get; set; }

        public EnumDic EnumDic { get; set; }

        public int ParentId { get; set; }

        public override string ToString()
        {
            return TypeName.ToString();
        }

        public string R1 { get; set; }

        public string R2 { get; set; }

        public string R3 { get; set; }

        public string R4 { get; set; }

        public string R5 { get; set; }

        public string R6 { get; set; }

        public string R7 { get; set; }

        public string R8 { get; set; }

        public string R9 { get; set; }

        public string R10 { get; set; }
    }
}
