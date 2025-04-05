namespace CurryGen.Domain.Entities;

public enum LanguageProficiency
{
};

public class KnowLanguage
{
    public required string Language { get; init; }
    public required LanguageProficiency Proficiency { get; init; }
}