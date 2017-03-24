using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuildDAL
{
    public class BaseDAL<T>
    {
        protected virtual bool Add(T t)
        {
            return false;
        }
        protected virtual bool Update(string primaryKey,T t)
        {
            return false;
        }
        protected virtual bool Delete(string primaryKey)
        {
            return false;
        }
        protected virtual T Select(T t)
        {
            return null;
        }
        protected virtual IList<T> Selects(T t)
        {
            return null;
        }
        protected virtual IList<T> Selects()
        {
            return null;
        }
    }
}
