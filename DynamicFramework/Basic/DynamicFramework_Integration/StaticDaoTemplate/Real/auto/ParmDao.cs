using System;
using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// Parm数据库操作类
    /// </summary>
    public class ParmDao
    {
        /// <summary>
        /// 添加一条[Parm]数据
        /// </summary>
        /// <param name="entity">[Parm]新实例</param>
        /// <returns>添加完成状态</returns>
        public static bool Add(ParmEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            MyBatis.SqlMap.Insert("AddParm", entity);
            return true;
        }

        /// <summary>
        /// 更新一条[Parm]数据
        /// </summary>
        /// <param name="entity">[Parm]更新实例</param>
        /// <returns>修改完成状态</returns>
        public static bool Update(ParmEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            int result = MyBatis.SqlMap.Update("UpdateParm", entity);
            return result > 0;
        }
        /// <summary>
        /// 删除一条[Parm]
        /// </summary>
        /// <param name="entityID">[Parm]主键编号</param>
        /// <returns>删除完成状态</returns>
        public static bool Delete(string entityID)
        {
            if (string.IsNullOrEmpty(entityID)) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            int result = MyBatis.SqlMap.Delete("DeleteParm", entityID);
            return result > 0;
        }
        /// <summary>
        /// 查询所有[Parm]
        /// </summary>
        /// <returns>[Parm]集合</returns>
        public static IList<ParmEntity> Selects()
        {
            return MyBatis.SqlMap.QueryForList<ParmEntity>("SelectParm", null);
        }
        /// <summary>
        /// 查看并筛选[Parm]
        /// </summary>
        /// <param name="t">[Parm]筛选实例</param>
        /// <returns>[Parm]集合</returns>
        public static IList<ParmEntity> Select(ParmEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            return MyBatis.SqlMap.QueryForList<ParmEntity>("SelectParm", null);
        }
		        /// <summary>
        /// 查询所有[Parm]带排序
        /// </summary>
        /// <param name="orderField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public static IList<ParmEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            ParmEntity entity = new ParmEntity() { OrderField = orderField, IsDesc = isDesc };
            return MyBatis.SqlMap.QueryForList<ParmEntity>("SelectParm", entity);
        }
    }
}
