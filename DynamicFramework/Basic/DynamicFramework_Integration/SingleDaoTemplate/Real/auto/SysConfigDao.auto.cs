using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// SysConfig数据库访问类
    /// </summary>
    public sealed partial class SysConfigDao :BaseDao<SysConfigEntity>,IBaseReal<SysConfigEntity>
    {
		#region 单例模式

		private SysConfigDao(){ }

        private static readonly object LockObj = new object();

        private static SysConfigDao _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static SysConfigDao Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new SysConfigDao();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        private const string DefaultKey = "SysConfig";

        /// <summary>
        /// 添加一条[SysConfig]
        /// </summary>
        /// <param name="entity">[SysConfig]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Add(SysConfigEntity entity)
        {
            return i("Add" + DefaultKey, entity);
        }

        /// <summary>
        /// 更新一条[SysConfig]
        /// </summary>
        /// <param name="entity">更新的[SysConfig]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Update(SysConfigEntity entity)
        {
            return u("Upate" + DefaultKey, entity);
        }

        /// <summary>
        /// 删除一条[SysConfig]
        /// </summary>
        /// <param name="entityID"></param>
        /// <returns>执行完成状态</returns>
        public bool Delete(string entityID)
        {
            return d("Delete" + DefaultKey, entityID);
        }

        /// <summary>
        /// 条件查询[SysConfig]
        /// </summary>
        /// <param name="entity">[SysConfig]筛选实例</param>
        /// <returns>[SysConfig结果集</returns>
        public IList<SysConfigEntity> Select(SysConfigEntity entity)
        {
            return s("Select" + DefaultKey, entity);
        }

        /// <summary>
        /// 查询所有[SysConfig]
        /// </summary>
        /// <returns></returns>
        public IList<SysConfigEntity> Selects()
        {
            return ss("Select" + DefaultKey);
        }
        /// <summary>
        /// 查询所有[SysConfig]带排序
        /// </summary>
        /// <param name="orderField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public IList<SysConfigEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            SysConfigEntity entity = new SysConfigEntity() { OrderField = orderField, IsDesc = isDesc };
            return s("Select" + DefaultKey, entity);
        }
    }
}
