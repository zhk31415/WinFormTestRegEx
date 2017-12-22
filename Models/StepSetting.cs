using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Extentions;

namespace Models
{
    /// <summary>
    /// 设置
    /// </summary>
    [TblName("StepSetting")]
    public class StepSetting
    {
        [PrimaryKey(true)]
        public int Id { get; set; }

        /// <summary>
        /// 网站类型
        /// </summary>
        public int WebTypeId { get; set; }

        /// <summary>
        /// 适用于表
        /// </summary>
        public string SuitTblName { get; set; }

        [ColName("Name")]
        public string Name { get; set; }

        public int NumStart { get; set; }

        public int NumEnd { get; set; }

        public int NumAdd { get; set; }

        public string Url { get; set; }

        /// <summary>
        /// 类型 方式1 方式2
        /// </summary>
        public string ListType { get; set; }

        public string Url2 { get; set; }

        public string PatternUrl { get; set; }

        public string Multi { get; set; }

        public string PatternUrl2 { get; set; }

        public string Multi2 { get; set; }

        /// <summary>
        /// 集合
        /// </summary>
        //[NotUpdate]
        //[NotAdd]
        //[NotSearch]
        [NotDataBaseAttribute]
        public List<StepDetailSetting> StepDetailSetting { get; set; }

        //////////////////////属性//////////////////

        public DateTime OpDate { get; set; }

        public string Remark { get; set; }

        public override string ToString()
        {
            return Name;
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
