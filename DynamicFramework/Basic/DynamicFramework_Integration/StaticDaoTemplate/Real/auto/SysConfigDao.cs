using System;
using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// SysConfig数据库操作类
    /// </summary>
    public class SysConfigDao
    {
        /// <summary>
        /// 添加一条[SysConfig]数据
        /// </summary>
        /// <param name="entity">[SysConfig]新实例</param>
        /// <returns>添加完成状态</returns>
        public static bool Add(SysConfigEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            MyBatis.SqlMap.Insert("AddSysConfig", entity);
            return true;
        }

        /// <summary>
        /// 更新一条[SysConfig]数据
        /// </summary>
        /// <param name="entity">[SysConfig]更新实例</param>
        /// <returns>修改完成状态</returns>
        public static bool Update(SysConfigEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            int result = MyBatis.SqlMap.Update("UpdateSysConfig", entity);
            return result > 0;
        }
        /// <summary>
        /// 删除一条[SysConfig]
        /// </summary>
        /// <param name="entityID">[SysConfig]主键编号</param>
        /// <returns>删除完成状态</returns>
        public static bool Delete(string entityID)
        {
            if (string.IsNullOrEmpty(entityID)) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            int result = MyBatis.SqlMap.Delete("DeleteSysConfig", entityID);
            return result > 0;
        }
        /// <summary>
        /// 查询所有[SysConfig]
        /// </summary>
        /// <returns>[SysConfig]集合</returns>
        public static IList<SysConfigEntity> Selects()
        {
            return MyBatis.SqlMap.QueryForList<SysConfigEntity>("SelectSysConfig", null);
        }
        /// <summary>
        /// 查看并筛选[SysConfig]
        /// </summary>
        /// <param name="t">[SysConfig]筛选实例</param>
        /// <returns>[SysConfig]集合</returns>
        public static IList<SysConfigEntity> Select(SysConfigEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            return MyBatis.SqlMap.QueryForList<SysConfigEntity>("SelectSysConfig", null);
        }
		        /// <summary>
        /// 查询所有[SysConfig]带排序
        /// </summary>
        /// <param name="orderField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public static IList<SysConfigEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            SysConfigEntity entity = new SysConfigEntity() { OrderField = orderField, IsDesc = isDesc };
            return MyBatis.SqlMap.QueryForList<SysConfigEntity>("SelectSysConfig", entity);
        }
    }
}
