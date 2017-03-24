using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryDaoTemplate.Abstract
{
    /// <summary>
    /// 逻辑工厂
    /// </summary>
    public class LogicProvider
    {
        private static LogicProvider _instance;
        /// <summary>
        /// 获取 [逻辑工厂] 操作对象实例
        /// </summary>
        public static LogicProvider Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LogicProvider();
                }
                return _instance;
            }
        }

        public ILogicDao<T> GetDao<T>(string Key) where T : ILogicDao<T>, new()
        {
            object obj;
            if (!LogicLibrary.TryGetValue(Key, out obj))
            {
                obj = AbstractDao<T>.GetInstance(Key);
                LogicLibrary.Add(Key, obj);
            }
            return obj as AbstractDao<T>;
        }

        private Dictionary<string, object> LogicLibrary = new Dictionary<string, object>();
    }
}
