using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// ParmItem数据库访问类
    /// </summary>
    public sealed partial class ParmItemDao :BaseDao<ParmItemEntity>,IBaseReal<ParmItemEntity>
    {
		#region 单例模式

		private ParmItemDao(){ }

        private static readonly object LockObj = new object();

        private static ParmItemDao _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static ParmItemDao Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new ParmItemDao();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        private const string DefaultKey = "ParmItem";

        /// <summary>
        /// 添加一条[ParmItem]
        /// </summary>
        /// <param name="entity">[ParmItem]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Add(ParmItemEntity entity)
        {
            return i("Add" + DefaultKey, entity);
        }

        /// <summary>
        /// 更新一条[ParmItem]
        /// </summary>
        /// <param name="entity">更新的[ParmItem]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Update(ParmItemEntity entity)
        {
            return u("Upate" + DefaultKey, entity);
        }

        /// <summary>
        /// 删除一条[ParmItem]
        /// </summary>
        /// <param name="entityID"></param>
        /// <returns>执行完成状态</returns>
        public bool Delete(string entityID)
        {
            return d("Delete" + DefaultKey, entityID);
        }

        /// <summary>
        /// 条件查询[ParmItem]
        /// </summary>
        /// <param name="entity">[ParmItem]筛选实例</param>
        /// <returns>[ParmItem结果集</returns>
        public IList<ParmItemEntity> Select(ParmItemEntity entity)
        {
            return s("Select" + DefaultKey, entity);
        }

        /// <summary>
        /// 查询所有[ParmItem]
        /// </summary>
        /// <returns></returns>
        public IList<ParmItemEntity> Selects()
        {
            return ss("Select" + DefaultKey);
        }
        /// <summary>
        /// 查询所有[ParmItem]带排序
        /// </summary>
        /// <param name="orderField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public IList<ParmItemEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            ParmItemEntity entity = new ParmItemEntity() { OrderField = orderField, IsDesc = isDesc };
            return s("Select" + DefaultKey, entity);
        }
    }
}
