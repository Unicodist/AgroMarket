using AgroMarket.Data.Enum;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AgroMarket.Data.Converters
{
    public class EnumConverter<T> : ValueConverter<T,string> where T : class
    {
        public EnumConverter() : base(e => e.ToString(), s => BaseEnum.GetAll<T>().SingleorDefault(x => x.ToString() == s))
        {

        }

    }
}
