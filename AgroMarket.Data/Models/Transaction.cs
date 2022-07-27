using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgroMarket.Shared.Enum;

namespace AgroMarket.Data.Models
{
    public class Transaction
    {
        public long Id { get; set; }
        public long OrderId { get; set; }
        public virtual Order Order {get;set;}
        public ShipmentState State { get; set; }
    }
}
