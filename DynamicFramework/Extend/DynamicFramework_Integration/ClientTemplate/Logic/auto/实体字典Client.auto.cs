using System;
using System.Collections.Generic;
using System.Linq;
using ClientTemplate.LogicService;

namespace DynamiClient
{
    /// <summary>
    /// [实体字典]客户端代理类
    /// </summary>
    public sealed partial class 实体字典Client
    {
        #region 单例模式

        private 实体字典Client() { }
    
        private static readonly object LockObj = new object();

        private static 实体字典Client _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static 实体字典Client Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new 实体字典Client();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        private LogicSrv service = new LogicSrv();

		#region 查询操作
		/// <summary>
        /// 条件查询[实体字典]
        /// </summary>
        /// <param name="entity">[实体字典]筛选实例</param>
        /// <returns>[实体字典结果集</returns>
        public IList<实体字典Entity> Select(实体字典Entity entity)
        {
            return service.实体字典_Select(entity);
        }
        /// <summary>
        /// 条件查询排序
        /// </summary>
        /// <param name="entity">筛选实例</param>
        /// <param name="sortField">排序字段名</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
		public IList<实体字典Entity> SelectForSort(实体字典Entity entity,string sortField, bool isDesc)
        {
            return service.实体字典_SelectForSort(entity,sortField,isDesc);
        }
		/// <summary>
        /// 条件查询分页[实体字典]
        /// </summary>
        /// <param name="entity">[实体字典]筛选实例</param>
        /// <param name="Skip">页数</param>
        /// <param name="Count">页条目数量</param>
        /// <returns>[实体字典结果集</returns>
        public IList<实体字典Entity> SelectForPage(实体字典Entity entity,int Skip,int Count)
        {
            return service.实体字典_SelectForPage(entity,Skip,Count);
        }
        /// <summary>
        /// 查询所有[实体字典]
        /// </summary>
        /// <returns></returns>
        public IList<实体字典Entity> Selects()
        {
            return service.实体字典_Selects();
        }
        /// <summary>
        /// 查询所有[实体字典]带排序
        /// </summary>
        /// <param name="sortField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public IList<实体字典Entity> SelectsForSort(string sortField,bool isDesc)
        {
            return service.实体字典_SelectsForSort(sortField,isDesc);
        }

        /// <summary>
        /// 查询所有[实体字典]分页
        /// </summary>
        /// <param name="Skip">页数</param>
        /// <param name="Count">页条目数量</param>
        /// <returns></returns>
        public IList<实体字典Entity> SelectsForPage(int Skip, int Count)
        {
            return service.实体字典_SelectsForPage(Skip,Count);
        }
		#endregion
    }
}
