using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DynamicDao;

namespace DynamicWebSrv
{
    /// <summary>
    /// DspFuncSrv 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class DspFuncSrv : System.Web.Services.WebService
    {	
        DspFuncDao daoHelp =  DspFuncDao.Instance;

        [WebMethod(Description="添加[DspFunc]")]
        public bool Add(DynamicEntity.DspFuncEntity o)
        {
            return daoHelp.Add(o);
        }
        [WebMethod(Description="更新[DspFunc]")]
        public bool Update(DynamicEntity.DspFuncEntity o)
        {
            return daoHelp.Update(o);
        }
        [WebMethod(Description="删除[DspFunc]")]
        public bool Delete(string o)
        {
            return daoHelp.Delete(o);
        }
        [WebMethod(Description="查询所有[DspFunc]")]
        public List<DynamicEntity.DspFuncEntity> Selects()
        {
            return daoHelp.Selects() as List<DynamicEntity.DspFuncEntity>;
        }
        [WebMethod(Description="条件查询[DspFunc]")]
        public List<DynamicEntity.DspFuncEntity> Select(DynamicEntity.DspFuncEntity o)
        {
            return daoHelp.Select(o) as List<DynamicEntity.DspFuncEntity>;
        }
        [WebMethod(Description="查询并排序所有[DspFunc]")]
        public List<DynamicEntity.DspFuncEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            return daoHelp.SelectsOrderBy(orderField, isDesc) as List<DynamicEntity.DspFuncEntity>;
        }
    }
}
