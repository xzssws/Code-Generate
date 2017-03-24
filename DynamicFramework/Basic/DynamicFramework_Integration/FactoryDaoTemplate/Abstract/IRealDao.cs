using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryDaoTemplate.Abstract
{
    interface IRealDao<T>
    {
        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="entity">添加的对象</param>
        /// <returns>是否成功</returns>
        bool Add(T entity);
       
        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="entity">修改的对象</param>
        /// <returns>是否成功</returns>
        bool Update(T entity);

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="entityID">删除的筛选对象</param>
        /// <returns>是否成功</returns>
        bool Delete(string entityID);
       
        /// <summary>
        /// 查看全部
        /// </summary>
        /// <returns>所有数据集合</returns>
        IList<T> Selects();
       
        /// <summary>
        /// 查看筛选数据
        /// </summary>
        /// <param name="entity">筛选对象</param>
        /// <returns>特定数据集合</returns>
        IList<T> Select(T entity);
       
    }
}
