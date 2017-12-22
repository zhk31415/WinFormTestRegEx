using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Extentions;

namespace Models
{
    /// <summary>
    /// 详细设置
    /// </summary>
    public class StepDetailSetting
    {
        public StepDetailSetting()
        { }
        #region Model
        private int _id;
        private string _propertyname;
        private string _fromsource;
        private string _pattern;
        private string _multi;
        private string _pattern2;
        private string _multi2;
        private int? _enumsavetype = 0;
        private DateTime _opdate;
        private string _remark;
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
        /// 外键
        /// </summary>
        [OnlyPrimary]
        public int StepSettingId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PropertyName
        {
            set { _propertyname = value; }
            get { return _propertyname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string FromSource
        {
            set { _fromsource = value; }
            get { return _fromsource; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Pattern
        {
            set { _pattern = value; }
            get { return _pattern; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Multi
        {
            set { _multi = value; }
            get { return _multi; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Pattern2
        {
            set { _pattern2 = value; }
            get { return _pattern2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Multi2
        {
            set { _multi2 = value; }
            get { return _multi2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? EnumSaveType
        {
            set { _enumsavetype = value; }
            get { return _enumsavetype; }
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
            return PropertyName + "_" + base.ToString();
        }
    }
}
