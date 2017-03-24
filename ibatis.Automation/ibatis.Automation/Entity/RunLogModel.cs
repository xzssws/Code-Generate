using System;

namespace APS.Entity
{
    /// <summary>
    /// RunLog
    /// </summary>
	[Serializable]
    public partial class RunLogModel
    {

        private DateTime @rl_createtime;
        /// <summary>
        /// RL_CreateTime
        /// </summary>
        public DateTime RL_CreateTime
        {
            get { return @rl_createtime; }
            set { @rl_createtime = value; }
        }

        private string @rl_username;
        /// <summary>
        /// RL_UserName
        /// </summary>
        public string RL_UserName
        {
            get { return @rl_username; }
            set { @rl_username = value; }
        }

        private string @rl_operationname;
        /// <summary>
        /// RL_OperationName
        /// </summary>
        public string RL_OperationName
        {
            get { return @rl_operationname; }
            set { @rl_operationname = value; }
        }

        private string @rl_type;
        /// <summary>
        /// RL_Type
        /// </summary>
        public string RL_Type
        {
            get { return @rl_type; }
            set { @rl_type = value; }
        }

        private string @rl_module;
        /// <summary>
        /// RL_Module
        /// </summary>
        public string RL_Module
        {
            get { return @rl_module; }
            set { @rl_module = value; }
        }

        private string @rl_content;
        /// <summary>
        /// RL_Content
        /// </summary>
        public string RL_Content
        {
            get { return @rl_content; }
            set { @rl_content = value; }
        }
   }
}
