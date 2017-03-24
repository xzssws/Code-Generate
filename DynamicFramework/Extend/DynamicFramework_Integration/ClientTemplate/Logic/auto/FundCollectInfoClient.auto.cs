using System;
using System.Collections.Generic;
using System.Linq;
using ClientTemplate.LogicService;

namespace DynamiClient
{
    /// <summary>
    /// [FundCollectInfo]客户端代理类
    /// </summary>
    public sealed partial class FundCollectInfoClient
    {
        #region 单例模式

        private FundCollectInfoClient() { }
    
        private static readonly object LockObj = new object();

        private static FundCollectInfoClient _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static FundCollectInfoClient Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new FundCollectInfoClient();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        private LogicSrv service = new LogicSrv();

		#region 查询操作
		/// <summary>
        /// 条件查询[FundCollectInfo]
        /// </summary>
        /// <param name="entity">[FundCollectInfo]筛选实例</param>
        /// <returns>[FundCollectInfo结果集</returns>
        public IList<FundCollectInfoEntity> Select(FundCollectInfoEntity entity)
        {
            return service.FundCollectInfo_Select(entity);
        }
        /// <summary>
        /// 条件查询排序
        /// </summary>
        /// <param name="entity">筛选实例</param>
        /// <param name="sortField">排序字段名</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
		public IList<FundCollectInfoEntity> SelectForSort(FundCollectInfoEntity entity,string sortField, bool isDesc)
        {
            return service.FundCollectInfo_SelectForSort(entity,sortField,isDesc);
        }
		/// <summary>
        /// 条件查询分页[FundCollectInfo]
        /// </summary>
        /// <param name="entity">[FundCollectInfo]筛选实例</param>
        /// <param name="Skip">页数</param>
        /// <param name="Count">页条目数量</param>
        /// <returns>[FundCollectInfo结果集</returns>
        public IList<FundCollectInfoEntity> SelectForPage(FundCollectInfoEntity entity,int Skip,int Count)
        {
            return service.FundCollectInfo_SelectForPage(entity,Skip,Count);
        }
        /// <summary>
        /// 查询所有[FundCollectInfo]
        /// </summary>
        /// <returns></returns>
        public IList<FundCollectInfoEntity> Selects()
        {
            return service.FundCollectInfo_Selects();
        }
        /// <summary>
        /// 查询所有[FundCollectInfo]带排序
        /// </summary>
        /// <param name="sortField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public IList<FundCollectInfoEntity> SelectsForSort(string sortField,bool isDesc)
        {
            return service.FundCollectInfo_SelectsForSort(sortField,isDesc);
        }

        /// <summary>
        /// 查询所有[FundCollectInfo]分页
        /// </summary>
        /// <param name="Skip">页数</param>
        /// <param name="Count">页条目数量</param>
        /// <returns></returns>
        public IList<FundCollectInfoEntity> SelectsForPage(int Skip, int Count)
        {
            return service.FundCollectInfo_SelectsForPage(Skip,Count);
        }
		#endregion
    }
}
