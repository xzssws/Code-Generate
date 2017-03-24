using System;

namespace DynamicEntity
{
    /// <summary>
    /// SysConfig
    /// </summary>
    public class SysConfigEntity:BaseEntity
    {

        private string _bankcode;
        /// <summary>
        /// 银行代码
        /// </summary>
        public string BankCode
        {
            get { return _bankcode; }
            set { _bankcode = value; }
        }

        private string _bankname;
        /// <summary>
        /// 银行名称
        /// </summary>
        public string BankName
        {
            get { return _bankname; }
            set { _bankname = value; }
        }

        private string _jgaccount;
        /// <summary>
        /// 监管账户
        /// </summary>
        public string JGAccount
        {
            get { return _jgaccount; }
            set { _jgaccount = value; }
        }

        private string _ip;
        /// <summary>
        /// 转发IP
        /// </summary>
        public string IP
        {
            get { return _ip; }
            set { _ip = value; }
        }

        private string _port;
        /// <summary>
        /// 转发端口
        /// </summary>
        public string Port
        {
            get { return _port; }
            set { _port = value; }
        }

        private DateTime? _payaccuraldate;
        /// <summary>
        /// 结息日期
        /// </summary>
        public DateTime? PayAccuralDate
        {
            get { return _payaccuraldate; }
            set { _payaccuraldate = value; }
        }
   }
}

