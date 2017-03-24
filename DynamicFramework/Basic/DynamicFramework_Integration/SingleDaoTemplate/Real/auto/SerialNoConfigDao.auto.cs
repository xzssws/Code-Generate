using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// SerialNoConfig数据库访问类
    /// </summary>
    public sealed partial class SerialNoConfigDao :BaseDao<SerialNoConfigEntity>,IBaseReal<SerialNoConfigEntity>
    {
		#region 单例模式

		private SerialNoConfigDao(){ }

        private static readonly object LockObj = new object();

        private static SerialNoConfigDao _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static SerialNoConfigDao Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new SerialNoConfigDao();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        private const string DefaultKey = "SerialNoConfig";

        /// <summary>
        /// 添加一条[SerialNoConfig]
        /// </summary>
        /// <param name="entity">[SerialNoConfig]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Add(SerialNoConfigEntity entity)
        {
            return i("Add" + DefaultKey, entity);
        }

        /// <summary>
        /// 更新一条[SerialNoConfig]
        /// </summary>
        /// <param name="entity">更新的[SerialNoConfig]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Update(SerialNoConfigEntity entity)
        {
            return u("Upate" + DefaultKey, entity);
        }

        /// <summary>
        /// 删除一条[SerialNoConfig]
        /// </summary>
        /// <param name="entityID"></param>
        /// <returns>执行完成状态</returns>
        public bool Delete(string entityID)
        {
            return d("Delete" + DefaultKey, entityID);
        }

        /// <summary>
        /// 条件查询[SerialNoConfig]
        /// </summary>
        /// <param name="entity">[SerialNoConfig]筛选实例</param>
        /// <returns>[SerialNoConfig结果集</returns>
        public IList<SerialNoConfigEntity> Select(SerialNoConfigEntity entity)
        {
            return s("Select" + DefaultKey, entity);
        }

        /// <summary>
        /// 查询所有[SerialNoConfig]
        /// </summary>
        /// <returns></returns>
        public IList<SerialNoConfigEntity> Selects()
        {
            return ss("Select" + DefaultKey);
        }
        /// <summary>
        /// 查询所有[SerialNoConfig]带排序
        /// </summary>
        /// <param name="orderField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public IList<SerialNoConfigEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            SerialNoConfigEntity entity = new SerialNoConfigEntity() { OrderField = orderField, IsDesc = isDesc };
            return s("Select" + DefaultKey, entity);
        }
    }
}
