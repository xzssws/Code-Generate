using System;
using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// UserDuty数据库操作类
    /// </summary>
    public class UserDutyDao
    {
        /// <summary>
        /// 添加一条[UserDuty]数据
        /// </summary>
        /// <param name="entity">[UserDuty]新实例</param>
        /// <returns>添加完成状态</returns>
        public static bool Add(UserDutyEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            MyBatis.SqlMap.Insert("AddUserDuty", entity);
            return true;
        }

        /// <summary>
        /// 更新一条[UserDuty]数据
        /// </summary>
        /// <param name="entity">[UserDuty]更新实例</param>
        /// <returns>修改完成状态</returns>
        public static bool Update(UserDutyEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            int result = MyBatis.SqlMap.Update("UpdateUserDuty", entity);
            return result > 0;
        }
        /// <summary>
        /// 删除一条[UserDuty]
        /// </summary>
        /// <param name="entityID">[UserDuty]主键编号</param>
        /// <returns>删除完成状态</returns>
        public static bool Delete(string entityID)
        {
            if (string.IsNullOrEmpty(entityID)) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            int result = MyBatis.SqlMap.Delete("DeleteUserDuty", entityID);
            return result > 0;
        }
        /// <summary>
        /// 查询所有[UserDuty]
        /// </summary>
        /// <returns>[UserDuty]集合</returns>
        public static IList<UserDutyEntity> Selects()
        {
            return MyBatis.SqlMap.QueryForList<UserDutyEntity>("SelectUserDuty", null);
        }
        /// <summary>
        /// 查看并筛选[UserDuty]
        /// </summary>
        /// <param name="t">[UserDuty]筛选实例</param>
        /// <returns>[UserDuty]集合</returns>
        public static IList<UserDutyEntity> Select(UserDutyEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            return MyBatis.SqlMap.QueryForList<UserDutyEntity>("SelectUserDuty", null);
        }
		        /// <summary>
        /// 查询所有[UserDuty]带排序
        /// </summary>
        /// <param name="orderField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public static IList<UserDutyEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            UserDutyEntity entity = new UserDutyEntity() { OrderField = orderField, IsDesc = isDesc };
            return MyBatis.SqlMap.QueryForList<UserDutyEntity>("SelectUserDuty", entity);
        }
    }
}
