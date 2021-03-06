using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DynamicDao;

namespace DynamicWebSrv
{
    /// <summary>
    /// JG_DepositSrv 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class JG_DepositSrv : System.Web.Services.WebService
    {	
        JG_DepositDao daoHelp =  JG_DepositDao.Instance;

        [WebMethod(Description="添加[JG_Deposit]")]
        public bool Add(DynamicEntity.JG_DepositEntity o)
        {
            return daoHelp.Add(o);
        }
        [WebMethod(Description="更新[JG_Deposit]")]
        public bool Update(DynamicEntity.JG_DepositEntity o)
        {
            return daoHelp.Update(o);
        }
        [WebMethod(Description="删除[JG_Deposit]")]
        public bool Delete(string o)
        {
            return daoHelp.Delete(o);
        }
        [WebMethod(Description="查询所有[JG_Deposit]")]
        public List<DynamicEntity.JG_DepositEntity> Selects()
        {
            return daoHelp.Selects() as List<DynamicEntity.JG_DepositEntity>;
        }
        [WebMethod(Description="条件查询[JG_Deposit]")]
        public List<DynamicEntity.JG_DepositEntity> Select(DynamicEntity.JG_DepositEntity o)
        {
            return daoHelp.Select(o) as List<DynamicEntity.JG_DepositEntity>;
        }
        [WebMethod(Description="查询并排序所有[JG_Deposit]")]
        public List<DynamicEntity.JG_DepositEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            return daoHelp.SelectsOrderBy(orderField, isDesc) as List<DynamicEntity.JG_DepositEntity>;
        }
    }
}
