using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroMarket.Data.BaseType
{
    public class Name
    {
        private string name;

        public Name(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
