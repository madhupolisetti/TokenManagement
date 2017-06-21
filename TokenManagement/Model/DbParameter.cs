using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokenManagement.Model
{
    public class DbParameter
    {
        private string _name = string.Empty;
        private System.Data.SqlDbType _sqlDbType;
        private long _size = -1;
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        public System.Data.SqlDbType SqlDbType
        {
            get { return this._sqlDbType; }
            set { this._sqlDbType = value; }
        }
        public long Size
        {
            get { return this._size; }
            set { this._size = value; }
        }
    }
}
