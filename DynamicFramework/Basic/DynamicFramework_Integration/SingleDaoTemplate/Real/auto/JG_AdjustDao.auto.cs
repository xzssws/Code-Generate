using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// JG_Adjust数据库访问类
    /// </summary>
    public sealed partial class JG_AdjustDao :BaseDao<JG_AdjustEntity>,IBaseReal<JG_AdjustEntity>
    {
		#region 单例模式

		private JG_AdjustDao(){ }

        private static readonly object LockObj = new object();

        private static JG_AdjustDao _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static JG_AdjustDao Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new JG_AdjustDao();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        private const string DefaultKey = "JG_Adjust";

        /// <summary>
        /// 添加一条[JG_Adjust]
        /// </summary>
        /// <param name="entity">[JG_Adjust]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Add(JG_AdjustEntity entity)
        {
            return i("Add" + DefaultKey, entity);
        }

        /// <summary>
        /// 更新一条[JG_Adjust]
        /// </summary>
        /// <param name="entity">更新的[JG_Adjust]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Update(JG_AdjustEntity entity)
        {
            return u("Upate" + DefaultKey, entity);
        }

        /// <summary>
        /// 删除一条[JG_Adjust]
        /// </summary>
        /// <param name="entityID"></param>
        /// <returns>执行完成状态</returns>
        public bool Delete(string entityID)
        {
            return d("Delete" + DefaultKey, entityID);
        }

        /// <summary>
        /// 条件查询[JG_Adjust]
        /// </summary>
        /// <param name="entity">[JG_Adjust]筛选实例</param>
        /// <returns>[JG_Adjust结果集</returns>
        public IList<JG_AdjustEntity> Select(JG_AdjustEntity entity)
        {
            return s("Select" + DefaultKey, entity);
        }

        /// <summary>
        /// 查询所有[JG_Adjust]
        /// </summary>
        /// <returns></returns>
        public IList<JG_AdjustEntity> Selects()
        {
            return ss("Select" + DefaultKey);
        }
        /// <summary>
        /// 查询所有[JG_Adjust]带排序
        /// </summary>
        /// <param name="orderField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public IList<JG_AdjustEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            JG_AdjustEntity entity = new JG_AdjustEntity() { OrderField = orderField, IsDesc = isDesc };
            return s("Select" + DefaultKey, entity);
        }
    }
}
