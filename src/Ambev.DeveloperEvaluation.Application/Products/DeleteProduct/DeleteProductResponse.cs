namespace Ambev.DeveloperEvaluation.Application.Products.DeleteProduct;

/// <summary>
/// Represents the response returned after successfully deleting a product.
/// </summary>
/// <remarks>
/// This response contains the unique identifier of the deleted product,
/// which can be used for logging or reference.
/// </remarks>
public class DeleteProductResponse
{
    /// <summary>
    /// Indicates whether the deletion was successful
    /// </summary>
    public bool Success { get; set; }
}
