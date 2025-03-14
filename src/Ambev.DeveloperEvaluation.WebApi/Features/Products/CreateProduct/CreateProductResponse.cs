using System;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.CreateProduct;

/// <summary>
/// API response model for CreateProduct operation
/// </summary>
public class CreateProductResponse
{
    /// <summary>
    /// The unique identifier of the created product
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The product's title
    /// </summary>
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// The product's description
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// The product's price
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// The product's category
    /// </summary>
    public string Category { get; set; } = string.Empty;

    /// <summary>
    /// The rating information of the product
    /// </summary>
    public RatingResponse Rating { get; set; } = new();
}

/// <summary>
/// Represents the rating details of a product
/// </summary>
public class RatingResponse
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