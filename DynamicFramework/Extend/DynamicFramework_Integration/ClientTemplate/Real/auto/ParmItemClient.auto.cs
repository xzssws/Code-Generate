using System;
using System.Collections.Generic;
using System.Linq;
using ClientTemplate.RealService;

namespace DynamiClient
{
    /// <summary>
    /// [ParmItem]客户端代理类
    /// </summary>
    public sealed partial class ParmItemClient
    {
        #region 单例模式

        private ParmItemClient() { }
    
        private static readonly object LockObj = new object();

        private static ParmItemClient _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static ParmItemClient Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new ParmItemClient();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        private RealSrv service = new RealSrv();

        #region 基础物理操作(增删改)
		/// <summary>
        /// 添加一条[ParmItem]
        /// </summary>
        /// <param name="entity">[ParmItem]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Add(ParmItemEntity entity)
        {
            return service.ParmItem_Add(entity);
        }

        /// <summary>
        /// 更新一条[ParmItem]
        /// </summary>
        /// <param name="entity">更新的[ParmItem]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Update(ParmItemEntity entity)
        {
            return service.ParmItem_Update(entity);
        }

        /// <summary>
        /// 删除一条[ParmItem]
        /// </summary>
        /// <param name="entityID"></param>
        /// <returns>执行完成状态</returns>
        public bool Delete(string entityID)
        {
            return service.ParmItem_Delete(entityID);
        }
		#endregion

		#region 查询操作
		/// <summary>
        /// 条件查询[ParmItem]
        /// </summary>
        /// <param name="entity">[ParmItem]筛选实例</param>
        /// <returns>[ParmItem结果集</returns>
        public IList<ParmItemEntity> Select(ParmItemEntity entity)
        {
            return service.ParmItem_Select(entity);
        }
        /// <summary>
        /// 条件查询排序
        /// </summary>
        /// <param name="entity">筛选实例</param>
        /// <param name="sortField">排序字段名</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
		public IList<ParmItemEntity> SelectForSort(ParmItemEntity entity,string sortField, bool isDesc)
        {
            return service.ParmItem_SelectForSort(entity,sortField,isDesc);
        }
		/// <summary>
        /// 条件查询分页[ParmItem]
        /// </summary>
        /// <param name="entity">[ParmItem]筛选实例</param>
        /// <param name="Skip">页数</param>
        /// <param name="Count">页条目数量</param>
        /// <returns>[ParmItem结果集</returns>
        public IList<ParmItemEntity> SelectForPage(ParmItemEntity entity,int Skip,int Count)
        {
            return service.ParmItem_SelectForPage(entity,Skip,Count);
        }
        /// <summary>
        /// 查询所有[ParmItem]
        /// </summary>
        /// <returns></returns>
        public IList<ParmItemEntity> Selects()
        {
            return service.ParmItem_Selects();
        }
        /// <summary>
        /// 查询所有[ParmItem]带排序
        /// </summary>
        /// <param name="sortField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public IList<ParmItemEntity> SelectsForSort(string sortField,bool isDesc)
        {
            return service.ParmItem_SelectsForSort(sortField,isDesc);
        }

        /// <summary>
        /// 查询所有[ParmItem]分页
        /// </summary>
        /// <param name="Skip">页数</param>
        /// <param name="Count">页条目数量</param>
        /// <returns></returns>
        public IList<ParmItemEntity> SelectsForPage(int Skip, int Count)
        {
            return service.ParmItem_SelectsForPage(Skip,Count);
        }
		#endregion
    }
}
