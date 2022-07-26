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
}