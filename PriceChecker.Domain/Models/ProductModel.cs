namespace PriceChecker.Domain.Models;

public record ProductModel : BaseModel
{
    public required string Name { get; set; }
    public required decimal AlertPrice { get; set; }
    public required IEnumerable<PricingModel> Prices { get; set; }

    public required IEnumerable<ShopProductIdentifier> ExternalIds { get; set; }
}
