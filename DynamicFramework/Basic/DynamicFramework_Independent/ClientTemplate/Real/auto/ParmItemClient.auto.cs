using System;
using System.Collections.Generic;
using System.Linq;
using DynamicWebSrv;
namespace DynamiClient
{
    /// <summary>
    /// [ParmItem]客户端代理类
    /// </summary>
    public sealed partial class ParmItemClient
    {
        #region 单例模式

        private ParmItemClient() { }
    
        private static readonly object LockObj = new object();

        private static ParmItemClient _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static ParmItemClient Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new ParmItemClient();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        private ParmItemSrv.ParmItemSrv service = new ParmItemSrv.ParmItemSrv();

        #region 基础物理操作(增删改查)
        /// <summary>
        /// 添加对象 ParmItem
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>完成状态</returns>
        public bool Add(ParmItemEntity entity)
        {
            return service.Add(entity);
        }
        /// <summary>
        /// 更新对象 ParmItem
        /// </summary>
        /// <param name="entity">更新的对象</param>
        /// <returns>完成状态</returns>
        public bool Update(ParmItemEntity entity)
        {
            return service.Update(entity);
        }
        /// <summary>
        /// 删除对象 ParmItem
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>完成状态</returns>
        public bool Delete(ParmItemEntity entity)
        {
            return service.Delete(entity);
        }
        /// <summary>
        /// 查询所有 ParmItem
        /// </summary>
        /// <returns>对象集合</returns>
        public List<ParmItemEntity> Selects()
        {
            return service.Selects().ToList<ParmItemEntity>();
        }
        /// <summary>
        /// 条件查询 ParmItem
        /// </summary>
        /// <param name="entity">筛选实例</param>
        /// <returns>对象集合</returns>
        public List<ParmItemEntity> Select(ParmItemEntity entity)
        {
            return service.Select(entity).ToList<ParmItemEntity>();
        }
        #endregion
    }
}
