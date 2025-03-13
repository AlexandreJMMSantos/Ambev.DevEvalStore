namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.DeleteProduct
{
    /// <summary>
    /// API response model for DeleteProduct operation
    /// </summary>
    public class DeleteProductResponse
    {
        /// <summary>
        /// Indicates whether the product was successfully deleted.
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Message providing additional information about the operation.
        /// </summary>
        public string Message { get; set; } = string.Empty;
    }
}
