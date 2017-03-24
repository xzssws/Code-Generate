using System;
using System.Collections.Generic;
using System.Linq;
using DynamicWebSrv;
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

        private UserDutySrv.UserDutySrv service = new UserDutySrv.UserDutySrv();

        #region 基础物理操作(增删改查)
        /// <summary>
        /// 添加对象 UserDuty
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>完成状态</returns>
        public bool Add(UserDutyEntity entity)
        {
            return service.Add(entity);
        }
        /// <summary>
        /// 更新对象 UserDuty
        /// </summary>
        /// <param name="entity">更新的对象</param>
        /// <returns>完成状态</returns>
        public bool Update(UserDutyEntity entity)
        {
            return service.Update(entity);
        }
        /// <summary>
        /// 删除对象 UserDuty
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>完成状态</returns>
        public bool Delete(UserDutyEntity entity)
        {
            return service.Delete(entity);
        }
        /// <summary>
        /// 查询所有 UserDuty
        /// </summary>
        /// <returns>对象集合</returns>
        public List<UserDutyEntity> Selects()
        {
            return service.Selects().ToList<UserDutyEntity>();
        }
        /// <summary>
        /// 条件查询 UserDuty
        /// </summary>
        /// <param name="entity">筛选实例</param>
        /// <returns>对象集合</returns>
        public List<UserDutyEntity> Select(UserDutyEntity entity)
        {
            return service.Select(entity).ToList<UserDutyEntity>();
        }
        #endregion
    }
}
