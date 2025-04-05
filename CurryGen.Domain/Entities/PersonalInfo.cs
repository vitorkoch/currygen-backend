using CurryGen.Domain.ValueObjects;

namespace CurryGen.Domain.Entities;

public class PersonalInfo
{
    public required string Name { get; init; }
    public required string? PictureUrl { get; init; }
    public required Email Email { get; init; }
    public required Phone Phone { get; init; }
    public required HabitationLocation HabitationLocation { get; init; }
    public required string? CoverLetter { get; init; }
}