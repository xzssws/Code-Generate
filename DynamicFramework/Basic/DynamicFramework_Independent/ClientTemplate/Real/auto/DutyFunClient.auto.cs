using System;
using System.Collections.Generic;
using System.Linq;
using DynamicWebSrv;
namespace DynamiClient
{
    /// <summary>
    /// [DutyFun]客户端代理类
    /// </summary>
    public sealed partial class DutyFunClient
    {
        #region 单例模式

        private DutyFunClient() { }
    
        private static readonly object LockObj = new object();

        private static DutyFunClient _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static DutyFunClient Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new DutyFunClient();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        private DutyFunSrv.DutyFunSrv service = new DutyFunSrv.DutyFunSrv();

        #region 基础物理操作(增删改查)
        /// <summary>
        /// 添加对象 DutyFun
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>完成状态</returns>
        public bool Add(DutyFunEntity entity)
        {
            return service.Add(entity);
        }
        /// <summary>
        /// 更新对象 DutyFun
        /// </summary>
        /// <param name="entity">更新的对象</param>
        /// <returns>完成状态</returns>
        public bool Update(DutyFunEntity entity)
        {
            return service.Update(entity);
        }
        /// <summary>
        /// 删除对象 DutyFun
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>完成状态</returns>
        public bool Delete(DutyFunEntity entity)
        {
            return service.Delete(entity);
        }
        /// <summary>
        /// 查询所有 DutyFun
        /// </summary>
        /// <returns>对象集合</returns>
        public List<DutyFunEntity> Selects()
        {
            return service.Selects().ToList<DutyFunEntity>();
        }
        /// <summary>
        /// 条件查询 DutyFun
        /// </summary>
        /// <param name="entity">筛选实例</param>
        /// <returns>对象集合</returns>
        public List<DutyFunEntity> Select(DutyFunEntity entity)
        {
            return service.Select(entity).ToList<DutyFunEntity>();
        }
        #endregion
    }
}
