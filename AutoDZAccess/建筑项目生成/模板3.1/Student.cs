using System;

namespace DongZheng.Soft.BT.Spi
{
    /// <summary>
    /// Student
    /// </summary>
    [Serializable]
    public class Student
    {

        private string _id;
        /// <summary>
        /// ID
        /// </summary>
        public string ID
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

        private string _age;
        /// <summary>
        /// Age
        /// </summary>
        public string Age
        {
            get { return _age; }
            set { _age = value; }
        }

        private string _passowrd;
        /// <summary>
        /// Passowrd
        /// </summary>
        public string Passowrd
        {
            get { return _passowrd; }
            set { _passowrd = value; }
        }

        private string _idnum;
        /// <summary>
        /// IDNum
        /// </summary>
        public string IDNum
        {
            get { return _idnum; }
            set { _idnum = value; }
        }
   }
}

