using System.ComponentModel;

namespace CurryGen.Domain.ValueObjects;

public enum KnowJobRoles
{
    [Description("Software Engineer")] SoftwareEngineer,
    [Description("CEO")] Ceo
}

public class JobRole(string role)
{
    public required string Role { get; init; } = role;
}