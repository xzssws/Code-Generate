using System;
using System.Collections.Generic;
using System.Linq;
using ClientTemplate.RealService;

namespace DynamiClient
{
    /// <summary>
    /// [JG_Payment]客户端代理类
    /// </summary>
    public sealed partial class JG_PaymentClient
    {
        #region 单例模式

        private JG_PaymentClient() { }
    
        private static readonly object LockObj = new object();

        private static JG_PaymentClient _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static JG_PaymentClient Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new JG_PaymentClient();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        private RealSrv service = new RealSrv();

        #region 基础物理操作(增删改)
		/// <summary>
        /// 添加一条[JG_Payment]
        /// </summary>
        /// <param name="entity">[JG_Payment]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Add(JG_PaymentEntity entity)
        {
            return service.JG_Payment_Add(entity);
        }

        /// <summary>
        /// 更新一条[JG_Payment]
        /// </summary>
        /// <param name="entity">更新的[JG_Payment]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Update(JG_PaymentEntity entity)
        {
            return service.JG_Payment_Update(entity);
        }

        /// <summary>
        /// 删除一条[JG_Payment]
        /// </summary>
        /// <param name="entityID"></param>
        /// <returns>执行完成状态</returns>
        public bool Delete(string entityID)
        {
            return service.JG_Payment_Delete(entityID);
        }
		#endregion

		#region 查询操作
		/// <summary>
        /// 条件查询[JG_Payment]
        /// </summary>
        /// <param name="entity">[JG_Payment]筛选实例</param>
        /// <returns>[JG_Payment结果集</returns>
        public IList<JG_PaymentEntity> Select(JG_PaymentEntity entity)
        {
            return service.JG_Payment_Select(entity);
        }
        /// <summary>
        /// 条件查询排序
        /// </summary>
        /// <param name="entity">筛选实例</param>
        /// <param name="sortField">排序字段名</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
		public IList<JG_PaymentEntity> SelectForSort(JG_PaymentEntity entity,string sortField, bool isDesc)
        {
            return service.JG_Payment_SelectForSort(entity,sortField,isDesc);
        }
		/// <summary>
        /// 条件查询分页[JG_Payment]
        /// </summary>
        /// <param name="entity">[JG_Payment]筛选实例</param>
        /// <param name="Skip">页数</param>
        /// <param name="Count">页条目数量</param>
        /// <returns>[JG_Payment结果集</returns>
        public IList<JG_PaymentEntity> SelectForPage(JG_PaymentEntity entity,int Skip,int Count)
        {
            return service.JG_Payment_SelectForPage(entity,Skip,Count);
        }
        /// <summary>
        /// 查询所有[JG_Payment]
        /// </summary>
        /// <returns></returns>
        public IList<JG_PaymentEntity> Selects()
        {
            return service.JG_Payment_Selects();
        }
        /// <summary>
        /// 查询所有[JG_Payment]带排序
        /// </summary>
        /// <param name="sortField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public IList<JG_PaymentEntity> SelectsForSort(string sortField,bool isDesc)
        {
            return service.JG_Payment_SelectsForSort(sortField,isDesc);
        }

        /// <summary>
        /// 查询所有[JG_Payment]分页
        /// </summary>
        /// <param name="Skip">页数</param>
        /// <param name="Count">页条目数量</param>
        /// <returns></returns>
        public IList<JG_PaymentEntity> SelectsForPage(int Skip, int Count)
        {
            return service.JG_Payment_SelectsForPage(Skip,Count);
        }
		#endregion
    }
}
