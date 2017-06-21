using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokenManagement.Model
{
    internal enum ConversationCategory
    {
        UNKNOWN = 0,
        REPLY_FROM_ACCOUNT = 1,
        REPLY_TO_ACCOUNT = 2,
        FORWARD = 3,
        RE_OPENED_BY_USER = 4        
    }
}
