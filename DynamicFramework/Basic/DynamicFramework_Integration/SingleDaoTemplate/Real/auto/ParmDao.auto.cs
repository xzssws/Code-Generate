using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// Parm数据库访问类
    /// </summary>
    public sealed partial class ParmDao :BaseDao<ParmEntity>,IBaseReal<ParmEntity>
    {
		#region 单例模式

		private ParmDao(){ }

        private static readonly object LockObj = new object();

        private static ParmDao _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static ParmDao Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new ParmDao();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        private const string DefaultKey = "Parm";

        /// <summary>
        /// 添加一条[Parm]
        /// </summary>
        /// <param name="entity">[Parm]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Add(ParmEntity entity)
        {
            return i("Add" + DefaultKey, entity);
        }

        /// <summary>
        /// 更新一条[Parm]
        /// </summary>
        /// <param name="entity">更新的[Parm]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Update(ParmEntity entity)
        {
            return u("Upate" + DefaultKey, entity);
        }

        /// <summary>
        /// 删除一条[Parm]
        /// </summary>
        /// <param name="entityID"></param>
        /// <returns>执行完成状态</returns>
        public bool Delete(string entityID)
        {
            return d("Delete" + DefaultKey, entityID);
        }

        /// <summary>
        /// 条件查询[Parm]
        /// </summary>
        /// <param name="entity">[Parm]筛选实例</param>
        /// <returns>[Parm结果集</returns>
        public IList<ParmEntity> Select(ParmEntity entity)
        {
            return s("Select" + DefaultKey, entity);
        }

        /// <summary>
        /// 查询所有[Parm]
        /// </summary>
        /// <returns></returns>
        public IList<ParmEntity> Selects()
        {
            return ss("Select" + DefaultKey);
        }
        /// <summary>
        /// 查询所有[Parm]带排序
        /// </summary>
        /// <param name="orderField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public IList<ParmEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            ParmEntity entity = new ParmEntity() { OrderField = orderField, IsDesc = isDesc };
            return s("Select" + DefaultKey, entity);
        }
    }
}
