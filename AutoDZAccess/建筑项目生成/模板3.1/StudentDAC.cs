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
    /// [Student]数据访问
    /// </summary>
    public class StudentDAC : AbstractDAC<Student, string>
    {
		private readonly bool isSuper = false;

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
                return "Student";
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
                return new string[]{ "ID","Name","Age","Passowrd","IDNum" };
            }
        }
        //更新字段集
        protected override string[] UpdateFields
        {
            get
            {
                return new string[]{ "Name","Age","Passowrd","IDNum" };
            }
        }
        //查询字段集
        protected override string QueryFields
        {
            get
            {
                return "ID,Name,Age,Passowrd,IDNum";
            }
        }

        //插入SQL赋值
        protected override object[] GetInsertSQLParamDataList(Student newObject)
        {
            return new object[] { newObject.ID,newObject.Name,newObject.Age,newObject.Passowrd,newObject.IDNum };
        }
		//更新SQL赋值
        protected override object[] GetUpdateRowSQLParamDataList(Student obj)
        {
			if(isSuper)
			{
				List<object> list = new List<object>();
				if(obj.Name!=null) list.Add(obj.Name);
				if(obj.Age!=null) list.Add(obj.Age);
				if(obj.Passowrd!=null) list.Add(obj.Passowrd);
				if(obj.IDNum!=null) list.Add(obj.IDNum);
				if(obj.ID!=null) list.Add(obj.ID);
				return list.ToArray();
			}
			else
			{
				return new object[]{ obj.Name,obj.Age,obj.Passowrd,obj.IDNum,obj.ID };
			}
        }

		//重写插入SQL
        protected override string GetInsertSQL(Student obj)
        {
            if (isSuper)
            {
                string deleteSql = string.Format("DELETE FROM {0} WHERE {1}='{2}' ;", this.Table, this.PrimaryKey, obj.ID);
                return deleteSql + base.GetInsertSQL(obj);
            }
            else
            {
                return base.GetInsertSQL(obj);
            }
        }
		//重写更新SQL
        protected override string GetUpdateRowSQL(Student obj)
        {
			if(isSuper)
			{
				StringBuilder sqlBuilder = new StringBuilder();
				sqlBuilder.AppendFormat("UPDATE {0} SET ",this.Table);
				int i = 0;
				if(obj.Name!=null)
				{
					sqlBuilder.Append("Name = {"+i+"} ,");
					i++;
				}
				if(obj.Age!=null)
				{
					sqlBuilder.Append("Age = {"+i+"} ,");
					i++;
				}
				if(obj.Passowrd!=null)
				{
					sqlBuilder.Append("Passowrd = {"+i+"} ,");
					i++;
				}
				if(obj.IDNum!=null)
				{
					sqlBuilder.Append("IDNum = {"+i+"} ,");
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
        protected override string GetContainsObjectSQL(Student obj)
        {
			return GetContainsKeySQL(obj.ID);
        }

        //通过DataRow给对象各个属性赋值
        protected override Student GetObjectByDataRow(DataRow row)
        {
            Student obj = new Student();
			if (row["ID"]!=null&&row["ID"]!=DBNull.Value) obj.ID = Convert.ToString(row["ID"]);
			if (row["Name"]!=null&&row["Name"]!=DBNull.Value) obj.Name = Convert.ToString(row["Name"]);
			if (row["Age"]!=null&&row["Age"]!=DBNull.Value) obj.Age = Convert.ToString(row["Age"]);
			if (row["Passowrd"]!=null&&row["Passowrd"]!=DBNull.Value) obj.Passowrd = Convert.ToString(row["Passowrd"]);
			if (row["IDNum"]!=null&&row["IDNum"]!=DBNull.Value) obj.IDNum = Convert.ToString(row["IDNum"]);
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
        private DZFFilter et_ObjectToFilter(Student obj)
        {
            if (obj == null) return new DZFFilter();

            DZFFilter filter = new DZFFilter();
            StringBuilder sqlfilter = new StringBuilder();
            sqlfilter.Append("1 = 1 ");
			if (obj.ID!=null) sqlfilter.AppendFormat(" AND ID = '{0}' ", obj.ID);
			if (obj.Name!=null) sqlfilter.AppendFormat(" AND Name = '{0}' ", obj.Name);
			if (obj.Age!=null) sqlfilter.AppendFormat(" AND Age = '{0}' ", obj.Age);
			if (obj.Passowrd!=null) sqlfilter.AppendFormat(" AND Passowrd = '{0}' ", obj.Passowrd);
			if (obj.IDNum!=null) sqlfilter.AppendFormat(" AND IDNum = '{0}' ", obj.IDNum);
			filter.FilterCondition = sqlfilter.ToString();
            return filter;
        }
        #endregion

        #region 预制方法

        //注：下列方法是基础的增删该查操作的实现。

        /// <summary>
        /// 增加一条[Student]
        /// </summary>
        public bool AddStudent(Student obj)
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
        /// 更改一条[Student]
        /// </summary>
        public bool UpdateStudent(Student obj, string primaryKey)
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
        /// 根据条件删除一条或多条[Student]
        /// </summary>
        public bool DeleteStudent(DZFFilter filter)
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
        /// 根据主键删除一条[Student]
        /// </summary>
        public bool DeleteStudent(string Key)
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
        /// 根据主键获取一条[Student]
        /// </summary>
        public Student GetStudent(string Key)
        {
            try
            {
                Student obj = this[Key];
                return obj;
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// 根据条件筛选并获得多条[Student]
        /// </summary>
        public List<Student> GetStudents(DZFFilter filter)
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
        /// 根据筛选实体筛选并获得多条[Student]
        /// </summary>
        public List<Student> GetStudents(Student obj)
        {
            DZFFilter dzf = et_ObjectToFilter(obj);
            return GetStudents(dzf);
        }
        /// <summary>
        /// 获取数据库中所有[Student]
        /// </summary>
        public List<Student> GetStudents()
        {
            DZFFilter dzf = new DZFFilter();
            return GetStudents(dzf);
        }
        /// <summary>
        /// 获取数据库中[Student](分页|集合)
        /// </summary>
        public List<Student> GetStudentPages(int pageCurrent, int pageSize, string sort, out int count)
        {
            DataSet dataset = GetStudentPages(pageCurrent, pageSize, sort);
            List<Student> result = GetObjectByDataset(dataset);
            count = Convert.ToInt32(dataset.Tables[1].Rows[0][0]);
            return result;
        }
        /// <summary>
        /// 获取数据库中[Student](分页|数据集)
        /// </summary>
        public DataSet GetStudentPages(int pageCurrent, int pageSize, string sort)
        {
            string sql = string.Format(@"SELECT {0} FORM (SELECT ROW_NUMBER() OVER (ORDER BY {4} DESC)PageNum,{0} FROM {1} WHERE a.Pagenum BETWEEN {2} and {3} ;
                                  SELECT COUNT(1) FORM", QueryFields, Table, (pageSize * (pageCurrent - 1) + 1), (pageSize * pageCurrent), sort);
            return GetData(sql);
        }
        #endregion

        #region 业务方法

        #endregion
    }
}


