using AgroMarket.Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroMarket.Data.Models
{
    public class User
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string MobileNumber { get; set; }
        public UserType Type { get; set; }
    }
}
