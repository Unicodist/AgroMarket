using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroMarket.Data.Models
{
    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ExpiryDate { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public long ProductClassId { get; set; }
        public long FarmerId { get; set; }
        public virtual ProductClass Class { get; set; }
        public virtual User Farmer { get; set; }
    }
}
