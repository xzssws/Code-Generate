using System;

namespace DynamicEntity
{
    /// <summary>
    /// JG_Listid
    /// </summary>
    public class JG_ListidEntity:BaseEntity
    {

        private int _id;
        /// <summary>
        ///  
        /// </summary>
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _sny;
        /// <summary>
        ///  
        /// </summary>
        public string sny
        {
            get { return _sny; }
            set { _sny = value; }
        }

        private string _lsh;
        /// <summary>
        ///  
        /// </summary>
        public string lsh
        {
            get { return _lsh; }
            set { _lsh = value; }
        }

        private int _zt;
        /// <summary>
        ///  
        /// </summary>
        public int zt
        {
            get { return _zt; }
            set { _zt = value; }
        }
   }
}

