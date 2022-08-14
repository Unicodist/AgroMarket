using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace AgroMarket.ViewModel.Product
{
    public class ProductViewModel
    {
        public string? FarmerName { get; set; }
        [DisplayName("Price")]
        public long? Price { get; set; }
        public IFormFile? Image { get; set; }
        [DisplayName("ExpiryDate")]
        public int Stock { get; set; }
    }
}
