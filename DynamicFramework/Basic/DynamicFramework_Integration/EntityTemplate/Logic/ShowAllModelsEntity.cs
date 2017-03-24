using System;

namespace DynamicEntity
{
    /// <summary>
    /// ShowAllModels
    /// </summary>
    public class ShowAllModelsEntity:BaseEntity
    {

        private string _fieldpagename;
        /// <summary>
        ///  
        /// </summary>
        public string FieldPageName
        {
            get { return _fieldpagename; }
            set { _fieldpagename = value; }
        }

        private string _fieldname;
        /// <summary>
        ///  
        /// </summary>
        public string FieldName
        {
            get { return _fieldname; }
            set { _fieldname = value; }
        }

        private string _fieldtype;
        /// <summary>
        ///  
        /// </summary>
        public string FieldType
        {
            get { return _fieldtype; }
            set { _fieldtype = value; }
        }

        private string _fieldlabel;
        /// <summary>
        ///  
        /// </summary>
        public string FieldLabel
        {
            get { return _fieldlabel; }
            set { _fieldlabel = value; }
        }

        private string _fieldpagelabel;
        /// <summary>
        ///  
        /// </summary>
        public string FieldPageLabel
        {
            get { return _fieldpagelabel; }
            set { _fieldpagelabel = value; }
        }

        private string _fieldremark;
        /// <summary>
        ///  
        /// </summary>
        public string FieldRemark
        {
            get { return _fieldremark; }
            set { _fieldremark = value; }
        }
   }
}

