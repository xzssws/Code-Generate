using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DynamicDao;

namespace DynamicWebSrv
{
    /// <summary>
    /// JG_AmountCollectSrv 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class JG_AmountCollectSrv : System.Web.Services.WebService
    {	
        [WebMethod(Description="添加[JG_AmountCollect]")]
        public bool Add(DynamicEntity.JG_AmountCollectEntity o)
        {
            return JG_AmountCollectDao.Add(o);
        }
        [WebMethod(Description="更新[JG_AmountCollect]")]
        public bool Update(DynamicEntity.JG_AmountCollectEntity o)
        {
            return JG_AmountCollectDao.Update(o);
        }
        [WebMethod(Description="删除[JG_AmountCollect]")]
        public bool Delete(string o)
        {
            return JG_AmountCollectDao.Delete(o);
        }
        [WebMethod(Description="查询所有[JG_AmountCollect]")]
        public List<DynamicEntity.JG_AmountCollectEntity> Selects()
        {
            return JG_AmountCollectDao.Selects() as List<DynamicEntity.JG_AmountCollectEntity>;
        }
        [WebMethod(Description="条件查询[JG_AmountCollect]")]
        public List<DynamicEntity.JG_AmountCollectEntity> Select(DynamicEntity.JG_AmountCollectEntity o)
        {
            return JG_AmountCollectDao.Select(o) as List<DynamicEntity.JG_AmountCollectEntity>;
        }
        [WebMethod(Description="查询并排序所有[JG_AmountCollect]")]
        public List<DynamicEntity.JG_AmountCollectEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            return JG_AmountCollectDao.SelectsOrderBy(orderField, isDesc) as List<DynamicEntity.JG_AmountCollectEntity>;
        }
    }
}
