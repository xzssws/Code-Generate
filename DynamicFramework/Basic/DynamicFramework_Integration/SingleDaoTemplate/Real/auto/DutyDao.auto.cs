using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// Duty数据库访问类
    /// </summary>
    public sealed partial class DutyDao :BaseDao<DutyEntity>,IBaseReal<DutyEntity>
    {
		#region 单例模式

		private DutyDao(){ }

        private static readonly object LockObj = new object();

        private static DutyDao _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static DutyDao Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new DutyDao();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        private const string DefaultKey = "Duty";

        /// <summary>
        /// 添加一条[Duty]
        /// </summary>
        /// <param name="entity">[Duty]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Add(DutyEntity entity)
        {
            return i("Add" + DefaultKey, entity);
        }

        /// <summary>
        /// 更新一条[Duty]
        /// </summary>
        /// <param name="entity">更新的[Duty]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Update(DutyEntity entity)
        {
            return u("Upate" + DefaultKey, entity);
        }

        /// <summary>
        /// 删除一条[Duty]
        /// </summary>
        /// <param name="entityID"></param>
        /// <returns>执行完成状态</returns>
        public bool Delete(string entityID)
        {
            return d("Delete" + DefaultKey, entityID);
        }

        /// <summary>
        /// 条件查询[Duty]
        /// </summary>
        /// <param name="entity">[Duty]筛选实例</param>
        /// <returns>[Duty结果集</returns>
        public IList<DutyEntity> Select(DutyEntity entity)
        {
            return s("Select" + DefaultKey, entity);
        }

        /// <summary>
        /// 查询所有[Duty]
        /// </summary>
        /// <returns></returns>
        public IList<DutyEntity> Selects()
        {
            return ss("Select" + DefaultKey);
        }
        /// <summary>
        /// 查询所有[Duty]带排序
        /// </summary>
        /// <param name="orderField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public IList<DutyEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            DutyEntity entity = new DutyEntity() { OrderField = orderField, IsDesc = isDesc };
            return s("Select" + DefaultKey, entity);
        }
    }
}
