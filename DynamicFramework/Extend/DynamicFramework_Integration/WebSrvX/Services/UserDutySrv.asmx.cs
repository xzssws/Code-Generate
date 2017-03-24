using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DynamicDao;

namespace DynamicWebSrv
{
    /// <summary>
    /// UserDutySrv 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class UserDutySrv : System.Web.Services.WebService
    {	
        UserDutyDao daoHelp =  UserDutyDao.Instance;

        [WebMethod(Description="添加[UserDuty]")]
        public bool Add(DynamicEntity.UserDutyEntity o)
        {
            return daoHelp.Add(o);
        }
        [WebMethod(Description="更新[UserDuty]")]
        public bool Update(DynamicEntity.UserDutyEntity o)
        {
            return daoHelp.Update(o);
        }
        [WebMethod(Description="删除[UserDuty]")]
        public bool Delete(string o)
        {
            return daoHelp.Delete(o);
        }
        [WebMethod(Description="条件查询[UserDuty]")]
        public List<DynamicEntity.UserDutyEntity> Select(DynamicEntity.UserDutyEntity entity)
        {
            return daoHelp.Select(entity) as List<DynamicEntity.UserDutyEntity>;
        }
        [WebMethod(Description="条件查询并排序[UserDuty]")]       
		public List<DynamicEntity.UserDutyEntity> SelectForSort(DynamicEntity.UserDutyEntity entity,string sortField, bool isDesc)
        {
            return daoHelp.SelectForSort(entity,sortField,isDesc) as List<DynamicEntity.UserDutyEntity>;
        }
        [WebMethod(Description="条件查询分页[UserDuty]")]
        public List<DynamicEntity.UserDutyEntity> SelectForPage(DynamicEntity.UserDutyEntity entity,int Skip,int Count)
        {
            return daoHelp.SelectForPage(entity,Skip,Count) as List<DynamicEntity.UserDutyEntity>;
        }
        [WebMethod(Description="查询所有[UserDuty]")]
        public List<DynamicEntity.UserDutyEntity> Selects()
        {
            return daoHelp.Selects() as List<DynamicEntity.UserDutyEntity>;
        }
        [WebMethod(Description="查询并排序所有[UserDuty]")]
        public List<DynamicEntity.UserDutyEntity> SelectsForSort(string sortField,bool isDesc)
        {
            return daoHelp.SelectsForSort(sortField,isDesc) as List<DynamicEntity.UserDutyEntity>;
        }
        [WebMethod(Description="查询所有[UserDuty]分页")]
        public List<DynamicEntity.UserDutyEntity> SelectsForPage(int Skip, int Count)
        {
            return daoHelp.SelectsForPage(Skip,Count) as List<DynamicEntity.UserDutyEntity>;
        }
    }
}
