using System;

namespace DynamicEntity
{
    /// <summary>
    /// ParmItem
    /// </summary>
    public class ParmItemEntity:BaseEntity
    {

        private string _pi_setcode;
        /// <summary>
        ///  
        /// </summary>
        public string PI_SetCode
        {
            get { return _pi_setcode; }
            set { _pi_setcode = value; }
        }

        private string _pi_itemcode;
        /// <summary>
        ///  
        /// </summary>
        public string PI_ItemCode
        {
            get { return _pi_itemcode; }
            set { _pi_itemcode = value; }
        }

        private string _pi_itemname;
        /// <summary>
        ///  
        /// </summary>
        public string PI_ItemName
        {
            get { return _pi_itemname; }
            set { _pi_itemname = value; }
        }

        private string _pi_colorvalue;
        /// <summary>
        ///  
        /// </summary>
        public string PI_ColorValue
        {
            get { return _pi_colorvalue; }
            set { _pi_colorvalue = value; }
        }

        private int? _pi_itemvalue;
        /// <summary>
        ///  
        /// </summary>
        public int? PI_ItemValue
        {
            get { return _pi_itemvalue; }
            set { _pi_itemvalue = value; }
        }

        private string _pi_parentsetcode;
        /// <summary>
        ///  
        /// </summary>
        public string PI_ParentSetCode
        {
            get { return _pi_parentsetcode; }
            set { _pi_parentsetcode = value; }
        }
   }
}

