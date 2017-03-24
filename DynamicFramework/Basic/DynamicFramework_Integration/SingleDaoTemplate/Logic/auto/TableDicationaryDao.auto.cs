using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// TableDicationary数据库访问类
    /// </summary>
    public sealed partial class TableDicationaryDao :BaseDao<TableDicationaryEntity>,IBaseLogic<TableDicationaryEntity>
    {
		#region 单例模式

		private TableDicationaryDao(){ }

        private static readonly object LockObj = new object();

        private static TableDicationaryDao _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static TableDicationaryDao Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new TableDicationaryDao();
                    }
                    return _instance;
                }
            }
        }

        #endregion
        
        private const string DefaultKey = "TableDicationary";

		/// <summary>
        /// 条件查询[TableDicationary]
        /// </summary>
        /// <param name="entity">[TableDicationary]筛选实例</param>
        /// <returns>[TableDicationary结果集</returns>
        public IList<TableDicationaryEntity> Select(TableDicationaryEntity entity)
        {
            return s("Select" + DefaultKey, entity);
        }

        /// <summary>
        /// 查询所有[TableDicationary]
        /// </summary>
        /// <returns></returns>
        public IList<TableDicationaryEntity> Selects()
        {
            return ss("Select" + DefaultKey);
        }
        /// <summary>
        /// 查询所有[TableDicationary]带排序
        /// </summary>
        /// <param name="orderField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public IList<TableDicationaryEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            TableDicationaryEntity entity = new TableDicationaryEntity() { OrderField = orderField, IsDesc = isDesc };
            return s("Select" + DefaultKey, entity);
        }
    }
}
