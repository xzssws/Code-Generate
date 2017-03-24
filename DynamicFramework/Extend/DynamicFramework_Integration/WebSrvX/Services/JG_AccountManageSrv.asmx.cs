using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DynamicDao;

namespace DynamicWebSrv
{
    /// <summary>
    /// JG_AccountManageSrv 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class JG_AccountManageSrv : System.Web.Services.WebService
    {	
        JG_AccountManageDao daoHelp =  JG_AccountManageDao.Instance;

        [WebMethod(Description="添加[JG_AccountManage]")]
        public bool Add(DynamicEntity.JG_AccountManageEntity o)
        {
            return daoHelp.Add(o);
        }
        [WebMethod(Description="更新[JG_AccountManage]")]
        public bool Update(DynamicEntity.JG_AccountManageEntity o)
        {
            return daoHelp.Update(o);
        }
        [WebMethod(Description="删除[JG_AccountManage]")]
        public bool Delete(string o)
        {
            return daoHelp.Delete(o);
        }
        [WebMethod(Description="条件查询[JG_AccountManage]")]
        public List<DynamicEntity.JG_AccountManageEntity> Select(DynamicEntity.JG_AccountManageEntity entity)
        {
            return daoHelp.Select(entity) as List<DynamicEntity.JG_AccountManageEntity>;
        }
        [WebMethod(Description="条件查询并排序[JG_AccountManage]")]       
		public List<DynamicEntity.JG_AccountManageEntity> SelectForSort(DynamicEntity.JG_AccountManageEntity entity,string sortField, bool isDesc)
        {
            return daoHelp.SelectForSort(entity,sortField,isDesc) as List<DynamicEntity.JG_AccountManageEntity>;
        }
        [WebMethod(Description="条件查询分页[JG_AccountManage]")]
        public List<DynamicEntity.JG_AccountManageEntity> SelectForPage(DynamicEntity.JG_AccountManageEntity entity,int Skip,int Count)
        {
            return daoHelp.SelectForPage(entity,Skip,Count) as List<DynamicEntity.JG_AccountManageEntity>;
        }
        [WebMethod(Description="查询所有[JG_AccountManage]")]
        public List<DynamicEntity.JG_AccountManageEntity> Selects()
        {
            return daoHelp.Selects() as List<DynamicEntity.JG_AccountManageEntity>;
        }
        [WebMethod(Description="查询并排序所有[JG_AccountManage]")]
        public List<DynamicEntity.JG_AccountManageEntity> SelectsForSort(string sortField,bool isDesc)
        {
            return daoHelp.SelectsForSort(sortField,isDesc) as List<DynamicEntity.JG_AccountManageEntity>;
        }
        [WebMethod(Description="查询所有[JG_AccountManage]分页")]
        public List<DynamicEntity.JG_AccountManageEntity> SelectsForPage(int Skip, int Count)
        {
            return daoHelp.SelectsForPage(Skip,Count) as List<DynamicEntity.JG_AccountManageEntity>;
        }
    }
}
