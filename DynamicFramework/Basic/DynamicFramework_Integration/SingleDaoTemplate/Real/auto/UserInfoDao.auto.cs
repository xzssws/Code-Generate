using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// UserInfo数据库访问类
    /// </summary>
    public sealed partial class UserInfoDao :BaseDao<UserInfoEntity>,IBaseReal<UserInfoEntity>
    {
		#region 单例模式

		private UserInfoDao(){ }

        private static readonly object LockObj = new object();

        private static UserInfoDao _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static UserInfoDao Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new UserInfoDao();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        private const string DefaultKey = "UserInfo";

        /// <summary>
        /// 添加一条[UserInfo]
        /// </summary>
        /// <param name="entity">[UserInfo]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Add(UserInfoEntity entity)
        {
            return i("Add" + DefaultKey, entity);
        }

        /// <summary>
        /// 更新一条[UserInfo]
        /// </summary>
        /// <param name="entity">更新的[UserInfo]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Update(UserInfoEntity entity)
        {
            return u("Upate" + DefaultKey, entity);
        }

        /// <summary>
        /// 删除一条[UserInfo]
        /// </summary>
        /// <param name="entityID"></param>
        /// <returns>执行完成状态</returns>
        public bool Delete(string entityID)
        {
            return d("Delete" + DefaultKey, entityID);
        }

        /// <summary>
        /// 条件查询[UserInfo]
        /// </summary>
        /// <param name="entity">[UserInfo]筛选实例</param>
        /// <returns>[UserInfo结果集</returns>
        public IList<UserInfoEntity> Select(UserInfoEntity entity)
        {
            return s("Select" + DefaultKey, entity);
        }

        /// <summary>
        /// 查询所有[UserInfo]
        /// </summary>
        /// <returns></returns>
        public IList<UserInfoEntity> Selects()
        {
            return ss("Select" + DefaultKey);
        }
        /// <summary>
        /// 查询所有[UserInfo]带排序
        /// </summary>
        /// <param name="orderField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public IList<UserInfoEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            UserInfoEntity entity = new UserInfoEntity() { OrderField = orderField, IsDesc = isDesc };
            return s("Select" + DefaultKey, entity);
        }
    }
}
