using CurryGen.Domain.ValueObjects;

namespace CurryGen.Domain.Entities;

public class Certificate
{
    public required List<Tag> Tags { get; init; }
}