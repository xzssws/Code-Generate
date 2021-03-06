using System;
using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// JG_Listid数据库操作类
    /// </summary>
    public class JG_ListidDao
    {
        /// <summary>
        /// 添加一条[JG_Listid]数据
        /// </summary>
        /// <param name="entity">[JG_Listid]新实例</param>
        /// <returns>添加完成状态</returns>
        public static bool Add(JG_ListidEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            MyBatis.SqlMap.Insert("AddJG_Listid", entity);
            return true;
        }

        /// <summary>
        /// 更新一条[JG_Listid]数据
        /// </summary>
        /// <param name="entity">[JG_Listid]更新实例</param>
        /// <returns>修改完成状态</returns>
        public static bool Update(JG_ListidEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            int result = MyBatis.SqlMap.Update("UpdateJG_Listid", entity);
            return result > 0;
        }
        /// <summary>
        /// 删除一条[JG_Listid]
        /// </summary>
        /// <param name="entityID">[JG_Listid]主键编号</param>
        /// <returns>删除完成状态</returns>
        public static bool Delete(string entityID)
        {
            if (string.IsNullOrEmpty(entityID)) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            int result = MyBatis.SqlMap.Delete("DeleteJG_Listid", entityID);
            return result > 0;
        }
        /// <summary>
        /// 查询所有[JG_Listid]
        /// </summary>
        /// <returns>[JG_Listid]集合</returns>
        public static IList<JG_ListidEntity> Selects()
        {
            return MyBatis.SqlMap.QueryForList<JG_ListidEntity>("SelectJG_Listid", null);
        }
        /// <summary>
        /// 查看并筛选[JG_Listid]
        /// </summary>
        /// <param name="t">[JG_Listid]筛选实例</param>
        /// <returns>[JG_Listid]集合</returns>
        public static IList<JG_ListidEntity> Select(JG_ListidEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            return MyBatis.SqlMap.QueryForList<JG_ListidEntity>("SelectJG_Listid", null);
        }
		        /// <summary>
        /// 查询所有[JG_Listid]带排序
        /// </summary>
        /// <param name="orderField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public static IList<JG_ListidEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            JG_ListidEntity entity = new JG_ListidEntity() { OrderField = orderField, IsDesc = isDesc };
            return MyBatis.SqlMap.QueryForList<JG_ListidEntity>("SelectJG_Listid", entity);
        }
    }
}
