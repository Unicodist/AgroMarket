namespace AgroMarket.Service.Dto.User
{
    public class UserCreateDto
    {
        public UserCreateDto()
        {
            
        }
        public UserCreateDto(string modelName, string modelMobileNumber, string password, string address)
        {
            Name = modelName;
            MobileNumber = modelMobileNumber;
            Password = password;
            Address = address;
        }

        public string Name { get; set; }
        public string MobileNumber { get; set; }
        public string Password { get; set; }
        public string Address { get; internal set; }
    }
}
