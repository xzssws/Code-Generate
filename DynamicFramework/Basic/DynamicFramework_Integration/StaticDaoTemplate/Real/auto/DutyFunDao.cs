using System;
using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// DutyFun数据库操作类
    /// </summary>
    public class DutyFunDao
    {
        /// <summary>
        /// 添加一条[DutyFun]数据
        /// </summary>
        /// <param name="entity">[DutyFun]新实例</param>
        /// <returns>添加完成状态</returns>
        public static bool Add(DutyFunEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            MyBatis.SqlMap.Insert("AddDutyFun", entity);
            return true;
        }

        /// <summary>
        /// 更新一条[DutyFun]数据
        /// </summary>
        /// <param name="entity">[DutyFun]更新实例</param>
        /// <returns>修改完成状态</returns>
        public static bool Update(DutyFunEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            int result = MyBatis.SqlMap.Update("UpdateDutyFun", entity);
            return result > 0;
        }
        /// <summary>
        /// 删除一条[DutyFun]
        /// </summary>
        /// <param name="entityID">[DutyFun]主键编号</param>
        /// <returns>删除完成状态</returns>
        public static bool Delete(string entityID)
        {
            if (string.IsNullOrEmpty(entityID)) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            int result = MyBatis.SqlMap.Delete("DeleteDutyFun", entityID);
            return result > 0;
        }
        /// <summary>
        /// 查询所有[DutyFun]
        /// </summary>
        /// <returns>[DutyFun]集合</returns>
        public static IList<DutyFunEntity> Selects()
        {
            return MyBatis.SqlMap.QueryForList<DutyFunEntity>("SelectDutyFun", null);
        }
        /// <summary>
        /// 查看并筛选[DutyFun]
        /// </summary>
        /// <param name="t">[DutyFun]筛选实例</param>
        /// <returns>[DutyFun]集合</returns>
        public static IList<DutyFunEntity> Select(DutyFunEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            return MyBatis.SqlMap.QueryForList<DutyFunEntity>("SelectDutyFun", null);
        }
		        /// <summary>
        /// 查询所有[DutyFun]带排序
        /// </summary>
        /// <param name="orderField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public static IList<DutyFunEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            DutyFunEntity entity = new DutyFunEntity() { OrderField = orderField, IsDesc = isDesc };
            return MyBatis.SqlMap.QueryForList<DutyFunEntity>("SelectDutyFun", entity);
        }
    }
}
