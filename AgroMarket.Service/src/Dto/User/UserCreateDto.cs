namespace AgroMarket.Service.Dto.User
{
    public class UserCreateDto
    {
        public UserCreateDto(string modelName, string modelMobileNumber)
        {
            Name = modelName;
            MobileNumber = modelMobileNumber;
        }

        public string Name { get; set; }
        public string MobileNumber { get; set; }
    }
}
