using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// UserDuty数据库访问类
    /// </summary>
    public sealed partial class UserDutyLogic
    {
		#region 单例模式

		private UserDutyLogic(){ }

        private static readonly object LockObj = new object();

        private static UserDutyLogic _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static UserDutyLogic Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new UserDutyLogic();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        UserDutyDao daoHelp =  UserDutyDao.Instance;

        public bool Add(UserDutyEntity o)
        {
            return daoHelp.Add(o);
        }
        public bool Update(UserDutyEntity o)
        {
            return daoHelp.Update(o);
        }
        public bool Delete(string o)
        {
            return daoHelp.Delete(o);
        }
        public List<UserDutyEntity> Select(UserDutyEntity entity)
        {
            return daoHelp.Select(entity) as List<UserDutyEntity>;
        }
		public List<UserDutyEntity> SelectForSort(UserDutyEntity entity,string sortField, bool isDesc)
        {
            return daoHelp.SelectForSort(entity,sortField,isDesc) as List<UserDutyEntity>;
        }
        public List<UserDutyEntity> SelectForPage(UserDutyEntity entity,int Skip,int Count)
        {
            return daoHelp.SelectForPage(entity,Skip,Count) as List<UserDutyEntity>;
        }
        public List<UserDutyEntity> Selects()
        {
            return daoHelp.Selects() as List<UserDutyEntity>;
        }
        public List<UserDutyEntity> SelectsForSort(string sortField,bool isDesc)
        {
            return daoHelp.SelectsForSort(sortField,isDesc) as List<UserDutyEntity>;
        }
        public List<UserDutyEntity> SelectsForPage(int Skip, int Count)
        {
            return daoHelp.SelectsForPage(Skip,Count) as List<UserDutyEntity>;
        }

    }
}
