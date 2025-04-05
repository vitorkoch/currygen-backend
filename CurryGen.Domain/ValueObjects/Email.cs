using System.ComponentModel.DataAnnotations;

namespace CurryGen.Domain.ValueObjects;

public record Email([EmailAddress] string Address);