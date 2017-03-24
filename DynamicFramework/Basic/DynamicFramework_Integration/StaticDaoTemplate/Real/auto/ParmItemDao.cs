using System;
using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// ParmItem数据库操作类
    /// </summary>
    public class ParmItemDao
    {
        /// <summary>
        /// 添加一条[ParmItem]数据
        /// </summary>
        /// <param name="entity">[ParmItem]新实例</param>
        /// <returns>添加完成状态</returns>
        public static bool Add(ParmItemEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            MyBatis.SqlMap.Insert("AddParmItem", entity);
            return true;
        }

        /// <summary>
        /// 更新一条[ParmItem]数据
        /// </summary>
        /// <param name="entity">[ParmItem]更新实例</param>
        /// <returns>修改完成状态</returns>
        public static bool Update(ParmItemEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            int result = MyBatis.SqlMap.Update("UpdateParmItem", entity);
            return result > 0;
        }
        /// <summary>
        /// 删除一条[ParmItem]
        /// </summary>
        /// <param name="entityID">[ParmItem]主键编号</param>
        /// <returns>删除完成状态</returns>
        public static bool Delete(string entityID)
        {
            if (string.IsNullOrEmpty(entityID)) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            int result = MyBatis.SqlMap.Delete("DeleteParmItem", entityID);
            return result > 0;
        }
        /// <summary>
        /// 查询所有[ParmItem]
        /// </summary>
        /// <returns>[ParmItem]集合</returns>
        public static IList<ParmItemEntity> Selects()
        {
            return MyBatis.SqlMap.QueryForList<ParmItemEntity>("SelectParmItem", null);
        }
        /// <summary>
        /// 查看并筛选[ParmItem]
        /// </summary>
        /// <param name="t">[ParmItem]筛选实例</param>
        /// <returns>[ParmItem]集合</returns>
        public static IList<ParmItemEntity> Select(ParmItemEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            return MyBatis.SqlMap.QueryForList<ParmItemEntity>("SelectParmItem", null);
        }
		        /// <summary>
        /// 查询所有[ParmItem]带排序
        /// </summary>
        /// <param name="orderField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public static IList<ParmItemEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            ParmItemEntity entity = new ParmItemEntity() { OrderField = orderField, IsDesc = isDesc };
            return MyBatis.SqlMap.QueryForList<ParmItemEntity>("SelectParmItem", entity);
        }
    }
}
