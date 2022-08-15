using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace AgroMarket.ViewModel.Product
{
    public class CategorizedProductViewModel
    {
        public string CategoryName { get; set; }
        public IEnumerable<ProductViewModel>? Products { get; set; }
    }
}
