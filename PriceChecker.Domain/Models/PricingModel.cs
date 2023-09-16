using PriceChecker.Domain.Enums;

namespace PriceChecker.Domain.Models;

public record PricingModel : BaseModel
{
    public required double Price { get; set; }
    public required DateTime Date { get; set; }
    public required Shop Shop { get; set; }
}
