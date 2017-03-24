using System;
using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// Duty数据库操作类
    /// </summary>
    public class DutyDao
    {
        /// <summary>
        /// 添加一条[Duty]数据
        /// </summary>
        /// <param name="entity">[Duty]新实例</param>
        /// <returns>添加完成状态</returns>
        public static bool Add(DutyEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            MyBatis.SqlMap.Insert("AddDuty", entity);
            return true;
        }

        /// <summary>
        /// 更新一条[Duty]数据
        /// </summary>
        /// <param name="entity">[Duty]更新实例</param>
        /// <returns>修改完成状态</returns>
        public static bool Update(DutyEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            int result = MyBatis.SqlMap.Update("UpdateDuty", entity);
            return result > 0;
        }
        /// <summary>
        /// 删除一条[Duty]
        /// </summary>
        /// <param name="entityID">[Duty]主键编号</param>
        /// <returns>删除完成状态</returns>
        public static bool Delete(string entityID)
        {
            if (string.IsNullOrEmpty(entityID)) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            int result = MyBatis.SqlMap.Delete("DeleteDuty", entityID);
            return result > 0;
        }
        /// <summary>
        /// 查询所有[Duty]
        /// </summary>
        /// <returns>[Duty]集合</returns>
        public static IList<DutyEntity> Selects()
        {
            return MyBatis.SqlMap.QueryForList<DutyEntity>("SelectDuty", null);
        }
        /// <summary>
        /// 查看并筛选[Duty]
        /// </summary>
        /// <param name="t">[Duty]筛选实例</param>
        /// <returns>[Duty]集合</returns>
        public static IList<DutyEntity> Select(DutyEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            return MyBatis.SqlMap.QueryForList<DutyEntity>("SelectDuty", null);
        }
		        /// <summary>
        /// 查询所有[Duty]带排序
        /// </summary>
        /// <param name="orderField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public static IList<DutyEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            DutyEntity entity = new DutyEntity() { OrderField = orderField, IsDesc = isDesc };
            return MyBatis.SqlMap.QueryForList<DutyEntity>("SelectDuty", entity);
        }
    }
}
