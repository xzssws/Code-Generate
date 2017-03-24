using System;
using System.Collections.Generic;
using System.Linq;
using DynamicWebSrv;
namespace DynamiClient
{
    /// <summary>
    /// [Parm]客户端代理类
    /// </summary>
    public sealed partial class ParmClient
    {
        #region 单例模式

        private ParmClient() { }
    
        private static readonly object LockObj = new object();

        private static ParmClient _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static ParmClient Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new ParmClient();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        private ParmSrv.ParmSrv service = new ParmSrv.ParmSrv();

        #region 基础物理操作(增删改查)
        /// <summary>
        /// 添加对象 Parm
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>完成状态</returns>
        public bool Add(ParmEntity entity)
        {
            return service.Add(entity);
        }
        /// <summary>
        /// 更新对象 Parm
        /// </summary>
        /// <param name="entity">更新的对象</param>
        /// <returns>完成状态</returns>
        public bool Update(ParmEntity entity)
        {
            return service.Update(entity);
        }
        /// <summary>
        /// 删除对象 Parm
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>完成状态</returns>
        public bool Delete(ParmEntity entity)
        {
            return service.Delete(entity);
        }
        /// <summary>
        /// 查询所有 Parm
        /// </summary>
        /// <returns>对象集合</returns>
        public List<ParmEntity> Selects()
        {
            return service.Selects().ToList<ParmEntity>();
        }
        /// <summary>
        /// 条件查询 Parm
        /// </summary>
        /// <param name="entity">筛选实例</param>
        /// <returns>对象集合</returns>
        public List<ParmEntity> Select(ParmEntity entity)
        {
            return service.Select(entity).ToList<ParmEntity>();
        }
        #endregion
    }
}
