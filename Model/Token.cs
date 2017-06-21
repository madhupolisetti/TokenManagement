using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokenManagement.Model
{
    public class Token
    {
        private long _id = 0;
        private long _accountId = 0;
        private int _employeeId = 0;
        private string _subject = string.Empty;
        private string _service = string.Empty;
        private string _category = string.Empty;
        private string _subCategory = string.Empty;
        private string _body = string.Empty;
        private string _source = string.Empty;
        private string _alternateContactNumber = string.Empty;
        private List<string> _ccEmailAddresses = null;
        private List<Attachment> _attachments = null;
        private TokenStatus _status = TokenStatus.NEW;
        private TokenSubStatus _subStatus = 0;
        private Priority _priority = Priority.LOW;
        public long Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        public string Subject
        {
            get { return this._subject; }
            set { this._subject = value; }
        }
        public string Service
        {
            get { return this._service; }
            set { this._service = value; }
        }
        public string Category
        {
            get { return this._category; }
            set { this._category = value; }
        }
        public string SubCategory
        {
            get { return this._subCategory; }
            set { this._subCategory = value; }
        }
        public string Body
        {
            get { return this._body; }
            set { this._body = value; }
        }
        public string Source
        {
            get { return this._source; }
            set { this._source = value; }
        }
        public List<Attachment> Attachments
        {
            get { if (this._attachments == null) { this._attachments = new List<Attachment>(); } return this._attachments; }
            set { this._attachments = value; }
        }
        public long AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }
        public int EmployeeId
        {
            get { return this._employeeId; }
            set { this._employeeId = value; }
        }
        public string AlternateContactNumber
        {
            get { return this._alternateContactNumber; }
            set { this._alternateContactNumber = value; }
        }
        public List<string> CCEmailAddresses
        {
            get { if (this._ccEmailAddresses == null) { this._ccEmailAddresses = new List<string>(); } return this._ccEmailAddresses; }
            set { this._ccEmailAddresses = value; }
        }
        public Priority Priority
        {
            get { return this._priority; }
            set { this._priority = value; }
        }        
    }
}
