namespace PriceChecker.Domain.Models;

public record BaseModel
{
    public Guid Id { get; init; }
    public DateTime CreatedAt { get; init; }
    public DateTime UpdatedAt { get; init; }
}
