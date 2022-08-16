using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace AgroMarket.ViewModel.Product
{
    public class ProductViewModel
    {
        public string FarmerName { get; set; }
        public string ProductName { get; set; }
        [DisplayName("Price")]
        public decimal Price { get; set; }
        public string Image { get; set; }
        
        public int Stock { get; set; }
    }
}
