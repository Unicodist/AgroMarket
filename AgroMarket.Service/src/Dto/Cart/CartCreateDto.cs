using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroMarket.Service.src.Dto.Cart
{
    public class CartCreateDto
    {
        public long UserId { get; set; }
        public long ProductId { get; set; }
    }
}
