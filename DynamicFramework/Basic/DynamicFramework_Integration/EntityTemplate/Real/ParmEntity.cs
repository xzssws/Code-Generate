using System;

namespace DynamicEntity
{
    /// <summary>
    /// Parm
    /// </summary>
    public class ParmEntity:BaseEntity
    {

        private string _pr_id;
        /// <summary>
        ///  
        /// </summary>
        public string PR_ID
        {
            get { return _pr_id; }
            set { _pr_id = value; }
        }

        private string _pr_setcode;
        /// <summary>
        ///  
        /// </summary>
        public string PR_SetCode
        {
            get { return _pr_setcode; }
            set { _pr_setcode = value; }
        }

        private string _pr_setname;
        /// <summary>
        ///  
        /// </summary>
        public string PR_SetName
        {
            get { return _pr_setname; }
            set { _pr_setname = value; }
        }

        private string _pr_ismaintainable;
        /// <summary>
        ///  
        /// </summary>
        public string PR_IsMaintainable
        {
            get { return _pr_ismaintainable; }
            set { _pr_ismaintainable = value; }
        }

        private string _pr_iscolor;
        /// <summary>
        ///  
        /// </summary>
        public string PR_IsColor
        {
            get { return _pr_iscolor; }
            set { _pr_iscolor = value; }
        }
   }
}

