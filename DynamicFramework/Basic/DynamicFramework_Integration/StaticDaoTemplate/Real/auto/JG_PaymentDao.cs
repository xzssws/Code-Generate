using System;
using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// JG_Payment数据库操作类
    /// </summary>
    public class JG_PaymentDao
    {
        /// <summary>
        /// 添加一条[JG_Payment]数据
        /// </summary>
        /// <param name="entity">[JG_Payment]新实例</param>
        /// <returns>添加完成状态</returns>
        public static bool Add(JG_PaymentEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            MyBatis.SqlMap.Insert("AddJG_Payment", entity);
            return true;
        }

        /// <summary>
        /// 更新一条[JG_Payment]数据
        /// </summary>
        /// <param name="entity">[JG_Payment]更新实例</param>
        /// <returns>修改完成状态</returns>
        public static bool Update(JG_PaymentEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            int result = MyBatis.SqlMap.Update("UpdateJG_Payment", entity);
            return result > 0;
        }
        /// <summary>
        /// 删除一条[JG_Payment]
        /// </summary>
        /// <param name="entityID">[JG_Payment]主键编号</param>
        /// <returns>删除完成状态</returns>
        public static bool Delete(string entityID)
        {
            if (string.IsNullOrEmpty(entityID)) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            int result = MyBatis.SqlMap.Delete("DeleteJG_Payment", entityID);
            return result > 0;
        }
        /// <summary>
        /// 查询所有[JG_Payment]
        /// </summary>
        /// <returns>[JG_Payment]集合</returns>
        public static IList<JG_PaymentEntity> Selects()
        {
            return MyBatis.SqlMap.QueryForList<JG_PaymentEntity>("SelectJG_Payment", null);
        }
        /// <summary>
        /// 查看并筛选[JG_Payment]
        /// </summary>
        /// <param name="t">[JG_Payment]筛选实例</param>
        /// <returns>[JG_Payment]集合</returns>
        public static IList<JG_PaymentEntity> Select(JG_PaymentEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            return MyBatis.SqlMap.QueryForList<JG_PaymentEntity>("SelectJG_Payment", null);
        }
		        /// <summary>
        /// 查询所有[JG_Payment]带排序
        /// </summary>
        /// <param name="orderField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public static IList<JG_PaymentEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            JG_PaymentEntity entity = new JG_PaymentEntity() { OrderField = orderField, IsDesc = isDesc };
            return MyBatis.SqlMap.QueryForList<JG_PaymentEntity>("SelectJG_Payment", entity);
        }
    }
}
