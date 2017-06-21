using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokenManagement.Model
{
    public enum Status
    {
        NEW = 0,
        PENDING = 1,
        COMPLETED = 2,
        CLOSED_BY_TEAM_LEAD = 3,
        CLOSED_BY_TEAM_MEMBER = 4,
        REOPNED = 5
    }
    public enum TokenSubStatus
    {

    }
}
