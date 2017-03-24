using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

interface IBaseLogic<T> where T : new()
{
    /// <summary>
    /// 条件查询实例
    /// </summary>
    /// <param name="entity">条件实例</param>
    /// <returns></returns>
    IList<T> Select(T entity);
    /// <summary>
    /// 查询所有实例
    /// </summary>
    /// <returns></returns>
    IList<T> Selects();
}

