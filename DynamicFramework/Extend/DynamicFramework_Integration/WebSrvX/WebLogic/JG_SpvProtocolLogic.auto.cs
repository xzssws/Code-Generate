using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// JG_SpvProtocol数据库访问类
    /// </summary>
    public sealed partial class JG_SpvProtocolLogic
    {
		#region 单例模式

		private JG_SpvProtocolLogic(){ }

        private static readonly object LockObj = new object();

        private static JG_SpvProtocolLogic _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static JG_SpvProtocolLogic Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new JG_SpvProtocolLogic();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        JG_SpvProtocolDao daoHelp =  JG_SpvProtocolDao.Instance;

        public bool Add(JG_SpvProtocolEntity o)
        {
            return daoHelp.Add(o);
        }
        public bool Update(JG_SpvProtocolEntity o)
        {
            return daoHelp.Update(o);
        }
        public bool Delete(string o)
        {
            return daoHelp.Delete(o);
        }
        public List<JG_SpvProtocolEntity> Select(JG_SpvProtocolEntity entity)
        {
            return daoHelp.Select(entity) as List<JG_SpvProtocolEntity>;
        }
		public List<JG_SpvProtocolEntity> SelectForSort(JG_SpvProtocolEntity entity,string sortField, bool isDesc)
        {
            return daoHelp.SelectForSort(entity,sortField,isDesc) as List<JG_SpvProtocolEntity>;
        }
        public List<JG_SpvProtocolEntity> SelectForPage(JG_SpvProtocolEntity entity,int Skip,int Count)
        {
            return daoHelp.SelectForPage(entity,Skip,Count) as List<JG_SpvProtocolEntity>;
        }
        public List<JG_SpvProtocolEntity> Selects()
        {
            return daoHelp.Selects() as List<JG_SpvProtocolEntity>;
        }
        public List<JG_SpvProtocolEntity> SelectsForSort(string sortField,bool isDesc)
        {
            return daoHelp.SelectsForSort(sortField,isDesc) as List<JG_SpvProtocolEntity>;
        }
        public List<JG_SpvProtocolEntity> SelectsForPage(int Skip, int Count)
        {
            return daoHelp.SelectsForPage(Skip,Count) as List<JG_SpvProtocolEntity>;
        }

    }
}
