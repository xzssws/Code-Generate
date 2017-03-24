using System;
public class StudentOther
{
/* 0101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101 */
        #region IStudent 成员
        /// <summary>
        /// 增加一条[Student]
        /// </summary>
        public bool AddStudent(Student obj)
        {
            StudentMgr mgr = new StudentMgr();
            return mgr.AddStudent(obj);
        }
        /// <summary>
        /// 更改一条[Student]
        /// </summary>
        public bool UpdateStudent(Student obj, string primaryKey)
        {
            StudentMgr mgr = new StudentMgr();
            return mgr.UpdateStudent(obj, primaryKey);
        }
        /// <summary>
        /// 根据条件删除一条或多条[Student]
        /// </summary>
        public bool DeleteStudent(DZFFilter filter)
        {
            StudentMgr mgr = new StudentMgr();
            return mgr.DeleteStudent(filter);
        }
        /// <summary>
        /// 根据主键删除一条[Student]
        /// </summary>
        public bool DeleteStudent(string Key)
        {
            StudentMgr mgr = new StudentMgr();
            return mgr.DeleteStudent(Key);
        }
        /// <summary>
        /// 根据主键获取一条[Student]
        /// </summary>
        public Student GetStudent(string Key)
        {
            StudentMgr mgr = new StudentMgr();
            return mgr.GetStudent(Key);
        }
        /// <summary>
        /// 根据条件筛选并获得多条[Student]
        /// </summary>
        public List<Student> GetStudents(DZFFilter filter)
        {
            StudentMgr mgr = new StudentMgr();
            return mgr.GetStudents(filter);
        }
        /// <summary>
        /// 根据筛选实体筛选并获得多条[Student]
        /// </summary>
        public List<Student> GetStudents(Student obj)
        {
            StudentMgr mgr = new StudentMgr();
            return mgr.GetStudents(obj);
        }
        /// <summary>
        /// 获取数据库中所有[Student]
        /// </summary>
        public List<Student> GetStudents()
        {
            StudentMgr mgr = new StudentMgr();
            return mgr.GetStudents();
        }
        /// <summary>
        /// 获取数据库中[Student](分页|集合)
        /// </summary>
        public List<Student> GetStudentPages(int pageCurrent, int pageSize, string sort, out int count)
        {
            StudentMgr mgr = new StudentMgr();
			return mgr.GetStudentPages(pageCurrent, pageSize, sort,out count);
        }
        /// <summary>
        /// 获取数据库中[Student](分页|数据集)
        /// </summary>
        public DataSet GetStudentPages(int pageCurrent, int pageSize, string sort)
        {
            StudentMgr mgr = new StudentMgr();
			return mgr.GetStudentPages(pageCurrent, pageSize, sort);
        }
        #endregion
/* 0101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101 */		
		#region Student Service
        /// <summary>
        /// 增加一条[Student]
        /// </summary>
        [WebMethod(EnableSession = true, Description = "增加一条[Student]")]
        public bool AddStudent(string objstr)
        {
            Student obj = BinarySerializer.Deserialize(objstr) as Student;
            return BT_MaterialStorageLocalClient.GetClient().AddStudent(obj);
        }
        /// <summary>
        /// 更改一条[Student]
        /// </summary>
        [WebMethod(EnableSession = true, Description = "更改一条[Student]")]
        public bool UpdateStudent(string objstr, string primaryKey)
        {
            Student obj = BinarySerializer.Deserialize(objstr) as Student;
            return BT_MaterialStorageLocalClient.GetClient().UpdateStudent(obj, primaryKey);
        }
        /// <summary>
        /// 根据条件删除一条或多条[Student]
        /// </summary>
        [WebMethod(EnableSession = true, Description = "根据条件删除一条或多条[Student]")]
        public bool DeleteStudentBF(string filterstr)
        {
            DZFFilter filter = BinarySerializer.Deserialize(filterstr) as DZFFilter;
            return BT_MaterialStorageLocalClient.GetClient().DeleteStudent(filter);
        }
        /// <summary>
        /// 根据主键删除一条[Student]
        /// </summary>
        [WebMethod(EnableSession = true, Description = "根据主键删除一条[Student]")]
        public bool DeleteStudentBK(string Key)
        {
            return BT_MaterialStorageLocalClient.GetClient().DeleteStudent(Key);
        }
        /// <summary>
        /// 根据主键获取一条[Student]
        /// </summary>
        [WebMethod(EnableSession = true, Description = "根据主键获取一条[Student]")]
        public string GetStudent(string Key)
        {
            Student obj = BT_MaterialStorageLocalClient.GetClient().GetStudent(Key);
            return BinarySerializer.Serialize(obj);
        }
        /// <summary>
        /// 根据条件筛选并获得多条[Student]
        /// </summary>
        [WebMethod(EnableSession = true, Description = "根据条件筛选并获得多条[Student]")]
        public string GetStudentsBF(string filterstr)
        {
            DZFFilter filter = BinarySerializer.Deserialize(filterstr) as DZFFilter;
            List<Student> list = BT_MaterialStorageLocalClient.GetClient().GetStudents(filter);
            return BinarySerializer.Serialize(list);
        }
        /// <summary>
        /// 根据筛选实体筛选并获得多条[Student]
        /// </summary>
        [WebMethod(EnableSession = true, Description = "根据筛选实体筛选并获得多条[Student]")]
        public string GetStudentsBE(string objstr)
        {
            Student obj = BinarySerializer.Deserialize(objstr) as Student;
            List<Student> list = BT_MaterialStorageLocalClient.GetClient().GetStudents(obj);
            return BinarySerializer.Serialize(list);
        }
        /// <summary>
        /// 获取数据库中所有[Student]
        /// </summary>
        [WebMethod(EnableSession = true, Description = "获取数据库中所有[Student]")]
        public string GetStudents()
        {
            List<Student> list = BT_MaterialStorageLocalClient.GetClient().GetStudents();
            return BinarySerializer.Serialize(list);
        }
        /// <summary>
        /// 获取数据库中[Student](分页|集合)
        /// </summary>
        [WebMethod(EnableSession = true, Description = "获取数据库中[Student](分页|集合)")]
        public string GetStudentPagesl(int pageCurrent, int pageSize, string sort, out int count)
        {
            List<Student> list = BT_MaterialStorageLocalClient.GetClient().GetStudentPages(pageCurrent, pageSize, sort,out count);
            return BinarySerializer.Serialize(list);
        }
        /// <summary>
        /// 获取数据库中[Student](分页|数据集)
        /// </summary>
        [WebMethod(EnableSession = true, Description = "获取数据库中[Student](分页|数据集)")]
        public string GetStudentPagesd(int pageCurrent, int pageSize, string sort)
        {
            DataSet dataset = BT_MaterialStorageLocalClient.GetClient().GetStudentPages(pageCurrent, pageSize, sort);
            return BinarySerializer.Serialize(dataset);
        }

