using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// DspFunc数据库访问类
    /// </summary>
    public sealed partial class DspFuncLogic
    {
		#region 单例模式

		private DspFuncLogic(){ }

        private static readonly object LockObj = new object();

        private static DspFuncLogic _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static DspFuncLogic Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new DspFuncLogic();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        DspFuncDao daoHelp =  DspFuncDao.Instance;

        public bool Add(DspFuncEntity o)
        {
            return daoHelp.Add(o);
        }
        public bool Update(DspFuncEntity o)
        {
            return daoHelp.Update(o);
        }
        public bool Delete(string o)
        {
            return daoHelp.Delete(o);
        }
        public List<DspFuncEntity> Select(DspFuncEntity entity)
        {
            return daoHelp.Select(entity) as List<DspFuncEntity>;
        }
		public List<DspFuncEntity> SelectForSort(DspFuncEntity entity,string sortField, bool isDesc)
        {
            return daoHelp.SelectForSort(entity,sortField,isDesc) as List<DspFuncEntity>;
        }
        public List<DspFuncEntity> SelectForPage(DspFuncEntity entity,int Skip,int Count)
        {
            return daoHelp.SelectForPage(entity,Skip,Count) as List<DspFuncEntity>;
        }
        public List<DspFuncEntity> Selects()
        {
            return daoHelp.Selects() as List<DspFuncEntity>;
        }
        public List<DspFuncEntity> SelectsForSort(string sortField,bool isDesc)
        {
            return daoHelp.SelectsForSort(sortField,isDesc) as List<DspFuncEntity>;
        }
        public List<DspFuncEntity> SelectsForPage(int Skip, int Count)
        {
            return daoHelp.SelectsForPage(Skip,Count) as List<DspFuncEntity>;
        }

    }
}
