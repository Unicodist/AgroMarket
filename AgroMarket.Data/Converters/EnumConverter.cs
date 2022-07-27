using System.Linq;
using AgroMarket.Shared.Enum;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AgroMarket.Data.Converters
{
    public class EnumConverter<T> : ValueConverter<T,string> where T : BaseEnum
    {
        public EnumConverter() : base(e => e.ToString(), s => BaseEnum.GetAll<T>().SingleOrDefault(x => x.ToString() == s))
        {

        }

    }
}