        #endregion
/* 0101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101 */		
		#region IStudent 成员
        /// <summary>
        /// 增加一条[Student]
        /// </summary>
        public bool AddStudent(Student obj)
        {
            string objstr = BinarySerializer.Serialize(obj);
            bool result = CurrentService.AddStudent(objstr);
            return result;
        }
        /// <summary>
        /// 更改一条[Student]
        /// </summary>
        public bool UpdateStudent(Student obj, string primaryKey)
        {
            string objstr = BinarySerializer.Serialize(obj);
            bool result = CurrentService.UpdateStudent(objstr, primaryKey);
            return result;
        }
        /// <summary>
        /// 根据条件删除一条或多条[Student]
        /// </summary>
        public bool DeleteStudent(DZFFilter filter)
        {
            string filterstr = BinarySerializer.Serialize(filter);
            bool result = CurrentService.DeleteStudentBF(filterstr);
            return result;
        }
        /// <summary>
        /// 根据主键删除一条[Student]
        /// </summary>
        public bool DeleteStudent(string Key)
        {
            bool result = CurrentService.DeleteStudentBK(Key);
            return result;
        }
        /// <summary>
        /// 根据主键获取一条[Student]
        /// </summary>
        public DongZheng.Soft.BT.Spi.Student GetStudent(string Key)
        {
            object obj = CurrentService.GetStudent(Key);
            DongZheng.Soft.BT.Spi.Student result = obj as DongZheng.Soft.BT.Spi.Student;
            return result;
        }
        /// <summary>
        /// 根据条件筛选并获得多条[Student]
        /// </summary>
        public List<DongZheng.Soft.BT.Spi.Student> GetStudents(DZFFilter filter)
        {
            string filterstr = BinarySerializer.Serialize(filter);
            object obj = BinarySerializer.Deserialize(CurrentService.GetStudentsBF(filterstr));
            List<DongZheng.Soft.BT.Spi.Student> result = obj as List<DongZheng.Soft.BT.Spi.Student>;
            return result;
        }
        /// <summary>
        /// 根据筛选实体筛选并获得多条[Student]
        /// </summary>
        public List<Student> GetStudents(Student obj)
        {
            string objstr = BinarySerializer.Serialize(obj);
            object resultobj = BinarySerializer.Deserialize(CurrentService.GetStudentsBE(objstr));
            List<DongZheng.Soft.BT.Spi.Student> result = resultobj as List<DongZheng.Soft.BT.Spi.Student>;
            return result;
        }
        /// <summary>
        /// 获取数据库中所有[Student]
        /// </summary>
        public List<Student> GetStudents()
        {
            object obj = BinarySerializer.Deserialize(CurrentService.GetStudents());
            List<DongZheng.Soft.BT.Spi.Student> result = obj as List<DongZheng.Soft.BT.Spi.Student>;
            return result;
        }
        /// <summary>
        /// 获取数据库中[Student](分页|集合)
        /// </summary>
        public List<Student> GetStudentPages(int pageCurrent, int pageSize, string sort, out int count)
        {
            object obj = BinarySerializer.Deserialize(CurrentService.GetStudentPagesl(pageCurrent, pageSize, sort,out count));
            List<DongZheng.Soft.BT.Spi.Student> result = obj as List<DongZheng.Soft.BT.Spi.Student>;
            return result;
        }
        /// <summary>
        /// 获取数据库中[Student](分页|数据集)
        /// </summary>
        public DataSet GetStudentPages(int pageCurrent, int pageSize, string sort)
        {
            object obj = BinarySerializer.Deserialize(CurrentService.GetStudentPagesd(pageCurrent, pageSize, sort));
            Dataset result = obj as DataSet;
            return result;
        }

        #endregion
}
