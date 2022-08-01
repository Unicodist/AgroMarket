using AgroMarket.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroMarket.Data.Repository
{
    public class CartRepository : BaseRepository<Cart>
    {
        public CartRepository(AmContext context) : base(context)
        {
        }

        //public User GetByUsername(string mobileNumber)
        //{
        //    return GetQueryable().SingleOrDefault(x => x.MobileNumber == mobileNumber) ?? throw new UserNotFoundException();
        //}
    }
}

    
