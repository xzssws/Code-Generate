using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// JG_Interest数据库访问类
    /// </summary>
    public sealed partial class JG_InterestLogic
    {
		#region 单例模式

		private JG_InterestLogic(){ }

        private static readonly object LockObj = new object();

        private static JG_InterestLogic _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static JG_InterestLogic Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new JG_InterestLogic();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        JG_InterestDao daoHelp =  JG_InterestDao.Instance;

        public bool Add(JG_InterestEntity o)
        {
            return daoHelp.Add(o);
        }
        public bool Update(JG_InterestEntity o)
        {
            return daoHelp.Update(o);
        }
        public bool Delete(string o)
        {
            return daoHelp.Delete(o);
        }
        public List<JG_InterestEntity> Select(JG_InterestEntity entity)
        {
            return daoHelp.Select(entity) as List<JG_InterestEntity>;
        }
		public List<JG_InterestEntity> SelectForSort(JG_InterestEntity entity,string sortField, bool isDesc)
        {
            return daoHelp.SelectForSort(entity,sortField,isDesc) as List<JG_InterestEntity>;
        }
        public List<JG_InterestEntity> SelectForPage(JG_InterestEntity entity,int Skip,int Count)
        {
            return daoHelp.SelectForPage(entity,Skip,Count) as List<JG_InterestEntity>;
        }
        public List<JG_InterestEntity> Selects()
        {
            return daoHelp.Selects() as List<JG_InterestEntity>;
        }
        public List<JG_InterestEntity> SelectsForSort(string sortField,bool isDesc)
        {
            return daoHelp.SelectsForSort(sortField,isDesc) as List<JG_InterestEntity>;
        }
        public List<JG_InterestEntity> SelectsForPage(int Skip, int Count)
        {
            return daoHelp.SelectsForPage(Skip,Count) as List<JG_InterestEntity>;
        }

    }
}
