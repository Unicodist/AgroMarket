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
        public User(string name, string mobileNumber, string password, string address)
        {
            Name = name;
            MobileNumber = mobileNumber;
            Type = UserType.Customer;
            Address = address;
            Password = password;
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string MobileNumber { get; set; }
        public string? PanNumber { get; set; }
        public string Address { get; set; }

        public UserType Type { get; set; }
        public string Password { get; set; }

        public void AddPan(string dtoPanNumber)
        {
            PanNumber = dtoPanNumber;
        }
    }
}
