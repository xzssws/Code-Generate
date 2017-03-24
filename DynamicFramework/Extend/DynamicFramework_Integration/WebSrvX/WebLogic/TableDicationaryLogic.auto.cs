using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// TableDicationary数据库访问类
    /// </summary>
    public sealed partial class TableDicationaryLogic
    {
		#region 单例模式

		private TableDicationaryLogic(){ }

        private static readonly object LockObj = new object();

        private static TableDicationaryLogic _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static TableDicationaryLogic Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new TableDicationaryLogic();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        TableDicationaryDao daoHelp =  TableDicationaryDao.Instance;

        public List<TableDicationaryEntity> Select(TableDicationaryEntity entity)
        {
            return daoHelp.Select(entity) as List<TableDicationaryEntity>;
        }
		public List<TableDicationaryEntity> SelectForSort(TableDicationaryEntity entity,string sortField, bool isDesc)
        {
            return daoHelp.SelectForSort(entity,sortField,isDesc) as List<TableDicationaryEntity>;
        }
        public List<TableDicationaryEntity> SelectForPage(TableDicationaryEntity entity,int Skip,int Count)
        {
            return daoHelp.SelectForPage(entity,Skip,Count) as List<TableDicationaryEntity>;
        }
        public List<TableDicationaryEntity> Selects()
        {
            return daoHelp.Selects() as List<TableDicationaryEntity>;
        }
        public List<TableDicationaryEntity> SelectsForSort(string sortField,bool isDesc)
        {
            return daoHelp.SelectsForSort(sortField,isDesc) as List<TableDicationaryEntity>;
        }
        public List<TableDicationaryEntity> SelectsForPage(int Skip, int Count)
        {
            return daoHelp.SelectsForPage(Skip,Count) as List<TableDicationaryEntity>;
        }

    }
}
