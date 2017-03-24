using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// JG_AccountManage数据库访问类
    /// </summary>
    public sealed partial class JG_AccountManageLogic
    {
		#region 单例模式

		private JG_AccountManageLogic(){ }

        private static readonly object LockObj = new object();

        private static JG_AccountManageLogic _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static JG_AccountManageLogic Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new JG_AccountManageLogic();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        JG_AccountManageDao daoHelp =  JG_AccountManageDao.Instance;

        public bool Add(JG_AccountManageEntity o)
        {
            return daoHelp.Add(o);
        }
        public bool Update(JG_AccountManageEntity o)
        {
            return daoHelp.Update(o);
        }
        public bool Delete(string o)
        {
            return daoHelp.Delete(o);
        }
        public List<JG_AccountManageEntity> Select(JG_AccountManageEntity entity)
        {
            return daoHelp.Select(entity) as List<JG_AccountManageEntity>;
        }
		public List<JG_AccountManageEntity> SelectForSort(JG_AccountManageEntity entity,string sortField, bool isDesc)
        {
            return daoHelp.SelectForSort(entity,sortField,isDesc) as List<JG_AccountManageEntity>;
        }
        public List<JG_AccountManageEntity> SelectForPage(JG_AccountManageEntity entity,int Skip,int Count)
        {
            return daoHelp.SelectForPage(entity,Skip,Count) as List<JG_AccountManageEntity>;
        }
        public List<JG_AccountManageEntity> Selects()
        {
            return daoHelp.Selects() as List<JG_AccountManageEntity>;
        }
        public List<JG_AccountManageEntity> SelectsForSort(string sortField,bool isDesc)
        {
            return daoHelp.SelectsForSort(sortField,isDesc) as List<JG_AccountManageEntity>;
        }
        public List<JG_AccountManageEntity> SelectsForPage(int Skip, int Count)
        {
            return daoHelp.SelectsForPage(Skip,Count) as List<JG_AccountManageEntity>;
        }

    }
}
