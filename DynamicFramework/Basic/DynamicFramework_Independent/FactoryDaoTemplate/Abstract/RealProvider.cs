using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryDaoTemplate.Abstract
{
    /// <summary>
    /// 物理提供者
    /// </summary>
    public class RealProvider
    {
        private static RealProvider _instance;
        /// <summary>
        /// 获取 [物理提供者] 操作对象实例
        /// </summary>
        public static RealProvider Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RealProvider();
                }
                return _instance;
            }
        }
        /// <summary>
        /// 获得实例Dao
        /// </summary>
        /// <typeparam name="T">Dao操作的实体类型</typeparam>
        /// <param name="Key">映射标识</param>
        /// <returns>返回实例</returns>
        public IRealDao<T> GetDao<T>(string Key) where T : new()
        {
            object obj;
            if (!RealLibrary.TryGetValue(Key, out obj))
            {
                obj = AbstractDao<T>.GetInstance(Key);
                RealLibrary.Add(Key, obj);
            }
            return obj as AbstractDao<T>;
        }
        /// <summary>
        /// 实例库
        /// </summary>
        private Dictionary<string, object> RealLibrary = new Dictionary<string, object>();
    }
}
