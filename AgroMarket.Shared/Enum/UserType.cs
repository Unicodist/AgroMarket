namespace AgroMarket.Shared.Enum
{
    public class UserType : BaseEnum
    {
        private UserType(int i, string value):base(i, value)
        {
            
        }
        private const string _customer = "Customer";
        private const string _farmer = "Farmer";

        public static UserType Customer = new UserType(1, _customer);
        public static UserType Farmer = new UserType(2, _farmer);
    }
}
