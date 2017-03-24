using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// JG_Deposit数据库访问类
    /// </summary>
    public sealed partial class JG_DepositLogic
    {
		#region 单例模式

		private JG_DepositLogic(){ }

        private static readonly object LockObj = new object();

        private static JG_DepositLogic _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static JG_DepositLogic Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new JG_DepositLogic();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        JG_DepositDao daoHelp =  JG_DepositDao.Instance;

        public bool Add(JG_DepositEntity o)
        {
            return daoHelp.Add(o);
        }
        public bool Update(JG_DepositEntity o)
        {
            return daoHelp.Update(o);
        }
        public bool Delete(string o)
        {
            return daoHelp.Delete(o);
        }
        public List<JG_DepositEntity> Select(JG_DepositEntity entity)
        {
            return daoHelp.Select(entity) as List<JG_DepositEntity>;
        }
		public List<JG_DepositEntity> SelectForSort(JG_DepositEntity entity,string sortField, bool isDesc)
        {
            return daoHelp.SelectForSort(entity,sortField,isDesc) as List<JG_DepositEntity>;
        }
        public List<JG_DepositEntity> SelectForPage(JG_DepositEntity entity,int Skip,int Count)
        {
            return daoHelp.SelectForPage(entity,Skip,Count) as List<JG_DepositEntity>;
        }
        public List<JG_DepositEntity> Selects()
        {
            return daoHelp.Selects() as List<JG_DepositEntity>;
        }
        public List<JG_DepositEntity> SelectsForSort(string sortField,bool isDesc)
        {
            return daoHelp.SelectsForSort(sortField,isDesc) as List<JG_DepositEntity>;
        }
        public List<JG_DepositEntity> SelectsForPage(int Skip, int Count)
        {
            return daoHelp.SelectsForPage(Skip,Count) as List<JG_DepositEntity>;
        }

    }
}
