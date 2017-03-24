using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// JG_Branches数据库访问类
    /// </summary>
    public sealed partial class JG_BranchesDao :BaseDao<JG_BranchesEntity>,IBaseReal<JG_BranchesEntity>
    {
		#region 单例模式

		private JG_BranchesDao(){ }

        private static readonly object LockObj = new object();

        private static JG_BranchesDao _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static JG_BranchesDao Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new JG_BranchesDao();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        private const string DefaultKey = "JG_Branches";

        /// <summary>
        /// 添加一条[JG_Branches]
        /// </summary>
        /// <param name="entity">[JG_Branches]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Add(JG_BranchesEntity entity)
        {
            return i("Add" + DefaultKey, entity);
        }

        /// <summary>
        /// 更新一条[JG_Branches]
        /// </summary>
        /// <param name="entity">更新的[JG_Branches]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Update(JG_BranchesEntity entity)
        {
            return u("Upate" + DefaultKey, entity);
        }

        /// <summary>
        /// 删除一条[JG_Branches]
        /// </summary>
        /// <param name="entityID"></param>
        /// <returns>执行完成状态</returns>
        public bool Delete(string entityID)
        {
            return d("Delete" + DefaultKey, entityID);
        }

        /// <summary>
        /// 条件查询[JG_Branches]
        /// </summary>
        /// <param name="entity">[JG_Branches]筛选实例</param>
        /// <returns>[JG_Branches结果集</returns>
        public IList<JG_BranchesEntity> Select(JG_BranchesEntity entity)
        {
            return s("Select" + DefaultKey, entity);
        }

        /// <summary>
        /// 查询所有[JG_Branches]
        /// </summary>
        /// <returns></returns>
        public IList<JG_BranchesEntity> Selects()
        {
            return ss("Select" + DefaultKey);
        }
        /// <summary>
        /// 查询所有[JG_Branches]带排序
        /// </summary>
        /// <param name="orderField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public IList<JG_BranchesEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            JG_BranchesEntity entity = new JG_BranchesEntity() { OrderField = orderField, IsDesc = isDesc };
            return s("Select" + DefaultKey, entity);
        }
    }
}
