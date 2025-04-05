using CurryGen.Domain.ValueObjects;

namespace CurryGen.Domain.Entities;

public class AcademicExperience
{
    public required DateTime FromDate { get; init; }
    public required DateTime ToDate { get; init; }
    public required JobRole JobRole { get; init; }
}