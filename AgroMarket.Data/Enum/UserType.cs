namespace AgroMarket.Data.Enum
{
    public class UserType : BaseEnum
    {
        private UserType(int i, string value):base(i, value)
        {
            
        }
        private const string _customer = "Customer";
        private const string _farmer = "Farmer";

        public UserType Customer = new UserType(1, _customer);
        public UserType Farmer = new UserType(2, _farmer);
    }
}
