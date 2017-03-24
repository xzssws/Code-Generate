using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DongZhengSoft.Framework.Core.DataAccess;
using DongZheng.Soft.BT.Spi;
using DongZhengSoft.Framework.Core.Common;

namespace DongZheng.Soft.BT.Core
{
	/// <summary>
    /// BM_OD访问类
    /// </summary>
	public partial class BM_ODDAC : AbstractDAC<BM_OD, string>
	{
		#region 业务方法

		#endregion
	}

	#region 基础实现模型
    public partial class BM_ODDAC : AbstractDAC<BM_OD, string>
    {
		private const bool isSuper = false;

        #region 基础实现
        
        //注：此段代码是实现框架对于基础的增删改查的实现，请注意修改。
        
        //获得数据库访问对象
        protected override IDZFDatabase GetDatabase()
        {
            return Database.GetDatabase();
        }
        //表名
        protected override string Table
        {
            get
            {
                return "BM_OD";
            }
        }
        //主键字段名称
        protected override string PrimaryKey
        {
            get
            {
                return "ID";
            }
        }

        //插入字段集
        protected override string[] InsertFields
        {
            get
            {
                return new string[]{ "ID","Flag","UserName","Password" };
            }
        }
        //更新字段集
        protected override string[] UpdateFields
        {
            get
            {
                return new string[]{ "Flag","UserName","Password" };
            }
        }
        //查询字段集
        protected override string QueryFields
        {
            get
            {
                return "ID,Flag,UserName,Password";
            }
        }

        //插入SQL赋值
        protected override object[] GetInsertSQLParamDataList(BM_OD newObject)
        {
            return new object[] { newObject.ID,newObject.Flag,newObject.UserName,newObject.Password };
        }
		//更新SQL赋值
        protected override object[] GetUpdateRowSQLParamDataList(BM_OD obj)
        {
			if(isSuper)
			{
				List<object> list = new List<object>();
				if(!string.IsNullOrEmpty(obj.Flag)) list.Add(obj.Flag);
				if(!string.IsNullOrEmpty(obj.UserName)) list.Add(obj.UserName);
				if(!string.IsNullOrEmpty(obj.Password)) list.Add(obj.Password);
				if(!string.IsNullOrEmpty(obj.ID)) list.Add(obj.ID);
				return list.ToArray();
			}
			else
			{
				return new object[]{ obj.Flag,obj.UserName,obj.Password,obj.ID };
			}
        }

		//重写更新SQL
        protected override string GetUpdateRowSQL(BM_OD obj)
        {
			if(isSuper)
			{
				StringBuilder sqlBuilder = new StringBuilder();
				sqlBuilder.AppendFormat("UPDATE {0} SET ",this.Table);
				int i = 0;
				if(!string.IsNullOrEmpty(obj.Flag))
				{
					sqlBuilder.Append("Flag = {"+i+"} ,");
					i++;
				}
				if(!string.IsNullOrEmpty(obj.UserName))
				{
					sqlBuilder.Append("UserName = {"+i+"} ,");
					i++;
				}
				if(!string.IsNullOrEmpty(obj.Password))
				{
					sqlBuilder.Append("Password = {"+i+"} ,");
					i++;
				}
				string WhereSQL = " WHERE ID = '{"+i+"}'";
				return sqlBuilder.ToString().TrimEnd(',')+ WhereSQL;
			}
			else
			{
				return base.GetUpdateRowSQL(obj);
			}
        }
        //重写存在检查SQL
        protected override string GetContainsObjectSQL(BM_OD obj)
        {
			return GetContainsKeySQL(obj.ID);
        }

        //通过DataRow给对象各个属性赋值
        protected override BM_OD GetObjectByDataRow(DataRow row)
        {
            BM_OD obj = new BM_OD();
			if (row["ID"]!=null&&row["ID"]!=DBNull.Value) obj.ID = Convert.ToString(row["ID"]);
			if (row["Flag"]!=null&&row["Flag"]!=DBNull.Value) obj.Flag = Convert.ToString(row["Flag"]);
			if (row["UserName"]!=null&&row["UserName"]!=DBNull.Value) obj.UserName = Convert.ToString(row["UserName"]);
			if (row["Password"]!=null&&row["Password"]!=DBNull.Value) obj.Password = Convert.ToString(row["Password"]);
			return obj;
        }
        /// <summary>
        /// 扩展_实体对象转换筛选对象 
        /// </summary>
        /// <remarks>
        /// 注：将对象不为空的属性加入条件筛选
        /// 特注：只为内部使用方便，没其他特殊含义。
        /// </remarks>
        /// <param name="obj">对象</param>
        /// <returns>过滤对象</returns>
        private DZFFilter et_ObjectToFilter(BM_OD obj)
        {
            if (obj == null) return new DZFFilter();

            DZFFilter filter = new DZFFilter();
            StringBuilder sqlfilter = new StringBuilder();
            sqlfilter.Append("1 = 1 ");
			if (!string.IsNullOrEmpty(obj.ID)) sqlfilter.AppendFormat(" AND ID = '{0}' ", obj.ID);
			if (!string.IsNullOrEmpty(obj.Flag)) sqlfilter.AppendFormat(" AND Flag = '{0}' ", obj.Flag);
			if (!string.IsNullOrEmpty(obj.UserName)) sqlfilter.AppendFormat(" AND UserName = '{0}' ", obj.UserName);
			if (!string.IsNullOrEmpty(obj.Password)) sqlfilter.AppendFormat(" AND Password = '{0}' ", obj.Password);
			filter.FilterCondition = sqlfilter.ToString();
            return filter;
        }
        #endregion

        #region 预制方法

        //注：下列方法是基础的增删该查操作的实现。

        /// <summary>
        /// 增加一条[BM_OD]
        /// </summary>
        public bool AddBM_OD(BM_OD obj)
        {
            try
            {
                this.Add(obj);
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// 更改一条[BM_OD]
        /// </summary>
        public bool UpdateBM_OD(BM_OD obj, string primaryKey)
        {
            try
            {
                this[primaryKey] = obj;
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// 根据条件删除一条或多条[BM_OD]
        /// </summary>
        public bool DeleteBM_OD(DZFFilter filter)
        {
            try
            {
                this.Remove(filter);
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// 根据主键删除一条[BM_OD]
        /// </summary>
        public bool DeleteBM_OD(string Key)
        {
            try
            {
                this.Remove(Key);
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// 根据主键获取一条[BM_OD]
        /// </summary>
        public BM_OD GetBM_OD(string Key)
        {
            try
            {
                BM_OD obj = this[Key];
                return obj;
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// 根据条件筛选并获得多条[BM_OD]
        /// </summary>
        public List<BM_OD> GetBM_ODs(DZFFilter filter)
        {
            try
            {
                return this.GetObjects(filter);
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// 根据筛选实体筛选并获得多条[BM_OD]
        /// </summary>
        public List<BM_OD> GetBM_ODs(BM_OD obj)
        {
            DZFFilter dzf = et_ObjectToFilter(obj);
            return GetBM_ODs(dzf);
        }
        /// <summary>
        /// 获取数据库中所有[BM_OD]
        /// </summary>
        public List<BM_OD> GetBM_ODs()
        {
            DZFFilter dzf = new DZFFilter();
            return GetBM_ODs(dzf);
        }
        #endregion
    }
	#endregion
}


