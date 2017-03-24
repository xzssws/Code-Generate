using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Test.DAL;

namespace Test.Service
{
    /// <summary>
    /// ClasssSrv 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class ClasssSrv : System.Web.Services.WebService
    {	
        ClasssDAL daoHelp =  ClasssDAL.Instance;

        [WebMethod(Description="添加[Classs]")]
        public bool Add(Test.Entity.ClasssInfo o)
        {
            return daoHelp.Add(o);
        }
        [WebMethod(Description="更新[Classs]")]
        public bool Update(Test.Entity.ClasssInfo o)
        {
            return daoHelp.Update(o);
        }
        [WebMethod(Description="删除[Classs]")]
        public bool Delete(string o)
        {
            return daoHelp.Delete(o);
        }
        [WebMethod(Description="条件查询[Classs]")]
        public List<Test.Entity.ClasssInfo> Select(Test.Entity.ClasssInfo entity)
        {
            return daoHelp.Select(entity) as List<Test.Entity.ClasssInfo>;
        }
        [WebMethod(Description="条件查询并排序[Classs]")]       
		public List<Test.Entity.ClasssInfo> SelectForSort(Test.Entity.ClasssInfo entity,string sortField, bool isDesc)
        {
            return daoHelp.SelectForSort(entity,sortField,isDesc) as List<Test.Entity.ClasssInfo>;
        }
        [WebMethod(Description="条件查询分页[Classs]")]
        public List<Test.Entity.ClasssInfo> SelectForPage(Test.Entity.ClasssInfo entity,int Skip,int Count)
        {
            return daoHelp.SelectForPage(entity,Skip,Count) as List<Test.Entity.ClasssInfo>;
        }
        [WebMethod(Description="查询所有[Classs]")]
        public List<Test.Entity.ClasssInfo> Selects()
        {
            return daoHelp.Selects() as List<Test.Entity.ClasssInfo>;
        }
        [WebMethod(Description="查询并排序所有[Classs]")]
        public List<Test.Entity.ClasssInfo> SelectsForSort(string sortField,bool isDesc)
        {
            return daoHelp.SelectsForSort(sortField,isDesc) as List<Test.Entity.ClasssInfo>;
        }
        [WebMethod(Description="查询所有[Classs]分页")]
        public List<Test.Entity.ClasssInfo> SelectsForPage(int Skip, int Count)
        {
            return daoHelp.SelectsForPage(Skip,Count) as List<Test.Entity.ClasssInfo>;
        }
    }
}
