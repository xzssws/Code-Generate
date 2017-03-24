using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// Parm数据库访问类
    /// </summary>
    public sealed partial class ParmLogic
    {
		#region 单例模式

		private ParmLogic(){ }

        private static readonly object LockObj = new object();

        private static ParmLogic _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static ParmLogic Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new ParmLogic();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        ParmDao daoHelp =  ParmDao.Instance;

        public bool Add(ParmEntity o)
        {
            return daoHelp.Add(o);
        }
        public bool Update(ParmEntity o)
        {
            return daoHelp.Update(o);
        }
        public bool Delete(string o)
        {
            return daoHelp.Delete(o);
        }
        public List<ParmEntity> Select(ParmEntity entity)
        {
            return daoHelp.Select(entity) as List<ParmEntity>;
        }
		public List<ParmEntity> SelectForSort(ParmEntity entity,string sortField, bool isDesc)
        {
            return daoHelp.SelectForSort(entity,sortField,isDesc) as List<ParmEntity>;
        }
        public List<ParmEntity> SelectForPage(ParmEntity entity,int Skip,int Count)
        {
            return daoHelp.SelectForPage(entity,Skip,Count) as List<ParmEntity>;
        }
        public List<ParmEntity> Selects()
        {
            return daoHelp.Selects() as List<ParmEntity>;
        }
        public List<ParmEntity> SelectsForSort(string sortField,bool isDesc)
        {
            return daoHelp.SelectsForSort(sortField,isDesc) as List<ParmEntity>;
        }
        public List<ParmEntity> SelectsForPage(int Skip, int Count)
        {
            return daoHelp.SelectsForPage(Skip,Count) as List<ParmEntity>;
        }

    }
}
