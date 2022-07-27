namespace AgroMarket.Shared.Enum;

public class ProductState : BaseEnum
{
    public ProductState(long id, string value) : base(id, value)
    {
    }

    private const string _active = "Active";
    private const string _expired = "Expired";
    private const string _sold = "Sold";

    public static ProductState Active = new ProductState(1,_active);
    public static ProductState Expired = new ProductState(2,_expired);
    public static ProductState Sold = new ProductState(3,_sold);
}