using System;
using System.Collections.Generic;
using System.Linq;
using DynamicWebSrv;
namespace DynamiClient
{
    /// <summary>
    /// [SerialNoConfig]客户端代理类
    /// </summary>
    public sealed partial class SerialNoConfigClient
    {
        #region 单例模式

        private SerialNoConfigClient() { }
    
        private static readonly object LockObj = new object();

        private static SerialNoConfigClient _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static SerialNoConfigClient Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new SerialNoConfigClient();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        private SerialNoConfigSrv.SerialNoConfigSrv service = new SerialNoConfigSrv.SerialNoConfigSrv();

        #region 基础物理操作(增删改查)
        /// <summary>
        /// 添加对象 SerialNoConfig
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>完成状态</returns>
        public bool Add(SerialNoConfigEntity entity)
        {
            return service.Add(entity);
        }
        /// <summary>
        /// 更新对象 SerialNoConfig
        /// </summary>
        /// <param name="entity">更新的对象</param>
        /// <returns>完成状态</returns>
        public bool Update(SerialNoConfigEntity entity)
        {
            return service.Update(entity);
        }
        /// <summary>
        /// 删除对象 SerialNoConfig
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>完成状态</returns>
        public bool Delete(SerialNoConfigEntity entity)
        {
            return service.Delete(entity);
        }
        /// <summary>
        /// 查询所有 SerialNoConfig
        /// </summary>
        /// <returns>对象集合</returns>
        public List<SerialNoConfigEntity> Selects()
        {
            return service.Selects().ToList<SerialNoConfigEntity>();
        }
        /// <summary>
        /// 条件查询 SerialNoConfig
        /// </summary>
        /// <param name="entity">筛选实例</param>
        /// <returns>对象集合</returns>
        public List<SerialNoConfigEntity> Select(SerialNoConfigEntity entity)
        {
            return service.Select(entity).ToList<SerialNoConfigEntity>();
        }
        #endregion
    }
}
