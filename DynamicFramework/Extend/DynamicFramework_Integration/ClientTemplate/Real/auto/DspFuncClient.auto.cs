using System;
using System.Collections.Generic;
using System.Linq;
using ClientTemplate.RealService;

namespace DynamiClient
{
    /// <summary>
    /// [DspFunc]客户端代理类
    /// </summary>
    public sealed partial class DspFuncClient
    {
        #region 单例模式

        private DspFuncClient() { }
    
        private static readonly object LockObj = new object();

        private static DspFuncClient _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static DspFuncClient Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new DspFuncClient();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        private RealSrv service = new RealSrv();

        #region 基础物理操作(增删改)
		/// <summary>
        /// 添加一条[DspFunc]
        /// </summary>
        /// <param name="entity">[DspFunc]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Add(DspFuncEntity entity)
        {
            return service.DspFunc_Add(entity);
        }

        /// <summary>
        /// 更新一条[DspFunc]
        /// </summary>
        /// <param name="entity">更新的[DspFunc]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Update(DspFuncEntity entity)
        {
            return service.DspFunc_Update(entity);
        }

        /// <summary>
        /// 删除一条[DspFunc]
        /// </summary>
        /// <param name="entityID"></param>
        /// <returns>执行完成状态</returns>
        public bool Delete(string entityID)
        {
            return service.DspFunc_Delete(entityID);
        }
		#endregion

		#region 查询操作
		/// <summary>
        /// 条件查询[DspFunc]
        /// </summary>
        /// <param name="entity">[DspFunc]筛选实例</param>
        /// <returns>[DspFunc结果集</returns>
        public IList<DspFuncEntity> Select(DspFuncEntity entity)
        {
            return service.DspFunc_Select(entity);
        }
        /// <summary>
        /// 条件查询排序
        /// </summary>
        /// <param name="entity">筛选实例</param>
        /// <param name="sortField">排序字段名</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
		public IList<DspFuncEntity> SelectForSort(DspFuncEntity entity,string sortField, bool isDesc)
        {
            return service.DspFunc_SelectForSort(entity,sortField,isDesc);
        }
		/// <summary>
        /// 条件查询分页[DspFunc]
        /// </summary>
        /// <param name="entity">[DspFunc]筛选实例</param>
        /// <param name="Skip">页数</param>
        /// <param name="Count">页条目数量</param>
        /// <returns>[DspFunc结果集</returns>
        public IList<DspFuncEntity> SelectForPage(DspFuncEntity entity,int Skip,int Count)
        {
            return service.DspFunc_SelectForPage(entity,Skip,Count);
        }
        /// <summary>
        /// 查询所有[DspFunc]
        /// </summary>
        /// <returns></returns>
        public IList<DspFuncEntity> Selects()
        {
            return service.DspFunc_Selects();
        }
        /// <summary>
        /// 查询所有[DspFunc]带排序
        /// </summary>
        /// <param name="sortField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public IList<DspFuncEntity> SelectsForSort(string sortField,bool isDesc)
        {
            return service.DspFunc_SelectsForSort(sortField,isDesc);
        }

        /// <summary>
        /// 查询所有[DspFunc]分页
        /// </summary>
        /// <param name="Skip">页数</param>
        /// <param name="Count">页条目数量</param>
        /// <returns></returns>
        public IList<DspFuncEntity> SelectsForPage(int Skip, int Count)
        {
            return service.DspFunc_SelectsForPage(Skip,Count);
        }
		#endregion
    }
}
