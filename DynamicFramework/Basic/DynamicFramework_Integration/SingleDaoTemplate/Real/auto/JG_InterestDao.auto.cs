using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// JG_Interest数据库访问类
    /// </summary>
    public sealed partial class JG_InterestDao :BaseDao<JG_InterestEntity>,IBaseReal<JG_InterestEntity>
    {
		#region 单例模式

		private JG_InterestDao(){ }

        private static readonly object LockObj = new object();

        private static JG_InterestDao _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static JG_InterestDao Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new JG_InterestDao();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        private const string DefaultKey = "JG_Interest";

        /// <summary>
        /// 添加一条[JG_Interest]
        /// </summary>
        /// <param name="entity">[JG_Interest]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Add(JG_InterestEntity entity)
        {
            return i("Add" + DefaultKey, entity);
        }

        /// <summary>
        /// 更新一条[JG_Interest]
        /// </summary>
        /// <param name="entity">更新的[JG_Interest]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Update(JG_InterestEntity entity)
        {
            return u("Upate" + DefaultKey, entity);
        }

        /// <summary>
        /// 删除一条[JG_Interest]
        /// </summary>
        /// <param name="entityID"></param>
        /// <returns>执行完成状态</returns>
        public bool Delete(string entityID)
        {
            return d("Delete" + DefaultKey, entityID);
        }

        /// <summary>
        /// 条件查询[JG_Interest]
        /// </summary>
        /// <param name="entity">[JG_Interest]筛选实例</param>
        /// <returns>[JG_Interest结果集</returns>
        public IList<JG_InterestEntity> Select(JG_InterestEntity entity)
        {
            return s("Select" + DefaultKey, entity);
        }

        /// <summary>
        /// 查询所有[JG_Interest]
        /// </summary>
        /// <returns></returns>
        public IList<JG_InterestEntity> Selects()
        {
            return ss("Select" + DefaultKey);
        }
        /// <summary>
        /// 查询所有[JG_Interest]带排序
        /// </summary>
        /// <param name="orderField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public IList<JG_InterestEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            JG_InterestEntity entity = new JG_InterestEntity() { OrderField = orderField, IsDesc = isDesc };
            return s("Select" + DefaultKey, entity);
        }
    }
}
