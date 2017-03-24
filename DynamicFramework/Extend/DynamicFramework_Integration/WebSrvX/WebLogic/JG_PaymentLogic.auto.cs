using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// JG_Payment数据库访问类
    /// </summary>
    public sealed partial class JG_PaymentLogic
    {
		#region 单例模式

		private JG_PaymentLogic(){ }

        private static readonly object LockObj = new object();

        private static JG_PaymentLogic _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static JG_PaymentLogic Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new JG_PaymentLogic();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        JG_PaymentDao daoHelp =  JG_PaymentDao.Instance;

        public bool Add(JG_PaymentEntity o)
        {
            return daoHelp.Add(o);
        }
        public bool Update(JG_PaymentEntity o)
        {
            return daoHelp.Update(o);
        }
        public bool Delete(string o)
        {
            return daoHelp.Delete(o);
        }
        public List<JG_PaymentEntity> Select(JG_PaymentEntity entity)
        {
            return daoHelp.Select(entity) as List<JG_PaymentEntity>;
        }
		public List<JG_PaymentEntity> SelectForSort(JG_PaymentEntity entity,string sortField, bool isDesc)
        {
            return daoHelp.SelectForSort(entity,sortField,isDesc) as List<JG_PaymentEntity>;
        }
        public List<JG_PaymentEntity> SelectForPage(JG_PaymentEntity entity,int Skip,int Count)
        {
            return daoHelp.SelectForPage(entity,Skip,Count) as List<JG_PaymentEntity>;
        }
        public List<JG_PaymentEntity> Selects()
        {
            return daoHelp.Selects() as List<JG_PaymentEntity>;
        }
        public List<JG_PaymentEntity> SelectsForSort(string sortField,bool isDesc)
        {
            return daoHelp.SelectsForSort(sortField,isDesc) as List<JG_PaymentEntity>;
        }
        public List<JG_PaymentEntity> SelectsForPage(int Skip, int Count)
        {
            return daoHelp.SelectsForPage(Skip,Count) as List<JG_PaymentEntity>;
        }

    }
}
