namespace AgroMarket.Service.Dto.Product;

public class ProductCreateDto
{
    public string Name { get; set; }
    public long CategoryId { get; set; }
    public int Stock { get; set; }
    public DateOnly? Date { get; set; }
    public string? Description { get; set; }
    public string Picture { get; set; }
    public decimal Price { get; set; }
    public string FarmerMobileNumber { get; set; }
}