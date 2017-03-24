using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// SerialNoConfig数据库访问类
    /// </summary>
    public sealed partial class SerialNoConfigLogic
    {
		#region 单例模式

		private SerialNoConfigLogic(){ }

        private static readonly object LockObj = new object();

        private static SerialNoConfigLogic _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static SerialNoConfigLogic Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new SerialNoConfigLogic();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        SerialNoConfigDao daoHelp =  SerialNoConfigDao.Instance;

        public bool Add(SerialNoConfigEntity o)
        {
            return daoHelp.Add(o);
        }
        public bool Update(SerialNoConfigEntity o)
        {
            return daoHelp.Update(o);
        }
        public bool Delete(string o)
        {
            return daoHelp.Delete(o);
        }
        public List<SerialNoConfigEntity> Select(SerialNoConfigEntity entity)
        {
            return daoHelp.Select(entity) as List<SerialNoConfigEntity>;
        }
		public List<SerialNoConfigEntity> SelectForSort(SerialNoConfigEntity entity,string sortField, bool isDesc)
        {
            return daoHelp.SelectForSort(entity,sortField,isDesc) as List<SerialNoConfigEntity>;
        }
        public List<SerialNoConfigEntity> SelectForPage(SerialNoConfigEntity entity,int Skip,int Count)
        {
            return daoHelp.SelectForPage(entity,Skip,Count) as List<SerialNoConfigEntity>;
        }
        public List<SerialNoConfigEntity> Selects()
        {
            return daoHelp.Selects() as List<SerialNoConfigEntity>;
        }
        public List<SerialNoConfigEntity> SelectsForSort(string sortField,bool isDesc)
        {
            return daoHelp.SelectsForSort(sortField,isDesc) as List<SerialNoConfigEntity>;
        }
        public List<SerialNoConfigEntity> SelectsForPage(int Skip, int Count)
        {
            return daoHelp.SelectsForPage(Skip,Count) as List<SerialNoConfigEntity>;
        }

    }
}
