using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DynamicDao;

namespace DynamicWebSrv
{
    /// <summary>
    /// JG_ListidSrv 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class JG_ListidSrv : System.Web.Services.WebService
    {	
        JG_ListidDao daoHelp =  JG_ListidDao.Instance;

        [WebMethod(Description="添加[JG_Listid]")]
        public bool Add(DynamicEntity.JG_ListidEntity o)
        {
            return daoHelp.Add(o);
        }
        [WebMethod(Description="更新[JG_Listid]")]
        public bool Update(DynamicEntity.JG_ListidEntity o)
        {
            return daoHelp.Update(o);
        }
        [WebMethod(Description="删除[JG_Listid]")]
        public bool Delete(string o)
        {
            return daoHelp.Delete(o);
        }
        [WebMethod(Description="条件查询[JG_Listid]")]
        public List<DynamicEntity.JG_ListidEntity> Select(DynamicEntity.JG_ListidEntity entity)
        {
            return daoHelp.Select(entity) as List<DynamicEntity.JG_ListidEntity>;
        }
        [WebMethod(Description="条件查询并排序[JG_Listid]")]       
		public List<DynamicEntity.JG_ListidEntity> SelectForSort(DynamicEntity.JG_ListidEntity entity,string sortField, bool isDesc)
        {
            return daoHelp.SelectForSort(entity,sortField,isDesc) as List<DynamicEntity.JG_ListidEntity>;
        }
        [WebMethod(Description="条件查询分页[JG_Listid]")]
        public List<DynamicEntity.JG_ListidEntity> SelectForPage(DynamicEntity.JG_ListidEntity entity,int Skip,int Count)
        {
            return daoHelp.SelectForPage(entity,Skip,Count) as List<DynamicEntity.JG_ListidEntity>;
        }
        [WebMethod(Description="查询所有[JG_Listid]")]
        public List<DynamicEntity.JG_ListidEntity> Selects()
        {
            return daoHelp.Selects() as List<DynamicEntity.JG_ListidEntity>;
        }
        [WebMethod(Description="查询并排序所有[JG_Listid]")]
        public List<DynamicEntity.JG_ListidEntity> SelectsForSort(string sortField,bool isDesc)
        {
            return daoHelp.SelectsForSort(sortField,isDesc) as List<DynamicEntity.JG_ListidEntity>;
        }
        [WebMethod(Description="查询所有[JG_Listid]分页")]
        public List<DynamicEntity.JG_ListidEntity> SelectsForPage(int Skip, int Count)
        {
            return daoHelp.SelectsForPage(Skip,Count) as List<DynamicEntity.JG_ListidEntity>;
        }
    }
}
