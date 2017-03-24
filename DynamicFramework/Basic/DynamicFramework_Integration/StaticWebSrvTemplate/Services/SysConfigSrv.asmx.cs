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
        [WebMethod(Description="添加[SysConfig]")]
        public bool Add(DynamicEntity.SysConfigEntity o)
        {
            return SysConfigDao.Add(o);
        }
        [WebMethod(Description="更新[SysConfig]")]
        public bool Update(DynamicEntity.SysConfigEntity o)
        {
            return SysConfigDao.Update(o);
        }
        [WebMethod(Description="删除[SysConfig]")]
        public bool Delete(string o)
        {
            return SysConfigDao.Delete(o);
        }
        [WebMethod(Description="查询所有[SysConfig]")]
        public List<DynamicEntity.SysConfigEntity> Selects()
        {
            return SysConfigDao.Selects() as List<DynamicEntity.SysConfigEntity>;
        }
        [WebMethod(Description="条件查询[SysConfig]")]
        public List<DynamicEntity.SysConfigEntity> Select(DynamicEntity.SysConfigEntity o)
        {
            return SysConfigDao.Select(o) as List<DynamicEntity.SysConfigEntity>;
        }
        [WebMethod(Description="查询并排序所有[SysConfig]")]
        public List<DynamicEntity.SysConfigEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            return SysConfigDao.SelectsOrderBy(orderField, isDesc) as List<DynamicEntity.SysConfigEntity>;
        }
    }
}
