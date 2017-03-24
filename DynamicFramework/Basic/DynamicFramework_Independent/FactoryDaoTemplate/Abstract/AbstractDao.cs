using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryDaoTemplate.Abstract
{
    /// <summary>
    /// 父DAO
    /// </summary>
    /// <typeparam name="T">实体类型</typeparam>
    public class AbstractDao<T> : ILogicDao<T>, IRealDao<T> where T : new()
    {

        private static readonly object LockObj = new object();

        private static AbstractDao<T> _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static AbstractDao<T> GetInstance(string Key)
        {

            lock (LockObj)
            {
                if (_instance == null)
                {
                    _instance = new AbstractDao<T>(Key);
                }
                return _instance;
            }

        }

        private AbstractDao(string Key)
        {
            this.DefaultKey = Key;
        }
        /// <summary>
        /// 映射标志
        /// </summary>
        private string DefaultKey;

        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="entity">添加的对象</param>
        /// <returns>是否成功</returns>
        public virtual bool Add(T entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            MyBatis.SqlMap.Insert("Add" + DefaultKey, entity);
            return true;
        }
        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="entity">修改的对象</param>
        /// <returns>是否成功</returns>
        public virtual bool Update(T entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            int result = MyBatis.SqlMap.Update("Update" + DefaultKey, entity);
            return result > 0;
        }
        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="entityID">删除的筛选对象</param>
        /// <returns>是否成功</returns>
        public virtual bool Delete(string entityID)
        {
            if (string.IsNullOrEmpty(entityID)) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            int result = MyBatis.SqlMap.Delete("Delete" + DefaultKey, entityID);
            return result > 0;
        }
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>所有数据集合</returns>
        public virtual IList<T> Selects()
        {
            return MyBatis.SqlMap.QueryForList<T>("Select" + DefaultKey, null);

        }
        /// <summary>
        /// 查看筛选数据
        /// </summary>
        /// <param name="entity">筛选对象</param>
        /// <returns>特定数据集合</returns>
        public virtual IList<T> Select(T entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            return MyBatis.SqlMap.QueryForList<T>("Select" + DefaultKey, null);
        }
    }
}
