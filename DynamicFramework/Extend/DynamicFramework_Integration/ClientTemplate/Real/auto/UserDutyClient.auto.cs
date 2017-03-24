using System;
using System.Collections.Generic;
using System.Linq;
using ClientTemplate.RealService;

namespace DynamiClient
{
    /// <summary>
    /// [UserDuty]客户端代理类
    /// </summary>
    public sealed partial class UserDutyClient
    {
        #region 单例模式

        private UserDutyClient() { }
    
        private static readonly object LockObj = new object();

        private static UserDutyClient _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static UserDutyClient Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new UserDutyClient();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        private RealSrv service = new RealSrv();

        #region 基础物理操作(增删改)
		/// <summary>
        /// 添加一条[UserDuty]
        /// </summary>
        /// <param name="entity">[UserDuty]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Add(UserDutyEntity entity)
        {
            return service.UserDuty_Add(entity);
        }

        /// <summary>
        /// 更新一条[UserDuty]
        /// </summary>
        /// <param name="entity">更新的[UserDuty]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Update(UserDutyEntity entity)
        {
            return service.UserDuty_Update(entity);
        }

        /// <summary>
        /// 删除一条[UserDuty]
        /// </summary>
        /// <param name="entityID"></param>
        /// <returns>执行完成状态</returns>
        public bool Delete(string entityID)
        {
            return service.UserDuty_Delete(entityID);
        }
		#endregion

		#region 查询操作
		/// <summary>
        /// 条件查询[UserDuty]
        /// </summary>
        /// <param name="entity">[UserDuty]筛选实例</param>
        /// <returns>[UserDuty结果集</returns>
        public IList<UserDutyEntity> Select(UserDutyEntity entity)
        {
            return service.UserDuty_Select(entity);
        }
        /// <summary>
        /// 条件查询排序
        /// </summary>
        /// <param name="entity">筛选实例</param>
        /// <param name="sortField">排序字段名</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
		public IList<UserDutyEntity> SelectForSort(UserDutyEntity entity,string sortField, bool isDesc)
        {
            return service.UserDuty_SelectForSort(entity,sortField,isDesc);
        }
		/// <summary>
        /// 条件查询分页[UserDuty]
        /// </summary>
        /// <param name="entity">[UserDuty]筛选实例</param>
        /// <param name="Skip">页数</param>
        /// <param name="Count">页条目数量</param>
        /// <returns>[UserDuty结果集</returns>
        public IList<UserDutyEntity> SelectForPage(UserDutyEntity entity,int Skip,int Count)
        {
            return service.UserDuty_SelectForPage(entity,Skip,Count);
        }
        /// <summary>
        /// 查询所有[UserDuty]
        /// </summary>
        /// <returns></returns>
        public IList<UserDutyEntity> Selects()
        {
            return service.UserDuty_Selects();
        }
        /// <summary>
        /// 查询所有[UserDuty]带排序
        /// </summary>
        /// <param name="sortField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public IList<UserDutyEntity> SelectsForSort(string sortField,bool isDesc)
        {
            return service.UserDuty_SelectsForSort(sortField,isDesc);
        }

        /// <summary>
        /// 查询所有[UserDuty]分页
        /// </summary>
        /// <param name="Skip">页数</param>
        /// <param name="Count">页条目数量</param>
        /// <returns></returns>
        public IList<UserDutyEntity> SelectsForPage(int Skip, int Count)
        {
            return service.UserDuty_SelectsForPage(Skip,Count);
        }
		#endregion
    }
}
