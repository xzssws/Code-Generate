using System;
public class BM_ODOther
{
/* 0101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101 */
        #region IBM_OD 成员
        /// <summary>
        /// 增加一条[BM_OD]
        /// </summary>
        public bool AddBM_OD(BM_OD obj)
        {
            BM_ODMgr mgr = new BM_ODMgr();
            return mgr.AddBM_OD(obj);
        }
        /// <summary>
        /// 更改一条[BM_OD]
        /// </summary>
        public bool UpdateBM_OD(BM_OD obj, string primaryKey)
        {
            BM_ODMgr mgr = new BM_ODMgr();
            return mgr.UpdateBM_OD(obj, primaryKey);
        }
        /// <summary>
        /// 根据条件删除一条或多条[BM_OD]
        /// </summary>
        public bool DeleteBM_OD(DZFFilter filter)
        {
            BM_ODMgr mgr = new BM_ODMgr();
            return mgr.DeleteBM_OD(filter);
        }
        /// <summary>
        /// 根据主键删除一条[BM_OD]
        /// </summary>
        public bool DeleteBM_OD(string Key)
        {
            BM_ODMgr mgr = new BM_ODMgr();
            return mgr.DeleteBM_OD(Key);
        }
        /// <summary>
        /// 根据主键获取一条[BM_OD]
        /// </summary>
        public BM_OD GetBM_OD(string Key)
        {
            BM_ODMgr mgr = new BM_ODMgr();
            return mgr.GetBM_OD(Key);
        }
        /// <summary>
        /// 根据条件筛选并获得多条[BM_OD]
        /// </summary>
        public List<BM_OD> GetBM_ODs(DZFFilter filter)
        {
            BM_ODMgr mgr = new BM_ODMgr();
            return mgr.GetBM_ODs(filter);
        }
        /// <summary>
        /// 根据筛选实体筛选并获得多条[BM_OD]
        /// </summary>
        public List<BM_OD> GetBM_ODs(BM_OD obj)
        {
            BM_ODMgr mgr = new BM_ODMgr();
            return mgr.GetBM_ODs(obj);
        }
        /// <summary>
        /// 获取数据库中所有[BM_OD]
        /// </summary>
        public List<BM_OD> GetBM_ODs()
        {
            BM_ODMgr mgr = new BM_ODMgr();
            return mgr.GetBM_ODs();
        }

        #endregion
/* 0101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101 */		
		#region BM_OD Service
        /// <summary>
        /// 增加一条[BM_OD]
        /// </summary>
        [WebMethod(EnableSession = true, Description = "增加一条[BM_OD]")]
        public bool AddBM_OD(string objstr)
        {
            BM_OD obj = BinarySerializer.Deserialize(objstr) as BM_OD;
            return BT_MaterialStorageLocalClient.GetClient().AddBM_OD(obj);
        }
        /// <summary>
        /// 更改一条[BM_OD]
        /// </summary>
        [WebMethod(EnableSession = true, Description = "更改一条[BM_OD]")]
        public bool UpdateBM_OD(string objstr, string primaryKey)
        {
            BM_OD obj = BinarySerializer.Deserialize(objstr) as BM_OD;
            return BT_MaterialStorageLocalClient.GetClient().UpdateBM_OD(obj, primaryKey);
        }
        /// <summary>
        /// 根据条件删除一条或多条[BM_OD]
        /// </summary>
        [WebMethod(EnableSession = true, Description = "根据条件删除一条或多条[BM_OD]")]
        public bool DeleteBM_ODBF(string filterstr)
        {
            DZFFilter filter = BinarySerializer.Deserialize(filterstr) as DZFFilter;
            return BT_MaterialStorageLocalClient.GetClient().DeleteBM_OD(filter);
        }
        /// <summary>
        /// 根据主键删除一条[BM_OD]
        /// </summary>
        [WebMethod(EnableSession = true, Description = "根据主键删除一条[BM_OD]")]
        public bool DeleteBM_ODBK(string Key)
        {
            return BT_MaterialStorageLocalClient.GetClient().DeleteBM_OD(Key);
        }
        /// <summary>
        /// 根据主键获取一条[BM_OD]
        /// </summary>
        [WebMethod(EnableSession = true, Description = "根据主键获取一条[BM_OD]")]
        public string GetBM_OD(string Key)
        {
            BM_OD obj = BT_MaterialStorageLocalClient.GetClient().GetBM_OD(Key);
            return BinarySerializer.Serialize(obj);
        }
        /// <summary>
        /// 根据条件筛选并获得多条[BM_OD]
        /// </summary>
        [WebMethod(EnableSession = true, Description = "根据条件筛选并获得多条[BM_OD]")]
        public string GetBM_ODsBF(string filterstr)
        {
            DZFFilter filter = BinarySerializer.Deserialize(filterstr) as DZFFilter;
            List<BM_OD> list = BT_MaterialStorageLocalClient.GetClient().GetBM_ODs(filter);
            return BinarySerializer.Serialize(list);
        }
        /// <summary>
        /// 根据筛选实体筛选并获得多条[BM_OD]
        /// </summary>
        [WebMethod(EnableSession = true, Description = "根据筛选实体筛选并获得多条[BM_OD]")]
        public string GetBM_ODsBE(string objstr)
        {
            BM_OD obj = BinarySerializer.Deserialize(objstr) as BM_OD;
            List<BM_OD> list = BT_MaterialStorageLocalClient.GetClient().GetBM_ODs(obj);
            return BinarySerializer.Serialize(list);
        }
        /// <summary>
        /// 获取数据库中所有[BM_OD]
        /// </summary>
        [WebMethod(EnableSession = true, Description = "获取数据库中多有[BM_OD]")]
        public string GetBM_ODs()
        {
            List<BM_OD> list = BT_MaterialStorageLocalClient.GetClient().GetBM_ODs();
            return BinarySerializer.Serialize(list);
        }

