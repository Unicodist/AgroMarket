using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroMarket.Service.src.Dto.User
{
    public class ProductClassUpdateDto
    {
        public ProductClassUpdateDto(long id, string name)
        {
            Id = id;
            Name = name; 
        }

        public long Id { get; set; }
        public string Name { get; set; }
        
    }
}
