using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DynamicDao;

namespace DynamicWebSrv
{
    /// <summary>
    /// JG_MessageInfoSrv 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class JG_MessageInfoSrv : System.Web.Services.WebService
    {	
        [WebMethod(Description="添加[JG_MessageInfo]")]
        public bool Add(DynamicEntity.JG_MessageInfoEntity o)
        {
            return JG_MessageInfoDao.Add(o);
        }
        [WebMethod(Description="更新[JG_MessageInfo]")]
        public bool Update(DynamicEntity.JG_MessageInfoEntity o)
        {
            return JG_MessageInfoDao.Update(o);
        }
        [WebMethod(Description="删除[JG_MessageInfo]")]
        public bool Delete(string o)
        {
            return JG_MessageInfoDao.Delete(o);
        }
        [WebMethod(Description="查询所有[JG_MessageInfo]")]
        public List<DynamicEntity.JG_MessageInfoEntity> Selects()
        {
            return JG_MessageInfoDao.Selects() as List<DynamicEntity.JG_MessageInfoEntity>;
        }
        [WebMethod(Description="条件查询[JG_MessageInfo]")]
        public List<DynamicEntity.JG_MessageInfoEntity> Select(DynamicEntity.JG_MessageInfoEntity o)
        {
            return JG_MessageInfoDao.Select(o) as List<DynamicEntity.JG_MessageInfoEntity>;
        }
        [WebMethod(Description="查询并排序所有[JG_MessageInfo]")]
        public List<DynamicEntity.JG_MessageInfoEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            return JG_MessageInfoDao.SelectsOrderBy(orderField, isDesc) as List<DynamicEntity.JG_MessageInfoEntity>;
        }
    }
}
