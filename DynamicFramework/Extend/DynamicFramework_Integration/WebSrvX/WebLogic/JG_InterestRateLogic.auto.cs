using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// JG_InterestRate数据库访问类
    /// </summary>
    public sealed partial class JG_InterestRateLogic
    {
		#region 单例模式

		private JG_InterestRateLogic(){ }

        private static readonly object LockObj = new object();

        private static JG_InterestRateLogic _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static JG_InterestRateLogic Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new JG_InterestRateLogic();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        JG_InterestRateDao daoHelp =  JG_InterestRateDao.Instance;

        public bool Add(JG_InterestRateEntity o)
        {
            return daoHelp.Add(o);
        }
        public bool Update(JG_InterestRateEntity o)
        {
            return daoHelp.Update(o);
        }
        public bool Delete(string o)
        {
            return daoHelp.Delete(o);
        }
        public List<JG_InterestRateEntity> Select(JG_InterestRateEntity entity)
        {
            return daoHelp.Select(entity) as List<JG_InterestRateEntity>;
        }
		public List<JG_InterestRateEntity> SelectForSort(JG_InterestRateEntity entity,string sortField, bool isDesc)
        {
            return daoHelp.SelectForSort(entity,sortField,isDesc) as List<JG_InterestRateEntity>;
        }
        public List<JG_InterestRateEntity> SelectForPage(JG_InterestRateEntity entity,int Skip,int Count)
        {
            return daoHelp.SelectForPage(entity,Skip,Count) as List<JG_InterestRateEntity>;
        }
        public List<JG_InterestRateEntity> Selects()
        {
            return daoHelp.Selects() as List<JG_InterestRateEntity>;
        }
        public List<JG_InterestRateEntity> SelectsForSort(string sortField,bool isDesc)
        {
            return daoHelp.SelectsForSort(sortField,isDesc) as List<JG_InterestRateEntity>;
        }
        public List<JG_InterestRateEntity> SelectsForPage(int Skip, int Count)
        {
            return daoHelp.SelectsForPage(Skip,Count) as List<JG_InterestRateEntity>;
        }

    }
}
