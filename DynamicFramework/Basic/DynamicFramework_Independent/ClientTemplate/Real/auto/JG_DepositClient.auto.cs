using System;
using System.Collections.Generic;
using System.Linq;
using DynamicWebSrv;
namespace DynamiClient
{
    /// <summary>
    /// [JG_Deposit]客户端代理类
    /// </summary>
    public sealed partial class JG_DepositClient
    {
        #region 单例模式

        private JG_DepositClient() { }
    
        private static readonly object LockObj = new object();

        private static JG_DepositClient _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static JG_DepositClient Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new JG_DepositClient();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        private JG_DepositSrv.JG_DepositSrv service = new JG_DepositSrv.JG_DepositSrv();

        #region 基础物理操作(增删改查)
        /// <summary>
        /// 添加对象 JG_Deposit
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>完成状态</returns>
        public bool Add(JG_DepositEntity entity)
        {
            return service.Add(entity);
        }
        /// <summary>
        /// 更新对象 JG_Deposit
        /// </summary>
        /// <param name="entity">更新的对象</param>
        /// <returns>完成状态</returns>
        public bool Update(JG_DepositEntity entity)
        {
            return service.Update(entity);
        }
        /// <summary>
        /// 删除对象 JG_Deposit
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>完成状态</returns>
        public bool Delete(JG_DepositEntity entity)
        {
            return service.Delete(entity);
        }
        /// <summary>
        /// 查询所有 JG_Deposit
        /// </summary>
        /// <returns>对象集合</returns>
        public List<JG_DepositEntity> Selects()
        {
            return service.Selects().ToList<JG_DepositEntity>();
        }
        /// <summary>
        /// 条件查询 JG_Deposit
        /// </summary>
        /// <param name="entity">筛选实例</param>
        /// <returns>对象集合</returns>
        public List<JG_DepositEntity> Select(JG_DepositEntity entity)
        {
            return service.Select(entity).ToList<JG_DepositEntity>();
        }
        #endregion
    }
}
