using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroMarket.Data.Models
{
    public class Product
    {
        public Product()
        {

        }
        public Product(string name, string description,string picture, DateOnly? expiryDate, decimal price, int stock, ProductClass @class, User farmer)
        {
            Name = name;
            Description = description;
            ExpiryDate = expiryDate;
            Price = price;
            Stock = stock;
            Class = @class;
            Farmer = farmer;
            Picture = picture;
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateOnly? ExpiryDate { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public long ProductClassId { get; set; }
        public long FarmerId { get; set; }
        public virtual ProductClass Class { get; set; }
        public virtual User Farmer { get; set; }
        public string Picture { get; set; }

        public void Update(string dtoName, string? dtoDescription, DateOnly? dtoDate, string dtoPicture, decimal dtoPrice, int dtoStock, ProductClass productClass)
        {
            Name = dtoName;
            Description = dtoDescription;
            ExpiryDate = dtoDate;
            Picture = dtoPicture;
            Price = dtoPrice;
            Stock = dtoStock;
            Class = productClass;
        }

    }
}
