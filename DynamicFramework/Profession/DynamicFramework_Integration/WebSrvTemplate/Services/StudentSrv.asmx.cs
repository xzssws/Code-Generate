using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Test.DAL;

namespace Test.Service
{
    /// <summary>
    /// StudentSrv 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class StudentSrv : System.Web.Services.WebService
    {	
        StudentDAL daoHelp =  StudentDAL.Instance;

        [WebMethod(Description="添加[Student]")]
        public bool Add(Test.Entity.StudentInfo o)
        {
            return daoHelp.Add(o);
        }
        [WebMethod(Description="更新[Student]")]
        public bool Update(Test.Entity.StudentInfo o)
        {
            return daoHelp.Update(o);
        }
        [WebMethod(Description="删除[Student]")]
        public bool Delete(string o)
        {
            return daoHelp.Delete(o);
        }
        [WebMethod(Description="条件查询[Student]")]
        public List<Test.Entity.StudentInfo> Select(Test.Entity.StudentInfo entity)
        {
            return daoHelp.Select(entity) as List<Test.Entity.StudentInfo>;
        }
        [WebMethod(Description="条件查询并排序[Student]")]       
		public List<Test.Entity.StudentInfo> SelectForSort(Test.Entity.StudentInfo entity,string sortField, bool isDesc)
        {
            return daoHelp.SelectForSort(entity,sortField,isDesc) as List<Test.Entity.StudentInfo>;
        }
        [WebMethod(Description="条件查询分页[Student]")]
        public List<Test.Entity.StudentInfo> SelectForPage(Test.Entity.StudentInfo entity,int Skip,int Count)
        {
            return daoHelp.SelectForPage(entity,Skip,Count) as List<Test.Entity.StudentInfo>;
        }
        [WebMethod(Description="查询所有[Student]")]
        public List<Test.Entity.StudentInfo> Selects()
        {
            return daoHelp.Selects() as List<Test.Entity.StudentInfo>;
        }
        [WebMethod(Description="查询并排序所有[Student]")]
        public List<Test.Entity.StudentInfo> SelectsForSort(string sortField,bool isDesc)
        {
            return daoHelp.SelectsForSort(sortField,isDesc) as List<Test.Entity.StudentInfo>;
        }
        [WebMethod(Description="查询所有[Student]分页")]
        public List<Test.Entity.StudentInfo> SelectsForPage(int Skip, int Count)
        {
            return daoHelp.SelectsForPage(Skip,Count) as List<Test.Entity.StudentInfo>;
        }
    }
}
