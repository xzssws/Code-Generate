using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DynamicDao;

namespace DynamicWebSrv
{
    /// <summary>
    /// JG_AdjustSrv 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class JG_AdjustSrv : System.Web.Services.WebService
    {	
        JG_AdjustDao daoHelp =  JG_AdjustDao.Instance;

        [WebMethod(Description="添加[JG_Adjust]")]
        public bool Add(DynamicEntity.JG_AdjustEntity o)
        {
            return daoHelp.Add(o);
        }
        [WebMethod(Description="更新[JG_Adjust]")]
        public bool Update(DynamicEntity.JG_AdjustEntity o)
        {
            return daoHelp.Update(o);
        }
        [WebMethod(Description="删除[JG_Adjust]")]
        public bool Delete(string o)
        {
            return daoHelp.Delete(o);
        }
        [WebMethod(Description="查询所有[JG_Adjust]")]
        public List<DynamicEntity.JG_AdjustEntity> Selects()
        {
            return daoHelp.Selects() as List<DynamicEntity.JG_AdjustEntity>;
        }
        [WebMethod(Description="条件查询[JG_Adjust]")]
        public List<DynamicEntity.JG_AdjustEntity> Select(DynamicEntity.JG_AdjustEntity o)
        {
            return daoHelp.Select(o) as List<DynamicEntity.JG_AdjustEntity>;
        }
        [WebMethod(Description="查询并排序所有[JG_Adjust]")]
        public List<DynamicEntity.JG_AdjustEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            return daoHelp.SelectsOrderBy(orderField, isDesc) as List<DynamicEntity.JG_AdjustEntity>;
        }
    }
}
