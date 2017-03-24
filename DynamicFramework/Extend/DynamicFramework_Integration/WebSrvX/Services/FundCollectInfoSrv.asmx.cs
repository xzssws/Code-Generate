using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DynamicDao;

namespace DynamicWebSrv
{
    /// <summary>
    /// FundCollectInfoSrv 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public partial class FundCollectInfoSrv : System.Web.Services.WebService
    {	
        FundCollectInfoDao daoHelp =  FundCollectInfoDao.Instance;

        [WebMethod(Description="条件查询[FundCollectInfo]")]
        public List<DynamicEntity.FundCollectInfoEntity> Select(DynamicEntity.FundCollectInfoEntity entity)
        {
            return daoHelp.Select(entity) as List<DynamicEntity.FundCollectInfoEntity>;
        }
        [WebMethod(Description="条件查询并排序[FundCollectInfo]")]       
		public List<DynamicEntity.FundCollectInfoEntity> SelectForSort(DynamicEntity.FundCollectInfoEntity entity,string sortField, bool isDesc)
        {
            return daoHelp.SelectForSort(entity,sortField,isDesc) as List<DynamicEntity.FundCollectInfoEntity>;
        }
        [WebMethod(Description="条件查询分页[FundCollectInfo]")]
        public List<DynamicEntity.FundCollectInfoEntity> SelectForPage(DynamicEntity.FundCollectInfoEntity entity,int Skip,int Count)
        {
            return daoHelp.SelectForPage(entity,Skip,Count) as List<DynamicEntity.FundCollectInfoEntity>;
        }
        [WebMethod(Description="查询所有[FundCollectInfo]")]
        public List<DynamicEntity.FundCollectInfoEntity> Selects()
        {
            return daoHelp.Selects() as List<DynamicEntity.FundCollectInfoEntity>;
        }
        [WebMethod(Description="查询并排序所有[FundCollectInfo]")]
        public List<DynamicEntity.FundCollectInfoEntity> SelectsForSort(string sortField,bool isDesc)
        {
            return daoHelp.SelectsForSort(sortField,isDesc) as List<DynamicEntity.FundCollectInfoEntity>;
        }
        [WebMethod(Description="查询所有[FundCollectInfo]分页")]
        public List<DynamicEntity.FundCollectInfoEntity> SelectsForPage(int Skip, int Count)
        {
            return daoHelp.SelectsForPage(Skip,Count) as List<DynamicEntity.FundCollectInfoEntity>;
        }
    }
}
