using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// 实体字典数据库访问类
    /// </summary>
    public sealed partial class 实体字典Dao :BaseDao<实体字典Entity>,IBaseLogic<实体字典Entity>
    {
		#region 单例模式

		private 实体字典Dao(){ }

        private static readonly object LockObj = new object();

        private static 实体字典Dao _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static 实体字典Dao Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new 实体字典Dao();
                    }
                    return _instance;
                }
            }
        }

        #endregion
        
        private const string DefaultKey = "实体字典";

		/// <summary>
        /// 条件查询[实体字典]
        /// </summary>
        /// <param name="entity">[实体字典]筛选实例</param>
        /// <returns>[实体字典结果集</returns>
        public IList<实体字典Entity> Select(实体字典Entity entity)
        {
            return s("Select" + DefaultKey, entity);
        }

        /// <summary>
        /// 查询所有[实体字典]
        /// </summary>
        /// <returns></returns>
        public IList<实体字典Entity> Selects()
        {
            return ss("Select" + DefaultKey);
        }
        /// <summary>
        /// 查询所有[实体字典]带排序
        /// </summary>
        /// <param name="orderField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public IList<实体字典Entity> SelectsOrderBy(string orderField,bool isDesc)
        {
            实体字典Entity entity = new 实体字典Entity() { OrderField = orderField, IsDesc = isDesc };
            return s("Select" + DefaultKey, entity);
        }
    }
}
