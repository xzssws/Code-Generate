using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IBatisNet.DataMapper;

/// <summary>
/// 基础DAO所有Dao的基类
/// </summary>
/// <typeparam name="T">操作实例类型</typeparam>
public class BaseDao<T> where T : new()
{
    protected ISqlMapper SqlMap = MyBatis.SqlMap;
    /// <summary>
    /// 添加
    /// </summary>
    /// <param name="Key"></param>
    /// <param name="entity"></param>
    /// <returns></returns>
    protected virtual bool i(string Key, T entity)
    {
        if (string.IsNullOrEmpty(Key)) throw new ArgumentNullException("系统错误:参数 key 不能是空");
        if (entity == null) throw new ArgumentNullException("系统错误:参数 entity 不能是空");
        SqlMap.Insert(Key, entity);
        return true;
    }
    /// <summary>
    /// 更新
    /// </summary>
    /// <param name="Key"></param>
    /// <param name="entity"></param>
    /// <returns></returns>
    protected virtual bool u(string Key, T entity)
    {
        if (string.IsNullOrEmpty(Key)) throw new ArgumentNullException("系统错误:参数 key 不能是空");
        if (entity == null) throw new ArgumentNullException("系统错误:参数 entity 不能是空");
        int result = (int)SqlMap.Update(Key, entity);
        return result > 0;
    }
    /// <summary>
    /// 删除
    /// </summary>
    /// <param name="Key"></param>
    /// <param name="entity"></param>
    /// <returns></returns>
    protected virtual bool d(string Key, string entity)
    {
        if (string.IsNullOrEmpty(Key)) throw new ArgumentNullException("系统错误:参数 key 不能是空");
        if (entity == null) throw new ArgumentNullException("系统错误:参数 entity 不能是空");
        int result = (int)SqlMap.Delete(Key, entity);
        return result > 0;
    }
    /// <summary>
    /// 条件查询
    /// </summary>
    /// <param name="Key"></param>
    /// <param name="entity"></param>
    /// <returns></returns>
    protected virtual IList<T> s(string Key, T entity)
    {
        if (string.IsNullOrEmpty(Key)) throw new ArgumentNullException("系统错误:参数 key 不能是空");
        return SqlMap.QueryForList<T>(Key, entity);
    }
    /// <summary>
    /// 查询所有
    /// </summary>
    /// <param name="Key"></param>
    /// <returns></returns>
    protected virtual IList<T> ss(string Key)
    {
        if (string.IsNullOrEmpty(Key)) throw new ArgumentNullException("系统错误:参数 key 不能是空");
        return SqlMap.QueryForList<T>(Key, null);
    }
    /// <summary>
    /// 条件查询+分页
    /// </summary>
    /// <param name="Key"></param>
    /// <param name="entity"></param>
    /// <param name="skip"></param>
    /// <param name="count"></param>
    /// <returns></returns>
    protected virtual IList<T> sp(string Key, T entity, int skip, int count)
    {
        if (string.IsNullOrEmpty(Key)) throw new ArgumentNullException("系统错误:参数 key 不能是空");
        return SqlMap.QueryForList<T>(Key, entity, skip, count);
    }
    /// <summary>
    /// 查询所有+分页
    /// </summary>
    /// <param name="Key"></param>
    /// <param name="skip"></param>
    /// <param name="count"></param>
    /// <returns></returns>
    protected virtual IList<T> ssp(string Key, int skip, int count)
    {
        if (string.IsNullOrEmpty(Key)) throw new ArgumentNullException("系统错误:参数 key 不能是空");
        return SqlMap.QueryForList<T>(Key, null, skip, count);
    }

}

