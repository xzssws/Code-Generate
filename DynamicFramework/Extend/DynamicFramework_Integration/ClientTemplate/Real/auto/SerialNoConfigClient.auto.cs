using System;
using System.Collections.Generic;
using System.Linq;
using ClientTemplate.RealService;

namespace DynamiClient
{
    /// <summary>
    /// [SerialNoConfig]客户端代理类
    /// </summary>
    public sealed partial class SerialNoConfigClient
    {
        #region 单例模式

        private SerialNoConfigClient() { }
    
        private static readonly object LockObj = new object();

        private static SerialNoConfigClient _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static SerialNoConfigClient Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new SerialNoConfigClient();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        private RealSrv service = new RealSrv();

        #region 基础物理操作(增删改)
		/// <summary>
        /// 添加一条[SerialNoConfig]
        /// </summary>
        /// <param name="entity">[SerialNoConfig]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Add(SerialNoConfigEntity entity)
        {
            return service.SerialNoConfig_Add(entity);
        }

        /// <summary>
        /// 更新一条[SerialNoConfig]
        /// </summary>
        /// <param name="entity">更新的[SerialNoConfig]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Update(SerialNoConfigEntity entity)
        {
            return service.SerialNoConfig_Update(entity);
        }

        /// <summary>
        /// 删除一条[SerialNoConfig]
        /// </summary>
        /// <param name="entityID"></param>
        /// <returns>执行完成状态</returns>
        public bool Delete(string entityID)
        {
            return service.SerialNoConfig_Delete(entityID);
        }
		#endregion

		#region 查询操作
		/// <summary>
        /// 条件查询[SerialNoConfig]
        /// </summary>
        /// <param name="entity">[SerialNoConfig]筛选实例</param>
        /// <returns>[SerialNoConfig结果集</returns>
        public IList<SerialNoConfigEntity> Select(SerialNoConfigEntity entity)
        {
            return service.SerialNoConfig_Select(entity);
        }
        /// <summary>
        /// 条件查询排序
        /// </summary>
        /// <param name="entity">筛选实例</param>
        /// <param name="sortField">排序字段名</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
		public IList<SerialNoConfigEntity> SelectForSort(SerialNoConfigEntity entity,string sortField, bool isDesc)
        {
            return service.SerialNoConfig_SelectForSort(entity,sortField,isDesc);
        }
		/// <summary>
        /// 条件查询分页[SerialNoConfig]
        /// </summary>
        /// <param name="entity">[SerialNoConfig]筛选实例</param>
        /// <param name="Skip">页数</param>
        /// <param name="Count">页条目数量</param>
        /// <returns>[SerialNoConfig结果集</returns>
        public IList<SerialNoConfigEntity> SelectForPage(SerialNoConfigEntity entity,int Skip,int Count)
        {
            return service.SerialNoConfig_SelectForPage(entity,Skip,Count);
        }
        /// <summary>
        /// 查询所有[SerialNoConfig]
        /// </summary>
        /// <returns></returns>
        public IList<SerialNoConfigEntity> Selects()
        {
            return service.SerialNoConfig_Selects();
        }
        /// <summary>
        /// 查询所有[SerialNoConfig]带排序
        /// </summary>
        /// <param name="sortField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public IList<SerialNoConfigEntity> SelectsForSort(string sortField,bool isDesc)
        {
            return service.SerialNoConfig_SelectsForSort(sortField,isDesc);
        }

        /// <summary>
        /// 查询所有[SerialNoConfig]分页
        /// </summary>
        /// <param name="Skip">页数</param>
        /// <param name="Count">页条目数量</param>
        /// <returns></returns>
        public IList<SerialNoConfigEntity> SelectsForPage(int Skip, int Count)
        {
            return service.SerialNoConfig_SelectsForPage(Skip,Count);
        }
		#endregion
    }
}
