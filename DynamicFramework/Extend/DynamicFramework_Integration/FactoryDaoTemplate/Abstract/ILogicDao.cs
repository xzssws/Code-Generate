using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryDaoTemplate.Abstract
{
    interface ILogicDao<T>
    {
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
