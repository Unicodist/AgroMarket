namespace AgroMarket.Data.Models;

public class ProductClass
{
    public ProductClass()
    {
    }

    public ProductClass(string name)
    {
        Name = name;
    }

    public long Id { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Product> Products { get; set; }
}