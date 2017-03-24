using System;
using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// 实体字典数据库操作类
    /// </summary>
    public class 实体字典Dao
    {
        /// <summary>
        /// 查询所有[实体字典]
        /// </summary>
        /// <returns>[实体字典]集合</returns>
        public static IList<实体字典Entity> Selects()
        {
            return MyBatis.SqlMap.QueryForList<实体字典Entity>("Select实体字典", null);
        }
        /// <summary>
        /// 查看并筛选[实体字典]
        /// </summary>
        /// <param name="t">[实体字典]筛选实例</param>
        /// <returns>[实体字典]集合</returns>
        public static IList<实体字典Entity> Select(实体字典Entity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            return MyBatis.SqlMap.QueryForList<实体字典Entity>("Select实体字典", null);
        }
        /// 查询所有[实体字典]带排序
        /// </summary>
        /// <param name="orderField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public static IList<实体字典Entity> SelectsOrderBy(string orderField,bool isDesc)
        {
            实体字典Entity entity = new 实体字典Entity() { OrderField = orderField, IsDesc = isDesc };
            return MyBatis.SqlMap.QueryForList<实体字典Entity>("Select实体字典", entity);
        }
    }
}
