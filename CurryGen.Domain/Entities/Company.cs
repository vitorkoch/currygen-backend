namespace CurryGen.Domain.Entities;

public class Company
{
    public required string Name { get; init; }
    public Uri? LogoUrl { get; init; }
    public required Location Location { get; init; }
}