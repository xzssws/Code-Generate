using System;
using System.Collections.Generic;
using System.Linq;
using DynamicWebSrv;
namespace DynamiClient
{
    /// <summary>
    /// [JG_AmountCollect]客户端代理类
    /// </summary>
    public sealed partial class JG_AmountCollectClient
    {
        #region 单例模式

        private JG_AmountCollectClient() { }
    
        private static readonly object LockObj = new object();

        private static JG_AmountCollectClient _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static JG_AmountCollectClient Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new JG_AmountCollectClient();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        private JG_AmountCollectSrv.JG_AmountCollectSrv service = new JG_AmountCollectSrv.JG_AmountCollectSrv();

        #region 基础物理操作(增删改查)
        /// <summary>
        /// 添加对象 JG_AmountCollect
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>完成状态</returns>
        public bool Add(JG_AmountCollectEntity entity)
        {
            return service.Add(entity);
        }
        /// <summary>
        /// 更新对象 JG_AmountCollect
        /// </summary>
        /// <param name="entity">更新的对象</param>
        /// <returns>完成状态</returns>
        public bool Update(JG_AmountCollectEntity entity)
        {
            return service.Update(entity);
        }
        /// <summary>
        /// 删除对象 JG_AmountCollect
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>完成状态</returns>
        public bool Delete(JG_AmountCollectEntity entity)
        {
            return service.Delete(entity);
        }
        /// <summary>
        /// 查询所有 JG_AmountCollect
        /// </summary>
        /// <returns>对象集合</returns>
        public List<JG_AmountCollectEntity> Selects()
        {
            return service.Selects().ToList<JG_AmountCollectEntity>();
        }
        /// <summary>
        /// 条件查询 JG_AmountCollect
        /// </summary>
        /// <param name="entity">筛选实例</param>
        /// <returns>对象集合</returns>
        public List<JG_AmountCollectEntity> Select(JG_AmountCollectEntity entity)
        {
            return service.Select(entity).ToList<JG_AmountCollectEntity>();
        }
        #endregion
    }
}
