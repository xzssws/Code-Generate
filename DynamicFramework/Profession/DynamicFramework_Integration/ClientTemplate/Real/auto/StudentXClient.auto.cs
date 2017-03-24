using System;
using System.Collections.Generic;
using System.Linq;
using ClientTemplate.RealService;

namespace DynamiClient
{
    /// <summary>
    /// [StudentX]客户端代理类
    /// </summary>
    public sealed partial class StudentXClient
    {
        #region 单例模式

        private StudentXClient() { }
    
        private static readonly object LockObj = new object();

        private static StudentXClient _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static StudentXClient Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new StudentXClient();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        private RealSrv service = new RealSrv();

        #region 基础物理操作(增删改)
		/// <summary>
        /// 添加一条[StudentX]
        /// </summary>
        /// <param name="entity">[StudentX]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Add(StudentXEntity entity)
        {
            return service.StudentX_Add(entity);
        }

        /// <summary>
        /// 更新一条[StudentX]
        /// </summary>
        /// <param name="entity">更新的[StudentX]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Update(StudentXEntity entity)
        {
            return service.StudentX_Update(entity);
        }

        /// <summary>
        /// 删除一条[StudentX]
        /// </summary>
        /// <param name="entityID"></param>
        /// <returns>执行完成状态</returns>
        public bool Delete(string entityID)
        {
            return service.StudentX_Delete(entityID);
        }
		#endregion

		#region 查询操作
		/// <summary>
        /// 条件查询[StudentX]
        /// </summary>
        /// <param name="entity">[StudentX]筛选实例</param>
        /// <returns>[StudentX结果集</returns>
        public IList<StudentXEntity> Select(StudentXEntity entity)
        {
            return service.StudentX_Select(entity);
        }
        /// <summary>
        /// 条件查询排序
        /// </summary>
        /// <param name="entity">筛选实例</param>
        /// <param name="sortField">排序字段名</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
		public IList<StudentXEntity> SelectForSort(StudentXEntity entity,string sortField, bool isDesc)
        {
            return service.StudentX_SelectForSort(entity,sortField,isDesc);
        }
		/// <summary>
        /// 条件查询分页[StudentX]
        /// </summary>
        /// <param name="entity">[StudentX]筛选实例</param>
        /// <param name="Skip">页数</param>
        /// <param name="Count">页条目数量</param>
        /// <returns>[StudentX结果集</returns>
        public IList<StudentXEntity> SelectForPage(StudentXEntity entity,int Skip,int Count)
        {
            return service.StudentX_SelectForPage(entity,Skip,Count);
        }
        /// <summary>
        /// 查询所有[StudentX]
        /// </summary>
        /// <returns></returns>
        public IList<StudentXEntity> Selects()
        {
            return service.StudentX_Selects();
        }
        /// <summary>
        /// 查询所有[StudentX]带排序
        /// </summary>
        /// <param name="sortField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public IList<StudentXEntity> SelectsForSort(string sortField,bool isDesc)
        {
            return service.StudentX_SelectsForSort(sortField,isDesc);
        }

        /// <summary>
        /// 查询所有[StudentX]分页
        /// </summary>
        /// <param name="Skip">页数</param>
        /// <param name="Count">页条目数量</param>
        /// <returns></returns>
        public IList<StudentXEntity> SelectsForPage(int Skip, int Count)
        {
            return service.StudentX_SelectsForPage(Skip,Count);
        }
		#endregion
    }
}
