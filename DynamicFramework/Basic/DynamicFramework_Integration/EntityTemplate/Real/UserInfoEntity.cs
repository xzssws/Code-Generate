using System;

namespace DynamicEntity
{
    /// <summary>
    /// UserInfo
    /// </summary>
    public class UserInfoEntity:BaseEntity
    {

        private string _userid;
        /// <summary>
        ///  
        /// </summary>
        public string UserId
        {
            get { return _userid; }
            set { _userid = value; }
        }

        private string _usercode;
        /// <summary>
        ///  
        /// </summary>
        public string UserCode
        {
            get { return _usercode; }
            set { _usercode = value; }
        }

        private string _userpwd;
        /// <summary>
        ///  
        /// </summary>
        public string UserPwd
        {
            get { return _userpwd; }
            set { _userpwd = value; }
        }

        private string _username;
        /// <summary>
        ///  
        /// </summary>
        public string UserName
        {
            get { return _username; }
            set { _username = value; }
        }

        private string _unitid;
        /// <summary>
        ///  
        /// </summary>
        public string UnitId
        {
            get { return _unitid; }
            set { _unitid = value; }
        }

        private string _sex;
        /// <summary>
        ///  
        /// </summary>
        public string Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }

        private string _linktel;
        /// <summary>
        ///  
        /// </summary>
        public string Linktel
        {
            get { return _linktel; }
            set { _linktel = value; }
        }

        private string _email;
        /// <summary>
        ///  
        /// </summary>
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private string _state;
        /// <summary>
        ///  
        /// </summary>
        public string State
        {
            get { return _state; }
            set { _state = value; }
        }

        private string _describe;
        /// <summary>
        ///  
        /// </summary>
        public string Describe
        {
            get { return _describe; }
            set { _describe = value; }
        }

        private string _loginip;
        /// <summary>
        ///  
        /// </summary>
        public string LoginIp
        {
            get { return _loginip; }
            set { _loginip = value; }
        }

        private string _ssq;
        /// <summary>
        ///  
        /// </summary>
        public string Ssq
        {
            get { return _ssq; }
            set { _ssq = value; }
        }
   }
}

