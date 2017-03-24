using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// JG_AmountCollect数据库访问类
    /// </summary>
    public sealed partial class JG_AmountCollectLogic
    {
		#region 单例模式

		private JG_AmountCollectLogic(){ }

        private static readonly object LockObj = new object();

        private static JG_AmountCollectLogic _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static JG_AmountCollectLogic Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new JG_AmountCollectLogic();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        JG_AmountCollectDao daoHelp =  JG_AmountCollectDao.Instance;

        public bool Add(JG_AmountCollectEntity o)
        {
            return daoHelp.Add(o);
        }
        public bool Update(JG_AmountCollectEntity o)
        {
            return daoHelp.Update(o);
        }
        public bool Delete(string o)
        {
            return daoHelp.Delete(o);
        }
        public List<JG_AmountCollectEntity> Select(JG_AmountCollectEntity entity)
        {
            return daoHelp.Select(entity) as List<JG_AmountCollectEntity>;
        }
		public List<JG_AmountCollectEntity> SelectForSort(JG_AmountCollectEntity entity,string sortField, bool isDesc)
        {
            return daoHelp.SelectForSort(entity,sortField,isDesc) as List<JG_AmountCollectEntity>;
        }
        public List<JG_AmountCollectEntity> SelectForPage(JG_AmountCollectEntity entity,int Skip,int Count)
        {
            return daoHelp.SelectForPage(entity,Skip,Count) as List<JG_AmountCollectEntity>;
        }
        public List<JG_AmountCollectEntity> Selects()
        {
            return daoHelp.Selects() as List<JG_AmountCollectEntity>;
        }
        public List<JG_AmountCollectEntity> SelectsForSort(string sortField,bool isDesc)
        {
            return daoHelp.SelectsForSort(sortField,isDesc) as List<JG_AmountCollectEntity>;
        }
        public List<JG_AmountCollectEntity> SelectsForPage(int Skip, int Count)
        {
            return daoHelp.SelectsForPage(Skip,Count) as List<JG_AmountCollectEntity>;
        }

    }
}
