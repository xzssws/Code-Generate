using System;
using System.Collections.Generic;
using System.Linq;
using ClientTemplate.RealService;

namespace DynamiClient
{
    /// <summary>
    /// [JG_Adjust]客户端代理类
    /// </summary>
    public sealed partial class JG_AdjustClient
    {
        #region 单例模式

        private JG_AdjustClient() { }
    
        private static readonly object LockObj = new object();

        private static JG_AdjustClient _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static JG_AdjustClient Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new JG_AdjustClient();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        private RealSrv service = new RealSrv();

        #region 基础物理操作(增删改)
		/// <summary>
        /// 添加一条[JG_Adjust]
        /// </summary>
        /// <param name="entity">[JG_Adjust]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Add(JG_AdjustEntity entity)
        {
            return service.JG_Adjust_Add(entity);
        }

        /// <summary>
        /// 更新一条[JG_Adjust]
        /// </summary>
        /// <param name="entity">更新的[JG_Adjust]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Update(JG_AdjustEntity entity)
        {
            return service.JG_Adjust_Update(entity);
        }

        /// <summary>
        /// 删除一条[JG_Adjust]
        /// </summary>
        /// <param name="entityID"></param>
        /// <returns>执行完成状态</returns>
        public bool Delete(string entityID)
        {
            return service.JG_Adjust_Delete(entityID);
        }
		#endregion

		#region 查询操作
		/// <summary>
        /// 条件查询[JG_Adjust]
        /// </summary>
        /// <param name="entity">[JG_Adjust]筛选实例</param>
        /// <returns>[JG_Adjust结果集</returns>
        public IList<JG_AdjustEntity> Select(JG_AdjustEntity entity)
        {
            return service.JG_Adjust_Select(entity);
        }
        /// <summary>
        /// 条件查询排序
        /// </summary>
        /// <param name="entity">筛选实例</param>
        /// <param name="sortField">排序字段名</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
		public IList<JG_AdjustEntity> SelectForSort(JG_AdjustEntity entity,string sortField, bool isDesc)
        {
            return service.JG_Adjust_SelectForSort(entity,sortField,isDesc);
        }
		/// <summary>
        /// 条件查询分页[JG_Adjust]
        /// </summary>
        /// <param name="entity">[JG_Adjust]筛选实例</param>
        /// <param name="Skip">页数</param>
        /// <param name="Count">页条目数量</param>
        /// <returns>[JG_Adjust结果集</returns>
        public IList<JG_AdjustEntity> SelectForPage(JG_AdjustEntity entity,int Skip,int Count)
        {
            return service.JG_Adjust_SelectForPage(entity,Skip,Count);
        }
        /// <summary>
        /// 查询所有[JG_Adjust]
        /// </summary>
        /// <returns></returns>
        public IList<JG_AdjustEntity> Selects()
        {
            return service.JG_Adjust_Selects();
        }
        /// <summary>
        /// 查询所有[JG_Adjust]带排序
        /// </summary>
        /// <param name="sortField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public IList<JG_AdjustEntity> SelectsForSort(string sortField,bool isDesc)
        {
            return service.JG_Adjust_SelectsForSort(sortField,isDesc);
        }

        /// <summary>
        /// 查询所有[JG_Adjust]分页
        /// </summary>
        /// <param name="Skip">页数</param>
        /// <param name="Count">页条目数量</param>
        /// <returns></returns>
        public IList<JG_AdjustEntity> SelectsForPage(int Skip, int Count)
        {
            return service.JG_Adjust_SelectsForPage(Skip,Count);
        }
		#endregion
    }
}
