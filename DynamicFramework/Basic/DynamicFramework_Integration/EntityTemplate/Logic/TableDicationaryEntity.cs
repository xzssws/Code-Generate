using System;

namespace DynamicEntity
{
    /// <summary>
    /// TableDicationary
    /// </summary>
    public class TableDicationaryEntity:BaseEntity
    {

        private string _表名;
        /// <summary>
        ///  
        /// </summary>
        public string 表名
        {
            get { return _表名; }
            set { _表名 = value; }
        }

        private string _字段序号;
        /// <summary>
        ///  
        /// </summary>
        public string 字段序号
        {
            get { return _字段序号; }
            set { _字段序号 = value; }
        }

        private string _字段名;
        /// <summary>
        ///  
        /// </summary>
        public string 字段名
        {
            get { return _字段名; }
            set { _字段名 = value; }
        }

        private string _标识;
        /// <summary>
        ///  
        /// </summary>
        public string 标识
        {
            get { return _标识; }
            set { _标识 = value; }
        }

        private string _主键;
        /// <summary>
        ///  
        /// </summary>
        public string 主键
        {
            get { return _主键; }
            set { _主键 = value; }
        }

        private string _类型;
        /// <summary>
        ///  
        /// </summary>
        public string 类型
        {
            get { return _类型; }
            set { _类型 = value; }
        }

        private string _占用字节数;
        /// <summary>
        ///  
        /// </summary>
        public string 占用字节数
        {
            get { return _占用字节数; }
            set { _占用字节数 = value; }
        }

        private int? _长度;
        /// <summary>
        ///  
        /// </summary>
        public int? 长度
        {
            get { return _长度; }
            set { _长度 = value; }
        }

        private int _小数位数;
        /// <summary>
        ///  
        /// </summary>
        public int 小数位数
        {
            get { return _小数位数; }
            set { _小数位数 = value; }
        }

        private string _允许空;
        /// <summary>
        ///  
        /// </summary>
        public string 允许空
        {
            get { return _允许空; }
            set { _允许空 = value; }
        }

        private string _默认值;
        /// <summary>
        ///  
        /// </summary>
        public string 默认值
        {
            get { return _默认值; }
            set { _默认值 = value; }
        }

        private string _说明;
        /// <summary>
        ///  
        /// </summary>
        public string 说明
        {
            get { return _说明; }
            set { _说明 = value; }
        }
   }
}

