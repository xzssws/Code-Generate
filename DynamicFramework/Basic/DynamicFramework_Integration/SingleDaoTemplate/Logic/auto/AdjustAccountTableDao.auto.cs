using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// AdjustAccountTable数据库访问类
    /// </summary>
    public sealed partial class AdjustAccountTableDao :BaseDao<AdjustAccountTableEntity>,IBaseLogic<AdjustAccountTableEntity>
    {
		#region 单例模式

		private AdjustAccountTableDao(){ }

        private static readonly object LockObj = new object();

        private static AdjustAccountTableDao _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static AdjustAccountTableDao Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new AdjustAccountTableDao();
                    }
                    return _instance;
                }
            }
        }

        #endregion
        
        private const string DefaultKey = "AdjustAccountTable";

		/// <summary>
        /// 条件查询[AdjustAccountTable]
        /// </summary>
        /// <param name="entity">[AdjustAccountTable]筛选实例</param>
        /// <returns>[AdjustAccountTable结果集</returns>
        public IList<AdjustAccountTableEntity> Select(AdjustAccountTableEntity entity)
        {
            return s("Select" + DefaultKey, entity);
        }

        /// <summary>
        /// 查询所有[AdjustAccountTable]
        /// </summary>
        /// <returns></returns>
        public IList<AdjustAccountTableEntity> Selects()
        {
            return ss("Select" + DefaultKey);
        }
        /// <summary>
        /// 查询所有[AdjustAccountTable]带排序
        /// </summary>
        /// <param name="orderField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public IList<AdjustAccountTableEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            AdjustAccountTableEntity entity = new AdjustAccountTableEntity() { OrderField = orderField, IsDesc = isDesc };
            return s("Select" + DefaultKey, entity);
        }
    }
}
