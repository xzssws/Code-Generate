using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DynamicDao;

namespace DynamicWebSrv
{
    /// <summary>
    /// JG_SpvProtocolSrv 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class JG_SpvProtocolSrv : System.Web.Services.WebService
    {	
        [WebMethod(Description="添加[JG_SpvProtocol]")]
        public bool Add(DynamicEntity.JG_SpvProtocolEntity o)
        {
            return JG_SpvProtocolDao.Add(o);
        }
        [WebMethod(Description="更新[JG_SpvProtocol]")]
        public bool Update(DynamicEntity.JG_SpvProtocolEntity o)
        {
            return JG_SpvProtocolDao.Update(o);
        }
        [WebMethod(Description="删除[JG_SpvProtocol]")]
        public bool Delete(string o)
        {
            return JG_SpvProtocolDao.Delete(o);
        }
        [WebMethod(Description="查询所有[JG_SpvProtocol]")]
        public List<DynamicEntity.JG_SpvProtocolEntity> Selects()
        {
            return JG_SpvProtocolDao.Selects() as List<DynamicEntity.JG_SpvProtocolEntity>;
        }
        [WebMethod(Description="条件查询[JG_SpvProtocol]")]
        public List<DynamicEntity.JG_SpvProtocolEntity> Select(DynamicEntity.JG_SpvProtocolEntity o)
        {
            return JG_SpvProtocolDao.Select(o) as List<DynamicEntity.JG_SpvProtocolEntity>;
        }
        [WebMethod(Description="查询并排序所有[JG_SpvProtocol]")]
        public List<DynamicEntity.JG_SpvProtocolEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            return JG_SpvProtocolDao.SelectsOrderBy(orderField, isDesc) as List<DynamicEntity.JG_SpvProtocolEntity>;
        }
    }
}
