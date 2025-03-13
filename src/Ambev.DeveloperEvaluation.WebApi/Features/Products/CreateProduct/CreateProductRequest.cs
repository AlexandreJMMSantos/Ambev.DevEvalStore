using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.CreateProduct;

/// <summary>
/// Represents a request to create a new product in the system.
/// </summary>
public class CreateProductRequest
{
    /// <summary>
    /// Gets or sets the product title. Must not be empty.
    /// </summary>
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the product description.
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the product price. Must be greater than zero.
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// Gets or sets the product category.
    /// </summary>
    public string Category { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the product image URL.
    /// </summary>
    public string Image { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the product rating information.
    /// </summary>
    public RatingRequest Rating { get; set; } = new();
}

/// <summary>
/// Represents the rating details for a product.
/// </summary>
public class RatingRequest
{
    /// <summary>
    /// Gets or sets the average rating value. Must be between 0 and 5.
    /// </summary>
    public decimal Rate { get; set; }

    /// <summary>
    /// Gets or sets the total count of reviews.
    /// </summary>
    public int Count { get; set; }
}
