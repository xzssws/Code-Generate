using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// JG_SpvProtocol数据库访问类
    /// </summary>
    public sealed partial class JG_SpvProtocolDao :BaseDao<JG_SpvProtocolEntity>,IBaseReal<JG_SpvProtocolEntity>
    {
		#region 单例模式

		private JG_SpvProtocolDao(){ }

        private static readonly object LockObj = new object();

        private static JG_SpvProtocolDao _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static JG_SpvProtocolDao Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new JG_SpvProtocolDao();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        private const string DefaultKey = "JG_SpvProtocol";

        /// <summary>
        /// 添加一条[JG_SpvProtocol]
        /// </summary>
        /// <param name="entity">[JG_SpvProtocol]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Add(JG_SpvProtocolEntity entity)
        {
            return i("Add" + DefaultKey, entity);
        }

        /// <summary>
        /// 更新一条[JG_SpvProtocol]
        /// </summary>
        /// <param name="entity">更新的[JG_SpvProtocol]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Update(JG_SpvProtocolEntity entity)
        {
            return u("Upate" + DefaultKey, entity);
        }

        /// <summary>
        /// 删除一条[JG_SpvProtocol]
        /// </summary>
        /// <param name="entityID"></param>
        /// <returns>执行完成状态</returns>
        public bool Delete(string entityID)
        {
            return d("Delete" + DefaultKey, entityID);
        }

        /// <summary>
        /// 条件查询[JG_SpvProtocol]
        /// </summary>
        /// <param name="entity">[JG_SpvProtocol]筛选实例</param>
        /// <returns>[JG_SpvProtocol结果集</returns>
        public IList<JG_SpvProtocolEntity> Select(JG_SpvProtocolEntity entity)
        {
            return s("Select" + DefaultKey, entity);
        }

        /// <summary>
        /// 查询所有[JG_SpvProtocol]
        /// </summary>
        /// <returns></returns>
        public IList<JG_SpvProtocolEntity> Selects()
        {
            return ss("Select" + DefaultKey);
        }
        /// <summary>
        /// 查询所有[JG_SpvProtocol]带排序
        /// </summary>
        /// <param name="orderField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public IList<JG_SpvProtocolEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            JG_SpvProtocolEntity entity = new JG_SpvProtocolEntity() { OrderField = orderField, IsDesc = isDesc };
            return s("Select" + DefaultKey, entity);
        }
    }
}
