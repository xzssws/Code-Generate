using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DynamicDao;

namespace DynamicWebSrv
{
    /// <summary>
    /// DutyFunSrv 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class DutyFunSrv : System.Web.Services.WebService
    {	
        DutyFunDao daoHelp =  DutyFunDao.Instance;

        [WebMethod(Description="添加[DutyFun]")]
        public bool Add(DynamicEntity.DutyFunEntity o)
        {
            return daoHelp.Add(o);
        }
        [WebMethod(Description="更新[DutyFun]")]
        public bool Update(DynamicEntity.DutyFunEntity o)
        {
            return daoHelp.Update(o);
        }
        [WebMethod(Description="删除[DutyFun]")]
        public bool Delete(string o)
        {
            return daoHelp.Delete(o);
        }
        [WebMethod(Description="查询所有[DutyFun]")]
        public List<DynamicEntity.DutyFunEntity> Selects()
        {
            return daoHelp.Selects() as List<DynamicEntity.DutyFunEntity>;
        }
        [WebMethod(Description="条件查询[DutyFun]")]
        public List<DynamicEntity.DutyFunEntity> Select(DynamicEntity.DutyFunEntity o)
        {
            return daoHelp.Select(o) as List<DynamicEntity.DutyFunEntity>;
        }
        [WebMethod(Description="查询并排序所有[DutyFun]")]
        public List<DynamicEntity.DutyFunEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            return daoHelp.SelectsOrderBy(orderField, isDesc) as List<DynamicEntity.DutyFunEntity>;
        }
    }
}
