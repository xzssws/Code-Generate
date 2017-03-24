using System;

namespace DynamicEntity
{
    /// <summary>
    /// UserDuty
    /// </summary>
    public class UserDutyEntity:BaseEntity
    {

        private string _userdutyid;
        /// <summary>
        ///  
        /// </summary>
        public string UserDutyId
        {
            get { return _userdutyid; }
            set { _userdutyid = value; }
        }

        private string _userid;
        /// <summary>
        ///  
        /// </summary>
        public string UserId
        {
            get { return _userid; }
            set { _userid = value; }
        }

        private string _dutyid;
        /// <summary>
        ///  
        /// </summary>
        public string DutyId
        {
            get { return _dutyid; }
            set { _dutyid = value; }
        }

        private string _remark;
        /// <summary>
        ///  
        /// </summary>
        public string Remark
        {
            get { return _remark; }
            set { _remark = value; }
        }
   }
}

