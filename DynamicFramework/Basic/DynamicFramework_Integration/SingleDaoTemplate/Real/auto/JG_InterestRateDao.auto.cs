using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// JG_InterestRate数据库访问类
    /// </summary>
    public sealed partial class JG_InterestRateDao :BaseDao<JG_InterestRateEntity>,IBaseReal<JG_InterestRateEntity>
    {
		#region 单例模式

		private JG_InterestRateDao(){ }

        private static readonly object LockObj = new object();

        private static JG_InterestRateDao _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static JG_InterestRateDao Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new JG_InterestRateDao();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        private const string DefaultKey = "JG_InterestRate";

        /// <summary>
        /// 添加一条[JG_InterestRate]
        /// </summary>
        /// <param name="entity">[JG_InterestRate]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Add(JG_InterestRateEntity entity)
        {
            return i("Add" + DefaultKey, entity);
        }

        /// <summary>
        /// 更新一条[JG_InterestRate]
        /// </summary>
        /// <param name="entity">更新的[JG_InterestRate]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Update(JG_InterestRateEntity entity)
        {
            return u("Upate" + DefaultKey, entity);
        }

        /// <summary>
        /// 删除一条[JG_InterestRate]
        /// </summary>
        /// <param name="entityID"></param>
        /// <returns>执行完成状态</returns>
        public bool Delete(string entityID)
        {
            return d("Delete" + DefaultKey, entityID);
        }

        /// <summary>
        /// 条件查询[JG_InterestRate]
        /// </summary>
        /// <param name="entity">[JG_InterestRate]筛选实例</param>
        /// <returns>[JG_InterestRate结果集</returns>
        public IList<JG_InterestRateEntity> Select(JG_InterestRateEntity entity)
        {
            return s("Select" + DefaultKey, entity);
        }

        /// <summary>
        /// 查询所有[JG_InterestRate]
        /// </summary>
        /// <returns></returns>
        public IList<JG_InterestRateEntity> Selects()
        {
            return ss("Select" + DefaultKey);
        }
        /// <summary>
        /// 查询所有[JG_InterestRate]带排序
        /// </summary>
        /// <param name="orderField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public IList<JG_InterestRateEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            JG_InterestRateEntity entity = new JG_InterestRateEntity() { OrderField = orderField, IsDesc = isDesc };
            return s("Select" + DefaultKey, entity);
        }
    }
}
