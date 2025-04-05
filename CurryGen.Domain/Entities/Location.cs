namespace CurryGen.Domain.Entities;

public class Location
{
    public required string Country { get; init; }
    public required string City { get; init; }
    public required string State { get; init; }
}