using System;

namespace DynamicEntity
{
    /// <summary>
    /// JG_Interest
    /// </summary>
    public class JG_InterestEntity:BaseEntity
    {

        private string _it_id;
        /// <summary>
        ///  
        /// </summary>
        public string IT_ID
        {
            get { return _it_id; }
            set { _it_id = value; }
        }

        private DateTime? _it_date;
        /// <summary>
        ///  
        /// </summary>
        public DateTime? IT_Date
        {
            get { return _it_date; }
            set { _it_date = value; }
        }

        private string _it_protocolno;
        /// <summary>
        ///  
        /// </summary>
        public string IT_ProtocolNo
        {
            get { return _it_protocolno; }
            set { _it_protocolno = value; }
        }

        private decimal? _it_amount;
        /// <summary>
        ///  
        /// </summary>
        public decimal? IT_Amount
        {
            get { return _it_amount; }
            set { _it_amount = value; }
        }

        private decimal? _it_interestrate;
        /// <summary>
        ///  
        /// </summary>
        public decimal? IT_InterestRate
        {
            get { return _it_interestrate; }
            set { _it_interestrate = value; }
        }

        private decimal? _it_interest;
        /// <summary>
        ///  
        /// </summary>
        public decimal? IT_Interest
        {
            get { return _it_interest; }
            set { _it_interest = value; }
        }

        private string _it_settleflag;
        /// <summary>
        /// 结算利息标志 0未结算 1已结算
        /// </summary>
        public string IT_SettleFlag
        {
            get { return _it_settleflag; }
            set { _it_settleflag = value; }
        }
   }
}

