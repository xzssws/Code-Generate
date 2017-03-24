using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// JG_AccountManage数据库访问类
    /// </summary>
    public sealed partial class JG_AccountManageDao :BaseDao<JG_AccountManageEntity>,IBaseReal<JG_AccountManageEntity>
    {
		#region 单例模式

		private JG_AccountManageDao(){ }

        private static readonly object LockObj = new object();

        private static JG_AccountManageDao _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static JG_AccountManageDao Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new JG_AccountManageDao();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        private const string DefaultKey = "JG_AccountManage";

        /// <summary>
        /// 添加一条[JG_AccountManage]
        /// </summary>
        /// <param name="entity">[JG_AccountManage]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Add(JG_AccountManageEntity entity)
        {
            return i("Add" + DefaultKey, entity);
        }

        /// <summary>
        /// 更新一条[JG_AccountManage]
        /// </summary>
        /// <param name="entity">更新的[JG_AccountManage]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Update(JG_AccountManageEntity entity)
        {
            return u("Upate" + DefaultKey, entity);
        }

        /// <summary>
        /// 删除一条[JG_AccountManage]
        /// </summary>
        /// <param name="entityID"></param>
        /// <returns>执行完成状态</returns>
        public bool Delete(string entityID)
        {
            return d("Delete" + DefaultKey, entityID);
        }

        /// <summary>
        /// 条件查询[JG_AccountManage]
        /// </summary>
        /// <param name="entity">[JG_AccountManage]筛选实例</param>
        /// <returns>[JG_AccountManage结果集</returns>
        public IList<JG_AccountManageEntity> Select(JG_AccountManageEntity entity)
        {
            return s("Select" + DefaultKey, entity);
        }

        /// <summary>
        /// 查询所有[JG_AccountManage]
        /// </summary>
        /// <returns></returns>
        public IList<JG_AccountManageEntity> Selects()
        {
            return ss("Select" + DefaultKey);
        }
        /// <summary>
        /// 查询所有[JG_AccountManage]带排序
        /// </summary>
        /// <param name="orderField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public IList<JG_AccountManageEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            JG_AccountManageEntity entity = new JG_AccountManageEntity() { OrderField = orderField, IsDesc = isDesc };
            return s("Select" + DefaultKey, entity);
        }
    }
}
