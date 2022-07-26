namespace AgroMarket.Data.Models;
public class Order
{
    public long Id { get; set; }
    public DateTime Date { get; set; }
    public long OrderedByUserId { get; set; }
    public virtual User OrderedBy { get; set; }
    public virtual ICollection<OrderProduct> Products { get; set; }
}