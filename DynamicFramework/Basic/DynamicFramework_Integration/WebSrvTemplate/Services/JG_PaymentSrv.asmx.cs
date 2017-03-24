using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DynamicDao;

namespace DynamicWebSrv
{
    /// <summary>
    /// JG_PaymentSrv 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class JG_PaymentSrv : System.Web.Services.WebService
    {	
        JG_PaymentDao daoHelp =  JG_PaymentDao.Instance;

        [WebMethod(Description="添加[JG_Payment]")]
        public bool Add(DynamicEntity.JG_PaymentEntity o)
        {
            return daoHelp.Add(o);
        }
        [WebMethod(Description="更新[JG_Payment]")]
        public bool Update(DynamicEntity.JG_PaymentEntity o)
        {
            return daoHelp.Update(o);
        }
        [WebMethod(Description="删除[JG_Payment]")]
        public bool Delete(string o)
        {
            return daoHelp.Delete(o);
        }
        [WebMethod(Description="查询所有[JG_Payment]")]
        public List<DynamicEntity.JG_PaymentEntity> Selects()
        {
            return daoHelp.Selects() as List<DynamicEntity.JG_PaymentEntity>;
        }
        [WebMethod(Description="条件查询[JG_Payment]")]
        public List<DynamicEntity.JG_PaymentEntity> Select(DynamicEntity.JG_PaymentEntity o)
        {
            return daoHelp.Select(o) as List<DynamicEntity.JG_PaymentEntity>;
        }
        [WebMethod(Description="查询并排序所有[JG_Payment]")]
        public List<DynamicEntity.JG_PaymentEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            return daoHelp.SelectsOrderBy(orderField, isDesc) as List<DynamicEntity.JG_PaymentEntity>;
        }
    }
}
