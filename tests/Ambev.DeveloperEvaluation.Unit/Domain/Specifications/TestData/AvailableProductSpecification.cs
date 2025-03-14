using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Domain.Specifications;

/// <summary>
/// Specification to check if a product is available for sale.
/// </summary>
public class AvailableProductSpecification
{
    /// <summary>
    /// Determines whether a given product is available for sale.
    /// </summary>
    /// <param name="product">The product entity to check.</param>
    /// <returns>True if the product has a valid price and category, otherwise false.</returns>
    public bool IsSatisfiedBy(Product product)
    {
        return product != null && product.Price > 0 && !string.IsNullOrWhiteSpace(product.Category);
    }
}
