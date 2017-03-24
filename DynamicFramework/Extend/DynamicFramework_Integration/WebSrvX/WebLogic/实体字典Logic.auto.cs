using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// 实体字典数据库访问类
    /// </summary>
    public sealed partial class 实体字典Logic
    {
		#region 单例模式

		private 实体字典Logic(){ }

        private static readonly object LockObj = new object();

        private static 实体字典Logic _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static 实体字典Logic Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new 实体字典Logic();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        实体字典Dao daoHelp =  实体字典Dao.Instance;

        public List<实体字典Entity> Select(实体字典Entity entity)
        {
            return daoHelp.Select(entity) as List<实体字典Entity>;
        }
		public List<实体字典Entity> SelectForSort(实体字典Entity entity,string sortField, bool isDesc)
        {
            return daoHelp.SelectForSort(entity,sortField,isDesc) as List<实体字典Entity>;
        }
        public List<实体字典Entity> SelectForPage(实体字典Entity entity,int Skip,int Count)
        {
            return daoHelp.SelectForPage(entity,Skip,Count) as List<实体字典Entity>;
        }
        public List<实体字典Entity> Selects()
        {
            return daoHelp.Selects() as List<实体字典Entity>;
        }
        public List<实体字典Entity> SelectsForSort(string sortField,bool isDesc)
        {
            return daoHelp.SelectsForSort(sortField,isDesc) as List<实体字典Entity>;
        }
        public List<实体字典Entity> SelectsForPage(int Skip, int Count)
        {
            return daoHelp.SelectsForPage(Skip,Count) as List<实体字典Entity>;
        }

    }
}
