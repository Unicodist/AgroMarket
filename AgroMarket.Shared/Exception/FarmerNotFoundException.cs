namespace AgroMarket.Shared.Exception;

public class FarmerNotFoundException:System.Exception
{
    public FarmerNotFoundException() : base("Cannot find the farmer")
    {
    }
}