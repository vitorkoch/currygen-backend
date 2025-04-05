namespace CurryGen.Domain.Entities;

public enum SkillProficiency
{
    VerySkilled
}

public class Skill
{
    public required string Title { get; init; }
    public required SkillProficiency Proficiency { get; init; }
}