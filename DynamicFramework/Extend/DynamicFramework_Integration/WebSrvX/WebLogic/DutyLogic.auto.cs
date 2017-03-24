using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// Duty数据库访问类
    /// </summary>
    public sealed partial class DutyLogic
    {
		#region 单例模式

		private DutyLogic(){ }

        private static readonly object LockObj = new object();

        private static DutyLogic _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static DutyLogic Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new DutyLogic();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        DutyDao daoHelp =  DutyDao.Instance;

        public bool Add(DutyEntity o)
        {
            return daoHelp.Add(o);
        }
        public bool Update(DutyEntity o)
        {
            return daoHelp.Update(o);
        }
        public bool Delete(string o)
        {
            return daoHelp.Delete(o);
        }
        public List<DutyEntity> Select(DutyEntity entity)
        {
            return daoHelp.Select(entity) as List<DutyEntity>;
        }
		public List<DutyEntity> SelectForSort(DutyEntity entity,string sortField, bool isDesc)
        {
            return daoHelp.SelectForSort(entity,sortField,isDesc) as List<DutyEntity>;
        }
        public List<DutyEntity> SelectForPage(DutyEntity entity,int Skip,int Count)
        {
            return daoHelp.SelectForPage(entity,Skip,Count) as List<DutyEntity>;
        }
        public List<DutyEntity> Selects()
        {
            return daoHelp.Selects() as List<DutyEntity>;
        }
        public List<DutyEntity> SelectsForSort(string sortField,bool isDesc)
        {
            return daoHelp.SelectsForSort(sortField,isDesc) as List<DutyEntity>;
        }
        public List<DutyEntity> SelectsForPage(int Skip, int Count)
        {
            return daoHelp.SelectsForPage(Skip,Count) as List<DutyEntity>;
        }

    }
}
