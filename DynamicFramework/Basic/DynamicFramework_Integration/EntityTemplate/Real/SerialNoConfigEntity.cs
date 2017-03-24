using System;

namespace DynamicEntity
{
    /// <summary>
    /// SerialNoConfig
    /// </summary>
    public class SerialNoConfigEntity:BaseEntity
    {

        private int? _serialno;
        /// <summary>
        ///  
        /// </summary>
        public int? SerialNo
        {
            get { return _serialno; }
            set { _serialno = value; }
        }
   }
}

