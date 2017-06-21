using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokenManagement.Core
{
    interface ITokenActions
    {
        dynamic Create(Model.Token token);
        dynamic Update(Model.Token token, int updatedBy);        
    }
}
