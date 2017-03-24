using System;
using System.Collections.Generic;
using System.Linq;
using DynamicWebSrv;
namespace DynamiClient
{
    /// <summary>
    /// [SysConfig]客户端代理类
    /// </summary>
    public sealed partial class SysConfigClient
    {
        #region 单例模式

        private SysConfigClient() { }
    
        private static readonly object LockObj = new object();

        private static SysConfigClient _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static SysConfigClient Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new SysConfigClient();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        private SysConfigSrv.SysConfigSrv service = new SysConfigSrv.SysConfigSrv();

        #region 基础物理操作(增删改查)
        /// <summary>
        /// 添加对象 SysConfig
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>完成状态</returns>
        public bool Add(SysConfigEntity entity)
        {
            return service.Add(entity);
        }
        /// <summary>
        /// 更新对象 SysConfig
        /// </summary>
        /// <param name="entity">更新的对象</param>
        /// <returns>完成状态</returns>
        public bool Update(SysConfigEntity entity)
        {
            return service.Update(entity);
        }
        /// <summary>
        /// 删除对象 SysConfig
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>完成状态</returns>
        public bool Delete(SysConfigEntity entity)
        {
            return service.Delete(entity);
        }
        /// <summary>
        /// 查询所有 SysConfig
        /// </summary>
        /// <returns>对象集合</returns>
        public List<SysConfigEntity> Selects()
        {
            return service.Selects().ToList<SysConfigEntity>();
        }
        /// <summary>
        /// 条件查询 SysConfig
        /// </summary>
        /// <param name="entity">筛选实例</param>
        /// <returns>对象集合</returns>
        public List<SysConfigEntity> Select(SysConfigEntity entity)
        {
            return service.Select(entity).ToList<SysConfigEntity>();
        }
        #endregion
    }
}
