using System;

namespace APS.Entity
{
    /// <summary>
    /// V_GroupAndPoint
    /// </summary>
	[Serializable]
    public partial class V_GroupAndPointModel
    {

        private string @ap_name;
        /// <summary>
        /// AP_Name
        /// </summary>
        public string AP_Name
        {
            get { return @ap_name; }
            set { @ap_name = value; }
        }

        private string @ag_name;
        /// <summary>
        /// AG_Name
        /// </summary>
        public string AG_Name
        {
            get { return @ag_name; }
            set { @ag_name = value; }
        }
   }
}
