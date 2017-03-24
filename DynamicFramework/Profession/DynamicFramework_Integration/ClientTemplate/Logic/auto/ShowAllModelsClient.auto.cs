using System;
using System.Collections.Generic;
using System.Linq;
using ClientTemplate.LogicService;

namespace DynamiClient
{
    /// <summary>
    /// [ShowAllModels]客户端代理类
    /// </summary>
    public sealed partial class ShowAllModelsClient
    {
        #region 单例模式

        private ShowAllModelsClient() { }
    
        private static readonly object LockObj = new object();

        private static ShowAllModelsClient _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static ShowAllModelsClient Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new ShowAllModelsClient();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        private LogicSrv service = new LogicSrv();

		#region 查询操作
		/// <summary>
        /// 条件查询[ShowAllModels]
        /// </summary>
        /// <param name="entity">[ShowAllModels]筛选实例</param>
        /// <returns>[ShowAllModels结果集</returns>
        public IList<ShowAllModelsEntity> Select(ShowAllModelsEntity entity)
        {
            return service.ShowAllModels_Select(entity);
        }
        /// <summary>
        /// 条件查询排序
        /// </summary>
        /// <param name="entity">筛选实例</param>
        /// <param name="sortField">排序字段名</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
		public IList<ShowAllModelsEntity> SelectForSort(ShowAllModelsEntity entity,string sortField, bool isDesc)
        {
            return service.ShowAllModels_SelectForSort(entity,sortField,isDesc);
        }
		/// <summary>
        /// 条件查询分页[ShowAllModels]
        /// </summary>
        /// <param name="entity">[ShowAllModels]筛选实例</param>
        /// <param name="Skip">页数</param>
        /// <param name="Count">页条目数量</param>
        /// <returns>[ShowAllModels结果集</returns>
        public IList<ShowAllModelsEntity> SelectForPage(ShowAllModelsEntity entity,int Skip,int Count)
        {
            return service.ShowAllModels_SelectForPage(entity,Skip,Count);
        }
        /// <summary>
        /// 查询所有[ShowAllModels]
        /// </summary>
        /// <returns></returns>
        public IList<ShowAllModelsEntity> Selects()
        {
            return service.ShowAllModels_Selects();
        }
        /// <summary>
        /// 查询所有[ShowAllModels]带排序
        /// </summary>
        /// <param name="sortField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public IList<ShowAllModelsEntity> SelectsForSort(string sortField,bool isDesc)
        {
            return service.ShowAllModels_SelectsForSort(sortField,isDesc);
        }

        /// <summary>
        /// 查询所有[ShowAllModels]分页
        /// </summary>
        /// <param name="Skip">页数</param>
        /// <param name="Count">页条目数量</param>
        /// <returns></returns>
        public IList<ShowAllModelsEntity> SelectsForPage(int Skip, int Count)
        {
            return service.ShowAllModels_SelectsForPage(Skip,Count);
        }
		#endregion
    }
}
