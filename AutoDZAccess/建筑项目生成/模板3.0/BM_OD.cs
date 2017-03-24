using System;

namespace DongZheng.Soft.BT.Spi
{
    /// <summary>
    /// BM_OD
    /// </summary>
    [Serializable]
    public class BM_OD
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

        private string _flag;
        /// <summary>
        /// Flag
        /// </summary>
        public string Flag
        {
            get { return _flag; }
            set { _flag = value; }
        }

        private string _username;
        /// <summary>
        /// UserName
        /// </summary>
        public string UserName
        {
            get { return _username; }
            set { _username = value; }
        }

        private string _password;
        /// <summary>
        /// Password
        /// </summary>
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
   }
}

