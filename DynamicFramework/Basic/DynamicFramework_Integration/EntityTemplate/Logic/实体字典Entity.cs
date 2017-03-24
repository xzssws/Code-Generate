using System;

namespace DynamicEntity
{
    /// <summary>
    /// 实体字典
    /// </summary>
    public class 实体字典Entity:BaseEntity
    {

        private string _字段;
        /// <summary>
        ///  
        /// </summary>
        public string 字段
        {
            get { return _字段; }
            set { _字段 = value; }
        }

        private string _字段类型;
        /// <summary>
        ///  
        /// </summary>
        public string 字段类型
        {
            get { return _字段类型; }
            set { _字段类型 = value; }
        }

        private string _字段备注;
        /// <summary>
        ///  
        /// </summary>
        public string 字段备注
        {
            get { return _字段备注; }
            set { _字段备注 = value; }
        }

        private string _实体类;
        /// <summary>
        ///  
        /// </summary>
        public string 实体类
        {
            get { return _实体类; }
            set { _实体类 = value; }
        }
   }
}

