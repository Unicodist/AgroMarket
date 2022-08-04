using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroMarket.Shared.Exception
{
    public class ProductClassAlreadyExistException : System.Exception
    {
        public ProductClassAlreadyExistException() : base("The product class already exists") { }
    }
}
