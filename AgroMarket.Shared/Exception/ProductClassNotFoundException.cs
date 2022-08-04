using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroMarket.Shared.Exception
{
    public class ProductClassNotFoundException : System.Exception
    {
        public ProductClassNotFoundException():base("The product class doesn't exist") {}
    }
}
