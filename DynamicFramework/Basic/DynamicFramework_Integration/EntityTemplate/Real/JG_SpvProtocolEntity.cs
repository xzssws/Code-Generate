using System;

namespace DynamicEntity
{
    /// <summary>
    /// JG_SpvProtocol
    /// </summary>
    public class JG_SpvProtocolEntity:BaseEntity
    {

        private string _sp_id;
        /// <summary>
        /// 协议ID
        /// </summary>
        public string SP_ID
        {
            get { return _sp_id; }
            set { _sp_id = value; }
        }

        private string _sp_saleitemid;
        /// <summary>
        /// 销售项目ID
        /// </summary>
        public string SP_SaleItemID
        {
            get { return _sp_saleitemid; }
            set { _sp_saleitemid = value; }
        }

        private string _sp_xybh;
        /// <summary>
        /// 协议编号
        /// </summary>
        public string SP_XYBH
        {
            get { return _sp_xybh; }
            set { _sp_xybh = value; }
        }

        private string _sp_jgjg;
        /// <summary>
        /// 监管机构
        /// </summary>
        public string SP_JGJG
        {
            get { return _sp_jgjg; }
            set { _sp_jgjg = value; }
        }

        private string _sp_corpcode;
        /// <summary>
        /// 企业编号
        /// </summary>
        public string SP_CorpCode
        {
            get { return _sp_corpcode; }
            set { _sp_corpcode = value; }
        }

        private string _sp_corpname;
        /// <summary>
        /// 企业名称
        /// </summary>
        public string SP_CorpName
        {
            get { return _sp_corpname; }
            set { _sp_corpname = value; }
        }

        private string _sp_qm;
        /// <summary>
        /// 区名
        /// </summary>
        public string SP_QM
        {
            get { return _sp_qm; }
            set { _sp_qm = value; }
        }

        private string _sp_itemsite;
        /// <summary>
        /// 项目坐落
        /// </summary>
        public string SP_ItemSite
        {
            get { return _sp_itemsite; }
            set { _sp_itemsite = value; }
        }

        private string _sp_itemname;
        /// <summary>
        /// 项目名称
        /// </summary>
        public string SP_ItemName
        {
            get { return _sp_itemname; }
            set { _sp_itemname = value; }
        }

        private decimal? _sp_jzmj;
        /// <summary>
        /// 建筑面积
        /// </summary>
        public decimal? SP_JZMJ
        {
            get { return _sp_jzmj; }
            set { _sp_jzmj = value; }
        }

        private string _sp_buildingno;
        /// <summary>
        /// 楼盘幢号
        /// </summary>
        public string SP_BuildingNo
        {
            get { return _sp_buildingno; }
            set { _sp_buildingno = value; }
        }

        private decimal? _sp_gcjsf;
        /// <summary>
        /// 工程建设费
        /// </summary>
        public decimal? SP_GCJSF
        {
            get { return _sp_gcjsf; }
            set { _sp_gcjsf = value; }
        }

        private decimal? _sp_bkyjf;
        /// <summary>
        /// 不可预见费
        /// </summary>
        public decimal? SP_BKYJF
        {
            get { return _sp_bkyjf; }
            set { _sp_bkyjf = value; }
        }

        private decimal? _sp_zdjgysk;
        /// <summary>
        /// 重点监管预售款
        /// </summary>
        public decimal? SP_ZDJGYSK
        {
            get { return _sp_zdjgysk; }
            set { _sp_zdjgysk = value; }
        }

        private string _sp_qyzhmc;
        /// <summary>
        /// 企业账户名称
        /// </summary>
        public string SP_QYZHMC
        {
            get { return _sp_qyzhmc; }
            set { _sp_qyzhmc = value; }
        }

        private string _sp_qykhyhbh;
        /// <summary>
        /// 企业开户银行编号
        /// </summary>
        public string SP_QYKHYHBH
        {
            get { return _sp_qykhyhbh; }
            set { _sp_qykhyhbh = value; }
        }

