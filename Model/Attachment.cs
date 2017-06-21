using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokenManagement.Model
{
    public class Attachment
    {
        private long _id = 0;
        private string _displayName = string.Empty;
        private string _path = string.Empty;
        private bool _isDisplay = false;
        public long Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }
        public bool IsDisplay
        {
            get { return this._isDisplay; }
            set { this._isDisplay = value; }
        }
    }
}
