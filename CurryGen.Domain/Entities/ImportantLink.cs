namespace CurryGen.Domain.Entities;

public class ImportantLink
{
    public required Uri Url { get; init; }
    public required string Label { get; init; }
    public required Uri IconUrl { get; init; }
}