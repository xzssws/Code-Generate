using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Test.DAL;

namespace Test.Service
{
    /// <summary>
    /// RealSrv 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class RealSrv : System.Web.Services.WebService
    {	
        #region [Classs]操作
        
		[WebMethod(Description="添加[Classs]")]
        public bool Classs_Add(Test.Entity.ClasssInfo o)
        {
            return ClasssDAL.Instance.Add(o);
        }
        [WebMethod(Description="更新[Classs]")]
        public bool Classs_Update(Test.Entity.ClasssInfo o)
        {
            return ClasssDAL.Instance.Update(o);
        }
        [WebMethod(Description="删除[Classs]")]
        public bool Classs_Delete(string o)
        {
            return ClasssDAL.Instance.Delete(o);
        }
        [WebMethod(Description="条件查询[Classs]")]
        public List<Test.Entity.ClasssInfo> Classs_Select(Test.Entity.ClasssInfo entity)
        {
            return ClasssDAL.Instance.Select(entity) as List<Test.Entity.ClasssInfo>;
        }
        [WebMethod(Description="条件查询并排序[Classs]")]       
		public List<Test.Entity.ClasssInfo> Classs_SelectForSort(Test.Entity.ClasssInfo entity,string sortField, bool isDesc)
        {
            return ClasssDAL.Instance.SelectForSort(entity,sortField,isDesc) as List<Test.Entity.ClasssInfo>;
        }
        [WebMethod(Description="条件查询分页[Classs]")]
        public List<Test.Entity.ClasssInfo> Classs_SelectForPage(Test.Entity.ClasssInfo entity,int Skip,int Count)
        {
            return ClasssDAL.Instance.SelectForPage(entity,Skip,Count) as List<Test.Entity.ClasssInfo>;
        }
        [WebMethod(Description="查询所有[Classs]")]
        public List<Test.Entity.ClasssInfo> Classs_Selects()
        {
            return ClasssDAL.Instance.Selects() as List<Test.Entity.ClasssInfo>;
        }
        [WebMethod(Description="查询并排序所有[Classs]")]
        public List<Test.Entity.ClasssInfo> Classs_SelectsForSort(string sortField,bool isDesc)
        {
            return ClasssDAL.Instance.SelectsForSort(sortField,isDesc) as List<Test.Entity.ClasssInfo>;
        }
        [WebMethod(Description="查询所有[Classs]分页")]
        public List<Test.Entity.ClasssInfo> Classs_SelectsForPage(int Skip, int Count)
        {
            return ClasssDAL.Instance.SelectsForPage(Skip,Count) as List<Test.Entity.ClasssInfo>;
        }

        #endregion
        #region [Student]操作
        
		[WebMethod(Description="添加[Student]")]
        public bool Student_Add(Test.Entity.StudentInfo o)
        {
            return StudentDAL.Instance.Add(o);
        }
        [WebMethod(Description="更新[Student]")]
        public bool Student_Update(Test.Entity.StudentInfo o)
        {
            return StudentDAL.Instance.Update(o);
        }
        [WebMethod(Description="删除[Student]")]
        public bool Student_Delete(string o)
        {
            return StudentDAL.Instance.Delete(o);
        }
        [WebMethod(Description="条件查询[Student]")]
        public List<Test.Entity.StudentInfo> Student_Select(Test.Entity.StudentInfo entity)
        {
            return StudentDAL.Instance.Select(entity) as List<Test.Entity.StudentInfo>;
        }
        [WebMethod(Description="条件查询并排序[Student]")]       
		public List<Test.Entity.StudentInfo> Student_SelectForSort(Test.Entity.StudentInfo entity,string sortField, bool isDesc)
        {
            return StudentDAL.Instance.SelectForSort(entity,sortField,isDesc) as List<Test.Entity.StudentInfo>;
        }
        [WebMethod(Description="条件查询分页[Student]")]
        public List<Test.Entity.StudentInfo> Student_SelectForPage(Test.Entity.StudentInfo entity,int Skip,int Count)
        {
            return StudentDAL.Instance.SelectForPage(entity,Skip,Count) as List<Test.Entity.StudentInfo>;
        }
        [WebMethod(Description="查询所有[Student]")]
        public List<Test.Entity.StudentInfo> Student_Selects()
        {
            return StudentDAL.Instance.Selects() as List<Test.Entity.StudentInfo>;
        }
        [WebMethod(Description="查询并排序所有[Student]")]
        public List<Test.Entity.StudentInfo> Student_SelectsForSort(string sortField,bool isDesc)
        {
            return StudentDAL.Instance.SelectsForSort(sortField,isDesc) as List<Test.Entity.StudentInfo>;
        }
        [WebMethod(Description="查询所有[Student]分页")]
        public List<Test.Entity.StudentInfo> Student_SelectsForPage(int Skip, int Count)
        {
            return StudentDAL.Instance.SelectsForPage(Skip,Count) as List<Test.Entity.StudentInfo>;
        }

        #endregion
        #region [StudentX]操作
        
		[WebMethod(Description="添加[StudentX]")]
        public bool StudentX_Add(Test.Entity.StudentXInfo o)
        {
            return StudentXDAL.Instance.Add(o);
        }
        [WebMethod(Description="更新[StudentX]")]
        public bool StudentX_Update(Test.Entity.StudentXInfo o)
        {
            return StudentXDAL.Instance.Update(o);
        }
        [WebMethod(Description="删除[StudentX]")]
        public bool StudentX_Delete(string o)
        {
            return StudentXDAL.Instance.Delete(o);
        }
        [WebMethod(Description="条件查询[StudentX]")]
        public List<Test.Entity.StudentXInfo> StudentX_Select(Test.Entity.StudentXInfo entity)
        {
            return StudentXDAL.Instance.Select(entity) as List<Test.Entity.StudentXInfo>;
        }
        [WebMethod(Description="条件查询并排序[StudentX]")]       
		public List<Test.Entity.StudentXInfo> StudentX_SelectForSort(Test.Entity.StudentXInfo entity,string sortField, bool isDesc)
        {
            return StudentXDAL.Instance.SelectForSort(entity,sortField,isDesc) as List<Test.Entity.StudentXInfo>;
        }
        [WebMethod(Description="条件查询分页[StudentX]")]
        public List<Test.Entity.StudentXInfo> StudentX_SelectForPage(Test.Entity.StudentXInfo entity,int Skip,int Count)
        {
            return StudentXDAL.Instance.SelectForPage(entity,Skip,Count) as List<Test.Entity.StudentXInfo>;
        }
        [WebMethod(Description="查询所有[StudentX]")]
        public List<Test.Entity.StudentXInfo> StudentX_Selects()
        {
            return StudentXDAL.Instance.Selects() as List<Test.Entity.StudentXInfo>;
        }
        [WebMethod(Description="查询并排序所有[StudentX]")]
        public List<Test.Entity.StudentXInfo> StudentX_SelectsForSort(string sortField,bool isDesc)
        {
            return StudentXDAL.Instance.SelectsForSort(sortField,isDesc) as List<Test.Entity.StudentXInfo>;
        }
        [WebMethod(Description="查询所有[StudentX]分页")]
        public List<Test.Entity.StudentXInfo> StudentX_SelectsForPage(int Skip, int Count)
        {
            return StudentXDAL.Instance.SelectsForPage(Skip,Count) as List<Test.Entity.StudentXInfo>;
        }

        #endregion
    }
}
