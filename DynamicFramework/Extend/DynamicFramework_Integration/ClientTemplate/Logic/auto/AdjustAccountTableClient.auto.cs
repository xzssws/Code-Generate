using System;
using System.Collections.Generic;
using System.Linq;
using ClientTemplate.LogicService;

namespace DynamiClient
{
    /// <summary>
    /// [AdjustAccountTable]客户端代理类
    /// </summary>
    public sealed partial class AdjustAccountTableClient
    {
        #region 单例模式

        private AdjustAccountTableClient() { }
    
        private static readonly object LockObj = new object();

        private static AdjustAccountTableClient _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static AdjustAccountTableClient Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new AdjustAccountTableClient();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        private LogicSrv service = new LogicSrv();

		#region 查询操作
		/// <summary>
        /// 条件查询[AdjustAccountTable]
        /// </summary>
        /// <param name="entity">[AdjustAccountTable]筛选实例</param>
        /// <returns>[AdjustAccountTable结果集</returns>
        public IList<AdjustAccountTableEntity> Select(AdjustAccountTableEntity entity)
        {
            return service.AdjustAccountTable_Select(entity);
        }
        /// <summary>
        /// 条件查询排序
        /// </summary>
        /// <param name="entity">筛选实例</param>
        /// <param name="sortField">排序字段名</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
		public IList<AdjustAccountTableEntity> SelectForSort(AdjustAccountTableEntity entity,string sortField, bool isDesc)
        {
            return service.AdjustAccountTable_SelectForSort(entity,sortField,isDesc);
        }
		/// <summary>
        /// 条件查询分页[AdjustAccountTable]
        /// </summary>
        /// <param name="entity">[AdjustAccountTable]筛选实例</param>
        /// <param name="Skip">页数</param>
        /// <param name="Count">页条目数量</param>
        /// <returns>[AdjustAccountTable结果集</returns>
        public IList<AdjustAccountTableEntity> SelectForPage(AdjustAccountTableEntity entity,int Skip,int Count)
        {
            return service.AdjustAccountTable_SelectForPage(entity,Skip,Count);
        }
        /// <summary>
        /// 查询所有[AdjustAccountTable]
        /// </summary>
        /// <returns></returns>
        public IList<AdjustAccountTableEntity> Selects()
        {
            return service.AdjustAccountTable_Selects();
        }
        /// <summary>
        /// 查询所有[AdjustAccountTable]带排序
        /// </summary>
        /// <param name="sortField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public IList<AdjustAccountTableEntity> SelectsForSort(string sortField,bool isDesc)
        {
            return service.AdjustAccountTable_SelectsForSort(sortField,isDesc);
        }

        /// <summary>
        /// 查询所有[AdjustAccountTable]分页
        /// </summary>
        /// <param name="Skip">页数</param>
        /// <param name="Count">页条目数量</param>
        /// <returns></returns>
        public IList<AdjustAccountTableEntity> SelectsForPage(int Skip, int Count)
        {
            return service.AdjustAccountTable_SelectsForPage(Skip,Count);
        }
		#endregion
    }
}
