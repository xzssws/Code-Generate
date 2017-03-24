using System;
using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// JG_Branches数据库操作类
    /// </summary>
    public class JG_BranchesDao
    {
        /// <summary>
        /// 添加一条[JG_Branches]数据
        /// </summary>
        /// <param name="entity">[JG_Branches]新实例</param>
        /// <returns>添加完成状态</returns>
        public static bool Add(JG_BranchesEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            MyBatis.SqlMap.Insert("AddJG_Branches", entity);
            return true;
        }

        /// <summary>
        /// 更新一条[JG_Branches]数据
        /// </summary>
        /// <param name="entity">[JG_Branches]更新实例</param>
        /// <returns>修改完成状态</returns>
        public static bool Update(JG_BranchesEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            int result = MyBatis.SqlMap.Update("UpdateJG_Branches", entity);
            return result > 0;
        }
        /// <summary>
        /// 删除一条[JG_Branches]
        /// </summary>
        /// <param name="entityID">[JG_Branches]主键编号</param>
        /// <returns>删除完成状态</returns>
        public static bool Delete(string entityID)
        {
            if (string.IsNullOrEmpty(entityID)) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            int result = MyBatis.SqlMap.Delete("DeleteJG_Branches", entityID);
            return result > 0;
        }
        /// <summary>
        /// 查询所有[JG_Branches]
        /// </summary>
        /// <returns>[JG_Branches]集合</returns>
        public static IList<JG_BranchesEntity> Selects()
        {
            return MyBatis.SqlMap.QueryForList<JG_BranchesEntity>("SelectJG_Branches", null);
        }
        /// <summary>
        /// 查看并筛选[JG_Branches]
        /// </summary>
        /// <param name="t">[JG_Branches]筛选实例</param>
        /// <returns>[JG_Branches]集合</returns>
        public static IList<JG_BranchesEntity> Select(JG_BranchesEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            return MyBatis.SqlMap.QueryForList<JG_BranchesEntity>("SelectJG_Branches", null);
        }
		        /// <summary>
        /// 查询所有[JG_Branches]带排序
        /// </summary>
        /// <param name="orderField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public static IList<JG_BranchesEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            JG_BranchesEntity entity = new JG_BranchesEntity() { OrderField = orderField, IsDesc = isDesc };
            return MyBatis.SqlMap.QueryForList<JG_BranchesEntity>("SelectJG_Branches", entity);
        }
    }
}
