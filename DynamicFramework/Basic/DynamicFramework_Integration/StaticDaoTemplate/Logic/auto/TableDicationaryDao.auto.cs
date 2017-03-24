using System;
using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// TableDicationary数据库操作类
    /// </summary>
    public class TableDicationaryDao
    {
        /// <summary>
        /// 查询所有[TableDicationary]
        /// </summary>
        /// <returns>[TableDicationary]集合</returns>
        public static IList<TableDicationaryEntity> Selects()
        {
            return MyBatis.SqlMap.QueryForList<TableDicationaryEntity>("SelectTableDicationary", null);
        }
        /// <summary>
        /// 查看并筛选[TableDicationary]
        /// </summary>
        /// <param name="t">[TableDicationary]筛选实例</param>
        /// <returns>[TableDicationary]集合</returns>
        public static IList<TableDicationaryEntity> Select(TableDicationaryEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            return MyBatis.SqlMap.QueryForList<TableDicationaryEntity>("SelectTableDicationary", null);
        }
        /// 查询所有[TableDicationary]带排序
        /// </summary>
        /// <param name="orderField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public static IList<TableDicationaryEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            TableDicationaryEntity entity = new TableDicationaryEntity() { OrderField = orderField, IsDesc = isDesc };
            return MyBatis.SqlMap.QueryForList<TableDicationaryEntity>("SelectTableDicationary", entity);
        }
    }
}
