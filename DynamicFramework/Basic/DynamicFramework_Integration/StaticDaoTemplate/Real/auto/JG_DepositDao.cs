using System;
using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// JG_Deposit数据库操作类
    /// </summary>
    public class JG_DepositDao
    {
        /// <summary>
        /// 添加一条[JG_Deposit]数据
        /// </summary>
        /// <param name="entity">[JG_Deposit]新实例</param>
        /// <returns>添加完成状态</returns>
        public static bool Add(JG_DepositEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            MyBatis.SqlMap.Insert("AddJG_Deposit", entity);
            return true;
        }

        /// <summary>
        /// 更新一条[JG_Deposit]数据
        /// </summary>
        /// <param name="entity">[JG_Deposit]更新实例</param>
        /// <returns>修改完成状态</returns>
        public static bool Update(JG_DepositEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            int result = MyBatis.SqlMap.Update("UpdateJG_Deposit", entity);
            return result > 0;
        }
        /// <summary>
        /// 删除一条[JG_Deposit]
        /// </summary>
        /// <param name="entityID">[JG_Deposit]主键编号</param>
        /// <returns>删除完成状态</returns>
        public static bool Delete(string entityID)
        {
            if (string.IsNullOrEmpty(entityID)) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            int result = MyBatis.SqlMap.Delete("DeleteJG_Deposit", entityID);
            return result > 0;
        }
        /// <summary>
        /// 查询所有[JG_Deposit]
        /// </summary>
        /// <returns>[JG_Deposit]集合</returns>
        public static IList<JG_DepositEntity> Selects()
        {
            return MyBatis.SqlMap.QueryForList<JG_DepositEntity>("SelectJG_Deposit", null);
        }
        /// <summary>
        /// 查看并筛选[JG_Deposit]
        /// </summary>
        /// <param name="t">[JG_Deposit]筛选实例</param>
        /// <returns>[JG_Deposit]集合</returns>
        public static IList<JG_DepositEntity> Select(JG_DepositEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            return MyBatis.SqlMap.QueryForList<JG_DepositEntity>("SelectJG_Deposit", null);
        }
		        /// <summary>
        /// 查询所有[JG_Deposit]带排序
        /// </summary>
        /// <param name="orderField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public static IList<JG_DepositEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            JG_DepositEntity entity = new JG_DepositEntity() { OrderField = orderField, IsDesc = isDesc };
            return MyBatis.SqlMap.QueryForList<JG_DepositEntity>("SelectJG_Deposit", entity);
        }
    }
}
