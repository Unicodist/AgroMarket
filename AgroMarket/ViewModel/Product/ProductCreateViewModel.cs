using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AgroMarket.ViewModel.Product;

public class ProductCreateViewModel
{
    public string Name { get; set; }
    [DisplayName("Category")]
    public long? CategoryId { get; set; }
    public int Stock { get; set; }
    [DisplayName("ExpiryDate")]
    public DateOnly? ExpiryDate { get; set; }
    public IFormFile? Picture { get; set; }
    [DisplayName("Description (optional)")]
    public string? Description { get; set; }
    public SelectList? Categories { get; set; }
    public int Price { get; set; }
}