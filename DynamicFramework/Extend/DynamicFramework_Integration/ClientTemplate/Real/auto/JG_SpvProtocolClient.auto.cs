using System;
using System.Collections.Generic;
using System.Linq;
using ClientTemplate.RealService;

namespace DynamiClient
{
    /// <summary>
    /// [JG_SpvProtocol]客户端代理类
    /// </summary>
    public sealed partial class JG_SpvProtocolClient
    {
        #region 单例模式

        private JG_SpvProtocolClient() { }
    
        private static readonly object LockObj = new object();

        private static JG_SpvProtocolClient _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static JG_SpvProtocolClient Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new JG_SpvProtocolClient();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        private RealSrv service = new RealSrv();

        #region 基础物理操作(增删改)
		/// <summary>
        /// 添加一条[JG_SpvProtocol]
        /// </summary>
        /// <param name="entity">[JG_SpvProtocol]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Add(JG_SpvProtocolEntity entity)
        {
            return service.JG_SpvProtocol_Add(entity);
        }

        /// <summary>
        /// 更新一条[JG_SpvProtocol]
        /// </summary>
        /// <param name="entity">更新的[JG_SpvProtocol]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Update(JG_SpvProtocolEntity entity)
        {
            return service.JG_SpvProtocol_Update(entity);
        }

        /// <summary>
        /// 删除一条[JG_SpvProtocol]
        /// </summary>
        /// <param name="entityID"></param>
        /// <returns>执行完成状态</returns>
        public bool Delete(string entityID)
        {
            return service.JG_SpvProtocol_Delete(entityID);
        }
		#endregion

		#region 查询操作
		/// <summary>
        /// 条件查询[JG_SpvProtocol]
        /// </summary>
        /// <param name="entity">[JG_SpvProtocol]筛选实例</param>
        /// <returns>[JG_SpvProtocol结果集</returns>
        public IList<JG_SpvProtocolEntity> Select(JG_SpvProtocolEntity entity)
        {
            return service.JG_SpvProtocol_Select(entity);
        }
        /// <summary>
        /// 条件查询排序
        /// </summary>
        /// <param name="entity">筛选实例</param>
        /// <param name="sortField">排序字段名</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
		public IList<JG_SpvProtocolEntity> SelectForSort(JG_SpvProtocolEntity entity,string sortField, bool isDesc)
        {
            return service.JG_SpvProtocol_SelectForSort(entity,sortField,isDesc);
        }
		/// <summary>
        /// 条件查询分页[JG_SpvProtocol]
        /// </summary>
        /// <param name="entity">[JG_SpvProtocol]筛选实例</param>
        /// <param name="Skip">页数</param>
        /// <param name="Count">页条目数量</param>
        /// <returns>[JG_SpvProtocol结果集</returns>
        public IList<JG_SpvProtocolEntity> SelectForPage(JG_SpvProtocolEntity entity,int Skip,int Count)
        {
            return service.JG_SpvProtocol_SelectForPage(entity,Skip,Count);
        }
        /// <summary>
        /// 查询所有[JG_SpvProtocol]
        /// </summary>
        /// <returns></returns>
        public IList<JG_SpvProtocolEntity> Selects()
        {
            return service.JG_SpvProtocol_Selects();
        }
        /// <summary>
        /// 查询所有[JG_SpvProtocol]带排序
        /// </summary>
        /// <param name="sortField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public IList<JG_SpvProtocolEntity> SelectsForSort(string sortField,bool isDesc)
        {
            return service.JG_SpvProtocol_SelectsForSort(sortField,isDesc);
        }

        /// <summary>
        /// 查询所有[JG_SpvProtocol]分页
        /// </summary>
        /// <param name="Skip">页数</param>
        /// <param name="Count">页条目数量</param>
        /// <returns></returns>
        public IList<JG_SpvProtocolEntity> SelectsForPage(int Skip, int Count)
        {
            return service.JG_SpvProtocol_SelectsForPage(Skip,Count);
        }
		#endregion
    }
}
