using System;
using System.Collections.Generic;
using System.Linq;
using ClientTemplate.RealService;

namespace DynamiClient
{
    /// <summary>
    /// [Student]客户端代理类
    /// </summary>
    public sealed partial class StudentClient
    {
        #region 单例模式

        private StudentClient() { }
    
        private static readonly object LockObj = new object();

        private static StudentClient _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static StudentClient Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new StudentClient();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        private RealSrv service = new RealSrv();

        #region 基础物理操作(增删改)
		/// <summary>
        /// 添加一条[Student]
        /// </summary>
        /// <param name="entity">[Student]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Add(StudentEntity entity)
        {
            return service.Student_Add(entity);
        }

        /// <summary>
        /// 更新一条[Student]
        /// </summary>
        /// <param name="entity">更新的[Student]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Update(StudentEntity entity)
        {
            return service.Student_Update(entity);
        }

        /// <summary>
        /// 删除一条[Student]
        /// </summary>
        /// <param name="entityID"></param>
        /// <returns>执行完成状态</returns>
        public bool Delete(string entityID)
        {
            return service.Student_Delete(entityID);
        }
		#endregion

		#region 查询操作
		/// <summary>
        /// 条件查询[Student]
        /// </summary>
        /// <param name="entity">[Student]筛选实例</param>
        /// <returns>[Student结果集</returns>
        public IList<StudentEntity> Select(StudentEntity entity)
        {
            return service.Student_Select(entity);
        }
        /// <summary>
        /// 条件查询排序
        /// </summary>
        /// <param name="entity">筛选实例</param>
        /// <param name="sortField">排序字段名</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
		public IList<StudentEntity> SelectForSort(StudentEntity entity,string sortField, bool isDesc)
        {
            return service.Student_SelectForSort(entity,sortField,isDesc);
        }
		/// <summary>
        /// 条件查询分页[Student]
        /// </summary>
        /// <param name="entity">[Student]筛选实例</param>
        /// <param name="Skip">页数</param>
        /// <param name="Count">页条目数量</param>
        /// <returns>[Student结果集</returns>
        public IList<StudentEntity> SelectForPage(StudentEntity entity,int Skip,int Count)
        {
            return service.Student_SelectForPage(entity,Skip,Count);
        }
        /// <summary>
        /// 查询所有[Student]
        /// </summary>
        /// <returns></returns>
        public IList<StudentEntity> Selects()
        {
            return service.Student_Selects();
        }
        /// <summary>
        /// 查询所有[Student]带排序
        /// </summary>
        /// <param name="sortField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public IList<StudentEntity> SelectsForSort(string sortField,bool isDesc)
        {
            return service.Student_SelectsForSort(sortField,isDesc);
        }

        /// <summary>
        /// 查询所有[Student]分页
        /// </summary>
        /// <param name="Skip">页数</param>
        /// <param name="Count">页条目数量</param>
        /// <returns></returns>
        public IList<StudentEntity> SelectsForPage(int Skip, int Count)
        {
            return service.Student_SelectsForPage(Skip,Count);
        }
		#endregion
    }
}
