using CurryGen.Domain.ValueObjects;

namespace CurryGen.Domain.Entities;

public class PersonalInfo
{
    public required string Name { get; init; }
    public string? PictureUrl { get; init; }
    public required Email Email { get; init; }
    public required Phone Phone { get; init; }
    public required Location Location { get; init; }
    public string? CoverLetter { get; init; }
    public required List<ImportantLink> HighlightedLinks { get; init; }
    public required JobRole JobRole { get; init; }
}