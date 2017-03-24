using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// JG_AmountCollect数据库访问类
    /// </summary>
    public sealed partial class JG_AmountCollectDao :BaseDao<JG_AmountCollectEntity>,IBaseReal<JG_AmountCollectEntity>
    {
		#region 单例模式

		private JG_AmountCollectDao(){ }

        private static readonly object LockObj = new object();

        private static JG_AmountCollectDao _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static JG_AmountCollectDao Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new JG_AmountCollectDao();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        private const string DefaultKey = "JG_AmountCollect";

        /// <summary>
        /// 添加一条[JG_AmountCollect]
        /// </summary>
        /// <param name="entity">[JG_AmountCollect]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Add(JG_AmountCollectEntity entity)
        {
            return i("Add" + DefaultKey, entity);
        }

        /// <summary>
        /// 更新一条[JG_AmountCollect]
        /// </summary>
        /// <param name="entity">更新的[JG_AmountCollect]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Update(JG_AmountCollectEntity entity)
        {
            return u("Upate" + DefaultKey, entity);
        }

        /// <summary>
        /// 删除一条[JG_AmountCollect]
        /// </summary>
        /// <param name="entityID"></param>
        /// <returns>执行完成状态</returns>
        public bool Delete(string entityID)
        {
            return d("Delete" + DefaultKey, entityID);
        }

        /// <summary>
        /// 条件查询[JG_AmountCollect]
        /// </summary>
        /// <param name="entity">[JG_AmountCollect]筛选实例</param>
        /// <returns>[JG_AmountCollect结果集</returns>
        public IList<JG_AmountCollectEntity> Select(JG_AmountCollectEntity entity)
        {
            return s("Select" + DefaultKey, entity);
        }

        /// <summary>
        /// 查询所有[JG_AmountCollect]
        /// </summary>
        /// <returns></returns>
        public IList<JG_AmountCollectEntity> Selects()
        {
            return ss("Select" + DefaultKey);
        }
        /// <summary>
        /// 查询所有[JG_AmountCollect]带排序
        /// </summary>
        /// <param name="orderField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public IList<JG_AmountCollectEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            JG_AmountCollectEntity entity = new JG_AmountCollectEntity() { OrderField = orderField, IsDesc = isDesc };
            return s("Select" + DefaultKey, entity);
        }
    }
}
