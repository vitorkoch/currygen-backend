namespace CurryGen.Domain.Entities;

public class AcademicInstitution
{
    public required string Name { get; init; }
    public Uri? LogoUrl { get; init; }
    public required Location Location { get; init; }
}