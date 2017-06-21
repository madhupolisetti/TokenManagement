using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokenManagement.Model
{
    internal class Reply
    {
        private long _id = 0;
        private long _tokenId = 0;
        private string _body = string.Empty;
        private ConversationCategory _conversationCategory = ConversationCategory.UNKNOWN;
        private int _employeeId = 0;
        private string _smtpMessageId = string.Empty;
        private List<string> _ccAddresses = null;
        private List<string> _bccAddresses = null;
        private DateTime _createdTime;
        private bool _displayToClient = true;
        private byte _closingSource = 0;
        private int _closedBy = 0;
        private int _completedBy = 0;
        private DateTime? _closedTime = null;
        private DateTime? _completedTime = null;
        private List<Attachment> _attachments = null;
        private Format _fromat = Format.OBJECT;
        
        public long Id 
        {
            get { return this._id; }
            set { this._id = value; }
        }
        public long TokenId
        {
            get { return this._tokenId; }
            set { this._tokenId = value; }
        }
    }
}
