using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// FundCollectInfo数据库访问类
    /// </summary>
    public sealed partial class FundCollectInfoLogic
    {
		#region 单例模式

		private FundCollectInfoLogic(){ }

        private static readonly object LockObj = new object();

        private static FundCollectInfoLogic _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static FundCollectInfoLogic Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new FundCollectInfoLogic();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        FundCollectInfoDao daoHelp =  FundCollectInfoDao.Instance;

        public List<FundCollectInfoEntity> Select(FundCollectInfoEntity entity)
        {
            return daoHelp.Select(entity) as List<FundCollectInfoEntity>;
        }
		public List<FundCollectInfoEntity> SelectForSort(FundCollectInfoEntity entity,string sortField, bool isDesc)
        {
            return daoHelp.SelectForSort(entity,sortField,isDesc) as List<FundCollectInfoEntity>;
        }
        public List<FundCollectInfoEntity> SelectForPage(FundCollectInfoEntity entity,int Skip,int Count)
        {
            return daoHelp.SelectForPage(entity,Skip,Count) as List<FundCollectInfoEntity>;
        }
        public List<FundCollectInfoEntity> Selects()
        {
            return daoHelp.Selects() as List<FundCollectInfoEntity>;
        }
        public List<FundCollectInfoEntity> SelectsForSort(string sortField,bool isDesc)
        {
            return daoHelp.SelectsForSort(sortField,isDesc) as List<FundCollectInfoEntity>;
        }
        public List<FundCollectInfoEntity> SelectsForPage(int Skip, int Count)
        {
            return daoHelp.SelectsForPage(Skip,Count) as List<FundCollectInfoEntity>;
        }

    }
}
