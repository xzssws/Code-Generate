using System.Collections.Generic;
using DynamicEntity;

namespace DynamicDao
{
    /// <summary>
    /// UserInfo数据库访问类
    /// </summary>
    public sealed partial class UserInfoLogic
    {
		#region 单例模式

		private UserInfoLogic(){ }

        private static readonly object LockObj = new object();

        private static UserInfoLogic _instance;

        /// <summary>
        /// 获得对象实例
        /// </summary>
        public static UserInfoLogic Instance
        {
            get
            {
                lock (LockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new UserInfoLogic();
                    }
                    return _instance;
                }
            }
        }

        #endregion

        UserInfoDao daoHelp =  UserInfoDao.Instance;

        public bool Add(UserInfoEntity o)
        {
            return daoHelp.Add(o);
        }
        public bool Update(UserInfoEntity o)
        {
            return daoHelp.Update(o);
        }
        public bool Delete(string o)
        {
            return daoHelp.Delete(o);
        }
        public List<UserInfoEntity> Select(UserInfoEntity entity)
        {
            return daoHelp.Select(entity) as List<UserInfoEntity>;
        }
		public List<UserInfoEntity> SelectForSort(UserInfoEntity entity,string sortField, bool isDesc)
        {
            return daoHelp.SelectForSort(entity,sortField,isDesc) as List<UserInfoEntity>;
        }
        public List<UserInfoEntity> SelectForPage(UserInfoEntity entity,int Skip,int Count)
        {
            return daoHelp.SelectForPage(entity,Skip,Count) as List<UserInfoEntity>;
        }
        public List<UserInfoEntity> Selects()
        {
            return daoHelp.Selects() as List<UserInfoEntity>;
        }
        public List<UserInfoEntity> SelectsForSort(string sortField,bool isDesc)
        {
            return daoHelp.SelectsForSort(sortField,isDesc) as List<UserInfoEntity>;
        }
        public List<UserInfoEntity> SelectsForPage(int Skip, int Count)
        {
            return daoHelp.SelectsForPage(Skip,Count) as List<UserInfoEntity>;
        }

    }
}
