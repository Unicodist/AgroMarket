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
        public long ProductClassId { get; set; }
        public virtual ProductClass Class { get; set; }
    }
}
