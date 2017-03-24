using System;

namespace DynamicEntity
{
    /// <summary>
    /// DutyFun
    /// </summary>
    public class DutyFunEntity:BaseEntity
    {

        private string _df_id;
        /// <summary>
        ///  
        /// </summary>
        public string DF_ID
        {
            get { return _df_id; }
            set { _df_id = value; }
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

        private string _funid;
        /// <summary>
        ///  
        /// </summary>
        public string FunId
        {
            get { return _funid; }
            set { _funid = value; }
        }
   }
}

