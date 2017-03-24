namespace AutoPage.Model
{
    /// <summary>
    /// 控件模型
    /// </summary>
    public class ControlModel
    {
        /// <summary>
        /// 控件编号
        /// </summary>
        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// 控件标签
        /// </summary>
        private string _label;

        public string Label
        {
            get { return _label; }
            set { _label = value; }
        }

        /// <summary>
        /// 控件名称
        /// </summary>
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// 控件备注
        /// </summary>
        private string _remark;

        public string Remark
        {
            get { return _remark; }
            set { _remark = value; }
        }

        /// <summary>
        /// 控件页面
        /// </summary>
        private int _page;

        public int Page
        {
            get { return _page; }
            set { _page = value; }
        }

        /// <summary>
        /// 控件类型
        /// </summary>
        private string _type;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        /// 控件数据类型
        /// </summary>
        private string _dataType;

        public string DataType
        {
            get { return _dataType; }
            set { _dataType = value; }
        }
    }
}