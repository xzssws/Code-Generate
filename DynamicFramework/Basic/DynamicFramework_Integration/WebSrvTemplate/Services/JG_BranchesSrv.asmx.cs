using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DynamicDao;

namespace DynamicWebSrv
{
    /// <summary>
    /// JG_BranchesSrv 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class JG_BranchesSrv : System.Web.Services.WebService
    {	
        JG_BranchesDao daoHelp =  JG_BranchesDao.Instance;

        [WebMethod(Description="添加[JG_Branches]")]
        public bool Add(DynamicEntity.JG_BranchesEntity o)
        {
            return daoHelp.Add(o);
        }
        [WebMethod(Description="更新[JG_Branches]")]
        public bool Update(DynamicEntity.JG_BranchesEntity o)
        {
            return daoHelp.Update(o);
        }
        [WebMethod(Description="删除[JG_Branches]")]
        public bool Delete(string o)
        {
            return daoHelp.Delete(o);
        }
        [WebMethod(Description="查询所有[JG_Branches]")]
        public List<DynamicEntity.JG_BranchesEntity> Selects()
        {
            return daoHelp.Selects() as List<DynamicEntity.JG_BranchesEntity>;
        }
        [WebMethod(Description="条件查询[JG_Branches]")]
        public List<DynamicEntity.JG_BranchesEntity> Select(DynamicEntity.JG_BranchesEntity o)
        {
            return daoHelp.Select(o) as List<DynamicEntity.JG_BranchesEntity>;
        }
        [WebMethod(Description="查询并排序所有[JG_Branches]")]
        public List<DynamicEntity.JG_BranchesEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            return daoHelp.SelectsOrderBy(orderField, isDesc) as List<DynamicEntity.JG_BranchesEntity>;
        }
    }
}
