using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.GetProduct;

/// <summary>
/// API response model for GetProduct operation
/// </summary>
public class GetProductResponse
{
    /// <summary>
    /// The unique identifier of the product
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The product title
    /// </summary>
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// The product price
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// The product description
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// The product category
    /// </summary>
    public string Category { get; set; } = string.Empty;

    /// <summary>
    /// The product rating
    /// </summary>
    public ProductRating Rating { get; set; } = new ProductRating();
}

/// <summary>
/// Represents the product rating details
/// </summary>
public class ProductRating
{
    /// <summary>
    /// The average rating of the product
    /// </summary>
    public decimal Rate { get; set; }

    /// <summary>
    /// The number of reviews for the product
    /// </summary>
    public int Count { get; set; }
}