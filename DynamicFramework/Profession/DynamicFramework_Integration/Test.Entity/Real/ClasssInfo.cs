using System;

namespace Test.Entity
{
    /// <summary>
    /// Classs
    /// </summary>
    public class ClasssInfo:BaseEntity
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

        private int? _student;
        /// <summary>
        /// Student
        /// </summary>
        public int? Student
        {
            get { return _student; }
            set { _student = value; }
        }
   }
}

