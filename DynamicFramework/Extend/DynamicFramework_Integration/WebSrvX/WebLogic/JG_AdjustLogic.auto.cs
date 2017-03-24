using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// JG_Adjust数据库访问类
    /// </summary>
    public sealed partial class JG_AdjustLogic
    {
		#region 单例模式

		private JG_AdjustLogic(){ }

        private static readonly object LockObj = new object();

        private static JG_AdjustLogic _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static JG_AdjustLogic Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new JG_AdjustLogic();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        JG_AdjustDao daoHelp =  JG_AdjustDao.Instance;

        public bool Add(JG_AdjustEntity o)
        {
            return daoHelp.Add(o);
        }
        public bool Update(JG_AdjustEntity o)
        {
            return daoHelp.Update(o);
        }
        public bool Delete(string o)
        {
            return daoHelp.Delete(o);
        }
        public List<JG_AdjustEntity> Select(JG_AdjustEntity entity)
        {
            return daoHelp.Select(entity) as List<JG_AdjustEntity>;
        }
		public List<JG_AdjustEntity> SelectForSort(JG_AdjustEntity entity,string sortField, bool isDesc)
        {
            return daoHelp.SelectForSort(entity,sortField,isDesc) as List<JG_AdjustEntity>;
        }
        public List<JG_AdjustEntity> SelectForPage(JG_AdjustEntity entity,int Skip,int Count)
        {
            return daoHelp.SelectForPage(entity,Skip,Count) as List<JG_AdjustEntity>;
        }
        public List<JG_AdjustEntity> Selects()
        {
            return daoHelp.Selects() as List<JG_AdjustEntity>;
        }
        public List<JG_AdjustEntity> SelectsForSort(string sortField,bool isDesc)
        {
            return daoHelp.SelectsForSort(sortField,isDesc) as List<JG_AdjustEntity>;
        }
        public List<JG_AdjustEntity> SelectsForPage(int Skip, int Count)
        {
            return daoHelp.SelectsForPage(Skip,Count) as List<JG_AdjustEntity>;
        }

    }
}
