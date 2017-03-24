using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// JG_Branches数据库访问类
    /// </summary>
    public sealed partial class JG_BranchesLogic
    {
		#region 单例模式

		private JG_BranchesLogic(){ }

        private static readonly object LockObj = new object();

        private static JG_BranchesLogic _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static JG_BranchesLogic Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new JG_BranchesLogic();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        JG_BranchesDao daoHelp =  JG_BranchesDao.Instance;

        public bool Add(JG_BranchesEntity o)
        {
            return daoHelp.Add(o);
        }
        public bool Update(JG_BranchesEntity o)
        {
            return daoHelp.Update(o);
        }
        public bool Delete(string o)
        {
            return daoHelp.Delete(o);
        }
        public List<JG_BranchesEntity> Select(JG_BranchesEntity entity)
        {
            return daoHelp.Select(entity) as List<JG_BranchesEntity>;
        }
		public List<JG_BranchesEntity> SelectForSort(JG_BranchesEntity entity,string sortField, bool isDesc)
        {
            return daoHelp.SelectForSort(entity,sortField,isDesc) as List<JG_BranchesEntity>;
        }
        public List<JG_BranchesEntity> SelectForPage(JG_BranchesEntity entity,int Skip,int Count)
        {
            return daoHelp.SelectForPage(entity,Skip,Count) as List<JG_BranchesEntity>;
        }
        public List<JG_BranchesEntity> Selects()
        {
            return daoHelp.Selects() as List<JG_BranchesEntity>;
        }
        public List<JG_BranchesEntity> SelectsForSort(string sortField,bool isDesc)
        {
            return daoHelp.SelectsForSort(sortField,isDesc) as List<JG_BranchesEntity>;
        }
        public List<JG_BranchesEntity> SelectsForPage(int Skip, int Count)
        {
            return daoHelp.SelectsForPage(Skip,Count) as List<JG_BranchesEntity>;
        }

    }
}
