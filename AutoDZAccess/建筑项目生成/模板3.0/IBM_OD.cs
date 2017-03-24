using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DongZhengSoft.Framework.Core.Common;

namespace DongZheng.Soft.BT.Spi
{
    /// <summary>
    /// 接口解释
    /// </summary>
    public interface IBM_OD
    {
        #region 预制方法
        /// <summary>
        /// 增加一条[BM_OD]
        /// </summary>
        bool AddBM_OD(BM_OD obj);
        /// <summary>
        /// 更改一条[BM_OD]
        /// </summary>
        bool UpdateBM_OD(BM_OD obj, string primaryKey);
        /// <summary>
        /// 根据条件删除一条或多条[BM_OD]
        /// </summary>
        bool DeleteBM_OD(DZFFilter filter);
        /// <summary>
        /// 根据主键删除一条[BM_OD]
        /// </summary>
        bool DeleteBM_OD(string Key);
        /// <summary>
        /// 根据主键获取一条[BM_OD]
        /// </summary>
        BM_OD GetBM_OD(string Key);
        /// <summary>
        /// 根据条件筛选并获得多条[BM_OD]
        /// </summary>
        List<BM_OD> GetBM_ODs(DZFFilter filter);
        /// <summary>
        /// 根据筛选实体筛选并获得多条[BM_OD]
        /// </summary>
        List<BM_OD> GetBM_ODs(BM_OD obj);
        /// <summary>
        /// 获取数据库中所有[BM_OD]
        /// </summary>
        List<BM_OD> GetBM_ODs(); 
        #endregion

        #region 业务方法

        #endregion
    }
}
