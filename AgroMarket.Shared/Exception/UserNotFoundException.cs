using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroMarket.Shared.Exception
{
    public class UserNotFoundException : System.Exception
    {
        public UserNotFoundException():base("Cannot find such user"){}
    }
}
