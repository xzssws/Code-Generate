using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// DspFunc数据库访问类
    /// </summary>
    public sealed partial class DspFuncDao :BaseDao<DspFuncEntity>,IBaseReal<DspFuncEntity>
    {
		#region 单例模式

		private DspFuncDao(){ }

        private static readonly object LockObj = new object();

        private static DspFuncDao _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static DspFuncDao Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new DspFuncDao();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        private const string DefaultKey = "DspFunc";

        /// <summary>
        /// 添加一条[DspFunc]
        /// </summary>
        /// <param name="entity">[DspFunc]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Add(DspFuncEntity entity)
        {
            return i("Add" + DefaultKey, entity);
        }

        /// <summary>
        /// 更新一条[DspFunc]
        /// </summary>
        /// <param name="entity">更新的[DspFunc]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Update(DspFuncEntity entity)
        {
            return u("Upate" + DefaultKey, entity);
        }

        /// <summary>
        /// 删除一条[DspFunc]
        /// </summary>
        /// <param name="entityID"></param>
        /// <returns>执行完成状态</returns>
        public bool Delete(string entityID)
        {
            return d("Delete" + DefaultKey, entityID);
        }

        /// <summary>
        /// 条件查询[DspFunc]
        /// </summary>
        /// <param name="entity">[DspFunc]筛选实例</param>
        /// <returns>[DspFunc结果集</returns>
        public IList<DspFuncEntity> Select(DspFuncEntity entity)
        {
            return s("Select" + DefaultKey, entity);
        }

        /// <summary>
        /// 查询所有[DspFunc]
        /// </summary>
        /// <returns></returns>
        public IList<DspFuncEntity> Selects()
        {
            return ss("Select" + DefaultKey);
        }
        /// <summary>
        /// 查询所有[DspFunc]带排序
        /// </summary>
        /// <param name="orderField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public IList<DspFuncEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            DspFuncEntity entity = new DspFuncEntity() { OrderField = orderField, IsDesc = isDesc };
            return s("Select" + DefaultKey, entity);
        }
    }
}
