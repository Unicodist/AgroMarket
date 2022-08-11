namespace AgroMarket.ViewModel.Product;

public class ProductCreateViewModel
{
    public string Name { get; set; }
    public long? CategoryId { get; set; }
    public int Stock { get; set; }
    public DateOnly? ExpiryDate { get; set; }
    public IFormFile? Picture { get; set; }
    public string? Description { get; set; }
}