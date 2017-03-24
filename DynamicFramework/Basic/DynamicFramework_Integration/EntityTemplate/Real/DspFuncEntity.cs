using System;

namespace DynamicEntity
{
    /// <summary>
    /// DspFunc
    /// </summary>
    public class DspFuncEntity:BaseEntity
    {

        private string _menuid;
        /// <summary>
        ///  
        /// </summary>
        public string MenuId
        {
            get { return _menuid; }
            set { _menuid = value; }
        }

        private string _code;
        /// <summary>
        ///  
        /// </summary>
        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        private string _name;
        /// <summary>
        ///  
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _path;
        /// <summary>
        ///  
        /// </summary>
        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }

        private int? _layer;
        /// <summary>
        ///  
        /// </summary>
        public int? Layer
        {
            get { return _layer; }
            set { _layer = value; }
        }

        private string _parent;
        /// <summary>
        ///  
        /// </summary>
        public string Parent
        {
            get { return _parent; }
            set { _parent = value; }
        }

        private string _isdetail;
        /// <summary>
        ///  
        /// </summary>
        public string IsDetail
        {
            get { return _isdetail; }
            set { _isdetail = value; }
        }

        private string _invokingconfig;
        /// <summary>
        ///  
        /// </summary>
        public string InvokingConfig
        {
            get { return _invokingconfig; }
            set { _invokingconfig = value; }
        }

        private string _icon;
        /// <summary>
        ///  
        /// </summary>
        public string ICon
        {
            get { return _icon; }
            set { _icon = value; }
        }

        private int? _ordinal;
        /// <summary>
        ///  
        /// </summary>
        public int? Ordinal
        {
            get { return _ordinal; }
            set { _ordinal = value; }
        }

        private string _assemblyname;
        /// <summary>
        ///  
        /// </summary>
        public string AssemblyName
        {
            get { return _assemblyname; }
            set { _assemblyname = value; }
        }

        private string _windowname;
        /// <summary>
        ///  
        /// </summary>
        public string WindowName
        {
            get { return _windowname; }
            set { _windowname = value; }
        }
   }
}

