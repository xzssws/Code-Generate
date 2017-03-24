using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// DutyFun数据库访问类
    /// </summary>
    public sealed partial class DutyFunLogic
    {
		#region 单例模式

		private DutyFunLogic(){ }

        private static readonly object LockObj = new object();

        private static DutyFunLogic _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static DutyFunLogic Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new DutyFunLogic();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        DutyFunDao daoHelp =  DutyFunDao.Instance;

        public bool Add(DutyFunEntity o)
        {
            return daoHelp.Add(o);
        }
        public bool Update(DutyFunEntity o)
        {
            return daoHelp.Update(o);
        }
        public bool Delete(string o)
        {
            return daoHelp.Delete(o);
        }
        public List<DutyFunEntity> Select(DutyFunEntity entity)
        {
            return daoHelp.Select(entity) as List<DutyFunEntity>;
        }
		public List<DutyFunEntity> SelectForSort(DutyFunEntity entity,string sortField, bool isDesc)
        {
            return daoHelp.SelectForSort(entity,sortField,isDesc) as List<DutyFunEntity>;
        }
        public List<DutyFunEntity> SelectForPage(DutyFunEntity entity,int Skip,int Count)
        {
            return daoHelp.SelectForPage(entity,Skip,Count) as List<DutyFunEntity>;
        }
        public List<DutyFunEntity> Selects()
        {
            return daoHelp.Selects() as List<DutyFunEntity>;
        }
        public List<DutyFunEntity> SelectsForSort(string sortField,bool isDesc)
        {
            return daoHelp.SelectsForSort(sortField,isDesc) as List<DutyFunEntity>;
        }
        public List<DutyFunEntity> SelectsForPage(int Skip, int Count)
        {
            return daoHelp.SelectsForPage(Skip,Count) as List<DutyFunEntity>;
        }

    }
}
