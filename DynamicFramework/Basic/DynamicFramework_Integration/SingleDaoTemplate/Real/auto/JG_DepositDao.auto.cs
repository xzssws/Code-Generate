using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// JG_Deposit数据库访问类
    /// </summary>
    public sealed partial class JG_DepositDao :BaseDao<JG_DepositEntity>,IBaseReal<JG_DepositEntity>
    {
		#region 单例模式

		private JG_DepositDao(){ }

        private static readonly object LockObj = new object();

        private static JG_DepositDao _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static JG_DepositDao Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new JG_DepositDao();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        private const string DefaultKey = "JG_Deposit";

        /// <summary>
        /// 添加一条[JG_Deposit]
        /// </summary>
        /// <param name="entity">[JG_Deposit]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Add(JG_DepositEntity entity)
        {
            return i("Add" + DefaultKey, entity);
        }

        /// <summary>
        /// 更新一条[JG_Deposit]
        /// </summary>
        /// <param name="entity">更新的[JG_Deposit]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Update(JG_DepositEntity entity)
        {
            return u("Upate" + DefaultKey, entity);
        }

        /// <summary>
        /// 删除一条[JG_Deposit]
        /// </summary>
        /// <param name="entityID"></param>
        /// <returns>执行完成状态</returns>
        public bool Delete(string entityID)
        {
            return d("Delete" + DefaultKey, entityID);
        }

        /// <summary>
        /// 条件查询[JG_Deposit]
        /// </summary>
        /// <param name="entity">[JG_Deposit]筛选实例</param>
        /// <returns>[JG_Deposit结果集</returns>
        public IList<JG_DepositEntity> Select(JG_DepositEntity entity)
        {
            return s("Select" + DefaultKey, entity);
        }

        /// <summary>
        /// 查询所有[JG_Deposit]
        /// </summary>
        /// <returns></returns>
        public IList<JG_DepositEntity> Selects()
        {
            return ss("Select" + DefaultKey);
        }
        /// <summary>
        /// 查询所有[JG_Deposit]带排序
        /// </summary>
        /// <param name="orderField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public IList<JG_DepositEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            JG_DepositEntity entity = new JG_DepositEntity() { OrderField = orderField, IsDesc = isDesc };
            return s("Select" + DefaultKey, entity);
        }
    }
}
