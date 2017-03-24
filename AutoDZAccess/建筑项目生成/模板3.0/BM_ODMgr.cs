using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DongZheng.Soft.BT.Spi;
using DongZhengSoft.Framework.Core.Common;

namespace DongZheng.Soft.BT.Core
{
    public class BM_ODMgr
    {
        #region DAC访问对象单例
        private BM_ODDAC dacInstance;
        /// <summary>
        /// 获得DAC对象
        /// </summary>
        /// <returns>DAC对象</returns>
        private BM_ODDAC GetDacInstance()
        {
            if (dacInstance == null)
                dacInstance = new BM_ODDAC();
            return dacInstance;
        }
        #endregion

        #region 预制方法
        /// <summary>
        /// 增加一条[BM_OD]
        /// </summary>
        public bool AddBM_OD(BM_OD obj)
        {
            return GetDacInstance().AddBM_OD(obj);
        }
        /// <summary>
        /// 更改一条[BM_OD]
        /// </summary>
        public bool UpdateBM_OD(BM_OD obj, string primaryKey)
        {
            return GetDacInstance().UpdateBM_OD(obj, primaryKey);
        }
        /// <summary>
        /// 根据条件删除一条或多条[BM_OD]
        /// </summary>
        public bool DeleteBM_OD(DZFFilter filter)
        {
            return GetDacInstance().DeleteBM_OD(filter);
        }
        /// <summary>
        /// 根据主键删除一条[BM_OD]
        /// </summary>
        public bool DeleteBM_OD(string Key)
        {
            return GetDacInstance().DeleteBM_OD(Key);
        }
        /// <summary>
        /// 根据主键获取一条[BM_OD]
        /// </summary>
        public BM_OD GetBM_OD(string Key)
        {
            return GetDacInstance().GetBM_OD(Key);
        }
        /// <summary>
        /// 根据条件筛选并获得多条[BM_OD]
        /// </summary>
        public List<BM_OD> GetBM_ODs(DZFFilter filter)
        {
            return GetDacInstance().GetBM_ODs(filter);
        }
        /// <summary>
        /// 根据筛选实体筛选并获得多条[BM_OD]
        /// </summary>
        public List<BM_OD> GetBM_ODs(BM_OD obj)
        {
            return GetDacInstance().GetBM_ODs(obj);
        }
        /// <summary>
        /// 获取数据库中所有[BM_OD]
        /// </summary>
        public List<BM_OD> GetBM_ODs()
        {
            return GetDacInstance().GetBM_ODs();
        }
        #endregion

        #region 业务方法

        #endregion
    }
}
