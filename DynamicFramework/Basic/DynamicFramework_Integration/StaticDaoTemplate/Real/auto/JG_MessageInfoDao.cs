using System;
using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// JG_MessageInfo数据库操作类
    /// </summary>
    public class JG_MessageInfoDao
    {
        /// <summary>
        /// 添加一条[JG_MessageInfo]数据
        /// </summary>
        /// <param name="entity">[JG_MessageInfo]新实例</param>
        /// <returns>添加完成状态</returns>
        public static bool Add(JG_MessageInfoEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            MyBatis.SqlMap.Insert("AddJG_MessageInfo", entity);
            return true;
        }

        /// <summary>
        /// 更新一条[JG_MessageInfo]数据
        /// </summary>
        /// <param name="entity">[JG_MessageInfo]更新实例</param>
        /// <returns>修改完成状态</returns>
        public static bool Update(JG_MessageInfoEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            int result = MyBatis.SqlMap.Update("UpdateJG_MessageInfo", entity);
            return result > 0;
        }
        /// <summary>
        /// 删除一条[JG_MessageInfo]
        /// </summary>
        /// <param name="entityID">[JG_MessageInfo]主键编号</param>
        /// <returns>删除完成状态</returns>
        public static bool Delete(string entityID)
        {
            if (string.IsNullOrEmpty(entityID)) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            int result = MyBatis.SqlMap.Delete("DeleteJG_MessageInfo", entityID);
            return result > 0;
        }
        /// <summary>
        /// 查询所有[JG_MessageInfo]
        /// </summary>
        /// <returns>[JG_MessageInfo]集合</returns>
        public static IList<JG_MessageInfoEntity> Selects()
        {
            return MyBatis.SqlMap.QueryForList<JG_MessageInfoEntity>("SelectJG_MessageInfo", null);
        }
        /// <summary>
        /// 查看并筛选[JG_MessageInfo]
        /// </summary>
        /// <param name="t">[JG_MessageInfo]筛选实例</param>
        /// <returns>[JG_MessageInfo]集合</returns>
        public static IList<JG_MessageInfoEntity> Select(JG_MessageInfoEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            return MyBatis.SqlMap.QueryForList<JG_MessageInfoEntity>("SelectJG_MessageInfo", null);
        }
		        /// <summary>
        /// 查询所有[JG_MessageInfo]带排序
        /// </summary>
        /// <param name="orderField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public static IList<JG_MessageInfoEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            JG_MessageInfoEntity entity = new JG_MessageInfoEntity() { OrderField = orderField, IsDesc = isDesc };
            return MyBatis.SqlMap.QueryForList<JG_MessageInfoEntity>("SelectJG_MessageInfo", entity);
        }
    }
}
