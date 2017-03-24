using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Test.NTest
{
    /// <summary>
    /// 测试类
    /// </summary>
    [TestFixture]
    public class TestClass
    {
        #region 预制

        /// <summary>
        /// 所有测试执行前执行(一次)
        /// </summary>
        [TestFixtureSetUp]
        public void ClassBegin()
        {
        }

        /// <summary>
        /// 所有测试完成后执行(一次)
        /// </summary>
        [TestFixtureTearDown]
        public void ClassEnd()
        {
        }

        /// <summary>
        /// 每次测试前执行(多次)
        /// </summary>
        [SetUp]
        public void TestBegin()
        {
        }

        /// <summary>
        /// 每次测试后执行(多次)
        /// </summary>
        [TearDown]
        public void TestEnd()
        {
        }

        #endregion 预制

        #region 测试方法

        //[Category("分类")] //测试分类
        //[Explicit] //默认不执行
        //[ExpectedException(typeof(AggregateException))]//跳过可能出现的异常
        //[Ignore("跳过")]//测试时忽略的方法
        [Test] //标注测试方法
        public void TestMethod()
        {
            Real.RealSrv rs = new Real.RealSrv();
            bool result =  rs.Classs_Add(new Real.ClasssInfo(){
                ID=new Random().Next(6345,421432),Name="vczx",Student=312
            });
            Assert.AreEqual(true, result);
        }

        #endregion 测试方法
    }
}