using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DynamicDao;

namespace DynamicWebSrv
{
    /// <summary>
    /// JG_InterestRateSrv 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class JG_InterestRateSrv : System.Web.Services.WebService
    {	
        JG_InterestRateDao daoHelp =  JG_InterestRateDao.Instance;

        [WebMethod(Description="添加[JG_InterestRate]")]
        public bool Add(DynamicEntity.JG_InterestRateEntity o)
        {
            return daoHelp.Add(o);
        }
        [WebMethod(Description="更新[JG_InterestRate]")]
        public bool Update(DynamicEntity.JG_InterestRateEntity o)
        {
            return daoHelp.Update(o);
        }
        [WebMethod(Description="删除[JG_InterestRate]")]
        public bool Delete(string o)
        {
            return daoHelp.Delete(o);
        }
        [WebMethod(Description="条件查询[JG_InterestRate]")]
        public List<DynamicEntity.JG_InterestRateEntity> Select(DynamicEntity.JG_InterestRateEntity entity)
        {
            return daoHelp.Select(entity) as List<DynamicEntity.JG_InterestRateEntity>;
        }
        [WebMethod(Description="条件查询并排序[JG_InterestRate]")]       
		public List<DynamicEntity.JG_InterestRateEntity> SelectForSort(DynamicEntity.JG_InterestRateEntity entity,string sortField, bool isDesc)
        {
            return daoHelp.SelectForSort(entity,sortField,isDesc) as List<DynamicEntity.JG_InterestRateEntity>;
        }
        [WebMethod(Description="条件查询分页[JG_InterestRate]")]
        public List<DynamicEntity.JG_InterestRateEntity> SelectForPage(DynamicEntity.JG_InterestRateEntity entity,int Skip,int Count)
        {
            return daoHelp.SelectForPage(entity,Skip,Count) as List<DynamicEntity.JG_InterestRateEntity>;
        }
        [WebMethod(Description="查询所有[JG_InterestRate]")]
        public List<DynamicEntity.JG_InterestRateEntity> Selects()
        {
            return daoHelp.Selects() as List<DynamicEntity.JG_InterestRateEntity>;
        }
        [WebMethod(Description="查询并排序所有[JG_InterestRate]")]
        public List<DynamicEntity.JG_InterestRateEntity> SelectsForSort(string sortField,bool isDesc)
        {
            return daoHelp.SelectsForSort(sortField,isDesc) as List<DynamicEntity.JG_InterestRateEntity>;
        }
        [WebMethod(Description="查询所有[JG_InterestRate]分页")]
        public List<DynamicEntity.JG_InterestRateEntity> SelectsForPage(int Skip, int Count)
        {
            return daoHelp.SelectsForPage(Skip,Count) as List<DynamicEntity.JG_InterestRateEntity>;
        }
    }
}
