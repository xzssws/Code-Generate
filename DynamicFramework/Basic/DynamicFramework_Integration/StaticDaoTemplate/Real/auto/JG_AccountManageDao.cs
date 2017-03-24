using System;
using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// JG_AccountManage数据库操作类
    /// </summary>
    public class JG_AccountManageDao
    {
        /// <summary>
        /// 添加一条[JG_AccountManage]数据
        /// </summary>
        /// <param name="entity">[JG_AccountManage]新实例</param>
        /// <returns>添加完成状态</returns>
        public static bool Add(JG_AccountManageEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            MyBatis.SqlMap.Insert("AddJG_AccountManage", entity);
            return true;
        }

        /// <summary>
        /// 更新一条[JG_AccountManage]数据
        /// </summary>
        /// <param name="entity">[JG_AccountManage]更新实例</param>
        /// <returns>修改完成状态</returns>
        public static bool Update(JG_AccountManageEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            int result = MyBatis.SqlMap.Update("UpdateJG_AccountManage", entity);
            return result > 0;
        }
        /// <summary>
        /// 删除一条[JG_AccountManage]
        /// </summary>
        /// <param name="entityID">[JG_AccountManage]主键编号</param>
        /// <returns>删除完成状态</returns>
        public static bool Delete(string entityID)
        {
            if (string.IsNullOrEmpty(entityID)) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            int result = MyBatis.SqlMap.Delete("DeleteJG_AccountManage", entityID);
            return result > 0;
        }
        /// <summary>
        /// 查询所有[JG_AccountManage]
        /// </summary>
        /// <returns>[JG_AccountManage]集合</returns>
        public static IList<JG_AccountManageEntity> Selects()
        {
            return MyBatis.SqlMap.QueryForList<JG_AccountManageEntity>("SelectJG_AccountManage", null);
        }
        /// <summary>
        /// 查看并筛选[JG_AccountManage]
        /// </summary>
        /// <param name="t">[JG_AccountManage]筛选实例</param>
        /// <returns>[JG_AccountManage]集合</returns>
        public static IList<JG_AccountManageEntity> Select(JG_AccountManageEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            return MyBatis.SqlMap.QueryForList<JG_AccountManageEntity>("SelectJG_AccountManage", null);
        }
		        /// <summary>
        /// 查询所有[JG_AccountManage]带排序
        /// </summary>
        /// <param name="orderField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public static IList<JG_AccountManageEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            JG_AccountManageEntity entity = new JG_AccountManageEntity() { OrderField = orderField, IsDesc = isDesc };
            return MyBatis.SqlMap.QueryForList<JG_AccountManageEntity>("SelectJG_AccountManage", entity);
        }
    }
}
