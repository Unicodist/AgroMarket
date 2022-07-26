namespace AgroMarket.Data.Models;

public class ProductClass
{
    public long Id { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Product> Products { get; set; }
}