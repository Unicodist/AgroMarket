namespace AgroMarket.Shared.Enum
{
    public class ShipmentState : BaseEnum
    {
        public ShipmentState(long id, string value) : base(id, value)
        {
        }

        private const string _ordered = "Ordered";
        private const string _shipped = "Shipped";
        private const string _delivered = "Delivered";
        private const string _cancelled = "Cancelled";

        public static ProductState Ordered = new ProductState(1, _ordered);
        public static ProductState Shipped = new ProductState(2, _shipped);
        public static ProductState Delivered = new ProductState(3, _delivered);
        public static ProductState Cancelled = new ProductState(4, _cancelled);
    }
}
