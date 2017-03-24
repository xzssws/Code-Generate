using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// ShowAllModels数据库访问类
    /// </summary>
    public sealed partial class ShowAllModelsLogic
    {
		#region 单例模式

		private ShowAllModelsLogic(){ }

        private static readonly object LockObj = new object();

        private static ShowAllModelsLogic _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static ShowAllModelsLogic Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new ShowAllModelsLogic();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        ShowAllModelsDao daoHelp =  ShowAllModelsDao.Instance;

        public List<ShowAllModelsEntity> Select(ShowAllModelsEntity entity)
        {
            return daoHelp.Select(entity) as List<ShowAllModelsEntity>;
        }
		public List<ShowAllModelsEntity> SelectForSort(ShowAllModelsEntity entity,string sortField, bool isDesc)
        {
            return daoHelp.SelectForSort(entity,sortField,isDesc) as List<ShowAllModelsEntity>;
        }
        public List<ShowAllModelsEntity> SelectForPage(ShowAllModelsEntity entity,int Skip,int Count)
        {
            return daoHelp.SelectForPage(entity,Skip,Count) as List<ShowAllModelsEntity>;
        }
        public List<ShowAllModelsEntity> Selects()
        {
            return daoHelp.Selects() as List<ShowAllModelsEntity>;
        }
        public List<ShowAllModelsEntity> SelectsForSort(string sortField,bool isDesc)
        {
            return daoHelp.SelectsForSort(sortField,isDesc) as List<ShowAllModelsEntity>;
        }
        public List<ShowAllModelsEntity> SelectsForPage(int Skip, int Count)
        {
            return daoHelp.SelectsForPage(Skip,Count) as List<ShowAllModelsEntity>;
        }

    }
}
