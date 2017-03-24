using System;
using System.Collections.Generic;
using System.Linq;
using ClientTemplate.RealService;

namespace DynamiClient
{
    /// <summary>
    /// [UserInfo]客户端代理类
    /// </summary>
    public sealed partial class UserInfoClient
    {
        #region 单例模式

        private UserInfoClient() { }
    
        private static readonly object LockObj = new object();

        private static UserInfoClient _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static UserInfoClient Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new UserInfoClient();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        private RealSrv service = new RealSrv();

        #region 基础物理操作(增删改)
		/// <summary>
        /// 添加一条[UserInfo]
        /// </summary>
        /// <param name="entity">[UserInfo]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Add(UserInfoEntity entity)
        {
            return service.UserInfo_Add(entity);
        }

        /// <summary>
        /// 更新一条[UserInfo]
        /// </summary>
        /// <param name="entity">更新的[UserInfo]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Update(UserInfoEntity entity)
        {
            return service.UserInfo_Update(entity);
        }

        /// <summary>
        /// 删除一条[UserInfo]
        /// </summary>
        /// <param name="entityID"></param>
        /// <returns>执行完成状态</returns>
        public bool Delete(string entityID)
        {
            return service.UserInfo_Delete(entityID);
        }
		#endregion

		#region 查询操作
		/// <summary>
        /// 条件查询[UserInfo]
        /// </summary>
        /// <param name="entity">[UserInfo]筛选实例</param>
        /// <returns>[UserInfo结果集</returns>
        public IList<UserInfoEntity> Select(UserInfoEntity entity)
        {
            return service.UserInfo_Select(entity);
        }
        /// <summary>
        /// 条件查询排序
        /// </summary>
        /// <param name="entity">筛选实例</param>
        /// <param name="sortField">排序字段名</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
		public IList<UserInfoEntity> SelectForSort(UserInfoEntity entity,string sortField, bool isDesc)
        {
            return service.UserInfo_SelectForSort(entity,sortField,isDesc);
        }
		/// <summary>
        /// 条件查询分页[UserInfo]
        /// </summary>
        /// <param name="entity">[UserInfo]筛选实例</param>
        /// <param name="Skip">页数</param>
        /// <param name="Count">页条目数量</param>
        /// <returns>[UserInfo结果集</returns>
        public IList<UserInfoEntity> SelectForPage(UserInfoEntity entity,int Skip,int Count)
        {
            return service.UserInfo_SelectForPage(entity,Skip,Count);
        }
        /// <summary>
        /// 查询所有[UserInfo]
        /// </summary>
        /// <returns></returns>
        public IList<UserInfoEntity> Selects()
        {
            return service.UserInfo_Selects();
        }
        /// <summary>
        /// 查询所有[UserInfo]带排序
        /// </summary>
        /// <param name="sortField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public IList<UserInfoEntity> SelectsForSort(string sortField,bool isDesc)
        {
            return service.UserInfo_SelectsForSort(sortField,isDesc);
        }

        /// <summary>
        /// 查询所有[UserInfo]分页
        /// </summary>
        /// <param name="Skip">页数</param>
        /// <param name="Count">页条目数量</param>
        /// <returns></returns>
        public IList<UserInfoEntity> SelectsForPage(int Skip, int Count)
        {
            return service.UserInfo_SelectsForPage(Skip,Count);
        }
		#endregion
    }
}
