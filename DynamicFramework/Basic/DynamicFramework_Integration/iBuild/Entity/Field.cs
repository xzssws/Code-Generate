namespace iBuild.Entity
{
    public class Field
    {
        private int id = 0;
        /// <summary>
        /// 编号 默认0
        /// </summary>
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string name = "";
        /// <summary>
        /// 名称 默认空
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string type = "VARCHAR";
        /// <summary>
        /// 类型 默认VARCHAR
        /// </summary>
        public string Type
        {
            get { return type; }
            set { type = value.ToUpper(); }
        }

        private int size = 0;
        /// <summary>
        /// 字节长度 默认0
        /// </summary>
        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        private int length = 0;
        /// <summary>
        /// 字段长度 默认0
        /// </summary>
        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        private int _double = 0;
        /// <summary>
        /// 精度 默认0
        /// </summary>
        public int Double
        {
            get { return _double; }
            set { _double = value; }
        }

        private bool isPrimary = false;
        /// <summary>
        /// 是否主键 默认False
        /// </summary>
        public bool IsPrimary
        {
            get { return isPrimary; }
            set { isPrimary = value; }
        }

        private bool isIdentity = false;
        /// <summary>
        /// 是否自增 默认False
        /// </summary>
        public bool IsIdentity
        {
            get { return isIdentity; }
            set { isIdentity = value; }
        }

        private bool canNull = false;
        /// <summary>
        /// 可以为空值 默认False
        /// </summary>
        public bool CanNull
        {
            get
            {
                return canNull;
            }
            set { canNull = value; }
        }

        private string _default;
        /// <summary>
        /// 默认值
        /// </summary>
        public string Default
        {
            get { return _default; }
            set { _default = value; }
        }

        private string remark;
        /// <summary>
        /// 备注 默认为当前字段
        /// </summary>
        public string Remark
        {
            get
            {
                if (string.IsNullOrEmpty(remark))
                {
                    return this.Name;
                }
                return remark;
            }
            set { remark = value; }
        }
    }
}