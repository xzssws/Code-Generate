using System;
using System.Collections.Generic;
using System.Linq;
using ClientTemplate.RealService;

namespace DynamiClient
{
    /// <summary>
    /// [JG_AmountCollect]客户端代理类
    /// </summary>
    public sealed partial class JG_AmountCollectClient
    {
        #region 单例模式

        private JG_AmountCollectClient() { }
    
        private static readonly object LockObj = new object();

        private static JG_AmountCollectClient _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static JG_AmountCollectClient Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new JG_AmountCollectClient();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        private RealSrv service = new RealSrv();

        #region 基础物理操作(增删改)
		/// <summary>
        /// 添加一条[JG_AmountCollect]
        /// </summary>
        /// <param name="entity">[JG_AmountCollect]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Add(JG_AmountCollectEntity entity)
        {
            return service.JG_AmountCollect_Add(entity);
        }

        /// <summary>
        /// 更新一条[JG_AmountCollect]
        /// </summary>
        /// <param name="entity">更新的[JG_AmountCollect]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Update(JG_AmountCollectEntity entity)
        {
            return service.JG_AmountCollect_Update(entity);
        }

        /// <summary>
        /// 删除一条[JG_AmountCollect]
        /// </summary>
        /// <param name="entityID"></param>
        /// <returns>执行完成状态</returns>
        public bool Delete(string entityID)
        {
            return service.JG_AmountCollect_Delete(entityID);
        }
		#endregion

		#region 查询操作
		/// <summary>
        /// 条件查询[JG_AmountCollect]
        /// </summary>
        /// <param name="entity">[JG_AmountCollect]筛选实例</param>
        /// <returns>[JG_AmountCollect结果集</returns>
        public IList<JG_AmountCollectEntity> Select(JG_AmountCollectEntity entity)
        {
            return service.JG_AmountCollect_Select(entity);
        }
        /// <summary>
        /// 条件查询排序
        /// </summary>
        /// <param name="entity">筛选实例</param>
        /// <param name="sortField">排序字段名</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
		public IList<JG_AmountCollectEntity> SelectForSort(JG_AmountCollectEntity entity,string sortField, bool isDesc)
        {
            return service.JG_AmountCollect_SelectForSort(entity,sortField,isDesc);
        }
		/// <summary>
        /// 条件查询分页[JG_AmountCollect]
        /// </summary>
        /// <param name="entity">[JG_AmountCollect]筛选实例</param>
        /// <param name="Skip">页数</param>
        /// <param name="Count">页条目数量</param>
        /// <returns>[JG_AmountCollect结果集</returns>
        public IList<JG_AmountCollectEntity> SelectForPage(JG_AmountCollectEntity entity,int Skip,int Count)
        {
            return service.JG_AmountCollect_SelectForPage(entity,Skip,Count);
        }
        /// <summary>
        /// 查询所有[JG_AmountCollect]
        /// </summary>
        /// <returns></returns>
        public IList<JG_AmountCollectEntity> Selects()
        {
            return service.JG_AmountCollect_Selects();
        }
        /// <summary>
        /// 查询所有[JG_AmountCollect]带排序
        /// </summary>
        /// <param name="sortField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public IList<JG_AmountCollectEntity> SelectsForSort(string sortField,bool isDesc)
        {
            return service.JG_AmountCollect_SelectsForSort(sortField,isDesc);
        }

        /// <summary>
        /// 查询所有[JG_AmountCollect]分页
        /// </summary>
        /// <param name="Skip">页数</param>
        /// <param name="Count">页条目数量</param>
        /// <returns></returns>
        public IList<JG_AmountCollectEntity> SelectsForPage(int Skip, int Count)
        {
            return service.JG_AmountCollect_SelectsForPage(Skip,Count);
        }
		#endregion
    }
}
