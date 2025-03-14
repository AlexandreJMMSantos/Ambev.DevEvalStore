namespace Ambev.DeveloperEvaluation.Application.Sales.DeleteSale;

/// <summary>
/// Represents the response returned after successfully deleting a sale.
/// </summary>
/// <remarks>
/// This response indicates whether the deletion was successful,
/// which can be used for logging or reference.
/// </remarks>
public class DeleteSaleResponse
{
    /// <summary>
    /// Indicates whether the deletion was successful
    /// </summary>
    public bool Success { get; set; }
}