        private string _sp_qykhyh;
        /// <summary>
        /// 企业开户银行
        /// </summary>
        public string SP_QYKHYH
        {
            get { return _sp_qykhyh; }
            set { _sp_qykhyh = value; }
        }

        private string _sp_qyzh;
        /// <summary>
        /// 企业账号
        /// </summary>
        public string SP_QYZH
        {
            get { return _sp_qyzh; }
            set { _sp_qyzh = value; }
        }

        private string _sp_jgjgzhmc;
        /// <summary>
        /// 监管机构账户名称
        /// </summary>
        public string SP_JGJGZHMC
        {
            get { return _sp_jgjgzhmc; }
            set { _sp_jgjgzhmc = value; }
        }

        private string _sp_jgjgkhyhbh;
        /// <summary>
        /// 监管机构开户银行编号
        /// </summary>
        public string SP_JGJGKHYHBH
        {
            get { return _sp_jgjgkhyhbh; }
            set { _sp_jgjgkhyhbh = value; }
        }

        private string _sp_jgjgkhyh;
        /// <summary>
        /// 监管机构开户银行
        /// </summary>
        public string SP_JGJGKHYH
        {
            get { return _sp_jgjgkhyh; }
            set { _sp_jgjgkhyh = value; }
        }

        private string _sp_jgjgzh;
        /// <summary>
        /// 监管机构账户
        /// </summary>
        public string SP_JGJGZH
        {
            get { return _sp_jgjgzh; }
            set { _sp_jgjgzh = value; }
        }

        private string _sp_xylc;
        /// <summary>
        /// 协议流程 01申请 02审核 03协议保存 
        /// </summary>
        public string SP_XYLC
        {
            get { return _sp_xylc; }
            set { _sp_xylc = value; }
        }

        private string _sp_xyzt;
        /// <summary>
        /// 协议状态 0无效 1生效
        /// </summary>
        public string SP_XYZT
        {
            get { return _sp_xyzt; }
            set { _sp_xyzt = value; }
        }

        private string _sp_isreject;
        /// <summary>
        /// 是否退回 0否 1是
        /// </summary>
        public string SP_IsReject
        {
            get { return _sp_isreject; }
            set { _sp_isreject = value; }
        }

        private string _sp_qylxdh;
        /// <summary>
        /// 申请表信息：企业联系电话
        /// </summary>
        public string SP_QYLXDH
        {
            get { return _sp_qylxdh; }
            set { _sp_qylxdh = value; }
        }

        private string _sp_lxr;
        /// <summary>
        /// 申请表信息：联系人
        /// </summary>
        public string SP_LXR
        {
            get { return _sp_lxr; }
            set { _sp_lxr = value; }
        }

        private string _sp_lxrdh;
        /// <summary>
        /// 申请表信息：联系人电话
        /// </summary>
        public string SP_LXRDH
        {
            get { return _sp_lxrdh; }
            set { _sp_lxrdh = value; }
        }

        private string _sp_jzx;
        /// <summary>
        /// 申请表信息：是否精装修 否 是
        /// </summary>
        public string SP_JZX
        {
            get { return _sp_jzx; }
            set { _sp_jzx = value; }
        }

        private string _sp_bz;
        /// <summary>
        /// 备注
        /// </summary>
        public string SP_BZ
        {
            get { return _sp_bz; }
            set { _sp_bz = value; }
        }

        private DateTime? _sp_createdate;
        /// <summary>
        /// 申请日期
        /// </summary>
        public DateTime? SP_CreateDate
        {
            get { return _sp_createdate; }
            set { _sp_createdate = value; }
        }

        private string _sp_zyjjfs;
        /// <summary>
        ///  
        /// </summary>
        public string SP_ZYJJFS
        {
            get { return _sp_zyjjfs; }
            set { _sp_zyjjfs = value; }
        }

        private DateTime? _sp_prtlsavedate;
        /// <summary>
        ///  
        /// </summary>
        public DateTime? SP_PrtlSaveDate
        {
            get { return _sp_prtlsavedate; }
            set { _sp_prtlsavedate = value; }
        }
   }
}

