using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// ShowAllModels数据库访问类
    /// </summary>
    public sealed partial class ShowAllModelsDao :BaseDao<ShowAllModelsEntity>,IBaseLogic<ShowAllModelsEntity>
    {
		#region 单例模式

		private ShowAllModelsDao(){ }

        private static readonly object LockObj = new object();

        private static ShowAllModelsDao _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static ShowAllModelsDao Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new ShowAllModelsDao();
                    }
                    return _instance;
                }
            }
        }

        #endregion
        
        private const string DefaultKey = "ShowAllModels";

		/// <summary>
        /// 条件查询[ShowAllModels]
        /// </summary>
        /// <param name="entity">[ShowAllModels]筛选实例</param>
        /// <returns>[ShowAllModels结果集</returns>
        public IList<ShowAllModelsEntity> Select(ShowAllModelsEntity entity)
        {
            return s("Select" + DefaultKey, entity);
        }

        /// <summary>
        /// 查询所有[ShowAllModels]
        /// </summary>
        /// <returns></returns>
        public IList<ShowAllModelsEntity> Selects()
        {
            return ss("Select" + DefaultKey);
        }
        /// <summary>
        /// 查询所有[ShowAllModels]带排序
        /// </summary>
        /// <param name="orderField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public IList<ShowAllModelsEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            ShowAllModelsEntity entity = new ShowAllModelsEntity() { OrderField = orderField, IsDesc = isDesc };
            return s("Select" + DefaultKey, entity);
        }
    }
}
