using System.Reflection;

namespace AgroMarket.Data.Enum;

public class BaseEnum
{
    public long Id;
    public string Value;

    public BaseEnum(long id, string value)
    {
        Id = id;
        Value = value;
    }
    public override string ToString()
    {
        return Value;
    }
    public static IEnumerable<T> GetAll<T>() where T : BaseEnum =>
        typeof(T).GetFields(BindingFlags.Public |
                            BindingFlags.Static |
                            BindingFlags.DeclaredOnly)
            .Select(f => f.GetValue(null))
            .Cast<T>();
}