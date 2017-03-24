using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DynamicDao;

namespace DynamicWebSrv
{
    /// <summary>
    /// JG_AccountManageSrv 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class JG_AccountManageSrv : System.Web.Services.WebService
    {	
        [WebMethod(Description="添加[JG_AccountManage]")]
        public bool Add(DynamicEntity.JG_AccountManageEntity o)
        {
            return JG_AccountManageDao.Add(o);
        }
        [WebMethod(Description="更新[JG_AccountManage]")]
        public bool Update(DynamicEntity.JG_AccountManageEntity o)
        {
            return JG_AccountManageDao.Update(o);
        }
        [WebMethod(Description="删除[JG_AccountManage]")]
        public bool Delete(string o)
        {
            return JG_AccountManageDao.Delete(o);
        }
        [WebMethod(Description="查询所有[JG_AccountManage]")]
        public List<DynamicEntity.JG_AccountManageEntity> Selects()
        {
            return JG_AccountManageDao.Selects() as List<DynamicEntity.JG_AccountManageEntity>;
        }
        [WebMethod(Description="条件查询[JG_AccountManage]")]
        public List<DynamicEntity.JG_AccountManageEntity> Select(DynamicEntity.JG_AccountManageEntity o)
        {
            return JG_AccountManageDao.Select(o) as List<DynamicEntity.JG_AccountManageEntity>;
        }
        [WebMethod(Description="查询并排序所有[JG_AccountManage]")]
        public List<DynamicEntity.JG_AccountManageEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            return JG_AccountManageDao.SelectsOrderBy(orderField, isDesc) as List<DynamicEntity.JG_AccountManageEntity>;
        }
    }
}
