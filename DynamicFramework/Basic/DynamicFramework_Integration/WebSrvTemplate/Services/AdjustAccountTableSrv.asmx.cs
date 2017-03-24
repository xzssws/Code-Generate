using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DynamicDao;

namespace DynamicWebSrv
{
    /// <summary>
    /// AdjustAccountTableSrv 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public partial class AdjustAccountTableSrv : System.Web.Services.WebService
    {	
        AdjustAccountTableDao daoHelp =  AdjustAccountTableDao.Instance;

        [WebMethod(Description="查询所有[AdjustAccountTable]")]
        public List<DynamicEntity.AdjustAccountTableEntity> Selects()
        {
            return daoHelp.Selects() as List<DynamicEntity.AdjustAccountTableEntity>;
        }
        [WebMethod(Description="条件查询[AdjustAccountTable]")]
        public List<DynamicEntity.AdjustAccountTableEntity> Select(DynamicEntity.AdjustAccountTableEntity o)
        {
            return daoHelp.Select(o) as List<DynamicEntity.AdjustAccountTableEntity>;
        }
        [WebMethod(Description="查询并排序所有[AdjustAccountTable]")]
        public List<DynamicEntity.AdjustAccountTableEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            return daoHelp.SelectsOrderBy(orderField, isDesc) as List<DynamicEntity.AdjustAccountTableEntity>;
        }
    }
}
