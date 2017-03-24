using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DynamicDao;

namespace DynamicWebSrv
{
    /// <summary>
    /// TableDicationarySrv 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public partial class TableDicationarySrv : System.Web.Services.WebService
    {	
        TableDicationaryDao daoHelp =  TableDicationaryDao.Instance;

        [WebMethod(Description="查询所有[TableDicationary]")]
        public List<DynamicEntity.TableDicationaryEntity> Selects()
        {
            return daoHelp.Selects() as List<DynamicEntity.TableDicationaryEntity>;
        }
        [WebMethod(Description="条件查询[TableDicationary]")]
        public List<DynamicEntity.TableDicationaryEntity> Select(DynamicEntity.TableDicationaryEntity o)
        {
            return daoHelp.Select(o) as List<DynamicEntity.TableDicationaryEntity>;
        }
        [WebMethod(Description="查询并排序所有[TableDicationary]")]
        public List<DynamicEntity.TableDicationaryEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            return daoHelp.SelectsOrderBy(orderField, isDesc) as List<DynamicEntity.TableDicationaryEntity>;
        }
    }
}
