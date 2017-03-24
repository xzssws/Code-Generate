using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DynamicDao;

namespace DynamicWebSrv
{
    /// <summary>
    /// SerialNoConfigSrv 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class SerialNoConfigSrv : System.Web.Services.WebService
    {	
        SerialNoConfigDao daoHelp =  SerialNoConfigDao.Instance;

        [WebMethod(Description="添加[SerialNoConfig]")]
        public bool Add(DynamicEntity.SerialNoConfigEntity o)
        {
            return daoHelp.Add(o);
        }
        [WebMethod(Description="更新[SerialNoConfig]")]
        public bool Update(DynamicEntity.SerialNoConfigEntity o)
        {
            return daoHelp.Update(o);
        }
        [WebMethod(Description="删除[SerialNoConfig]")]
        public bool Delete(string o)
        {
            return daoHelp.Delete(o);
        }
        [WebMethod(Description="条件查询[SerialNoConfig]")]
        public List<DynamicEntity.SerialNoConfigEntity> Select(DynamicEntity.SerialNoConfigEntity entity)
        {
            return daoHelp.Select(entity) as List<DynamicEntity.SerialNoConfigEntity>;
        }
        [WebMethod(Description="条件查询并排序[SerialNoConfig]")]       
		public List<DynamicEntity.SerialNoConfigEntity> SelectForSort(DynamicEntity.SerialNoConfigEntity entity,string sortField, bool isDesc)
        {
            return daoHelp.SelectForSort(entity,sortField,isDesc) as List<DynamicEntity.SerialNoConfigEntity>;
        }
        [WebMethod(Description="条件查询分页[SerialNoConfig]")]
        public List<DynamicEntity.SerialNoConfigEntity> SelectForPage(DynamicEntity.SerialNoConfigEntity entity,int Skip,int Count)
        {
            return daoHelp.SelectForPage(entity,Skip,Count) as List<DynamicEntity.SerialNoConfigEntity>;
        }
        [WebMethod(Description="查询所有[SerialNoConfig]")]
        public List<DynamicEntity.SerialNoConfigEntity> Selects()
        {
            return daoHelp.Selects() as List<DynamicEntity.SerialNoConfigEntity>;
        }
        [WebMethod(Description="查询并排序所有[SerialNoConfig]")]
        public List<DynamicEntity.SerialNoConfigEntity> SelectsForSort(string sortField,bool isDesc)
        {
            return daoHelp.SelectsForSort(sortField,isDesc) as List<DynamicEntity.SerialNoConfigEntity>;
        }
        [WebMethod(Description="查询所有[SerialNoConfig]分页")]
        public List<DynamicEntity.SerialNoConfigEntity> SelectsForPage(int Skip, int Count)
        {
            return daoHelp.SelectsForPage(Skip,Count) as List<DynamicEntity.SerialNoConfigEntity>;
        }
    }
}
