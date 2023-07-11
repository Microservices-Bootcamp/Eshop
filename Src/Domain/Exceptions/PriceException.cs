namespace Src.Domain.Exceptions;

public class PriceException : Exception
{
    public PriceException() : base("Prices are not sent correctly")
    {
    }
}