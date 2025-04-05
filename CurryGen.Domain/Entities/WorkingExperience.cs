using CurryGen.Domain.ValueObjects;

namespace CurryGen.Domain.Entities;

public class WorkingExperience
{
    public required DateTime FromDate { get; init; }
    public required DateTime ToDate { get; init; }
    public required JobRole JobRole { get; init; }
    public required List<Tag> Tags { get; init; }
    public required Company Company { get; init; }
}