using System;
using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// AdjustAccountTable数据库操作类
    /// </summary>
    public class AdjustAccountTableDao
    {
        /// <summary>
        /// 查询所有[AdjustAccountTable]
        /// </summary>
        /// <returns>[AdjustAccountTable]集合</returns>
        public static IList<AdjustAccountTableEntity> Selects()
        {
            return MyBatis.SqlMap.QueryForList<AdjustAccountTableEntity>("SelectAdjustAccountTable", null);
        }
        /// <summary>
        /// 查看并筛选[AdjustAccountTable]
        /// </summary>
        /// <param name="t">[AdjustAccountTable]筛选实例</param>
        /// <returns>[AdjustAccountTable]集合</returns>
        public static IList<AdjustAccountTableEntity> Select(AdjustAccountTableEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            return MyBatis.SqlMap.QueryForList<AdjustAccountTableEntity>("SelectAdjustAccountTable", null);
        }
        /// 查询所有[AdjustAccountTable]带排序
        /// </summary>
        /// <param name="orderField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public static IList<AdjustAccountTableEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            AdjustAccountTableEntity entity = new AdjustAccountTableEntity() { OrderField = orderField, IsDesc = isDesc };
            return MyBatis.SqlMap.QueryForList<AdjustAccountTableEntity>("SelectAdjustAccountTable", entity);
        }
    }
}
