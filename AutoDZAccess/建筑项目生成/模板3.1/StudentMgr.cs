using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DongZheng.Soft.BT.Spi;
using DongZhengSoft.Framework.Core.Common;

namespace DongZheng.Soft.BT.Core
{
    public class StudentMgr
    {
        #region DAC访问对象单例
        private StudentDAC dacInstance;
        /// <summary>
        /// 获得DAC对象
        /// </summary>
        /// <returns>DAC对象</returns>
        private StudentDAC GetDacInstance()
        {
            if (dacInstance == null)
                dacInstance = new StudentDAC();
            return dacInstance;
        }
        #endregion

        #region 预制方法
        /// <summary>
        /// 增加一条[Student]
        /// </summary>
        public bool AddStudent(Student obj)
        {
            return GetDacInstance().AddStudent(obj);
        }
        /// <summary>
        /// 更改一条[Student]
        /// </summary>
        public bool UpdateStudent(Student obj, string primaryKey)
        {
            return GetDacInstance().UpdateStudent(obj, primaryKey);
        }
        /// <summary>
        /// 根据条件删除一条或多条[Student]
        /// </summary>
        public bool DeleteStudent(DZFFilter filter)
        {
            return GetDacInstance().DeleteStudent(filter);
        }
        /// <summary>
        /// 根据主键删除一条[Student]
        /// </summary>
        public bool DeleteStudent(string Key)
        {
            return GetDacInstance().DeleteStudent(Key);
        }
        /// <summary>
        /// 根据主键获取一条[Student]
        /// </summary>
        public Student GetStudent(string Key)
        {
            return GetDacInstance().GetStudent(Key);
        }
        /// <summary>
        /// 根据条件筛选并获得多条[Student]
        /// </summary>
        public List<Student> GetStudents(DZFFilter filter)
        {
            return GetDacInstance().GetStudents(filter);
        }
        /// <summary>
        /// 根据筛选实体筛选并获得多条[Student]
        /// </summary>
        public List<Student> GetStudents(Student obj)
        {
            return GetDacInstance().GetStudents(obj);
        }
        /// <summary>
        /// 获取数据库中所有[Student]
        /// </summary>
        public List<Student> GetStudents()
        {
            return GetDacInstance().GetStudents();
        }
        /// <summary>
        /// 获取数据库中[Student](分页|集合)
        /// </summary>
        public List<Student> GetStudentPages(int pageCurrent, int pageSize, string sort, out int count)
        {
			return GetDacInstance().GetStudentPages(pageCurrent, pageSize, sort,out count);
        }
        /// <summary>
        /// 获取数据库中[Student](分页|数据集)
        /// </summary>
        public DataSet GetStudentPages(int pageCurrent, int pageSize, string sort)
        {
			return GetDacInstance().GetStudentPages(pageCurrent, pageSize, sort);
        }
        #endregion

        #region 业务方法

        #endregion
    }
}
