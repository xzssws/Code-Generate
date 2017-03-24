using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// UserDuty数据库访问类
    /// </summary>
    public sealed partial class UserDutyDao :BaseDao<UserDutyEntity>,IBaseReal<UserDutyEntity>
    {
		#region 单例模式

		private UserDutyDao(){ }

        private static readonly object LockObj = new object();

        private static UserDutyDao _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static UserDutyDao Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new UserDutyDao();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        private const string DefaultKey = "UserDuty";

        /// <summary>
        /// 添加一条[UserDuty]
        /// </summary>
        /// <param name="entity">[UserDuty]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Add(UserDutyEntity entity)
        {
            return i("Add" + DefaultKey, entity);
        }

        /// <summary>
        /// 更新一条[UserDuty]
        /// </summary>
        /// <param name="entity">更新的[UserDuty]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Update(UserDutyEntity entity)
        {
            return u("Upate" + DefaultKey, entity);
        }

        /// <summary>
        /// 删除一条[UserDuty]
        /// </summary>
        /// <param name="entityID"></param>
        /// <returns>执行完成状态</returns>
        public bool Delete(string entityID)
        {
            return d("Delete" + DefaultKey, entityID);
        }

        /// <summary>
        /// 条件查询[UserDuty]
        /// </summary>
        /// <param name="entity">[UserDuty]筛选实例</param>
        /// <returns>[UserDuty结果集</returns>
        public IList<UserDutyEntity> Select(UserDutyEntity entity)
        {
            return s("Select" + DefaultKey, entity);
        }

        /// <summary>
        /// 查询所有[UserDuty]
        /// </summary>
        /// <returns></returns>
        public IList<UserDutyEntity> Selects()
        {
            return ss("Select" + DefaultKey);
        }
        /// <summary>
        /// 查询所有[UserDuty]带排序
        /// </summary>
        /// <param name="orderField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public IList<UserDutyEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            UserDutyEntity entity = new UserDutyEntity() { OrderField = orderField, IsDesc = isDesc };
            return s("Select" + DefaultKey, entity);
        }
    }
}
