namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.DeleteProduct
{
    /// <summary>
    /// Represents a request to delete a product in the system.
    /// </summary>
    public class DeleteProductRequest
    {
        /// <summary>
        /// Gets or sets the unique identifier of the product to delete.
        /// </summary>
        public Guid Id { get; set; }
    }
}
