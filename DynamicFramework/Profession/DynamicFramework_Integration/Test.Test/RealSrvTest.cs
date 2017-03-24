using Test.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using Test.Entity;
using System.Collections.Generic;

namespace Test.Test
{
    
    
    /// <summary>
    ///这是 RealSrvTest 的测试类，旨在
    ///包含所有 RealSrvTest 单元测试
    ///</summary>
    [TestClass()]
    public class RealSrvTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///获取或设置测试上下文，上下文提供
        ///有关当前测试运行及其功能的信息。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        static RealSrv target;
        #region 附加测试特性
        // 
        //编写测试时，还可使用以下特性:
        //
        //使用 ClassInitialize 在运行类中的第一个测试前先运行代码
        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext)
        {
            target = new RealSrv();
        }
        
        //使用 ClassCleanup 在运行完类中的所有测试后再运行代码
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //使用 TestInitialize 在运行每个测试前先运行代码
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //使用 TestCleanup 在运行完每个测试后运行代码
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Classs_Add 的测试
        ///</summary>
        [TestMethod()]
        ////[HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("E:\\LocalProjects\\DynamicFramework\\Profession\\DynamicFramework_Integration\\Test.Service", "/")]
        [UrlToTest("http://localhost:28232/")]
        public void Classs_AddTest()
        {
            
            ClasssInfo o = new ClasssInfo
            {
                ID=7865,
                Name="fsdf",
                Student=321
            }; // TODO: 初始化为适当的值
            bool expected = true; // TODO: 初始化为适当的值
            bool actual;
            actual = target.Classs_Add(o);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Classs_Add 的测试
        ///</summary>
        // TODO: 确保 UrlToTest 特性指定一个指向 ASP.NET 页的 URL(例如，
        // http://.../Default.aspx)。这对于在 Web 服务器上执行单元测试是必需的，
        //无论要测试页、Web 服务还是 WCF 服务都是如此。
        [TestMethod()]
        //[HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("E:\\LocalProjects\\DynamicFramework\\Profession\\DynamicFramework_Integration\\Test.Service", "/")]
        [UrlToTest("http://localhost:28232/")]
        public void Classs_AddTest1()
        {
            ClasssInfo o = new ClasssInfo
            {
                ID=0,
                Name="",
                Student=0
            };
            bool expected = false; // TODO: 初始化为适当的值
            bool actual;
            actual = target.Classs_Add(o);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///Classs_Delete 的测试
        ///</summary>
        // TODO: 确保 UrlToTest 特性指定一个指向 ASP.NET 页的 URL(例如，
        // http://.../Default.aspx)。这对于在 Web 服务器上执行单元测试是必需的，
        //无论要测试页、Web 服务还是 WCF 服务都是如此。
        [TestMethod()]
        //[HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("E:\\LocalProjects\\DynamicFramework\\Profession\\DynamicFramework_Integration\\Test.Service", "/")]
        [UrlToTest("http://localhost:28232/")]
        public void Classs_DeleteTest()
        {
            
            string o = string.Empty; // TODO: 初始化为适当的值
            bool expected = false; // TODO: 初始化为适当的值
            bool actual;
            actual = target.Classs_Delete(o);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///Classs_Select 的测试
        ///</summary>
        // TODO: 确保 UrlToTest 特性指定一个指向 ASP.NET 页的 URL(例如，
        // http://.../Default.aspx)。这对于在 Web 服务器上执行单元测试是必需的，
        //无论要测试页、Web 服务还是 WCF 服务都是如此。
        [TestMethod()]
        //[HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("E:\\LocalProjects\\DynamicFramework\\Profession\\DynamicFramework_Integration\\Test.Service", "/")]
        [UrlToTest("http://localhost:28232/")]
        public void Classs_SelectTest()
        {
            
            ClasssInfo entity = null; // TODO: 初始化为适当的值
            List<ClasssInfo> expected = null; // TODO: 初始化为适当的值
            List<ClasssInfo> actual;
            actual = target.Classs_Select(entity);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///Classs_SelectForPage 的测试
        ///</summary>
        // TODO: 确保 UrlToTest 特性指定一个指向 ASP.NET 页的 URL(例如，
        // http://.../Default.aspx)。这对于在 Web 服务器上执行单元测试是必需的，
        //无论要测试页、Web 服务还是 WCF 服务都是如此。
        [TestMethod()]
        //[HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("E:\\LocalProjects\\DynamicFramework\\Profession\\DynamicFramework_Integration\\Test.Service", "/")]
        [UrlToTest("http://localhost:28232/")]
        public void Classs_SelectForPageTest()
        {
            
            ClasssInfo entity = null; // TODO: 初始化为适当的值
            int Skip = 0; // TODO: 初始化为适当的值
            int Count = 0; // TODO: 初始化为适当的值
            List<ClasssInfo> expected = null; // TODO: 初始化为适当的值
            List<ClasssInfo> actual;
            actual = target.Classs_SelectForPage(entity, Skip, Count);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///Classs_SelectForSort 的测试
        ///</summary>
        // TODO: 确保 UrlToTest 特性指定一个指向 ASP.NET 页的 URL(例如，
        // http://.../Default.aspx)。这对于在 Web 服务器上执行单元测试是必需的，
        //无论要测试页、Web 服务还是 WCF 服务都是如此。
        [TestMethod()]
        //[HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("E:\\LocalProjects\\DynamicFramework\\Profession\\DynamicFramework_Integration\\Test.Service", "/")]
        [UrlToTest("http://localhost:28232/")]
        public void Classs_SelectForSortTest()
        {
            
            ClasssInfo entity = null; // TODO: 初始化为适当的值
            string sortField = string.Empty; // TODO: 初始化为适当的值
            bool isDesc = false; // TODO: 初始化为适当的值
            List<ClasssInfo> expected = null; // TODO: 初始化为适当的值
            List<ClasssInfo> actual;
            actual = target.Classs_SelectForSort(entity, sortField, isDesc);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///Classs_Selects 的测试
        ///</summary>
        // TODO: 确保 UrlToTest 特性指定一个指向 ASP.NET 页的 URL(例如，
        // http://.../Default.aspx)。这对于在 Web 服务器上执行单元测试是必需的，
        //无论要测试页、Web 服务还是 WCF 服务都是如此。
        [TestMethod()]
        //[HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("E:\\LocalProjects\\DynamicFramework\\Profession\\DynamicFramework_Integration\\Test.Service", "/")]
        [UrlToTest("http://localhost:28232/")]
        public void Classs_SelectsTest()
        {
            
            List<ClasssInfo> expected = null; // TODO: 初始化为适当的值
            List<ClasssInfo> actual;
            actual = target.Classs_Selects();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///Classs_SelectsForPage 的测试
        ///</summary>
        // TODO: 确保 UrlToTest 特性指定一个指向 ASP.NET 页的 URL(例如，
        // http://.../Default.aspx)。这对于在 Web 服务器上执行单元测试是必需的，
        //无论要测试页、Web 服务还是 WCF 服务都是如此。
        [TestMethod()]
        //[HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("E:\\LocalProjects\\DynamicFramework\\Profession\\DynamicFramework_Integration\\Test.Service", "/")]
        [UrlToTest("http://localhost:28232/")]
        public void Classs_SelectsForPageTest()
        {
            
            int Skip = 0; // TODO: 初始化为适当的值
            int Count = 0; // TODO: 初始化为适当的值
            List<ClasssInfo> expected = null; // TODO: 初始化为适当的值
            List<ClasssInfo> actual;
            actual = target.Classs_SelectsForPage(Skip, Count);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///Classs_SelectsForSort 的测试
        ///</summary>
        // TODO: 确保 UrlToTest 特性指定一个指向 ASP.NET 页的 URL(例如，
        // http://.../Default.aspx)。这对于在 Web 服务器上执行单元测试是必需的，
        //无论要测试页、Web 服务还是 WCF 服务都是如此。
        [TestMethod()]
        //[HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("E:\\LocalProjects\\DynamicFramework\\Profession\\DynamicFramework_Integration\\Test.Service", "/")]
        [UrlToTest("http://localhost:28232/")]
        public void Classs_SelectsForSortTest()
        {
            
            string sortField = string.Empty; // TODO: 初始化为适当的值
            bool isDesc = false; // TODO: 初始化为适当的值
            List<ClasssInfo> expected = null; // TODO: 初始化为适当的值
            List<ClasssInfo> actual;
            actual = target.Classs_SelectsForSort(sortField, isDesc);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///Classs_Update 的测试
        ///</summary>
        // TODO: 确保 UrlToTest 特性指定一个指向 ASP.NET 页的 URL(例如，
        // http://.../Default.aspx)。这对于在 Web 服务器上执行单元测试是必需的，
        //无论要测试页、Web 服务还是 WCF 服务都是如此。
        [TestMethod()]
        //[HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("E:\\LocalProjects\\DynamicFramework\\Profession\\DynamicFramework_Integration\\Test.Service", "/")]
        [UrlToTest("http://localhost:28232/")]
        public void Classs_UpdateTest()
        {
            
            ClasssInfo o = null; // TODO: 初始化为适当的值
            bool expected = false; // TODO: 初始化为适当的值
            bool actual;
            actual = target.Classs_Update(o);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///StudentX_Add 的测试
        ///</summary>
        // TODO: 确保 UrlToTest 特性指定一个指向 ASP.NET 页的 URL(例如，
        // http://.../Default.aspx)。这对于在 Web 服务器上执行单元测试是必需的，
        //无论要测试页、Web 服务还是 WCF 服务都是如此。
        [TestMethod()]
        //[HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("E:\\LocalProjects\\DynamicFramework\\Profession\\DynamicFramework_Integration\\Test.Service", "/")]
        [UrlToTest("http://localhost:28232/")]
        public void StudentX_AddTest()
        {
            
            StudentXInfo o = null; // TODO: 初始化为适当的值
            bool expected = false; // TODO: 初始化为适当的值
            bool actual;
            actual = target.StudentX_Add(o);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///StudentX_Delete 的测试
        ///</summary>
        // TODO: 确保 UrlToTest 特性指定一个指向 ASP.NET 页的 URL(例如，
        // http://.../Default.aspx)。这对于在 Web 服务器上执行单元测试是必需的，
        //无论要测试页、Web 服务还是 WCF 服务都是如此。
        [TestMethod()]
        //[HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("E:\\LocalProjects\\DynamicFramework\\Profession\\DynamicFramework_Integration\\Test.Service", "/")]
        [UrlToTest("http://localhost:28232/")]
        public void StudentX_DeleteTest()
        {
            
            string o = string.Empty; // TODO: 初始化为适当的值
            bool expected = false; // TODO: 初始化为适当的值
            bool actual;
            actual = target.StudentX_Delete(o);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///StudentX_Select 的测试
        ///</summary>
        // TODO: 确保 UrlToTest 特性指定一个指向 ASP.NET 页的 URL(例如，
        // http://.../Default.aspx)。这对于在 Web 服务器上执行单元测试是必需的，
        //无论要测试页、Web 服务还是 WCF 服务都是如此。
        [TestMethod()]
        //[HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("E:\\LocalProjects\\DynamicFramework\\Profession\\DynamicFramework_Integration\\Test.Service", "/")]
        [UrlToTest("http://localhost:28232/")]
        public void StudentX_SelectTest()
        {
            
            StudentXInfo entity = null; // TODO: 初始化为适当的值
            List<StudentXInfo> expected = null; // TODO: 初始化为适当的值
            List<StudentXInfo> actual;
            actual = target.StudentX_Select(entity);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///StudentX_SelectForPage 的测试
        ///</summary>
        // TODO: 确保 UrlToTest 特性指定一个指向 ASP.NET 页的 URL(例如，
        // http://.../Default.aspx)。这对于在 Web 服务器上执行单元测试是必需的，
        //无论要测试页、Web 服务还是 WCF 服务都是如此。
        [TestMethod()]
        //[HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("E:\\LocalProjects\\DynamicFramework\\Profession\\DynamicFramework_Integration\\Test.Service", "/")]
        [UrlToTest("http://localhost:28232/")]
        public void StudentX_SelectForPageTest()
        {
            
            StudentXInfo entity = null; // TODO: 初始化为适当的值
            int Skip = 0; // TODO: 初始化为适当的值
            int Count = 0; // TODO: 初始化为适当的值
            List<StudentXInfo> expected = null; // TODO: 初始化为适当的值
            List<StudentXInfo> actual;
            actual = target.StudentX_SelectForPage(entity, Skip, Count);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///StudentX_SelectForSort 的测试
        ///</summary>
        // TODO: 确保 UrlToTest 特性指定一个指向 ASP.NET 页的 URL(例如，
        // http://.../Default.aspx)。这对于在 Web 服务器上执行单元测试是必需的，
        //无论要测试页、Web 服务还是 WCF 服务都是如此。
        [TestMethod()]
        //[HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("E:\\LocalProjects\\DynamicFramework\\Profession\\DynamicFramework_Integration\\Test.Service", "/")]
        [UrlToTest("http://localhost:28232/")]
        public void StudentX_SelectForSortTest()
        {
            
            StudentXInfo entity = null; // TODO: 初始化为适当的值
            string sortField = string.Empty; // TODO: 初始化为适当的值
            bool isDesc = false; // TODO: 初始化为适当的值
            List<StudentXInfo> expected = null; // TODO: 初始化为适当的值
            List<StudentXInfo> actual;
            actual = target.StudentX_SelectForSort(entity, sortField, isDesc);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///StudentX_Selects 的测试
        ///</summary>
        // TODO: 确保 UrlToTest 特性指定一个指向 ASP.NET 页的 URL(例如，
        // http://.../Default.aspx)。这对于在 Web 服务器上执行单元测试是必需的，
        //无论要测试页、Web 服务还是 WCF 服务都是如此。
        [TestMethod()]
        //[HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("E:\\LocalProjects\\DynamicFramework\\Profession\\DynamicFramework_Integration\\Test.Service", "/")]
        [UrlToTest("http://localhost:28232/")]
        public void StudentX_SelectsTest()
        {
            
            List<StudentXInfo> expected = null; // TODO: 初始化为适当的值
            List<StudentXInfo> actual;
            actual = target.StudentX_Selects();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///StudentX_SelectsForPage 的测试
        ///</summary>
        // TODO: 确保 UrlToTest 特性指定一个指向 ASP.NET 页的 URL(例如，
        // http://.../Default.aspx)。这对于在 Web 服务器上执行单元测试是必需的，
        //无论要测试页、Web 服务还是 WCF 服务都是如此。
        [TestMethod()]
        //[HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("E:\\LocalProjects\\DynamicFramework\\Profession\\DynamicFramework_Integration\\Test.Service", "/")]
        [UrlToTest("http://localhost:28232/")]
        public void StudentX_SelectsForPageTest()
        {
            
            int Skip = 0; // TODO: 初始化为适当的值
            int Count = 0; // TODO: 初始化为适当的值
            List<StudentXInfo> expected = null; // TODO: 初始化为适当的值
            List<StudentXInfo> actual;
            actual = target.StudentX_SelectsForPage(Skip, Count);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///StudentX_SelectsForSort 的测试
        ///</summary>
        // TODO: 确保 UrlToTest 特性指定一个指向 ASP.NET 页的 URL(例如，
        // http://.../Default.aspx)。这对于在 Web 服务器上执行单元测试是必需的，
        //无论要测试页、Web 服务还是 WCF 服务都是如此。
        [TestMethod()]
        //[HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("E:\\LocalProjects\\DynamicFramework\\Profession\\DynamicFramework_Integration\\Test.Service", "/")]
        [UrlToTest("http://localhost:28232/")]
        public void StudentX_SelectsForSortTest()
        {
            
            string sortField = string.Empty; // TODO: 初始化为适当的值
            bool isDesc = false; // TODO: 初始化为适当的值
            List<StudentXInfo> expected = null; // TODO: 初始化为适当的值
            List<StudentXInfo> actual;
            actual = target.StudentX_SelectsForSort(sortField, isDesc);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///StudentX_Update 的测试
        ///</summary>
        // TODO: 确保 UrlToTest 特性指定一个指向 ASP.NET 页的 URL(例如，
        // http://.../Default.aspx)。这对于在 Web 服务器上执行单元测试是必需的，
        //无论要测试页、Web 服务还是 WCF 服务都是如此。
        [TestMethod()]
        //[HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("E:\\LocalProjects\\DynamicFramework\\Profession\\DynamicFramework_Integration\\Test.Service", "/")]
        [UrlToTest("http://localhost:28232/")]
        public void StudentX_UpdateTest()
        {
            
            StudentXInfo o = null; // TODO: 初始化为适当的值
            bool expected = false; // TODO: 初始化为适当的值
            bool actual;
            actual = target.StudentX_Update(o);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///Student_Add 的测试
        ///</summary>
        // TODO: 确保 UrlToTest 特性指定一个指向 ASP.NET 页的 URL(例如，
        // http://.../Default.aspx)。这对于在 Web 服务器上执行单元测试是必需的，
        //无论要测试页、Web 服务还是 WCF 服务都是如此。
        [TestMethod()]
        //[HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("E:\\LocalProjects\\DynamicFramework\\Profession\\DynamicFramework_Integration\\Test.Service", "/")]
        [UrlToTest("http://localhost:28232/")]
        public void Student_AddTest()
        {
            
            StudentInfo o = null; // TODO: 初始化为适当的值
            bool expected = false; // TODO: 初始化为适当的值
            bool actual;
            actual = target.Student_Add(o);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///Student_Delete 的测试
        ///</summary>
        // TODO: 确保 UrlToTest 特性指定一个指向 ASP.NET 页的 URL(例如，
        // http://.../Default.aspx)。这对于在 Web 服务器上执行单元测试是必需的，
        //无论要测试页、Web 服务还是 WCF 服务都是如此。
        [TestMethod()]
        //[HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("E:\\LocalProjects\\DynamicFramework\\Profession\\DynamicFramework_Integration\\Test.Service", "/")]
        [UrlToTest("http://localhost:28232/")]
        public void Student_DeleteTest()
        {
            
            string o = string.Empty; // TODO: 初始化为适当的值
            bool expected = false; // TODO: 初始化为适当的值
            bool actual;
            actual = target.Student_Delete(o);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///Student_Select 的测试
        ///</summary>
        // TODO: 确保 UrlToTest 特性指定一个指向 ASP.NET 页的 URL(例如，
        // http://.../Default.aspx)。这对于在 Web 服务器上执行单元测试是必需的，
        //无论要测试页、Web 服务还是 WCF 服务都是如此。
        [TestMethod()]
        //[HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("E:\\LocalProjects\\DynamicFramework\\Profession\\DynamicFramework_Integration\\Test.Service", "/")]
        [UrlToTest("http://localhost:28232/")]
        public void Student_SelectTest()
        {
            
            StudentInfo entity = null; // TODO: 初始化为适当的值
            List<StudentInfo> expected = null; // TODO: 初始化为适当的值
            List<StudentInfo> actual;
            actual = target.Student_Select(entity);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///Student_SelectForPage 的测试
        ///</summary>
        // TODO: 确保 UrlToTest 特性指定一个指向 ASP.NET 页的 URL(例如，
        // http://.../Default.aspx)。这对于在 Web 服务器上执行单元测试是必需的，
        //无论要测试页、Web 服务还是 WCF 服务都是如此。
        [TestMethod()]
        //[HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("E:\\LocalProjects\\DynamicFramework\\Profession\\DynamicFramework_Integration\\Test.Service", "/")]
        [UrlToTest("http://localhost:28232/")]
        public void Student_SelectForPageTest()
        {
            
            StudentInfo entity = null; // TODO: 初始化为适当的值
            int Skip = 0; // TODO: 初始化为适当的值
            int Count = 0; // TODO: 初始化为适当的值
            List<StudentInfo> expected = null; // TODO: 初始化为适当的值
            List<StudentInfo> actual;
            actual = target.Student_SelectForPage(entity, Skip, Count);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///Student_SelectForSort 的测试
        ///</summary>
        // TODO: 确保 UrlToTest 特性指定一个指向 ASP.NET 页的 URL(例如，
        // http://.../Default.aspx)。这对于在 Web 服务器上执行单元测试是必需的，
        //无论要测试页、Web 服务还是 WCF 服务都是如此。
        [TestMethod()]
        //[HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("E:\\LocalProjects\\DynamicFramework\\Profession\\DynamicFramework_Integration\\Test.Service", "/")]
        [UrlToTest("http://localhost:28232/")]
        public void Student_SelectForSortTest()
        {
            
            StudentInfo entity = null; // TODO: 初始化为适当的值
            string sortField = string.Empty; // TODO: 初始化为适当的值
            bool isDesc = false; // TODO: 初始化为适当的值
            List<StudentInfo> expected = null; // TODO: 初始化为适当的值
            List<StudentInfo> actual;
            actual = target.Student_SelectForSort(entity, sortField, isDesc);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///Student_Selects 的测试
        ///</summary>
        // TODO: 确保 UrlToTest 特性指定一个指向 ASP.NET 页的 URL(例如，
        // http://.../Default.aspx)。这对于在 Web 服务器上执行单元测试是必需的，
        //无论要测试页、Web 服务还是 WCF 服务都是如此。
        [TestMethod()]
        //[HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("E:\\LocalProjects\\DynamicFramework\\Profession\\DynamicFramework_Integration\\Test.Service", "/")]
        [UrlToTest("http://localhost:28232/")]
        public void Student_SelectsTest()
        {
            
            List<StudentInfo> expected = null; // TODO: 初始化为适当的值
            List<StudentInfo> actual;
            actual = target.Student_Selects();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///Student_SelectsForPage 的测试
        ///</summary>
        // TODO: 确保 UrlToTest 特性指定一个指向 ASP.NET 页的 URL(例如，
        // http://.../Default.aspx)。这对于在 Web 服务器上执行单元测试是必需的，
        //无论要测试页、Web 服务还是 WCF 服务都是如此。
        [TestMethod()]
        //[HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("E:\\LocalProjects\\DynamicFramework\\Profession\\DynamicFramework_Integration\\Test.Service", "/")]
        [UrlToTest("http://localhost:28232/")]
        public void Student_SelectsForPageTest()
        {
            
            int Skip = 0; // TODO: 初始化为适当的值
            int Count = 0; // TODO: 初始化为适当的值
            List<StudentInfo> expected = null; // TODO: 初始化为适当的值
            List<StudentInfo> actual;
            actual = target.Student_SelectsForPage(Skip, Count);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///Student_SelectsForSort 的测试
        ///</summary>
        // TODO: 确保 UrlToTest 特性指定一个指向 ASP.NET 页的 URL(例如，
        // http://.../Default.aspx)。这对于在 Web 服务器上执行单元测试是必需的，
        //无论要测试页、Web 服务还是 WCF 服务都是如此。
        [TestMethod()]
        //[HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("E:\\LocalProjects\\DynamicFramework\\Profession\\DynamicFramework_Integration\\Test.Service", "/")]
        [UrlToTest("http://localhost:28232/")]
        public void Student_SelectsForSortTest()
        {
            
            string sortField = string.Empty; // TODO: 初始化为适当的值
            bool isDesc = false; // TODO: 初始化为适当的值
            List<StudentInfo> expected = null; // TODO: 初始化为适当的值
            List<StudentInfo> actual;
            actual = target.Student_SelectsForSort(sortField, isDesc);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///Student_Update 的测试
        ///</summary>
        // TODO: 确保 UrlToTest 特性指定一个指向 ASP.NET 页的 URL(例如，
        // http://.../Default.aspx)。这对于在 Web 服务器上执行单元测试是必需的，
        //无论要测试页、Web 服务还是 WCF 服务都是如此。
        [TestMethod()]
        //[HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("E:\\LocalProjects\\DynamicFramework\\Profession\\DynamicFramework_Integration\\Test.Service", "/")]
        [UrlToTest("http://localhost:28232/")]
        public void Student_UpdateTest()
        {
            
            StudentInfo o = null; // TODO: 初始化为适当的值
            bool expected = false; // TODO: 初始化为适当的值
            bool actual;
            actual = target.Student_Update(o);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }
    }
}
