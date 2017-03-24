using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DynamicDao;

namespace DynamicWebSrv
{
    /// <summary>
    /// ShowAllModelsSrv 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public partial class ShowAllModelsSrv : System.Web.Services.WebService
    {	
        [WebMethod(Description="查询所有[ShowAllModels]")]
        public List<DynamicEntity.ShowAllModelsEntity> Selects()
        {
            return ShowAllModelsDao.Selects() as List<DynamicEntity.ShowAllModelsEntity>;
        }
        [WebMethod(Description="条件查询[ShowAllModels]")]
        public List<DynamicEntity.ShowAllModelsEntity> Select(DynamicEntity.ShowAllModelsEntity o)
        {
            return ShowAllModelsDao.Select(o) as List<DynamicEntity.ShowAllModelsEntity>;
        }
        [WebMethod(Description="查询并排序所有[ShowAllModels]")]
        public List<DynamicEntity.ShowAllModelsEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            return ShowAllModelsDao.SelectsOrderBy(orderField, isDesc) as List<DynamicEntity.ShowAllModelsEntity>;
        }
    }
}
