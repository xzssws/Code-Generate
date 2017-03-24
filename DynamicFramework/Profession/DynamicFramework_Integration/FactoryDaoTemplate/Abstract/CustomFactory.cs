using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryDaoTemplate.Abstract
{
    /// <summary>
    /// 自定义工厂
    /// </summary>
    public class CustomFactory
    {
        private static CustomFactory _instance;
        /// <summary>
        /// 获取 [自定义工厂] 操作对象实例
        /// </summary>
        public static CustomFactory Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CustomFactory();
                }
                return _instance;
            }
        }
    }
}
