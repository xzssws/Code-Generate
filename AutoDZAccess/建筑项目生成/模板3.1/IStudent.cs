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
    public interface IStudent
    {
        #region 预制方法
        /// <summary>
        /// 增加一条[Student]
        /// </summary>
        bool AddStudent(Student obj);
        /// <summary>
        /// 更改一条[Student]
        /// </summary>
        bool UpdateStudent(Student obj, string primaryKey);
        /// <summary>
        /// 根据条件删除一条或多条[Student]
        /// </summary>
        bool DeleteStudent(DZFFilter filter);
        /// <summary>
        /// 根据主键删除一条[Student]
        /// </summary>
        bool DeleteStudent(string Key);
        /// <summary>
        /// 根据主键获取一条[Student]
        /// </summary>
        Student GetStudent(string Key);
        /// <summary>
        /// 根据条件筛选并获得多条[Student]
        /// </summary>
        List<Student> GetStudents(DZFFilter filter);
        /// <summary>
        /// 根据筛选实体筛选并获得多条[Student]
        /// </summary>
        List<Student> GetStudents(Student obj);
        /// <summary>
        /// 获取数据库中所有[Student]
        /// </summary>
        List<Student> GetStudents(); 
        /// <summary>
        /// 获取数据库中[Student](分页|集合)
        /// </summary>
        List<Student> GetStudentPages(int pageCurrent, int pageSize, string sort, out int count);
        /// <summary>
        /// 获取数据库中[Student](分页|数据集)
        /// </summary>
        DataSet GetStudentPages(int pageCurrent, int pageSize, string sort);
        #endregion

        #region 业务方法

        #endregion
    }
}
