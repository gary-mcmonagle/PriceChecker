using PriceChecker.Domain.Enums;

namespace PriceChecker.Domain.Models;

public record ShopProductIdentifier : BaseModel
{
    public required string Identifier { get; set; }
    public required Shop Shop { get; set; }
}
