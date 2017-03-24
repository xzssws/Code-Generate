using System;
using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// DspFunc数据库操作类
    /// </summary>
    public class DspFuncDao
    {
        /// <summary>
        /// 添加一条[DspFunc]数据
        /// </summary>
        /// <param name="entity">[DspFunc]新实例</param>
        /// <returns>添加完成状态</returns>
        public static bool Add(DspFuncEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            MyBatis.SqlMap.Insert("AddDspFunc", entity);
            return true;
        }

        /// <summary>
        /// 更新一条[DspFunc]数据
        /// </summary>
        /// <param name="entity">[DspFunc]更新实例</param>
        /// <returns>修改完成状态</returns>
        public static bool Update(DspFuncEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            int result = MyBatis.SqlMap.Update("UpdateDspFunc", entity);
            return result > 0;
        }
        /// <summary>
        /// 删除一条[DspFunc]
        /// </summary>
        /// <param name="entityID">[DspFunc]主键编号</param>
        /// <returns>删除完成状态</returns>
        public static bool Delete(string entityID)
        {
            if (string.IsNullOrEmpty(entityID)) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            int result = MyBatis.SqlMap.Delete("DeleteDspFunc", entityID);
            return result > 0;
        }
        /// <summary>
        /// 查询所有[DspFunc]
        /// </summary>
        /// <returns>[DspFunc]集合</returns>
        public static IList<DspFuncEntity> Selects()
        {
            return MyBatis.SqlMap.QueryForList<DspFuncEntity>("SelectDspFunc", null);
        }
        /// <summary>
        /// 查看并筛选[DspFunc]
        /// </summary>
        /// <param name="t">[DspFunc]筛选实例</param>
        /// <returns>[DspFunc]集合</returns>
        public static IList<DspFuncEntity> Select(DspFuncEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            return MyBatis.SqlMap.QueryForList<DspFuncEntity>("SelectDspFunc", null);
        }
		        /// <summary>
        /// 查询所有[DspFunc]带排序
        /// </summary>
        /// <param name="orderField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public static IList<DspFuncEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            DspFuncEntity entity = new DspFuncEntity() { OrderField = orderField, IsDesc = isDesc };
            return MyBatis.SqlMap.QueryForList<DspFuncEntity>("SelectDspFunc", entity);
        }
    }
}
