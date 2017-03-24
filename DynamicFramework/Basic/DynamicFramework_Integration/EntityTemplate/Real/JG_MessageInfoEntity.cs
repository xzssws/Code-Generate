using System;

namespace DynamicEntity
{
    /// <summary>
    /// JG_MessageInfo
    /// </summary>
    public class JG_MessageInfoEntity:BaseEntity
    {

        private string _mi_id;
        /// <summary>
        /// 报文ID
        /// </summary>
        public string MI_ID
        {
            get { return _mi_id; }
            set { _mi_id = value; }
        }

        private string _mi_xybh;
        /// <summary>
        /// 协议编号
        /// </summary>
        public string MI_xybh
        {
            get { return _mi_xybh; }
            set { _mi_xybh = value; }
        }

        private string _mi_bwlsh;
        /// <summary>
        /// 报文流水号
        /// </summary>
        public string MI_Bwlsh
        {
            get { return _mi_bwlsh; }
            set { _mi_bwlsh = value; }
        }

        private string _mi_jydm;
        /// <summary>
        /// 交易代码
        /// </summary>
        public string MI_Jydm
        {
            get { return _mi_jydm; }
            set { _mi_jydm = value; }
        }

        private string _mi_dzdate;
        /// <summary>
        /// 交易日期
        /// </summary>
        public string MI_DzDate
        {
            get { return _mi_dzdate; }
            set { _mi_dzdate = value; }
        }

        private DateTime? _mi_dztime;
        /// <summary>
        /// 交易时间
        /// </summary>
        public DateTime? MI_DzTime
        {
            get { return _mi_dztime; }
            set { _mi_dztime = value; }
        }

        private string _mi_bwnr;
        /// <summary>
        /// 报文内容
        /// </summary>
        public string MI_Bwnr
        {
            get { return _mi_bwnr; }
            set { _mi_bwnr = value; }
        }

        private string _mi_bwfx;
        /// <summary>
        /// 报文方向
        /// </summary>
        public string MI_Bwfx
        {
            get { return _mi_bwfx; }
            set { _mi_bwfx = value; }
        }
   }
}

