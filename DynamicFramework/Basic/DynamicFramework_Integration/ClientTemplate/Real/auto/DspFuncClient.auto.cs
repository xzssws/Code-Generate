using System;
using System.Collections.Generic;
using System.Linq;
using DynamicWebSrv;
namespace DynamiClient
{
    /// <summary>
    /// [DspFunc]客户端代理类
    /// </summary>
    public sealed partial class DspFuncClient
    {
        #region 单例模式

        private DspFuncClient() { }
    
        private static readonly object LockObj = new object();

        private static DspFuncClient _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static DspFuncClient Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new DspFuncClient();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        private DspFuncSrv.DspFuncSrv service = new DspFuncSrv.DspFuncSrv();

        #region 基础物理操作(增删改查)
        /// <summary>
        /// 添加对象 DspFunc
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>完成状态</returns>
        public bool Add(DspFuncEntity entity)
        {
            return service.Add(entity);
        }
        /// <summary>
        /// 更新对象 DspFunc
        /// </summary>
        /// <param name="entity">更新的对象</param>
        /// <returns>完成状态</returns>
        public bool Update(DspFuncEntity entity)
        {
            return service.Update(entity);
        }
        /// <summary>
        /// 删除对象 DspFunc
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>完成状态</returns>
        public bool Delete(DspFuncEntity entity)
        {
            return service.Delete(entity);
        }
        /// <summary>
        /// 查询所有 DspFunc
        /// </summary>
        /// <returns>对象集合</returns>
        public List<DspFuncEntity> Selects()
        {
            return service.Selects().ToList<DspFuncEntity>();
        }
        /// <summary>
        /// 条件查询 DspFunc
        /// </summary>
        /// <param name="entity">筛选实例</param>
        /// <returns>对象集合</returns>
        public List<DspFuncEntity> Select(DspFuncEntity entity)
        {
            return service.Select(entity).ToList<DspFuncEntity>();
        }
        #endregion
    }
}
