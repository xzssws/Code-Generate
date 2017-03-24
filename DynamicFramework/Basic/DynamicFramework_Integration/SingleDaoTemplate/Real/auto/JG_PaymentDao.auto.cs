using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// JG_Payment数据库访问类
    /// </summary>
    public sealed partial class JG_PaymentDao :BaseDao<JG_PaymentEntity>,IBaseReal<JG_PaymentEntity>
    {
		#region 单例模式

		private JG_PaymentDao(){ }

        private static readonly object LockObj = new object();

        private static JG_PaymentDao _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static JG_PaymentDao Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new JG_PaymentDao();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        private const string DefaultKey = "JG_Payment";

        /// <summary>
        /// 添加一条[JG_Payment]
        /// </summary>
        /// <param name="entity">[JG_Payment]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Add(JG_PaymentEntity entity)
        {
            return i("Add" + DefaultKey, entity);
        }

        /// <summary>
        /// 更新一条[JG_Payment]
        /// </summary>
        /// <param name="entity">更新的[JG_Payment]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Update(JG_PaymentEntity entity)
        {
            return u("Upate" + DefaultKey, entity);
        }

        /// <summary>
        /// 删除一条[JG_Payment]
        /// </summary>
        /// <param name="entityID"></param>
        /// <returns>执行完成状态</returns>
        public bool Delete(string entityID)
        {
            return d("Delete" + DefaultKey, entityID);
        }

        /// <summary>
        /// 条件查询[JG_Payment]
        /// </summary>
        /// <param name="entity">[JG_Payment]筛选实例</param>
        /// <returns>[JG_Payment结果集</returns>
        public IList<JG_PaymentEntity> Select(JG_PaymentEntity entity)
        {
            return s("Select" + DefaultKey, entity);
        }

        /// <summary>
        /// 查询所有[JG_Payment]
        /// </summary>
        /// <returns></returns>
        public IList<JG_PaymentEntity> Selects()
        {
            return ss("Select" + DefaultKey);
        }
        /// <summary>
        /// 查询所有[JG_Payment]带排序
        /// </summary>
        /// <param name="orderField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public IList<JG_PaymentEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            JG_PaymentEntity entity = new JG_PaymentEntity() { OrderField = orderField, IsDesc = isDesc };
            return s("Select" + DefaultKey, entity);
        }
    }
}
