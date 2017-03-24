using System;
using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// UserInfo数据库操作类
    /// </summary>
    public class UserInfoDao
    {
        /// <summary>
        /// 添加一条[UserInfo]数据
        /// </summary>
        /// <param name="entity">[UserInfo]新实例</param>
        /// <returns>添加完成状态</returns>
        public static bool Add(UserInfoEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            MyBatis.SqlMap.Insert("AddUserInfo", entity);
            return true;
        }

        /// <summary>
        /// 更新一条[UserInfo]数据
        /// </summary>
        /// <param name="entity">[UserInfo]更新实例</param>
        /// <returns>修改完成状态</returns>
        public static bool Update(UserInfoEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            int result = MyBatis.SqlMap.Update("UpdateUserInfo", entity);
            return result > 0;
        }
        /// <summary>
        /// 删除一条[UserInfo]
        /// </summary>
        /// <param name="entityID">[UserInfo]主键编号</param>
        /// <returns>删除完成状态</returns>
        public static bool Delete(string entityID)
        {
            if (string.IsNullOrEmpty(entityID)) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            int result = MyBatis.SqlMap.Delete("DeleteUserInfo", entityID);
            return result > 0;
        }
        /// <summary>
        /// 查询所有[UserInfo]
        /// </summary>
        /// <returns>[UserInfo]集合</returns>
        public static IList<UserInfoEntity> Selects()
        {
            return MyBatis.SqlMap.QueryForList<UserInfoEntity>("SelectUserInfo", null);
        }
        /// <summary>
        /// 查看并筛选[UserInfo]
        /// </summary>
        /// <param name="t">[UserInfo]筛选实例</param>
        /// <returns>[UserInfo]集合</returns>
        public static IList<UserInfoEntity> Select(UserInfoEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            return MyBatis.SqlMap.QueryForList<UserInfoEntity>("SelectUserInfo", null);
        }
		        /// <summary>
        /// 查询所有[UserInfo]带排序
        /// </summary>
        /// <param name="orderField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public static IList<UserInfoEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            UserInfoEntity entity = new UserInfoEntity() { OrderField = orderField, IsDesc = isDesc };
            return MyBatis.SqlMap.QueryForList<UserInfoEntity>("SelectUserInfo", entity);
        }
    }
}
