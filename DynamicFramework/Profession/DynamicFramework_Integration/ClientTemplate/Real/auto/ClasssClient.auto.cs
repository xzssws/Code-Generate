using System;
using System.Collections.Generic;
using System.Linq;
using ClientTemplate.RealService;

namespace DynamiClient
{
    /// <summary>
    /// [Classs]客户端代理类
    /// </summary>
    public sealed partial class ClasssClient
    {
        #region 单例模式

        private ClasssClient() { }
    
        private static readonly object LockObj = new object();

        private static ClasssClient _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static ClasssClient Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new ClasssClient();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        private RealSrv service = new RealSrv();

        #region 基础物理操作(增删改)
		/// <summary>
        /// 添加一条[Classs]
        /// </summary>
        /// <param name="entity">[Classs]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Add(ClasssEntity entity)
        {
            return service.Classs_Add(entity);
        }

        /// <summary>
        /// 更新一条[Classs]
        /// </summary>
        /// <param name="entity">更新的[Classs]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Update(ClasssEntity entity)
        {
            return service.Classs_Update(entity);
        }

        /// <summary>
        /// 删除一条[Classs]
        /// </summary>
        /// <param name="entityID"></param>
        /// <returns>执行完成状态</returns>
        public bool Delete(string entityID)
        {
            return service.Classs_Delete(entityID);
        }
		#endregion

		#region 查询操作
		/// <summary>
        /// 条件查询[Classs]
        /// </summary>
        /// <param name="entity">[Classs]筛选实例</param>
        /// <returns>[Classs结果集</returns>
        public IList<ClasssEntity> Select(ClasssEntity entity)
        {
            return service.Classs_Select(entity);
        }
        /// <summary>
        /// 条件查询排序
        /// </summary>
        /// <param name="entity">筛选实例</param>
        /// <param name="sortField">排序字段名</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
		public IList<ClasssEntity> SelectForSort(ClasssEntity entity,string sortField, bool isDesc)
        {
            return service.Classs_SelectForSort(entity,sortField,isDesc);
        }
		/// <summary>
        /// 条件查询分页[Classs]
        /// </summary>
        /// <param name="entity">[Classs]筛选实例</param>
        /// <param name="Skip">页数</param>
        /// <param name="Count">页条目数量</param>
        /// <returns>[Classs结果集</returns>
        public IList<ClasssEntity> SelectForPage(ClasssEntity entity,int Skip,int Count)
        {
            return service.Classs_SelectForPage(entity,Skip,Count);
        }
        /// <summary>
        /// 查询所有[Classs]
        /// </summary>
        /// <returns></returns>
        public IList<ClasssEntity> Selects()
        {
            return service.Classs_Selects();
        }
        /// <summary>
        /// 查询所有[Classs]带排序
        /// </summary>
        /// <param name="sortField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public IList<ClasssEntity> SelectsForSort(string sortField,bool isDesc)
        {
            return service.Classs_SelectsForSort(sortField,isDesc);
        }

        /// <summary>
        /// 查询所有[Classs]分页
        /// </summary>
        /// <param name="Skip">页数</param>
        /// <param name="Count">页条目数量</param>
        /// <returns></returns>
        public IList<ClasssEntity> SelectsForPage(int Skip, int Count)
        {
            return service.Classs_SelectsForPage(Skip,Count);
        }
		#endregion
    }
}
