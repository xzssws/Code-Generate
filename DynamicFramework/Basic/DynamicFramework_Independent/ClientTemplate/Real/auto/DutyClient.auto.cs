using System;
using System.Collections.Generic;
using System.Linq;
using DynamicWebSrv;
namespace DynamiClient
{
    /// <summary>
    /// [Duty]客户端代理类
    /// </summary>
    public sealed partial class DutyClient
    {
        #region 单例模式

        private DutyClient() { }
    
        private static readonly object LockObj = new object();

        private static DutyClient _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static DutyClient Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new DutyClient();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        private DutySrv.DutySrv service = new DutySrv.DutySrv();

        #region 基础物理操作(增删改查)
        /// <summary>
        /// 添加对象 Duty
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>完成状态</returns>
        public bool Add(DutyEntity entity)
        {
            return service.Add(entity);
        }
        /// <summary>
        /// 更新对象 Duty
        /// </summary>
        /// <param name="entity">更新的对象</param>
        /// <returns>完成状态</returns>
        public bool Update(DutyEntity entity)
        {
            return service.Update(entity);
        }
        /// <summary>
        /// 删除对象 Duty
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>完成状态</returns>
        public bool Delete(DutyEntity entity)
        {
            return service.Delete(entity);
        }
        /// <summary>
        /// 查询所有 Duty
        /// </summary>
        /// <returns>对象集合</returns>
        public List<DutyEntity> Selects()
        {
            return service.Selects().ToList<DutyEntity>();
        }
        /// <summary>
        /// 条件查询 Duty
        /// </summary>
        /// <param name="entity">筛选实例</param>
        /// <returns>对象集合</returns>
        public List<DutyEntity> Select(DutyEntity entity)
        {
            return service.Select(entity).ToList<DutyEntity>();
        }
        #endregion
    }
}
