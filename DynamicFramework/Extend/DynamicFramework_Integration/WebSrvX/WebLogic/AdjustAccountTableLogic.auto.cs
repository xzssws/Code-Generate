using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// AdjustAccountTable数据库访问类
    /// </summary>
    public sealed partial class AdjustAccountTableLogic
    {
		#region 单例模式

		private AdjustAccountTableLogic(){ }

        private static readonly object LockObj = new object();

        private static AdjustAccountTableLogic _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static AdjustAccountTableLogic Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new AdjustAccountTableLogic();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        AdjustAccountTableDao daoHelp =  AdjustAccountTableDao.Instance;

        public List<AdjustAccountTableEntity> Select(AdjustAccountTableEntity entity)
        {
            return daoHelp.Select(entity) as List<AdjustAccountTableEntity>;
        }
		public List<AdjustAccountTableEntity> SelectForSort(AdjustAccountTableEntity entity,string sortField, bool isDesc)
        {
            return daoHelp.SelectForSort(entity,sortField,isDesc) as List<AdjustAccountTableEntity>;
        }
        public List<AdjustAccountTableEntity> SelectForPage(AdjustAccountTableEntity entity,int Skip,int Count)
        {
            return daoHelp.SelectForPage(entity,Skip,Count) as List<AdjustAccountTableEntity>;
        }
        public List<AdjustAccountTableEntity> Selects()
        {
            return daoHelp.Selects() as List<AdjustAccountTableEntity>;
        }
        public List<AdjustAccountTableEntity> SelectsForSort(string sortField,bool isDesc)
        {
            return daoHelp.SelectsForSort(sortField,isDesc) as List<AdjustAccountTableEntity>;
        }
        public List<AdjustAccountTableEntity> SelectsForPage(int Skip, int Count)
        {
            return daoHelp.SelectsForPage(Skip,Count) as List<AdjustAccountTableEntity>;
        }

    }
}
