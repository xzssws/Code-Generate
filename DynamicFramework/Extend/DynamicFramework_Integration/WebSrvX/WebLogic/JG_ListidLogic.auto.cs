using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// JG_Listid数据库访问类
    /// </summary>
    public sealed partial class JG_ListidLogic
    {
		#region 单例模式

		private JG_ListidLogic(){ }

        private static readonly object LockObj = new object();

        private static JG_ListidLogic _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static JG_ListidLogic Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new JG_ListidLogic();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        JG_ListidDao daoHelp =  JG_ListidDao.Instance;

        public bool Add(JG_ListidEntity o)
        {
            return daoHelp.Add(o);
        }
        public bool Update(JG_ListidEntity o)
        {
            return daoHelp.Update(o);
        }
        public bool Delete(string o)
        {
            return daoHelp.Delete(o);
        }
        public List<JG_ListidEntity> Select(JG_ListidEntity entity)
        {
            return daoHelp.Select(entity) as List<JG_ListidEntity>;
        }
		public List<JG_ListidEntity> SelectForSort(JG_ListidEntity entity,string sortField, bool isDesc)
        {
            return daoHelp.SelectForSort(entity,sortField,isDesc) as List<JG_ListidEntity>;
        }
        public List<JG_ListidEntity> SelectForPage(JG_ListidEntity entity,int Skip,int Count)
        {
            return daoHelp.SelectForPage(entity,Skip,Count) as List<JG_ListidEntity>;
        }
        public List<JG_ListidEntity> Selects()
        {
            return daoHelp.Selects() as List<JG_ListidEntity>;
        }
        public List<JG_ListidEntity> SelectsForSort(string sortField,bool isDesc)
        {
            return daoHelp.SelectsForSort(sortField,isDesc) as List<JG_ListidEntity>;
        }
        public List<JG_ListidEntity> SelectsForPage(int Skip, int Count)
        {
            return daoHelp.SelectsForPage(Skip,Count) as List<JG_ListidEntity>;
        }

    }
}
