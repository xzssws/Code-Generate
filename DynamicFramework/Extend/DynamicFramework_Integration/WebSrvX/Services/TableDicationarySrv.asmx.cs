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

        [WebMethod(Description="条件查询[TableDicationary]")]
        public List<DynamicEntity.TableDicationaryEntity> Select(DynamicEntity.TableDicationaryEntity entity)
        {
            return daoHelp.Select(entity) as List<DynamicEntity.TableDicationaryEntity>;
        }
        [WebMethod(Description="条件查询并排序[TableDicationary]")]       
		public List<DynamicEntity.TableDicationaryEntity> SelectForSort(DynamicEntity.TableDicationaryEntity entity,string sortField, bool isDesc)
        {
            return daoHelp.SelectForSort(entity,sortField,isDesc) as List<DynamicEntity.TableDicationaryEntity>;
        }
        [WebMethod(Description="条件查询分页[TableDicationary]")]
        public List<DynamicEntity.TableDicationaryEntity> SelectForPage(DynamicEntity.TableDicationaryEntity entity,int Skip,int Count)
        {
            return daoHelp.SelectForPage(entity,Skip,Count) as List<DynamicEntity.TableDicationaryEntity>;
        }
        [WebMethod(Description="查询所有[TableDicationary]")]
        public List<DynamicEntity.TableDicationaryEntity> Selects()
        {
            return daoHelp.Selects() as List<DynamicEntity.TableDicationaryEntity>;
        }
        [WebMethod(Description="查询并排序所有[TableDicationary]")]
        public List<DynamicEntity.TableDicationaryEntity> SelectsForSort(string sortField,bool isDesc)
        {
            return daoHelp.SelectsForSort(sortField,isDesc) as List<DynamicEntity.TableDicationaryEntity>;
        }
        [WebMethod(Description="查询所有[TableDicationary]分页")]
        public List<DynamicEntity.TableDicationaryEntity> SelectsForPage(int Skip, int Count)
        {
            return daoHelp.SelectsForPage(Skip,Count) as List<DynamicEntity.TableDicationaryEntity>;
        }
    }
}
