using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    /// <summary>
    /// 电影属性
    /// </summary>
    public partial class DataInfo
    {
        #region Model

        private int _id;
        private int _stepsettingid;
        private DateTime _opdate;
        private string _remark;
        private string _comefromurl;
        private string _comefromkey;
        private string _名称;
        private string _类型;
        private string _导演;
        private string _编剧;
        private string _主演;
        private string _标签;
        private string _语言;
        private string _上映时间;
        private string _片长;
        private string _又名;
        private string _评分链接;
        private string _介绍;
        private string _r1;
        private string _r2;
        private string _r3;
        private string _r4;
        private string _r5;
        private string _r6;
        private string _r7;
        private string _r8;
        private string _r9;
        private string _r10;
        /// <summary>
        /// 
        /// </summary>
        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int StepSettingId
        {
            set { _stepsettingid = value; }
            get { return _stepsettingid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime OpDate
        {
            set { _opdate = value; }
            get { return _opdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Remark
        {
            set { _remark = value; }
            get { return _remark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ComeFromUrl
        {
            set { _comefromurl = value; }
            get { return _comefromurl; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ComeFromKey
        {
            set { _comefromkey = value; }
            get { return _comefromkey; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string 名称
        {
            set { _名称 = value; }
            get { return _名称; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string 类型
        {
            set { _类型 = value; }
            get { return _类型; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string 导演
        {
            set { _导演 = value; }
            get { return _导演; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string 编剧
        {
            set { _编剧 = value; }
            get { return _编剧; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string 主演
        {
            set { _主演 = value; }
            get { return _主演; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string 标签
        {
            set { _标签 = value; }
            get { return _标签; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string 语言
        {
            set { _语言 = value; }
            get { return _语言; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string 上映时间
        {
            set { _上映时间 = value; }
            get { return _上映时间; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string 片长
        {
            set { _片长 = value; }
            get { return _片长; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string 又名
        {
            set { _又名 = value; }
            get { return _又名; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string 评分链接
        {
            set { _评分链接 = value; }
            get { return _评分链接; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string 介绍
        {
            set { _介绍 = value; }
            get { return _介绍; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string R1
        {
            set { _r1 = value; }
            get { return _r1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string R2
        {
            set { _r2 = value; }
            get { return _r2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string R3
        {
            set { _r3 = value; }
            get { return _r3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string R4
        {
            set { _r4 = value; }
            get { return _r4; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string R5
        {
            set { _r5 = value; }
            get { return _r5; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string R6
        {
            set { _r6 = value; }
            get { return _r6; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string R7
        {
            set { _r7 = value; }
            get { return _r7; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string R8
        {
            set { _r8 = value; }
            get { return _r8; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string R9
        {
            set { _r9 = value; }
            get { return _r9; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string R10
        {
            set { _r10 = value; }
            get { return _r10; }
        }

        #endregion Model

        public override string ToString()
        {
            return "名称:" + 名称 + StringExtentions.HuanHang + " 类型:" + 类型;
        }
    }
}
