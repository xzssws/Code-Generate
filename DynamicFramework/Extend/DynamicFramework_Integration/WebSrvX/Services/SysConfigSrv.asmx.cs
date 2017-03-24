using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DynamicDao;

namespace DynamicWebSrv
{
    /// <summary>
    /// SysConfigSrv 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class SysConfigSrv : System.Web.Services.WebService
    {	
        SysConfigDao daoHelp =  SysConfigDao.Instance;

        [WebMethod(Description="添加[SysConfig]")]
        public bool Add(DynamicEntity.SysConfigEntity o)
        {
            return daoHelp.Add(o);
        }
        [WebMethod(Description="更新[SysConfig]")]
        public bool Update(DynamicEntity.SysConfigEntity o)
        {
            return daoHelp.Update(o);
        }
        [WebMethod(Description="删除[SysConfig]")]
        public bool Delete(string o)
        {
            return daoHelp.Delete(o);
        }
        [WebMethod(Description="条件查询[SysConfig]")]
        public List<DynamicEntity.SysConfigEntity> Select(DynamicEntity.SysConfigEntity entity)
        {
            return daoHelp.Select(entity) as List<DynamicEntity.SysConfigEntity>;
        }
        [WebMethod(Description="条件查询并排序[SysConfig]")]       
		public List<DynamicEntity.SysConfigEntity> SelectForSort(DynamicEntity.SysConfigEntity entity,string sortField, bool isDesc)
        {
            return daoHelp.SelectForSort(entity,sortField,isDesc) as List<DynamicEntity.SysConfigEntity>;
        }
        [WebMethod(Description="条件查询分页[SysConfig]")]
        public List<DynamicEntity.SysConfigEntity> SelectForPage(DynamicEntity.SysConfigEntity entity,int Skip,int Count)
        {
            return daoHelp.SelectForPage(entity,Skip,Count) as List<DynamicEntity.SysConfigEntity>;
        }
        [WebMethod(Description="查询所有[SysConfig]")]
        public List<DynamicEntity.SysConfigEntity> Selects()
        {
            return daoHelp.Selects() as List<DynamicEntity.SysConfigEntity>;
        }
        [WebMethod(Description="查询并排序所有[SysConfig]")]
        public List<DynamicEntity.SysConfigEntity> SelectsForSort(string sortField,bool isDesc)
        {
            return daoHelp.SelectsForSort(sortField,isDesc) as List<DynamicEntity.SysConfigEntity>;
        }
        [WebMethod(Description="查询所有[SysConfig]分页")]
        public List<DynamicEntity.SysConfigEntity> SelectsForPage(int Skip, int Count)
        {
            return daoHelp.SelectsForPage(Skip,Count) as List<DynamicEntity.SysConfigEntity>;
        }
    }
}
