using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DynamicDao;

namespace DynamicWebSrv
{
    /// <summary>
    /// 实体字典Srv 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public partial class 实体字典Srv : System.Web.Services.WebService
    {	
        实体字典Dao daoHelp =  实体字典Dao.Instance;

        [WebMethod(Description="查询所有[实体字典]")]
        public List<DynamicEntity.实体字典Entity> Selects()
        {
            return daoHelp.Selects() as List<DynamicEntity.实体字典Entity>;
        }
        [WebMethod(Description="条件查询[实体字典]")]
        public List<DynamicEntity.实体字典Entity> Select(DynamicEntity.实体字典Entity o)
        {
            return daoHelp.Select(o) as List<DynamicEntity.实体字典Entity>;
        }
        [WebMethod(Description="查询并排序所有[实体字典]")]
        public List<DynamicEntity.实体字典Entity> SelectsOrderBy(string orderField,bool isDesc)
        {
            return daoHelp.SelectsOrderBy(orderField, isDesc) as List<DynamicEntity.实体字典Entity>;
        }
    }
}
