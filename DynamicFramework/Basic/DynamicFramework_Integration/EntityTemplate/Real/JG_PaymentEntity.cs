using System;

namespace DynamicEntity
{
    /// <summary>
    /// JG_Payment
    /// </summary>
    public class JG_PaymentEntity:BaseEntity
    {

        private string _pa_id;
        /// <summary>
        /// 支付ID
        /// </summary>
        public string PA_ID
        {
            get { return _pa_id; }
            set { _pa_id = value; }
        }

        private string _pa_xybh;
        /// <summary>
        /// 协议编号
        /// </summary>
        public string PA_xybh
        {
            get { return _pa_xybh; }
            set { _pa_xybh = value; }
        }

        private string _pa_zqlb;
        /// <summary>
        /// 支取类别 0 重要 1非重要 2 利息 3 扣款 4调账
        /// </summary>
        public string PA_zqlb
        {
            get { return _pa_zqlb; }
            set { _pa_zqlb = value; }
        }

        private decimal? _pa_zqje;
        /// <summary>
        /// 支取金额
        /// </summary>
        public decimal? PA_zqje
        {
            get { return _pa_zqje; }
            set { _pa_zqje = value; }
        }

        private string _pa_zqjd;
        /// <summary>
        /// 支取节点
        /// </summary>
        public string PA_zqjd
        {
            get { return _pa_zqjd; }
            set { _pa_zqjd = value; }
        }

        private string _pa_fkfzh;
        /// <summary>
        /// 付款方账户
        /// </summary>
        public string PA_fkfzh
        {
            get { return _pa_fkfzh; }
            set { _pa_fkfzh = value; }
        }

        private string _pa_fkfmc;
        /// <summary>
        /// 付款方名称
        /// </summary>
        public string PA_fkfmc
        {
            get { return _pa_fkfmc; }
            set { _pa_fkfmc = value; }
        }

        private string _pa_fkbank;
        /// <summary>
        /// 付款银行
        /// </summary>
        public string PA_fkBank
        {
            get { return _pa_fkbank; }
            set { _pa_fkbank = value; }
        }

        private decimal? _pa_fkfye;
        /// <summary>
        /// 付款账户余额
        /// </summary>
        public decimal? PA_fkfye
        {
            get { return _pa_fkfye; }
            set { _pa_fkfye = value; }
        }

        private string _pa_skfzh;
        /// <summary>
        /// 收款方账户
        /// </summary>
        public string PA_skfzh
        {
            get { return _pa_skfzh; }
            set { _pa_skfzh = value; }
        }

        private string _pa_skfmc;
        /// <summary>
        /// 收款方名称
        /// </summary>
        public string PA_skfmc
        {
            get { return _pa_skfmc; }
            set { _pa_skfmc = value; }
        }

        private string _pa_skbank;
        /// <summary>
        /// 收款银行
        /// </summary>
        public string PA_skBank
        {
            get { return _pa_skbank; }
            set { _pa_skbank = value; }
        }

        private string _pa_zfqqlsh;
        /// <summary>
        /// 支付请求流水号
        /// </summary>
        public string PA_zfqqlsh
        {
            get { return _pa_zfqqlsh; }
            set { _pa_zfqqlsh = value; }
        }

        private string _pa_zfqrlsh;
        /// <summary>
        /// 支付确认流水号
        /// </summary>
        public string PA_zfqrlsh
        {
            get { return _pa_zfqrlsh; }
            set { _pa_zfqrlsh = value; }
        }

        private DateTime? _pa_zfrq;
        /// <summary>
        /// 支付日期
        /// </summary>
        public DateTime? PA_zfrq
        {
            get { return _pa_zfrq; }
            set { _pa_zfrq = value; }
        }

        private DateTime? _pa_yhzfrq;
        /// <summary>
        /// 银行支付日期
        /// </summary>
        public DateTime? PA_yhzfrq
        {
            get { return _pa_yhzfrq; }
            set { _pa_yhzfrq = value; }
        }

        private string _pa_sqr;
        /// <summary>
        /// 申请人
        /// </summary>
        public string PA_sqr
        {
            get { return _pa_sqr; }
            set { _pa_sqr = value; }
        }

        private string _pa_sqrq;
        /// <summary>
        /// 申请日期
        /// </summary>
        public string PA_sqrq
        {
            get { return _pa_sqrq; }
            set { _pa_sqrq = value; }
        }

        private string _pa_shr;
        /// <summary>
        /// 审核人
        /// </summary>
        public string PA_shr
        {
            get { return _pa_shr; }
            set { _pa_shr = value; }
        }

        private string _pa_shrq;
        /// <summary>
        /// 审核日期
        /// </summary>
        public string PA_shrq
        {
            get { return _pa_shrq; }
            set { _pa_shrq = value; }
        }

        private string _pa_lc;
        /// <summary>
        /// 流程 (0: 申请 1:完成)
        /// </summary>
        public string PA_lc
        {
            get { return _pa_lc; }
            set { _pa_lc = value; }
        }

        private string _pa_person;
        /// <summary>
        /// 经办人
        /// </summary>
        public string PA_Person
        {
            get { return _pa_person; }
            set { _pa_person = value; }
        }

        private string _pa_bankcode;
        /// <summary>
        ///  
        /// </summary>
        public string PA_BankCode
        {
            get { return _pa_bankcode; }
            set { _pa_bankcode = value; }
        }

        private string _pa_remark;
        /// <summary>
        /// 备注项 用于扣款说明
        /// </summary>
        public string PA_Remark
        {
            get { return _pa_remark; }
            set { _pa_remark = value; }
        }
   }
}

