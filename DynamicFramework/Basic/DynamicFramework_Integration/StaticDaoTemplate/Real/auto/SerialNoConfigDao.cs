using System;
using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// SerialNoConfig数据库操作类
    /// </summary>
    public class SerialNoConfigDao
    {
        /// <summary>
        /// 添加一条[SerialNoConfig]数据
        /// </summary>
        /// <param name="entity">[SerialNoConfig]新实例</param>
        /// <returns>添加完成状态</returns>
        public static bool Add(SerialNoConfigEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            MyBatis.SqlMap.Insert("AddSerialNoConfig", entity);
            return true;
        }

        /// <summary>
        /// 更新一条[SerialNoConfig]数据
        /// </summary>
        /// <param name="entity">[SerialNoConfig]更新实例</param>
        /// <returns>修改完成状态</returns>
        public static bool Update(SerialNoConfigEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            int result = MyBatis.SqlMap.Update("UpdateSerialNoConfig", entity);
            return result > 0;
        }
        /// <summary>
        /// 删除一条[SerialNoConfig]
        /// </summary>
        /// <param name="entityID">[SerialNoConfig]主键编号</param>
        /// <returns>删除完成状态</returns>
        public static bool Delete(string entityID)
        {
            if (string.IsNullOrEmpty(entityID)) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            int result = MyBatis.SqlMap.Delete("DeleteSerialNoConfig", entityID);
            return result > 0;
        }
        /// <summary>
        /// 查询所有[SerialNoConfig]
        /// </summary>
        /// <returns>[SerialNoConfig]集合</returns>
        public static IList<SerialNoConfigEntity> Selects()
        {
            return MyBatis.SqlMap.QueryForList<SerialNoConfigEntity>("SelectSerialNoConfig", null);
        }
        /// <summary>
        /// 查看并筛选[SerialNoConfig]
        /// </summary>
        /// <param name="t">[SerialNoConfig]筛选实例</param>
        /// <returns>[SerialNoConfig]集合</returns>
        public static IList<SerialNoConfigEntity> Select(SerialNoConfigEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            return MyBatis.SqlMap.QueryForList<SerialNoConfigEntity>("SelectSerialNoConfig", null);
        }
		        /// <summary>
        /// 查询所有[SerialNoConfig]带排序
        /// </summary>
        /// <param name="orderField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public static IList<SerialNoConfigEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            SerialNoConfigEntity entity = new SerialNoConfigEntity() { OrderField = orderField, IsDesc = isDesc };
            return MyBatis.SqlMap.QueryForList<SerialNoConfigEntity>("SelectSerialNoConfig", entity);
        }
    }
}
