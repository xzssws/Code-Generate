using System;

namespace DynamicEntity
{
    /// <summary>
    /// JG_Adjust
    /// </summary>
    public class JG_AdjustEntity:BaseEntity
    {

        private string _ja_id;
        /// <summary>
        /// 存款ID
        /// </summary>
        public string JA_ID
        {
            get { return _ja_id; }
            set { _ja_id = value; }
        }

        private string _ja_fmid;
        /// <summary>
        /// 原存款ID
        /// </summary>
        public string JA_FmID
        {
            get { return _ja_fmid; }
            set { _ja_fmid = value; }
        }

        private string _ja_xybh;
        /// <summary>
        /// 协议编号
        /// </summary>
        public string JA_Xybh
        {
            get { return _ja_xybh; }
            set { _ja_xybh = value; }
        }

        private string _ja_fmxybh;
        /// <summary>
        /// 原协议编号
        /// </summary>
        public string JA_FmXybh
        {
            get { return _ja_fmxybh; }
            set { _ja_fmxybh = value; }
        }

        private DateTime? _ja_sqtime;
        /// <summary>
        /// 申请时间
        /// </summary>
        public DateTime? JA_SqTime
        {
            get { return _ja_sqtime; }
            set { _ja_sqtime = value; }
        }

        private DateTime? _ja_qrtime;
        /// <summary>
        /// 确认时间
        /// </summary>
        public DateTime? JA_QrTime
        {
            get { return _ja_qrtime; }
            set { _ja_qrtime = value; }
        }

        private string _ja_qrr;
        /// <summary>
        /// 确认人
        /// </summary>
        public string JA_Qrr
        {
            get { return _ja_qrr; }
            set { _ja_qrr = value; }
        }

        private string _ja_lc;
        /// <summary>
        /// 0:申请1审核2确认
        /// </summary>
        public string JA_LC
        {
            get { return _ja_lc; }
            set { _ja_lc = value; }
        }

        private string _ja_tzzflsh;
        /// <summary>
        /// 调账支付流水号
        /// </summary>
        public string JA_Tzzflsh
        {
            get { return _ja_tzzflsh; }
            set { _ja_tzzflsh = value; }
        }

        private string _ja_fmcklsh;
        /// <summary>
        /// 原存款流水号
        /// </summary>
        public string JA_FmCklsh
        {
            get { return _ja_fmcklsh; }
            set { _ja_fmcklsh = value; }
        }
   }
}

