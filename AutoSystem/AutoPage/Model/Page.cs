namespace AutoPage.Model
{
    /// <summary>
    /// 页面
    /// </summary>
    public class PageModel
    {
        /// <summary>
        /// 页面编号
        /// </summary>
        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// 页面标题
        /// </summary>
        private string _label;

        public string Label
        {
            get { return _label; }
            set { _label = value; }
        }

        /// <summary>
        /// 页面名称
        /// </summary>
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// 页面备注
        /// </summary>
        private string _remark;

        public string Remark
        {
            get { return _remark; }
            set { _remark = value; }
        }

        private System.Collections.Generic.List<ControlModel> _controls;
        /// <summary>
        /// 页面控件集合
        /// </summary>
        public System.Collections.Generic.List<ControlModel> Controls
        {
            get
            {
                if (_controls == null) _controls = new System.Collections.Generic.List<ControlModel>();
                return _controls;
            }
            set { _controls = value; }
        }

    }
}