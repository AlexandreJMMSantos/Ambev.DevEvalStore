namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.DeleteSale
{
    /// <summary>
    /// API response model for DeleteSale operation
    /// </summary>
    public class DeleteSaleResponse
    {
        /// <summary>
        /// Indicates whether the sale was successfully deleted.
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Message providing additional information about the operation.
        /// </summary>
        public string Message { get; set; } = string.Empty;
    }
}