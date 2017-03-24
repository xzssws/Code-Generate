using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// SysConfig数据库访问类
    /// </summary>
    public sealed partial class SysConfigLogic
    {
		#region 单例模式

		private SysConfigLogic(){ }

        private static readonly object LockObj = new object();

        private static SysConfigLogic _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static SysConfigLogic Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new SysConfigLogic();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        SysConfigDao daoHelp =  SysConfigDao.Instance;

        public bool Add(SysConfigEntity o)
        {
            return daoHelp.Add(o);
        }
        public bool Update(SysConfigEntity o)
        {
            return daoHelp.Update(o);
        }
        public bool Delete(string o)
        {
            return daoHelp.Delete(o);
        }
        public List<SysConfigEntity> Select(SysConfigEntity entity)
        {
            return daoHelp.Select(entity) as List<SysConfigEntity>;
        }
		public List<SysConfigEntity> SelectForSort(SysConfigEntity entity,string sortField, bool isDesc)
        {
            return daoHelp.SelectForSort(entity,sortField,isDesc) as List<SysConfigEntity>;
        }
        public List<SysConfigEntity> SelectForPage(SysConfigEntity entity,int Skip,int Count)
        {
            return daoHelp.SelectForPage(entity,Skip,Count) as List<SysConfigEntity>;
        }
        public List<SysConfigEntity> Selects()
        {
            return daoHelp.Selects() as List<SysConfigEntity>;
        }
        public List<SysConfigEntity> SelectsForSort(string sortField,bool isDesc)
        {
            return daoHelp.SelectsForSort(sortField,isDesc) as List<SysConfigEntity>;
        }
        public List<SysConfigEntity> SelectsForPage(int Skip, int Count)
        {
            return daoHelp.SelectsForPage(Skip,Count) as List<SysConfigEntity>;
        }

    }
}
