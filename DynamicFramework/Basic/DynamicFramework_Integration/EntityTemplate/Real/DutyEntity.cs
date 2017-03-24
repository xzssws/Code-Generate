using System;

namespace DynamicEntity
{
    /// <summary>
    /// Duty
    /// </summary>
    public class DutyEntity:BaseEntity
    {

        private string _dutyid;
        /// <summary>
        ///  
        /// </summary>
        public string DutyId
        {
            get { return _dutyid; }
            set { _dutyid = value; }
        }

        private string _dutycode;
        /// <summary>
        ///  
        /// </summary>
        public string DutyCode
        {
            get { return _dutycode; }
            set { _dutycode = value; }
        }

        private string _dutyname;
        /// <summary>
        ///  
        /// </summary>
        public string DutyName
        {
            get { return _dutyname; }
            set { _dutyname = value; }
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
   }
}

