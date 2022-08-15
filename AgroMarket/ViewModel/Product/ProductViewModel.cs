using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace AgroMarket.ViewModel.Product
{
    public class ProductViewModel
    {
        public string FarmerName { get; set; }
        [DisplayName("Price")]
        public decimal Price { get; set; }
        public string Image { get; set; }
        [DisplayName("ExpiryDate")]
        public int Stock { get; set; }
    }
}
