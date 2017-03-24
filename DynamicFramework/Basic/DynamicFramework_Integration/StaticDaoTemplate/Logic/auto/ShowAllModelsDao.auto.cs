using System;
using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// ShowAllModels数据库操作类
    /// </summary>
    public class ShowAllModelsDao
    {
        /// <summary>
        /// 查询所有[ShowAllModels]
        /// </summary>
        /// <returns>[ShowAllModels]集合</returns>
        public static IList<ShowAllModelsEntity> Selects()
        {
            return MyBatis.SqlMap.QueryForList<ShowAllModelsEntity>("SelectShowAllModels", null);
        }
        /// <summary>
        /// 查看并筛选[ShowAllModels]
        /// </summary>
        /// <param name="t">[ShowAllModels]筛选实例</param>
        /// <returns>[ShowAllModels]集合</returns>
        public static IList<ShowAllModelsEntity> Select(ShowAllModelsEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            return MyBatis.SqlMap.QueryForList<ShowAllModelsEntity>("SelectShowAllModels", null);
        }
        /// 查询所有[ShowAllModels]带排序
        /// </summary>
        /// <param name="orderField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public static IList<ShowAllModelsEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            ShowAllModelsEntity entity = new ShowAllModelsEntity() { OrderField = orderField, IsDesc = isDesc };
            return MyBatis.SqlMap.QueryForList<ShowAllModelsEntity>("SelectShowAllModels", entity);
        }
    }
}
