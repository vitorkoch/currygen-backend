namespace CurryGen.Domain.ValueObjects;

public class Phone
{
    public required string CountryCode { get; init; }
    public required string AreaCode { get; init; }
    public required string Number { get; init; }
}