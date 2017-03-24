using System;
using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// JG_AmountCollect数据库操作类
    /// </summary>
    public class JG_AmountCollectDao
    {
        /// <summary>
        /// 添加一条[JG_AmountCollect]数据
        /// </summary>
        /// <param name="entity">[JG_AmountCollect]新实例</param>
        /// <returns>添加完成状态</returns>
        public static bool Add(JG_AmountCollectEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            MyBatis.SqlMap.Insert("AddJG_AmountCollect", entity);
            return true;
        }

        /// <summary>
        /// 更新一条[JG_AmountCollect]数据
        /// </summary>
        /// <param name="entity">[JG_AmountCollect]更新实例</param>
        /// <returns>修改完成状态</returns>
        public static bool Update(JG_AmountCollectEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            int result = MyBatis.SqlMap.Update("UpdateJG_AmountCollect", entity);
            return result > 0;
        }
        /// <summary>
        /// 删除一条[JG_AmountCollect]
        /// </summary>
        /// <param name="entityID">[JG_AmountCollect]主键编号</param>
        /// <returns>删除完成状态</returns>
        public static bool Delete(string entityID)
        {
            if (string.IsNullOrEmpty(entityID)) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            int result = MyBatis.SqlMap.Delete("DeleteJG_AmountCollect", entityID);
            return result > 0;
        }
        /// <summary>
        /// 查询所有[JG_AmountCollect]
        /// </summary>
        /// <returns>[JG_AmountCollect]集合</returns>
        public static IList<JG_AmountCollectEntity> Selects()
        {
            return MyBatis.SqlMap.QueryForList<JG_AmountCollectEntity>("SelectJG_AmountCollect", null);
        }
        /// <summary>
        /// 查看并筛选[JG_AmountCollect]
        /// </summary>
        /// <param name="t">[JG_AmountCollect]筛选实例</param>
        /// <returns>[JG_AmountCollect]集合</returns>
        public static IList<JG_AmountCollectEntity> Select(JG_AmountCollectEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            return MyBatis.SqlMap.QueryForList<JG_AmountCollectEntity>("SelectJG_AmountCollect", null);
        }
		        /// <summary>
        /// 查询所有[JG_AmountCollect]带排序
        /// </summary>
        /// <param name="orderField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public static IList<JG_AmountCollectEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            JG_AmountCollectEntity entity = new JG_AmountCollectEntity() { OrderField = orderField, IsDesc = isDesc };
            return MyBatis.SqlMap.QueryForList<JG_AmountCollectEntity>("SelectJG_AmountCollect", entity);
        }
    }
}
