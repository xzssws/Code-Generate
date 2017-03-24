using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DynamicDao;

namespace DynamicWebSrv
{
    /// <summary>
    /// JG_InterestSrv 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class JG_InterestSrv : System.Web.Services.WebService
    {	
        [WebMethod(Description="添加[JG_Interest]")]
        public bool Add(DynamicEntity.JG_InterestEntity o)
        {
            return JG_InterestDao.Add(o);
        }
        [WebMethod(Description="更新[JG_Interest]")]
        public bool Update(DynamicEntity.JG_InterestEntity o)
        {
            return JG_InterestDao.Update(o);
        }
        [WebMethod(Description="删除[JG_Interest]")]
        public bool Delete(string o)
        {
            return JG_InterestDao.Delete(o);
        }
        [WebMethod(Description="查询所有[JG_Interest]")]
        public List<DynamicEntity.JG_InterestEntity> Selects()
        {
            return JG_InterestDao.Selects() as List<DynamicEntity.JG_InterestEntity>;
        }
        [WebMethod(Description="条件查询[JG_Interest]")]
        public List<DynamicEntity.JG_InterestEntity> Select(DynamicEntity.JG_InterestEntity o)
        {
            return JG_InterestDao.Select(o) as List<DynamicEntity.JG_InterestEntity>;
        }
        [WebMethod(Description="查询并排序所有[JG_Interest]")]
        public List<DynamicEntity.JG_InterestEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            return JG_InterestDao.SelectsOrderBy(orderField, isDesc) as List<DynamicEntity.JG_InterestEntity>;
        }
    }
}
