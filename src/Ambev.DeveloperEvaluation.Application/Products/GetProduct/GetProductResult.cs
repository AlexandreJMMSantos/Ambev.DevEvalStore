namespace Ambev.DeveloperEvaluation.Application.Products.GetProduct;

/// <summary>
/// Represents the response returned after successfully retrieving a product.
/// </summary>
/// <remarks>
/// This response contains the details of the requested product,
/// which can be used for display or further processing.
/// </remarks>
public class GetProductResult
{
    /// <summary>
    /// Gets or sets the unique identifier of the retrieved product.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the product title.
    /// </summary>
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the product price.
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// Gets or sets the product description.
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the product category.
    /// </summary>
    public string Category { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the product image URL.
    /// </summary>
    public string Image { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the product rating.
    /// </summary>
    public ProductRating Rating { get; set; } = new ProductRating();
}

/// <summary>
/// Represents the product rating details.
/// </summary>
public class ProductRating
{
    /// <summary>
    /// Gets or sets the average rating of the product.
    /// </summary>
    public decimal Rate { get; set; }

    /// <summary>
    /// Gets or sets the number of reviews for the product.
    /// </summary>
    public int Count { get; set; }
}
