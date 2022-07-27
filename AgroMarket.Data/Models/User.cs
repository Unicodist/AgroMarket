using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgroMarket.Shared.Enum;

namespace AgroMarket.Data.Models
{
    public class User
    {
        public User(string name, string mobileNumber)
        {
            Name = name;
            MobileNumber = mobileNumber;
            Type = UserType.Customer;
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string MobileNumber { get; set; }
        public UserType Type { get; set; }
    }
}
