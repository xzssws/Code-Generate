using System;

namespace Test.Entity
{
    /// <summary>
    /// StudentX
    /// </summary>
    public class StudentXInfo:BaseEntity
    {

        private int _id;
        /// <summary>
        /// ID
        /// </summary>
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;
        /// <summary>
        /// Name
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int? _age;
        /// <summary>
        /// Age
        /// </summary>
        public int? Age
        {
            get { return _age; }
            set { _age = value; }
        }

        private string _sex;
        /// <summary>
        /// Sex
        /// </summary>
        public string Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }

        private string _class;
        /// <summary>
        /// Class
        /// </summary>
        public string Class
        {
            get { return _class; }
            set { _class = value; }
        }

        private string _flag;
        /// <summary>
        /// Flag
        /// </summary>
        public string Flag
        {
            get { return _flag; }
            set { _flag = value; }
        }
   }
}

