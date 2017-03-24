using System;
using System.Collections.Generic;
using System.Linq;
using DynamicWebSrv;
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

        private UserInfoSrv.UserInfoSrv service = new UserInfoSrv.UserInfoSrv();

        #region 基础物理操作(增删改查)
        /// <summary>
        /// 添加对象 UserInfo
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>完成状态</returns>
        public bool Add(UserInfoEntity entity)
        {
            return service.Add(entity);
        }
        /// <summary>
        /// 更新对象 UserInfo
        /// </summary>
        /// <param name="entity">更新的对象</param>
        /// <returns>完成状态</returns>
        public bool Update(UserInfoEntity entity)
        {
            return service.Update(entity);
        }
        /// <summary>
        /// 删除对象 UserInfo
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>完成状态</returns>
        public bool Delete(UserInfoEntity entity)
        {
            return service.Delete(entity);
        }
        /// <summary>
        /// 查询所有 UserInfo
        /// </summary>
        /// <returns>对象集合</returns>
        public List<UserInfoEntity> Selects()
        {
            return service.Selects().ToList<UserInfoEntity>();
        }
        /// <summary>
        /// 条件查询 UserInfo
        /// </summary>
        /// <param name="entity">筛选实例</param>
        /// <returns>对象集合</returns>
        public List<UserInfoEntity> Select(UserInfoEntity entity)
        {
            return service.Select(entity).ToList<UserInfoEntity>();
        }
        #endregion
    }
}
