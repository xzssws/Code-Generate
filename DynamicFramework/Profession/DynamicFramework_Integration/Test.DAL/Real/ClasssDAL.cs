using System;
using System.Collections.Generic;
using Test.Entity;

namespace Test.DAL
{
    /// <summary>
    /// Classs数据库访问类
    /// </summary>
    public sealed partial class ClasssDAL :BaseDao<ClasssInfo>,IBaseReal<ClasssInfo>
    {
		#region 单例模式

		private ClasssDAL(){ }

        private static readonly object LockObj = new object();

        private static ClasssDAL _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static ClasssDAL Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new ClasssDAL();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        #region 默认标志

        private const string DefaultKey = "Classs";
        #endregion

        #region 执行操作

        /// <summary>
        /// 添加一条[Classs]
        /// </summary>
        /// <param name="entity">[Classs]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Add(ClasssInfo entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            return i("Add" + DefaultKey, entity);
        }

        /// <summary>
        /// 更新一条[Classs]
        /// </summary>
        /// <param name="entity">更新的[Classs]实例</param>
        /// <returns>执行完成状态</returns>
        public bool Update(ClasssInfo entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            return u("Upate" + DefaultKey, entity);
        }

        /// <summary>
        /// 删除一条[Classs]
        /// </summary>
        /// <param name="entityID"></param>
        /// <returns>执行完成状态</returns>
        public bool Delete(string entityID)
        {
            if (string.IsNullOrEmpty(entityID)) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            return d("Delete" + DefaultKey, entityID);
        }
        #endregion

        #region 查询操作

		/// <summary>
        /// 条件查询[Classs]
        /// </summary>
        /// <param name="entity">[Classs]筛选实例</param>
        /// <returns>[Classs结果集</returns>
        public IList<ClasssInfo> Select(ClasssInfo entity)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            return s("Select" + DefaultKey, entity);
        }
        /// <summary>
        /// 条件查询排序
        /// </summary>
        /// <param name="entity">筛选实例</param>
        /// <param name="sortField">排序字段名</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
		public IList<ClasssInfo> SelectForSort(ClasssInfo entity,string sortField, bool isDesc)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            if (string.IsNullOrEmpty(sortField)) throw new ArgumentNullException("系统异常:参数 sortField 是空值");
            entity.SortField = sortField;
            entity.IsDesc = isDesc;
            return s("Select" + DefaultKey, entity);
        }
		/// <summary>
        /// 条件查询分页[Classs]
        /// </summary>
        /// <param name="entity">[Classs]筛选实例</param>
        /// <param name="Skip">页数</param>
        /// <param name="Count">页条目数量</param>
        /// <returns>[Classs结果集</returns>
        public IList<ClasssInfo> SelectForPage(ClasssInfo entity,int Skip,int Count)
        {
            if (entity == null) throw new ArgumentNullException("系统异常:参数 entity 是空值");
            if (Count==0) throw new ArgumentNullException("系统异常:参数 Count 不可以是0");
            return sp("Select" + DefaultKey, entity,Skip,Count);
        }
        /// <summary>
        /// 查询所有[Classs]
        /// </summary>
        /// <returns></returns>
        public IList<ClasssInfo> Selects()
        {
            return ss("Select" + DefaultKey);
        }
        /// <summary>
        /// 查询所有[Classs]带排序
        /// </summary>
        /// <param name="sortField">排序列</param>
        /// <param name="isDesc">是否倒序</param>
        /// <returns></returns>
        public IList<ClasssInfo> SelectsForSort(string sortField,bool isDesc)
        {
            if (string.IsNullOrEmpty(sortField)) throw new ArgumentNullException("系统异常:参数 sortField 是空值");
            ClasssInfo entity = new ClasssInfo() { SortField = sortField, IsDesc = isDesc };
            return s("Select" + DefaultKey, entity);
        }

        /// <summary>
        /// 查询所有[Classs]分页
        /// </summary>
        /// <param name="Skip">页数</param>
        /// <param name="Count">页条目数量</param>
        /// <returns></returns>
        public IList<ClasssInfo> SelectsForPage(int Skip, int Count)
        {
            if (Count==0) throw new ArgumentNullException("系统异常:参数 Count 不可以是0");
            return ssp("Select" + DefaultKey, Skip,Count);
        }
        #endregion
    }
}
