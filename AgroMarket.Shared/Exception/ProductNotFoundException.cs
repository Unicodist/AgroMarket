namespace AgroMarket.Shared.Exception;

public class ProductNotFoundException : System.Exception
{
    public ProductNotFoundException() : base("The product is not available")
    {
    }
}