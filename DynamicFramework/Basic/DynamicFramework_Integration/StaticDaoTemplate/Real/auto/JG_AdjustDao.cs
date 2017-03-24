using System;
using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// JG_Adjust数据库操作类
    /// </summary>
    public class JG_AdjustDao
    {
        /// <summary>
        /// 添加一条[JG_Adjust]数据
        /// </summary>
        /// <param name="entity">[JG_Adjust]新实例</param>
        /// <returns>添加完成状态</returns>
        public static bool Add(JG_AdjustEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            MyBatis.SqlMap.Insert("AddJG_Adjust", entity);
            return true;
        }

        /// <summary>
        /// 更新一条[JG_Adjust]数据
        /// </summary>
        /// <param name="entity">[JG_Adjust]更新实例</param>
        /// <returns>修改完成状态</returns>
        public static bool Update(JG_AdjustEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            int result = MyBatis.SqlMap.Update("UpdateJG_Adjust", entity);
            return result > 0;
        }
        /// <summary>
        /// 删除一条[JG_Adjust]
        /// </summary>
        /// <param name="entityID">[JG_Adjust]主键编号</param>
        /// <returns>删除完成状态</returns>
        public static bool Delete(string entityID)
        {
            if (string.IsNullOrEmpty(entityID)) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            int result = MyBatis.SqlMap.Delete("DeleteJG_Adjust", entityID);
            return result > 0;
        }
        /// <summary>
        /// 查询所有[JG_Adjust]
        /// </summary>
        /// <returns>[JG_Adjust]集合</returns>
        public static IList<JG_AdjustEntity> Selects()
        {
            return MyBatis.SqlMap.QueryForList<JG_AdjustEntity>("SelectJG_Adjust", null);
        }
        /// <summary>
        /// 查看并筛选[JG_Adjust]
        /// </summary>
        /// <param name="t">[JG_Adjust]筛选实例</param>
        /// <returns>[JG_Adjust]集合</returns>
        public static IList<JG_AdjustEntity> Select(JG_AdjustEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            return MyBatis.SqlMap.QueryForList<JG_AdjustEntity>("SelectJG_Adjust", null);
        }
		        /// <summary>
        /// 查询所有[JG_Adjust]带排序
        /// </summary>
        /// <param name="orderField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public static IList<JG_AdjustEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            JG_AdjustEntity entity = new JG_AdjustEntity() { OrderField = orderField, IsDesc = isDesc };
            return MyBatis.SqlMap.QueryForList<JG_AdjustEntity>("SelectJG_Adjust", entity);
        }
    }
}