        #endregion
/* 0101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101 */		
		#region IBM_OD 成员
        /// <summary>
        /// 增加一条[BM_OD]
        /// </summary>
        public bool AddBM_OD(BM_OD obj)
        {
            string objstr = BinarySerializer.Serialize(obj);
            bool result = CurrentService.AddBM_OD(objstr);
            return result;
        }
        /// <summary>
        /// 更改一条[BM_OD]
        /// </summary>
        public bool UpdateBM_OD(BM_OD obj, string primaryKey)
        {
            string objstr = BinarySerializer.Serialize(obj);
            bool result = CurrentService.UpdateBM_OD(objstr, primaryKey);
            return result;
        }
        /// <summary>
        /// 根据条件删除一条或多条[BM_OD]
        /// </summary>
        public bool DeleteBM_OD(DZFFilter filter)
        {
            string filterstr = BinarySerializer.Serialize(filter);
            bool result = CurrentService.DeleteBM_ODBF(filterstr);
            return result;
        }
        /// <summary>
        /// 根据主键删除一条[BM_OD]
        /// </summary>
        public bool DeleteBM_OD(string Key)
        {
            bool result = CurrentService.DeleteBM_ODBK(Key);
            return result;
        }
        /// <summary>
        /// 根据主键获取一条[BM_OD]
        /// </summary>
        public DongZheng.Soft.BT.Spi.BM_OD GetBM_OD(string Key)
        {
            object obj = CurrentService.GetBM_OD(Key);
            DongZheng.Soft.BT.Spi.BM_OD result = obj as DongZheng.Soft.BT.Spi.BM_OD;
            return result;
        }
        /// <summary>
        /// 根据条件筛选并获得多条[BM_OD]
        /// </summary>
        public List<DongZheng.Soft.BT.Spi.BM_OD> GetBM_ODs(DZFFilter filter)
        {
            string filterstr = BinarySerializer.Serialize(filter);
            object obj = BinarySerializer.Deserialize(CurrentService.GetBM_ODsBF(filterstr));
            List<DongZheng.Soft.BT.Spi.BM_OD> result = obj as List<DongZheng.Soft.BT.Spi.BM_OD>;
            return result;
        }
        /// <summary>
        /// 根据筛选实体筛选并获得多条[BM_OD]
        /// </summary>
        public List<BM_OD> GetBM_ODs(BM_OD obj)
        {
            string objstr = BinarySerializer.Serialize(obj);
            object resultobj = BinarySerializer.Deserialize(CurrentService.GetBM_ODsBE(objstr));
            List<DongZheng.Soft.BT.Spi.BM_OD> result = resultobj as List<DongZheng.Soft.BT.Spi.BM_OD>;
            return result;
        }
        /// <summary>
        /// 获取数据库中所有[BM_OD]
        /// </summary>
        public List<BM_OD> GetBM_ODs()
        {
            object obj = BinarySerializer.Deserialize(CurrentService.GetBM_ODs());
            List<DongZheng.Soft.BT.Spi.BM_OD> result = obj as List<DongZheng.Soft.BT.Spi.BM_OD>;
            return result;
        }

        #endregion
}
