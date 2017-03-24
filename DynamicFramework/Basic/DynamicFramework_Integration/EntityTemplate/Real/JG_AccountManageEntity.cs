using System;

namespace DynamicEntity
{
    /// <summary>
    /// JG_AccountManage
    /// </summary>
    public class JG_AccountManageEntity:BaseEntity
    {

        private string _am_id;
        /// <summary>
        /// 账户编号
        /// </summary>
        public string AM_ID
        {
            get { return _am_id; }
            set { _am_id = value; }
        }

        private string _am_zhmc;
        /// <summary>
        /// 账户名称
        /// </summary>
        public string AM_zhmc
        {
            get { return _am_zhmc; }
            set { _am_zhmc = value; }
        }

        private string _am_corpcode;
        /// <summary>
        /// 企业编号
        /// </summary>
        public string AM_CorpCode
        {
            get { return _am_corpcode; }
            set { _am_corpcode = value; }
        }

        private string _am_corpname;
        /// <summary>
        /// 企业名称
        /// </summary>
        public string AM_CorpName
        {
            get { return _am_corpname; }
            set { _am_corpname = value; }
        }

        private string _am_itemname;
        /// <summary>
        /// 项目名称
        /// </summary>
        public string AM_ItemName
        {
            get { return _am_itemname; }
            set { _am_itemname = value; }
        }

        private string _am_jgaccount;
        /// <summary>
        /// 监管账号
        /// </summary>
        public string AM_JgAccount
        {
            get { return _am_jgaccount; }
            set { _am_jgaccount = value; }
        }

        private string _am_shbh;
        /// <summary>
        /// 商户编号
        /// </summary>
        public string AM_Shbh
        {
            get { return _am_shbh; }
            set { _am_shbh = value; }
        }

        private string _am_createdate;
        /// <summary>
        /// 开户时间
        /// </summary>
        public string AM_CreateDate
        {
            get { return _am_createdate; }
            set { _am_createdate = value; }
        }

        private string _am_useflag;
        /// <summary>
        /// 使用标志 0:未使用 1:已使用
        /// </summary>
        public string AM_UseFlag
        {
            get { return _am_useflag; }
            set { _am_useflag = value; }
        }

        private string _am_person;
        /// <summary>
        /// 经办人
        /// </summary>
        public string AM_Person
        {
            get { return _am_person; }
            set { _am_person = value; }
        }

        private string _am_bankcode;
        /// <summary>
        /// 银行网点
        /// </summary>
        public string AM_BankCode
        {
            get { return _am_bankcode; }
            set { _am_bankcode = value; }
        }
   }
}

