using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// JG_MessageInfo数据库访问类
    /// </summary>
    public sealed partial class JG_MessageInfoLogic
    {
		#region 单例模式

		private JG_MessageInfoLogic(){ }

        private static readonly object LockObj = new object();

        private static JG_MessageInfoLogic _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static JG_MessageInfoLogic Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new JG_MessageInfoLogic();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        JG_MessageInfoDao daoHelp =  JG_MessageInfoDao.Instance;

        public bool Add(JG_MessageInfoEntity o)
        {
            return daoHelp.Add(o);
        }
        public bool Update(JG_MessageInfoEntity o)
        {
            return daoHelp.Update(o);
        }
        public bool Delete(string o)
        {
            return daoHelp.Delete(o);
        }
        public List<JG_MessageInfoEntity> Select(JG_MessageInfoEntity entity)
        {
            return daoHelp.Select(entity) as List<JG_MessageInfoEntity>;
        }
		public List<JG_MessageInfoEntity> SelectForSort(JG_MessageInfoEntity entity,string sortField, bool isDesc)
        {
            return daoHelp.SelectForSort(entity,sortField,isDesc) as List<JG_MessageInfoEntity>;
        }
        public List<JG_MessageInfoEntity> SelectForPage(JG_MessageInfoEntity entity,int Skip,int Count)
        {
            return daoHelp.SelectForPage(entity,Skip,Count) as List<JG_MessageInfoEntity>;
        }
        public List<JG_MessageInfoEntity> Selects()
        {
            return daoHelp.Selects() as List<JG_MessageInfoEntity>;
        }
        public List<JG_MessageInfoEntity> SelectsForSort(string sortField,bool isDesc)
        {
            return daoHelp.SelectsForSort(sortField,isDesc) as List<JG_MessageInfoEntity>;
        }
        public List<JG_MessageInfoEntity> SelectsForPage(int Skip, int Count)
        {
            return daoHelp.SelectsForPage(Skip,Count) as List<JG_MessageInfoEntity>;
        }

    }
}
