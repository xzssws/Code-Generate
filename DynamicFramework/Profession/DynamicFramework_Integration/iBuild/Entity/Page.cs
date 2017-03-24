using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iBuild.Entity
{
    public class Page
    {
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


        private List<Field> _fields;
        /// <summary>
        /// 页面字段集合
        /// </summary>
        public List<Field> Fields
        {
            get
            {
                if (_fields == null) _fields = new System.Collections.Generic.List<Field>();
                return _fields;
            }
            set { _fields = value; }
        }

        private Field _pk;
        /// <summary>
        /// 主键字段
        /// </summary>
        public Field PK
        {
            get
            {
                if (_pk == null) _pk = new Field() { Name = "NULLPRIMARY" };
                return _pk;
            }
            set { _pk = value; }
        }


    }
}
