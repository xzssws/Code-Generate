using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// JG_MessageInfo数据库访问类
    /// </summary>
    public sealed partial class JG_MessageInfoDao :BaseDao<JG_MessageInfoEntity>,IBaseReal<JG_MessageInfoEntity>
    {
		#region 单例模式

		private JG_MessageInfoDao(){ }

        private static readonly object LockObj = new object();

        private static JG_MessageInfoDao _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static JG_MessageInfoDao Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new JG_MessageInfoDao();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        private const string DefaultKey = "JG_MessageInfo";

        /// <summary>
        /// 添加一条[JG_MessageInfo]
        /// </summary>
        /// <param name="entity">[JG_MessageInfo]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Add(JG_MessageInfoEntity entity)
        {
            return i("Add" + DefaultKey, entity);
        }

        /// <summary>
        /// 更新一条[JG_MessageInfo]
        /// </summary>
        /// <param name="entity">更新的[JG_MessageInfo]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Update(JG_MessageInfoEntity entity)
        {
            return u("Upate" + DefaultKey, entity);
        }

        /// <summary>
        /// 删除一条[JG_MessageInfo]
        /// </summary>
        /// <param name="entityID"></param>
        /// <returns>执行完成状态</returns>
        public bool Delete(string entityID)
        {
            return d("Delete" + DefaultKey, entityID);
        }

        /// <summary>
        /// 条件查询[JG_MessageInfo]
        /// </summary>
        /// <param name="entity">[JG_MessageInfo]筛选实例</param>
        /// <returns>[JG_MessageInfo结果集</returns>
        public IList<JG_MessageInfoEntity> Select(JG_MessageInfoEntity entity)
        {
            return s("Select" + DefaultKey, entity);
        }

        /// <summary>
        /// 查询所有[JG_MessageInfo]
        /// </summary>
        /// <returns></returns>
        public IList<JG_MessageInfoEntity> Selects()
        {
            return ss("Select" + DefaultKey);
        }
        /// <summary>
        /// 查询所有[JG_MessageInfo]带排序
        /// </summary>
        /// <param name="orderField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public IList<JG_MessageInfoEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            JG_MessageInfoEntity entity = new JG_MessageInfoEntity() { OrderField = orderField, IsDesc = isDesc };
            return s("Select" + DefaultKey, entity);
        }
    }
}
