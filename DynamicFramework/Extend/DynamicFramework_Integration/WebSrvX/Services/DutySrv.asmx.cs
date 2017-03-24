using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DynamicDao;

namespace DynamicWebSrv
{
    /// <summary>
    /// DutySrv 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class DutySrv : System.Web.Services.WebService
    {	
        DutyDao daoHelp =  DutyDao.Instance;

        [WebMethod(Description="添加[Duty]")]
        public bool Add(DynamicEntity.DutyEntity o)
        {
            return daoHelp.Add(o);
        }
        [WebMethod(Description="更新[Duty]")]
        public bool Update(DynamicEntity.DutyEntity o)
        {
            return daoHelp.Update(o);
        }
        [WebMethod(Description="删除[Duty]")]
        public bool Delete(string o)
        {
            return daoHelp.Delete(o);
        }
        [WebMethod(Description="条件查询[Duty]")]
        public List<DynamicEntity.DutyEntity> Select(DynamicEntity.DutyEntity entity)
        {
            return daoHelp.Select(entity) as List<DynamicEntity.DutyEntity>;
        }
        [WebMethod(Description="条件查询并排序[Duty]")]       
		public List<DynamicEntity.DutyEntity> SelectForSort(DynamicEntity.DutyEntity entity,string sortField, bool isDesc)
        {
            return daoHelp.SelectForSort(entity,sortField,isDesc) as List<DynamicEntity.DutyEntity>;
        }
        [WebMethod(Description="条件查询分页[Duty]")]
        public List<DynamicEntity.DutyEntity> SelectForPage(DynamicEntity.DutyEntity entity,int Skip,int Count)
        {
            return daoHelp.SelectForPage(entity,Skip,Count) as List<DynamicEntity.DutyEntity>;
        }
        [WebMethod(Description="查询所有[Duty]")]
        public List<DynamicEntity.DutyEntity> Selects()
        {
            return daoHelp.Selects() as List<DynamicEntity.DutyEntity>;
        }
        [WebMethod(Description="查询并排序所有[Duty]")]
        public List<DynamicEntity.DutyEntity> SelectsForSort(string sortField,bool isDesc)
        {
            return daoHelp.SelectsForSort(sortField,isDesc) as List<DynamicEntity.DutyEntity>;
        }
        [WebMethod(Description="查询所有[Duty]分页")]
        public List<DynamicEntity.DutyEntity> SelectsForPage(int Skip, int Count)
        {
            return daoHelp.SelectsForPage(Skip,Count) as List<DynamicEntity.DutyEntity>;
        }
    }
}
