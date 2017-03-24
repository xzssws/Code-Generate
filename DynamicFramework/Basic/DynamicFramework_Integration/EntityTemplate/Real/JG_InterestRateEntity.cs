using System;

namespace DynamicEntity
{
    /// <summary>
    /// JG_InterestRate
    /// </summary>
    public class JG_InterestRateEntity:BaseEntity
    {

        private string _id;
        /// <summary>
        ///  
        /// </summary>
        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private decimal _interestrate;
        /// <summary>
        /// 利率
        /// </summary>
        public decimal InterestRate
        {
            get { return _interestrate; }
            set { _interestrate = value; }
        }

        private DateTime _setdate;
        /// <summary>
        /// 设定日期
        /// </summary>
        public DateTime SetDate
        {
            get { return _setdate; }
            set { _setdate = value; }
        }

        private string _remark;
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark
        {
            get { return _remark; }
            set { _remark = value; }
        }

        private string _flag;
        /// <summary>
        /// 是否使用
        /// </summary>
        public string Flag
        {
            get { return _flag; }
            set { _flag = value; }
        }
   }
}

