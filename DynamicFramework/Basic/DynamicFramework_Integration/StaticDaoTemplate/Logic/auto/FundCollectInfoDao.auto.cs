using System;
using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// FundCollectInfo数据库操作类
    /// </summary>
    public class FundCollectInfoDao
    {
        /// <summary>
        /// 查询所有[FundCollectInfo]
        /// </summary>
        /// <returns>[FundCollectInfo]集合</returns>
        public static IList<FundCollectInfoEntity> Selects()
        {
            return MyBatis.SqlMap.QueryForList<FundCollectInfoEntity>("SelectFundCollectInfo", null);
        }
        /// <summary>
        /// 查看并筛选[FundCollectInfo]
        /// </summary>
        /// <param name="t">[FundCollectInfo]筛选实例</param>
        /// <returns>[FundCollectInfo]集合</returns>
        public static IList<FundCollectInfoEntity> Select(FundCollectInfoEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            return MyBatis.SqlMap.QueryForList<FundCollectInfoEntity>("SelectFundCollectInfo", null);
        }
        /// 查询所有[FundCollectInfo]带排序
        /// </summary>
        /// <param name="orderField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public static IList<FundCollectInfoEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            FundCollectInfoEntity entity = new FundCollectInfoEntity() { OrderField = orderField, IsDesc = isDesc };
            return MyBatis.SqlMap.QueryForList<FundCollectInfoEntity>("SelectFundCollectInfo", entity);
        }
    }
}
