using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// FundCollectInfo数据库访问类
    /// </summary>
    public sealed partial class FundCollectInfoDao :BaseDao<FundCollectInfoEntity>,IBaseLogic<FundCollectInfoEntity>
    {
		#region 单例模式

		private FundCollectInfoDao(){ }

        private static readonly object LockObj = new object();

        private static FundCollectInfoDao _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static FundCollectInfoDao Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new FundCollectInfoDao();
                    }
                    return _instance;
                }
            }
        }

        #endregion
        
        private const string DefaultKey = "FundCollectInfo";

		/// <summary>
        /// 条件查询[FundCollectInfo]
        /// </summary>
        /// <param name="entity">[FundCollectInfo]筛选实例</param>
        /// <returns>[FundCollectInfo结果集</returns>
        public IList<FundCollectInfoEntity> Select(FundCollectInfoEntity entity)
        {
            return s("Select" + DefaultKey, entity);
        }

        /// <summary>
        /// 查询所有[FundCollectInfo]
        /// </summary>
        /// <returns></returns>
        public IList<FundCollectInfoEntity> Selects()
        {
            return ss("Select" + DefaultKey);
        }
        /// <summary>
        /// 查询所有[FundCollectInfo]带排序
        /// </summary>
        /// <param name="orderField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public IList<FundCollectInfoEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            FundCollectInfoEntity entity = new FundCollectInfoEntity() { OrderField = orderField, IsDesc = isDesc };
            return s("Select" + DefaultKey, entity);
        }
    }
}
