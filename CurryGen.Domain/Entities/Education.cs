using CurryGen.Domain.ValueObjects;

namespace CurryGen.Domain.Entities;

public class Education
{
    public required List<Tag> Tags { get; init; }
}