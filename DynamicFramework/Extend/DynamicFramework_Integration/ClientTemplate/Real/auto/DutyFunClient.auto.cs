using System;
using System.Collections.Generic;
using System.Linq;
using ClientTemplate.RealService;

namespace DynamiClient
{
    /// <summary>
    /// [DutyFun]客户端代理类
    /// </summary>
    public sealed partial class DutyFunClient
    {
        #region 单例模式

        private DutyFunClient() { }
    
        private static readonly object LockObj = new object();

        private static DutyFunClient _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static DutyFunClient Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new DutyFunClient();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        private RealSrv service = new RealSrv();

        #region 基础物理操作(增删改)
		/// <summary>
        /// 添加一条[DutyFun]
        /// </summary>
        /// <param name="entity">[DutyFun]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Add(DutyFunEntity entity)
        {
            return service.DutyFun_Add(entity);
        }

        /// <summary>
        /// 更新一条[DutyFun]
        /// </summary>
        /// <param name="entity">更新的[DutyFun]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Update(DutyFunEntity entity)
        {
            return service.DutyFun_Update(entity);
        }

        /// <summary>
        /// 删除一条[DutyFun]
        /// </summary>
        /// <param name="entityID"></param>
        /// <returns>执行完成状态</returns>
        public bool Delete(string entityID)
        {
            return service.DutyFun_Delete(entityID);
        }
		#endregion

		#region 查询操作
		/// <summary>
        /// 条件查询[DutyFun]
        /// </summary>
        /// <param name="entity">[DutyFun]筛选实例</param>
        /// <returns>[DutyFun结果集</returns>
        public IList<DutyFunEntity> Select(DutyFunEntity entity)
        {
            return service.DutyFun_Select(entity);
        }
        /// <summary>
        /// 条件查询排序
        /// </summary>
        /// <param name="entity">筛选实例</param>
        /// <param name="sortField">排序字段名</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
		public IList<DutyFunEntity> SelectForSort(DutyFunEntity entity,string sortField, bool isDesc)
        {
            return service.DutyFun_SelectForSort(entity,sortField,isDesc);
        }
		/// <summary>
        /// 条件查询分页[DutyFun]
        /// </summary>
        /// <param name="entity">[DutyFun]筛选实例</param>
        /// <param name="Skip">页数</param>
        /// <param name="Count">页条目数量</param>
        /// <returns>[DutyFun结果集</returns>
        public IList<DutyFunEntity> SelectForPage(DutyFunEntity entity,int Skip,int Count)
        {
            return service.DutyFun_SelectForPage(entity,Skip,Count);
        }
        /// <summary>
        /// 查询所有[DutyFun]
        /// </summary>
        /// <returns></returns>
        public IList<DutyFunEntity> Selects()
        {
            return service.DutyFun_Selects();
        }
        /// <summary>
        /// 查询所有[DutyFun]带排序
        /// </summary>
        /// <param name="sortField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public IList<DutyFunEntity> SelectsForSort(string sortField,bool isDesc)
        {
            return service.DutyFun_SelectsForSort(sortField,isDesc);
        }

        /// <summary>
        /// 查询所有[DutyFun]分页
        /// </summary>
        /// <param name="Skip">页数</param>
        /// <param name="Count">页条目数量</param>
        /// <returns></returns>
        public IList<DutyFunEntity> SelectsForPage(int Skip, int Count)
        {
            return service.DutyFun_SelectsForPage(Skip,Count);
        }
		#endregion
    }
}
