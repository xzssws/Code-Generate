using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// DutyFun数据库访问类
    /// </summary>
    public sealed partial class DutyFunDao :BaseDao<DutyFunEntity>,IBaseReal<DutyFunEntity>
    {
		#region 单例模式

		private DutyFunDao(){ }

        private static readonly object LockObj = new object();

        private static DutyFunDao _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static DutyFunDao Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new DutyFunDao();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        private const string DefaultKey = "DutyFun";

        /// <summary>
        /// 添加一条[DutyFun]
        /// </summary>
        /// <param name="entity">[DutyFun]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Add(DutyFunEntity entity)
        {
            return i("Add" + DefaultKey, entity);
        }

        /// <summary>
        /// 更新一条[DutyFun]
        /// </summary>
        /// <param name="entity">更新的[DutyFun]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Update(DutyFunEntity entity)
        {
            return u("Upate" + DefaultKey, entity);
        }

        /// <summary>
        /// 删除一条[DutyFun]
        /// </summary>
        /// <param name="entityID"></param>
        /// <returns>执行完成状态</returns>
        public bool Delete(string entityID)
        {
            return d("Delete" + DefaultKey, entityID);
        }

        /// <summary>
        /// 条件查询[DutyFun]
        /// </summary>
        /// <param name="entity">[DutyFun]筛选实例</param>
        /// <returns>[DutyFun结果集</returns>
        public IList<DutyFunEntity> Select(DutyFunEntity entity)
        {
            return s("Select" + DefaultKey, entity);
        }

        /// <summary>
        /// 查询所有[DutyFun]
        /// </summary>
        /// <returns></returns>
        public IList<DutyFunEntity> Selects()
        {
            return ss("Select" + DefaultKey);
        }
        /// <summary>
        /// 查询所有[DutyFun]带排序
        /// </summary>
        /// <param name="orderField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public IList<DutyFunEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            DutyFunEntity entity = new DutyFunEntity() { OrderField = orderField, IsDesc = isDesc };
            return s("Select" + DefaultKey, entity);
        }
    }
}
