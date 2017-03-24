using System;
using System.Collections.Generic;
using System.Linq;
using ClientTemplate.LogicService;

namespace DynamiClient
{
    /// <summary>
    /// [TableDicationary]客户端代理类
    /// </summary>
    public sealed partial class TableDicationaryClient
    {
        #region 单例模式

        private TableDicationaryClient() { }
    
        private static readonly object LockObj = new object();

        private static TableDicationaryClient _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static TableDicationaryClient Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new TableDicationaryClient();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        private LogicSrv service = new LogicSrv();

		#region 查询操作
		/// <summary>
        /// 条件查询[TableDicationary]
        /// </summary>
        /// <param name="entity">[TableDicationary]筛选实例</param>
        /// <returns>[TableDicationary结果集</returns>
        public IList<TableDicationaryEntity> Select(TableDicationaryEntity entity)
        {
            return service.TableDicationary_Select(entity);
        }
        /// <summary>
        /// 条件查询排序
        /// </summary>
        /// <param name="entity">筛选实例</param>
        /// <param name="sortField">排序字段名</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
		public IList<TableDicationaryEntity> SelectForSort(TableDicationaryEntity entity,string sortField, bool isDesc)
        {
            return service.TableDicationary_SelectForSort(entity,sortField,isDesc);
        }
		/// <summary>
        /// 条件查询分页[TableDicationary]
        /// </summary>
        /// <param name="entity">[TableDicationary]筛选实例</param>
        /// <param name="Skip">页数</param>
        /// <param name="Count">页条目数量</param>
        /// <returns>[TableDicationary结果集</returns>
        public IList<TableDicationaryEntity> SelectForPage(TableDicationaryEntity entity,int Skip,int Count)
        {
            return service.TableDicationary_SelectForPage(entity,Skip,Count);
        }
        /// <summary>
        /// 查询所有[TableDicationary]
        /// </summary>
        /// <returns></returns>
        public IList<TableDicationaryEntity> Selects()
        {
            return service.TableDicationary_Selects();
        }
        /// <summary>
        /// 查询所有[TableDicationary]带排序
        /// </summary>
        /// <param name="sortField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public IList<TableDicationaryEntity> SelectsForSort(string sortField,bool isDesc)
        {
            return service.TableDicationary_SelectsForSort(sortField,isDesc);
        }

        /// <summary>
        /// 查询所有[TableDicationary]分页
        /// </summary>
        /// <param name="Skip">页数</param>
        /// <param name="Count">页条目数量</param>
        /// <returns></returns>
        public IList<TableDicationaryEntity> SelectsForPage(int Skip, int Count)
        {
            return service.TableDicationary_SelectsForPage(Skip,Count);
        }
		#endregion
    }
}
