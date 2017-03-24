using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

interface IBaseReal<T>
{
    /// <summary>
    /// 添加一条实例
    /// </summary>
    /// <param name="entity">要添加的实例</param>
    /// <returns></returns>
    bool Add(T entity);
    /// <summary>
    /// 更新一条实例
    /// </summary>
    /// <param name="entity">要更新的实例ID为条件</param>
    /// <returns></returns>
    bool Update(T entity);
    /// <summary>
    /// 删除一条实例
    /// </summary>
    /// <param name="entityID">实例的唯一标识</param>
    /// <returns></returns>
    bool Delete(string entityID);
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

