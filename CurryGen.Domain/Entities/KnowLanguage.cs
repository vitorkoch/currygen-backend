namespace CurryGen.Domain.Entities;

public class LanguageProficiency
{
    public required string Proficiency { get; init; }
    public Certificate? Certificate { get; init; }
}

public class KnowLanguage
{
    public required string Language { get; init; }
    public required LanguageProficiency Proficiency { get; init; }
}