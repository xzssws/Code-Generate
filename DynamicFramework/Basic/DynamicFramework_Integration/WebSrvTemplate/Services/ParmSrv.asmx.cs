using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DynamicDao;

namespace DynamicWebSrv
{
    /// <summary>
    /// ParmSrv 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class ParmSrv : System.Web.Services.WebService
    {	
        ParmDao daoHelp =  ParmDao.Instance;

        [WebMethod(Description="添加[Parm]")]
        public bool Add(DynamicEntity.ParmEntity o)
        {
            return daoHelp.Add(o);
        }
        [WebMethod(Description="更新[Parm]")]
        public bool Update(DynamicEntity.ParmEntity o)
        {
            return daoHelp.Update(o);
        }
        [WebMethod(Description="删除[Parm]")]
        public bool Delete(string o)
        {
            return daoHelp.Delete(o);
        }
        [WebMethod(Description="查询所有[Parm]")]
        public List<DynamicEntity.ParmEntity> Selects()
        {
            return daoHelp.Selects() as List<DynamicEntity.ParmEntity>;
        }
        [WebMethod(Description="条件查询[Parm]")]
        public List<DynamicEntity.ParmEntity> Select(DynamicEntity.ParmEntity o)
        {
            return daoHelp.Select(o) as List<DynamicEntity.ParmEntity>;
        }
        [WebMethod(Description="查询并排序所有[Parm]")]
        public List<DynamicEntity.ParmEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            return daoHelp.SelectsOrderBy(orderField, isDesc) as List<DynamicEntity.ParmEntity>;
        }
    }
}
