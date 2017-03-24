using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DynamicDao;

namespace DynamicWebSrv
{
    /// <summary>
    /// ParmItemSrv 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class ParmItemSrv : System.Web.Services.WebService
    {	
        [WebMethod(Description="添加[ParmItem]")]
        public bool Add(DynamicEntity.ParmItemEntity o)
        {
            return ParmItemDao.Add(o);
        }
        [WebMethod(Description="更新[ParmItem]")]
        public bool Update(DynamicEntity.ParmItemEntity o)
        {
            return ParmItemDao.Update(o);
        }
        [WebMethod(Description="删除[ParmItem]")]
        public bool Delete(string o)
        {
            return ParmItemDao.Delete(o);
        }
        [WebMethod(Description="查询所有[ParmItem]")]
        public List<DynamicEntity.ParmItemEntity> Selects()
        {
            return ParmItemDao.Selects() as List<DynamicEntity.ParmItemEntity>;
        }
        [WebMethod(Description="条件查询[ParmItem]")]
        public List<DynamicEntity.ParmItemEntity> Select(DynamicEntity.ParmItemEntity o)
        {
            return ParmItemDao.Select(o) as List<DynamicEntity.ParmItemEntity>;
        }
        [WebMethod(Description="查询并排序所有[ParmItem]")]
        public List<DynamicEntity.ParmItemEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            return ParmItemDao.SelectsOrderBy(orderField, isDesc) as List<DynamicEntity.ParmItemEntity>;
        }
    }
}
