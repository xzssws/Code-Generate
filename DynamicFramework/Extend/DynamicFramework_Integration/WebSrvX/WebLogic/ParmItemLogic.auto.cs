using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// ParmItem数据库访问类
    /// </summary>
    public sealed partial class ParmItemLogic
    {
		#region 单例模式

		private ParmItemLogic(){ }

        private static readonly object LockObj = new object();

        private static ParmItemLogic _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static ParmItemLogic Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new ParmItemLogic();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        ParmItemDao daoHelp =  ParmItemDao.Instance;

        public bool Add(ParmItemEntity o)
        {
            return daoHelp.Add(o);
        }
        public bool Update(ParmItemEntity o)
        {
            return daoHelp.Update(o);
        }
        public bool Delete(string o)
        {
            return daoHelp.Delete(o);
        }
        public List<ParmItemEntity> Select(ParmItemEntity entity)
        {
            return daoHelp.Select(entity) as List<ParmItemEntity>;
        }
		public List<ParmItemEntity> SelectForSort(ParmItemEntity entity,string sortField, bool isDesc)
        {
            return daoHelp.SelectForSort(entity,sortField,isDesc) as List<ParmItemEntity>;
        }
        public List<ParmItemEntity> SelectForPage(ParmItemEntity entity,int Skip,int Count)
        {
            return daoHelp.SelectForPage(entity,Skip,Count) as List<ParmItemEntity>;
        }
        public List<ParmItemEntity> Selects()
        {
            return daoHelp.Selects() as List<ParmItemEntity>;
        }
        public List<ParmItemEntity> SelectsForSort(string sortField,bool isDesc)
        {
            return daoHelp.SelectsForSort(sortField,isDesc) as List<ParmItemEntity>;
        }
        public List<ParmItemEntity> SelectsForPage(int Skip, int Count)
        {
            return daoHelp.SelectsForPage(Skip,Count) as List<ParmItemEntity>;
        }

    }
}
