using Ambev.DeveloperEvaluation.Domain.Entities;
using Bogus;

namespace Ambev.DeveloperEvaluation.Unit.Domain.Specifications.TestData;

/// <summary>
/// Provides methods for generating test data for AvailableProductSpecification tests.
/// Ensures consistent test cases for validating product availability.
/// </summary>
public static class AvailableProductSpecificationTestData
{
    private static readonly Faker<Product> productFaker = new Faker<Product>()
        .CustomInstantiator(f => new Product
        {
            Title = f.Commerce.ProductName(),
            Description = f.Lorem.Sentence(),
            Price = f.Random.Decimal(1, 1000),
            Category = f.Commerce.Categories(1)[0],
            Image = f.Image.PicsumUrl(),
            Rating = new Rating(f.Random.Decimal(1, 5), f.Random.Int(1, 1000)),
            CreatedAt = DateTime.UtcNow
        });

    /// <summary>
    /// Generates a product with the specified price and category.
    /// </summary>
    /// <param name="price">The price of the product.</param>
    /// <param name="category">The category of the product.</param>
    /// <returns>A product with specified attributes.</returns>
    public static Product GenerateProduct(decimal price, string category)
    {
        var product = productFaker.Generate();
        product.Price = price;
        product.Category = category;
        return product;
    }
}
