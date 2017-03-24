using System;
using System.Collections.Generic;
using System.Linq;
using ClientTemplate.RealService;

namespace DynamiClient
{
    /// <summary>
    /// [Duty]客户端代理类
    /// </summary>
    public sealed partial class DutyClient
    {
        #region 单例模式

        private DutyClient() { }
    
        private static readonly object LockObj = new object();

        private static DutyClient _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static DutyClient Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new DutyClient();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        private RealSrv service = new RealSrv();

        #region 基础物理操作(增删改)
		/// <summary>
        /// 添加一条[Duty]
        /// </summary>
        /// <param name="entity">[Duty]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Add(DutyEntity entity)
        {
            return service.Duty_Add(entity);
        }

        /// <summary>
        /// 更新一条[Duty]
        /// </summary>
        /// <param name="entity">更新的[Duty]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Update(DutyEntity entity)
        {
            return service.Duty_Update(entity);
        }

        /// <summary>
        /// 删除一条[Duty]
        /// </summary>
        /// <param name="entityID"></param>
        /// <returns>执行完成状态</returns>
        public bool Delete(string entityID)
        {
            return service.Duty_Delete(entityID);
        }
		#endregion

		#region 查询操作
		/// <summary>
        /// 条件查询[Duty]
        /// </summary>
        /// <param name="entity">[Duty]筛选实例</param>
        /// <returns>[Duty结果集</returns>
        public IList<DutyEntity> Select(DutyEntity entity)
        {
            return service.Duty_Select(entity);
        }
        /// <summary>
        /// 条件查询排序
        /// </summary>
        /// <param name="entity">筛选实例</param>
        /// <param name="sortField">排序字段名</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
		public IList<DutyEntity> SelectForSort(DutyEntity entity,string sortField, bool isDesc)
        {
            return service.Duty_SelectForSort(entity,sortField,isDesc);
        }
		/// <summary>
        /// 条件查询分页[Duty]
        /// </summary>
        /// <param name="entity">[Duty]筛选实例</param>
        /// <param name="Skip">页数</param>
        /// <param name="Count">页条目数量</param>
        /// <returns>[Duty结果集</returns>
        public IList<DutyEntity> SelectForPage(DutyEntity entity,int Skip,int Count)
        {
            return service.Duty_SelectForPage(entity,Skip,Count);
        }
        /// <summary>
        /// 查询所有[Duty]
        /// </summary>
        /// <returns></returns>
        public IList<DutyEntity> Selects()
        {
            return service.Duty_Selects();
        }
        /// <summary>
        /// 查询所有[Duty]带排序
        /// </summary>
        /// <param name="sortField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public IList<DutyEntity> SelectsForSort(string sortField,bool isDesc)
        {
            return service.Duty_SelectsForSort(sortField,isDesc);
        }

        /// <summary>
        /// 查询所有[Duty]分页
        /// </summary>
        /// <param name="Skip">页数</param>
        /// <param name="Count">页条目数量</param>
        /// <returns></returns>
        public IList<DutyEntity> SelectsForPage(int Skip, int Count)
        {
            return service.Duty_SelectsForPage(Skip,Count);
        }
		#endregion
    }
}
