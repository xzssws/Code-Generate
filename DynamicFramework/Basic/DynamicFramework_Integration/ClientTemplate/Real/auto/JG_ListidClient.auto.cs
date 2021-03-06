using System;
using System.Collections.Generic;
using System.Linq;
using DynamicWebSrv;
namespace DynamiClient
{
    /// <summary>
    /// [JG_Listid]客户端代理类
    /// </summary>
    public sealed partial class JG_ListidClient
    {
        #region 单例模式

        private JG_ListidClient() { }
    
        private static readonly object LockObj = new object();

        private static JG_ListidClient _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static JG_ListidClient Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new JG_ListidClient();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        private JG_ListidSrv.JG_ListidSrv service = new JG_ListidSrv.JG_ListidSrv();

        #region 基础物理操作(增删改查)
        /// <summary>
        /// 添加对象 JG_Listid
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>完成状态</returns>
        public bool Add(JG_ListidEntity entity)
        {
            return service.Add(entity);
        }
        /// <summary>
        /// 更新对象 JG_Listid
        /// </summary>
        /// <param name="entity">更新的对象</param>
        /// <returns>完成状态</returns>
        public bool Update(JG_ListidEntity entity)
        {
            return service.Update(entity);
        }
        /// <summary>
        /// 删除对象 JG_Listid
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>完成状态</returns>
        public bool Delete(JG_ListidEntity entity)
        {
            return service.Delete(entity);
        }
        /// <summary>
        /// 查询所有 JG_Listid
        /// </summary>
        /// <returns>对象集合</returns>
        public List<JG_ListidEntity> Selects()
        {
            return service.Selects().ToList<JG_ListidEntity>();
        }
        /// <summary>
        /// 条件查询 JG_Listid
        /// </summary>
        /// <param name="entity">筛选实例</param>
        /// <returns>对象集合</returns>
        public List<JG_ListidEntity> Select(JG_ListidEntity entity)
        {
            return service.Select(entity).ToList<JG_ListidEntity>();
        }
        #endregion
    }
}
