using System;
using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// JG_InterestRate数据库操作类
    /// </summary>
    public class JG_InterestRateDao
    {
        /// <summary>
        /// 添加一条[JG_InterestRate]数据
        /// </summary>
        /// <param name="entity">[JG_InterestRate]新实例</param>
        /// <returns>添加完成状态</returns>
        public static bool Add(JG_InterestRateEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            MyBatis.SqlMap.Insert("AddJG_InterestRate", entity);
            return true;
        }

        /// <summary>
        /// 更新一条[JG_InterestRate]数据
        /// </summary>
        /// <param name="entity">[JG_InterestRate]更新实例</param>
        /// <returns>修改完成状态</returns>
        public static bool Update(JG_InterestRateEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            int result = MyBatis.SqlMap.Update("UpdateJG_InterestRate", entity);
            return result > 0;
        }
        /// <summary>
        /// 删除一条[JG_InterestRate]
        /// </summary>
        /// <param name="entityID">[JG_InterestRate]主键编号</param>
        /// <returns>删除完成状态</returns>
        public static bool Delete(string entityID)
        {
            if (string.IsNullOrEmpty(entityID)) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            int result = MyBatis.SqlMap.Delete("DeleteJG_InterestRate", entityID);
            return result > 0;
        }
        /// <summary>
        /// 查询所有[JG_InterestRate]
        /// </summary>
        /// <returns>[JG_InterestRate]集合</returns>
        public static IList<JG_InterestRateEntity> Selects()
        {
            return MyBatis.SqlMap.QueryForList<JG_InterestRateEntity>("SelectJG_InterestRate", null);
        }
        /// <summary>
        /// 查看并筛选[JG_InterestRate]
        /// </summary>
        /// <param name="t">[JG_InterestRate]筛选实例</param>
        /// <returns>[JG_InterestRate]集合</returns>
        public static IList<JG_InterestRateEntity> Select(JG_InterestRateEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            return MyBatis.SqlMap.QueryForList<JG_InterestRateEntity>("SelectJG_InterestRate", null);
        }
		        /// <summary>
        /// 查询所有[JG_InterestRate]带排序
        /// </summary>
        /// <param name="orderField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public static IList<JG_InterestRateEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            JG_InterestRateEntity entity = new JG_InterestRateEntity() { OrderField = orderField, IsDesc = isDesc };
            return MyBatis.SqlMap.QueryForList<JG_InterestRateEntity>("SelectJG_InterestRate", entity);
        }
    }
}
