using System;
using System.Collections.Generic;

namespace HSIS.DAO
{
    public class DemoDao : BaseDAO<Object>
    {
        public DemoDao()
        {
            DefaultKey = "dd";
        }

        public override bool Add(object t)
        {
            return i(t);
        }

        public override bool Update(object t)
        {
            return u(t);
        }

        public override bool Delete(object t)
        {
            return d(t);
        }

        public override IList<object> Selects()
        {
            return ss();
        }

        public override IList<object> Select(object t)
        {
            return s(t);
        }
    }
}