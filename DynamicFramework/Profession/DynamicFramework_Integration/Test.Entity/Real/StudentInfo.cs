using System;

namespace Test.Entity
{
    /// <summary>
    /// Student
    /// </summary>
    public class StudentInfo:BaseEntity
    {

        private int _id;
        /// <summary>
        /// 编号
        /// </summary>
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;
        /// <summary>
        /// 名称
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int? _age;
        /// <summary>
        /// 年龄
        /// </summary>
        public int? Age
        {
            get { return _age; }
            set { _age = value; }
        }

        private string _sex;
        /// <summary>
        /// 性别
        /// </summary>
        public string Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }

        private string _class;
        /// <summary>
        /// 班级
        /// </summary>
        public string Class
        {
            get { return _class; }
            set { _class = value; }
        }
   }
}

