using System;
using System.Collections.Generic;
using System.Linq;
using ClientTemplate.RealService;

namespace DynamiClient
{
    /// <summary>
    /// [SysConfig]客户端代理类
    /// </summary>
    public sealed partial class SysConfigClient
    {
        #region 单例模式

        private SysConfigClient() { }
    
        private static readonly object LockObj = new object();

        private static SysConfigClient _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static SysConfigClient Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new SysConfigClient();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        private RealSrv service = new RealSrv();

        #region 基础物理操作(增删改)
		/// <summary>
        /// 添加一条[SysConfig]
        /// </summary>
        /// <param name="entity">[SysConfig]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Add(SysConfigEntity entity)
        {
            return service.SysConfig_Add(entity);
        }

        /// <summary>
        /// 更新一条[SysConfig]
        /// </summary>
        /// <param name="entity">更新的[SysConfig]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Update(SysConfigEntity entity)
        {
            return service.SysConfig_Update(entity);
        }

        /// <summary>
        /// 删除一条[SysConfig]
        /// </summary>
        /// <param name="entityID"></param>
        /// <returns>执行完成状态</returns>
        public bool Delete(string entityID)
        {
            return service.SysConfig_Delete(entityID);
        }
		#endregion

		#region 查询操作
		/// <summary>
        /// 条件查询[SysConfig]
        /// </summary>
        /// <param name="entity">[SysConfig]筛选实例</param>
        /// <returns>[SysConfig结果集</returns>
        public IList<SysConfigEntity> Select(SysConfigEntity entity)
        {
            return service.SysConfig_Select(entity);
        }
        /// <summary>
        /// 条件查询排序
        /// </summary>
        /// <param name="entity">筛选实例</param>
        /// <param name="sortField">排序字段名</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
		public IList<SysConfigEntity> SelectForSort(SysConfigEntity entity,string sortField, bool isDesc)
        {
            return service.SysConfig_SelectForSort(entity,sortField,isDesc);
        }
		/// <summary>
        /// 条件查询分页[SysConfig]
        /// </summary>
        /// <param name="entity">[SysConfig]筛选实例</param>
        /// <param name="Skip">页数</param>
        /// <param name="Count">页条目数量</param>
        /// <returns>[SysConfig结果集</returns>
        public IList<SysConfigEntity> SelectForPage(SysConfigEntity entity,int Skip,int Count)
        {
            return service.SysConfig_SelectForPage(entity,Skip,Count);
        }
        /// <summary>
        /// 查询所有[SysConfig]
        /// </summary>
        /// <returns></returns>
        public IList<SysConfigEntity> Selects()
        {
            return service.SysConfig_Selects();
        }
        /// <summary>
        /// 查询所有[SysConfig]带排序
        /// </summary>
        /// <param name="sortField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public IList<SysConfigEntity> SelectsForSort(string sortField,bool isDesc)
        {
            return service.SysConfig_SelectsForSort(sortField,isDesc);
        }

        /// <summary>
        /// 查询所有[SysConfig]分页
        /// </summary>
        /// <param name="Skip">页数</param>
        /// <param name="Count">页条目数量</param>
        /// <returns></returns>
        public IList<SysConfigEntity> SelectsForPage(int Skip, int Count)
        {
            return service.SysConfig_SelectsForPage(Skip,Count);
        }
		#endregion
    }
}
