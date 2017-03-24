using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Test.DAL;

namespace Test.Service
{
    /// <summary>
    /// StudentXSrv 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class StudentXSrv : System.Web.Services.WebService
    {	
        StudentXDAL daoHelp =  StudentXDAL.Instance;

        [WebMethod(Description="添加[StudentX]")]
        public bool Add(Test.Entity.StudentXInfo o)
        {
            return daoHelp.Add(o);
        }
        [WebMethod(Description="更新[StudentX]")]
        public bool Update(Test.Entity.StudentXInfo o)
        {
            return daoHelp.Update(o);
        }
        [WebMethod(Description="删除[StudentX]")]
        public bool Delete(string o)
        {
            return daoHelp.Delete(o);
        }
        [WebMethod(Description="条件查询[StudentX]")]
        public List<Test.Entity.StudentXInfo> Select(Test.Entity.StudentXInfo entity)
        {
            return daoHelp.Select(entity) as List<Test.Entity.StudentXInfo>;
        }
        [WebMethod(Description="条件查询并排序[StudentX]")]       
		public List<Test.Entity.StudentXInfo> SelectForSort(Test.Entity.StudentXInfo entity,string sortField, bool isDesc)
        {
            return daoHelp.SelectForSort(entity,sortField,isDesc) as List<Test.Entity.StudentXInfo>;
        }
        [WebMethod(Description="条件查询分页[StudentX]")]
        public List<Test.Entity.StudentXInfo> SelectForPage(Test.Entity.StudentXInfo entity,int Skip,int Count)
        {
            return daoHelp.SelectForPage(entity,Skip,Count) as List<Test.Entity.StudentXInfo>;
        }
        [WebMethod(Description="查询所有[StudentX]")]
        public List<Test.Entity.StudentXInfo> Selects()
        {
            return daoHelp.Selects() as List<Test.Entity.StudentXInfo>;
        }
        [WebMethod(Description="查询并排序所有[StudentX]")]
        public List<Test.Entity.StudentXInfo> SelectsForSort(string sortField,bool isDesc)
        {
            return daoHelp.SelectsForSort(sortField,isDesc) as List<Test.Entity.StudentXInfo>;
        }
        [WebMethod(Description="查询所有[StudentX]分页")]
        public List<Test.Entity.StudentXInfo> SelectsForPage(int Skip, int Count)
        {
            return daoHelp.SelectsForPage(Skip,Count) as List<Test.Entity.StudentXInfo>;
        }
    }
}
