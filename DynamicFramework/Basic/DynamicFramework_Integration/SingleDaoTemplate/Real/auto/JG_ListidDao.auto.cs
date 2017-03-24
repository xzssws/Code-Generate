using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// JG_Listid数据库访问类
    /// </summary>
    public sealed partial class JG_ListidDao :BaseDao<JG_ListidEntity>,IBaseReal<JG_ListidEntity>
    {
		#region 单例模式

		private JG_ListidDao(){ }

        private static readonly object LockObj = new object();

        private static JG_ListidDao _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static JG_ListidDao Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new JG_ListidDao();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        private const string DefaultKey = "JG_Listid";

        /// <summary>
        /// 添加一条[JG_Listid]
        /// </summary>
        /// <param name="entity">[JG_Listid]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Add(JG_ListidEntity entity)
        {
            return i("Add" + DefaultKey, entity);
        }

        /// <summary>
        /// 更新一条[JG_Listid]
        /// </summary>
        /// <param name="entity">更新的[JG_Listid]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Update(JG_ListidEntity entity)
        {
            return u("Upate" + DefaultKey, entity);
        }

        /// <summary>
        /// 删除一条[JG_Listid]
        /// </summary>
        /// <param name="entityID"></param>
        /// <returns>执行完成状态</returns>
        public bool Delete(string entityID)
        {
            return d("Delete" + DefaultKey, entityID);
        }

        /// <summary>
        /// 条件查询[JG_Listid]
        /// </summary>
        /// <param name="entity">[JG_Listid]筛选实例</param>
        /// <returns>[JG_Listid结果集</returns>
        public IList<JG_ListidEntity> Select(JG_ListidEntity entity)
        {
            return s("Select" + DefaultKey, entity);
        }

        /// <summary>
        /// 查询所有[JG_Listid]
        /// </summary>
        /// <returns></returns>
        public IList<JG_ListidEntity> Selects()
        {
            return ss("Select" + DefaultKey);
        }
        /// <summary>
        /// 查询所有[JG_Listid]带排序
        /// </summary>
        /// <param name="orderField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public IList<JG_ListidEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            JG_ListidEntity entity = new JG_ListidEntity() { OrderField = orderField, IsDesc = isDesc };
            return s("Select" + DefaultKey, entity);
        }
    }
}
