using System;

namespace APS.Entity
{
    /// <summary>
    /// AlarmHistory
    /// </summary>
	[Serializable]
    public partial class AlarmHistoryModel
    {

        private DateTime @ai_createtime;
        /// <summary>
        /// AI_CreateTime
        /// </summary>
        public DateTime AI_CreateTime
        {
            get { return @ai_createtime; }
            set { @ai_createtime = value; }
        }

        private short @ap_tagid;
        /// <summary>
        /// AP_TagID
        /// </summary>
        public short AP_TagID
        {
            get { return @ap_tagid; }
            set { @ap_tagid = value; }
        }

        private string @ap_systemnum;
        /// <summary>
        /// AP_SystemNum
        /// </summary>
        public string AP_SystemNum
        {
            get { return @ap_systemnum; }
            set { @ap_systemnum = value; }
        }

        private string @ap_description;
        /// <summary>
        /// AP_Description
        /// </summary>
        public string AP_Description
        {
            get { return @ap_description; }
            set { @ap_description = value; }
        }

        private string @ap_endescription;
        /// <summary>
        /// AP_EnDescription
        /// </summary>
        public string AP_EnDescription
        {
            get { return @ap_endescription; }
            set { @ap_endescription = value; }
        }

        private string @ap_unit;
        /// <summary>
        /// AP_Unit
        /// </summary>
        public string AP_Unit
        {
            get { return @ap_unit; }
            set { @ap_unit = value; }
        }

        private string @al_qualitystatus;
        /// <summary>
        /// AL_QualityStatus
        /// </summary>
        public string AL_QualityStatus
        {
            get { return @al_qualitystatus; }
            set { @al_qualitystatus = value; }
        }

        private string @al_value;
        /// <summary>
        /// AL_Value
        /// </summary>
        public string AL_Value
        {
            get { return @al_value; }
            set { @al_value = value; }
        }

        private string @ap_name;
        /// <summary>
        /// AP_Name
        /// </summary>
        public string AP_Name
        {
            get { return @ap_name; }
            set { @ap_name = value; }
        }

        private short @ap_pointtype;
        /// <summary>
        /// AP_PointType
        /// </summary>
        public short AP_PointType
        {
            get { return @ap_pointtype; }
            set { @ap_pointtype = value; }
        }

        private string @al_status;
        /// <summary>
        /// AL_Status
        /// </summary>
        public string AL_Status
        {
            get { return @al_status; }
            set { @al_status = value; }
        }

        private string @al_priority;
        /// <summary>
        /// AL_Priority
        /// </summary>
        public string AL_Priority
        {
            get { return @al_priority; }
            set { @al_priority = value; }
        }

        private string @al_type;
        /// <summary>
        /// AL_Type
        /// </summary>
        public string AL_Type
        {
            get { return @al_type; }
            set { @al_type = value; }
        }
   }
}
