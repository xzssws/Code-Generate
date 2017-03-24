using System;
using System.Collections.Generic;
using System.Linq;
using ClientTemplate.RealService;

namespace DynamiClient
{
    /// <summary>
    /// [Parm]客户端代理类
    /// </summary>
    public sealed partial class ParmClient
    {
        #region 单例模式

        private ParmClient() { }
    
        private static readonly object LockObj = new object();

        private static ParmClient _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static ParmClient Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new ParmClient();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        private RealSrv service = new RealSrv();

        #region 基础物理操作(增删改)
		/// <summary>
        /// 添加一条[Parm]
        /// </summary>
        /// <param name="entity">[Parm]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Add(ParmEntity entity)
        {
            return service.Parm_Add(entity);
        }

        /// <summary>
        /// 更新一条[Parm]
        /// </summary>
        /// <param name="entity">更新的[Parm]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Update(ParmEntity entity)
        {
            return service.Parm_Update(entity);
        }

        /// <summary>
        /// 删除一条[Parm]
        /// </summary>
        /// <param name="entityID"></param>
        /// <returns>执行完成状态</returns>
        public bool Delete(string entityID)
        {
            return service.Parm_Delete(entityID);
        }
		#endregion

		#region 查询操作
		/// <summary>
        /// 条件查询[Parm]
        /// </summary>
        /// <param name="entity">[Parm]筛选实例</param>
        /// <returns>[Parm结果集</returns>
        public IList<ParmEntity> Select(ParmEntity entity)
        {
            return service.Parm_Select(entity);
        }
        /// <summary>
        /// 条件查询排序
        /// </summary>
        /// <param name="entity">筛选实例</param>
        /// <param name="sortField">排序字段名</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
		public IList<ParmEntity> SelectForSort(ParmEntity entity,string sortField, bool isDesc)
        {
            return service.Parm_SelectForSort(entity,sortField,isDesc);
        }
		/// <summary>
        /// 条件查询分页[Parm]
        /// </summary>
        /// <param name="entity">[Parm]筛选实例</param>
        /// <param name="Skip">页数</param>
        /// <param name="Count">页条目数量</param>
        /// <returns>[Parm结果集</returns>
        public IList<ParmEntity> SelectForPage(ParmEntity entity,int Skip,int Count)
        {
            return service.Parm_SelectForPage(entity,Skip,Count);
        }
        /// <summary>
        /// 查询所有[Parm]
        /// </summary>
        /// <returns></returns>
        public IList<ParmEntity> Selects()
        {
            return service.Parm_Selects();
        }
        /// <summary>
        /// 查询所有[Parm]带排序
        /// </summary>
        /// <param name="sortField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public IList<ParmEntity> SelectsForSort(string sortField,bool isDesc)
        {
            return service.Parm_SelectsForSort(sortField,isDesc);
        }

        /// <summary>
        /// 查询所有[Parm]分页
        /// </summary>
        /// <param name="Skip">页数</param>
        /// <param name="Count">页条目数量</param>
        /// <returns></returns>
        public IList<ParmEntity> SelectsForPage(int Skip, int Count)
        {
            return service.Parm_SelectsForPage(Skip,Count);
        }
		#endregion
    }
}
