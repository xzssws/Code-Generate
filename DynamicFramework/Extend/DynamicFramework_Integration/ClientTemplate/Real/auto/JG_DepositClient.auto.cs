using System;
using System.Collections.Generic;
using System.Linq;
using ClientTemplate.RealService;

namespace DynamiClient
{
    /// <summary>
    /// [JG_Deposit]客户端代理类
    /// </summary>
    public sealed partial class JG_DepositClient
    {
        #region 单例模式

        private JG_DepositClient() { }
    
        private static readonly object LockObj = new object();

        private static JG_DepositClient _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static JG_DepositClient Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new JG_DepositClient();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        private RealSrv service = new RealSrv();

        #region 基础物理操作(增删改)
		/// <summary>
        /// 添加一条[JG_Deposit]
        /// </summary>
        /// <param name="entity">[JG_Deposit]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Add(JG_DepositEntity entity)
        {
            return service.JG_Deposit_Add(entity);
        }

        /// <summary>
        /// 更新一条[JG_Deposit]
        /// </summary>
        /// <param name="entity">更新的[JG_Deposit]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Update(JG_DepositEntity entity)
        {
            return service.JG_Deposit_Update(entity);
        }

        /// <summary>
        /// 删除一条[JG_Deposit]
        /// </summary>
        /// <param name="entityID"></param>
        /// <returns>执行完成状态</returns>
        public bool Delete(string entityID)
        {
            return service.JG_Deposit_Delete(entityID);
        }
		#endregion

		#region 查询操作
		/// <summary>
        /// 条件查询[JG_Deposit]
        /// </summary>
        /// <param name="entity">[JG_Deposit]筛选实例</param>
        /// <returns>[JG_Deposit结果集</returns>
        public IList<JG_DepositEntity> Select(JG_DepositEntity entity)
        {
            return service.JG_Deposit_Select(entity);
        }
        /// <summary>
        /// 条件查询排序
        /// </summary>
        /// <param name="entity">筛选实例</param>
        /// <param name="sortField">排序字段名</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
		public IList<JG_DepositEntity> SelectForSort(JG_DepositEntity entity,string sortField, bool isDesc)
        {
            return service.JG_Deposit_SelectForSort(entity,sortField,isDesc);
        }
		/// <summary>
        /// 条件查询分页[JG_Deposit]
        /// </summary>
        /// <param name="entity">[JG_Deposit]筛选实例</param>
        /// <param name="Skip">页数</param>
        /// <param name="Count">页条目数量</param>
        /// <returns>[JG_Deposit结果集</returns>
        public IList<JG_DepositEntity> SelectForPage(JG_DepositEntity entity,int Skip,int Count)
        {
            return service.JG_Deposit_SelectForPage(entity,Skip,Count);
        }
        /// <summary>
        /// 查询所有[JG_Deposit]
        /// </summary>
        /// <returns></returns>
        public IList<JG_DepositEntity> Selects()
        {
            return service.JG_Deposit_Selects();
        }
        /// <summary>
        /// 查询所有[JG_Deposit]带排序
        /// </summary>
        /// <param name="sortField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public IList<JG_DepositEntity> SelectsForSort(string sortField,bool isDesc)
        {
            return service.JG_Deposit_SelectsForSort(sortField,isDesc);
        }

        /// <summary>
        /// 查询所有[JG_Deposit]分页
        /// </summary>
        /// <param name="Skip">页数</param>
        /// <param name="Count">页条目数量</param>
        /// <returns></returns>
        public IList<JG_DepositEntity> SelectsForPage(int Skip, int Count)
        {
            return service.JG_Deposit_SelectsForPage(Skip,Count);
        }
		#endregion
    }
}
