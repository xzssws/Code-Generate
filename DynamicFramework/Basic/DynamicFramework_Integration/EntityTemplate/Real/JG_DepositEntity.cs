using System;

namespace DynamicEntity
{
    /// <summary>
    /// JG_Deposit
    /// </summary>
    public class JG_DepositEntity:BaseEntity
    {

        private string _de_id;
        /// <summary>
        /// 存款ID
        /// </summary>
        public string DE_ID
        {
            get { return _de_id; }
            set { _de_id = value; }
        }

        private string _de_xybh;
        /// <summary>
        /// 协议编号
        /// </summary>
        public string DE_xybh
        {
            get { return _de_xybh; }
            set { _de_xybh = value; }
        }

        private string _de_qybh;
        /// <summary>
        /// 合同备案号 
        /// </summary>
        public string DE_qybh
        {
            get { return _de_qybh; }
            set { _de_qybh = value; }
        }

        private string _de_ckr;
        /// <summary>
        /// 存款人
        /// </summary>
        public string DE_ckr
        {
            get { return _de_ckr; }
            set { _de_ckr = value; }
        }

        private string _de_dwbh;
        /// <summary>
        /// 银行编号
        /// </summary>
        public string DE_dwbh
        {
            get { return _de_dwbh; }
            set { _de_dwbh = value; }
        }

        private string _de_ckxz;
        /// <summary>
        /// 存款性质 1非贷款  2商业贷款  3公积金贷款  4银联转账  9结息 
        /// </summary>
        public string DE_ckxz
        {
            get { return _de_ckxz; }
            set { _de_ckxz = value; }
        }

        private string _de_cklb;
        /// <summary>
        /// 存款类别 1 存款 9红冲 8调账
        /// </summary>
        public string DE_cklb
        {
            get { return _de_cklb; }
            set { _de_cklb = value; }
        }

        private decimal? _de_ckje;
        /// <summary>
        /// 存款金额
        /// </summary>
        public decimal? DE_ckje
        {
            get { return _de_ckje; }
            set { _de_ckje = value; }
        }

        private DateTime? _de_ckrq;
        /// <summary>
        /// 存款日期
        /// </summary>
        public DateTime? DE_ckrq
        {
            get { return _de_ckrq; }
            set { _de_ckrq = value; }
        }

        private string _de_cklsh;
        /// <summary>
        /// 存款流水号
        /// </summary>
        public string DE_cklsh
        {
            get { return _de_cklsh; }
            set { _de_cklsh = value; }
        }

        private string _de_person;
        /// <summary>
        /// 经办人
        /// </summary>
        public string DE_Person
        {
            get { return _de_person; }
            set { _de_person = value; }
        }

        private string _de_jyckh;
        /// <summary>
        /// 交易参考号
        /// </summary>
        public string DE_jyckh
        {
            get { return _de_jyckh; }
            set { _de_jyckh = value; }
        }

        private string _de_bankcode;
        /// <summary>
        /// 网店代码
        /// </summary>
        public string DE_BankCode
        {
            get { return _de_bankcode; }
            set { _de_bankcode = value; }
        }

        private decimal? _de_zhye;
        /// <summary>
        /// 账户余额
        /// </summary>
        public decimal? DE_zhye
        {
            get { return _de_zhye; }
            set { _de_zhye = value; }
        }
   }
}

