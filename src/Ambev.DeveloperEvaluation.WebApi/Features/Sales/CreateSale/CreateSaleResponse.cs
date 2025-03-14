using System;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale;

/// <summary>
/// API response model for CreateSale operation
/// </summary>
public class CreateSaleResponse
{
    /// <summary>
    /// The unique identifier of the created sale
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The sale number
    /// </summary>
    public string SaleNumber { get; set; } = string.Empty;

    /// <summary>
    /// The date when the sale was made
    /// </summary>
    public DateTime SaleDate { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier of the user who made the sale.
    /// </summary>
    public Guid ChartId { get; set; }

    /// <summary>
    /// The unique identifier of the user who made the sale
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// The unique identifier of the product sold
    /// </summary>
    public Guid ProductId { get; set; }

    /// <summary>
    /// The quantity of the product sold
    /// </summary>
    public int Quantity { get; set; }

    /// <summary>
    /// The unit price of the product
    /// </summary>
    public decimal UnitPrice { get; set; }

    /// <summary>
    /// The discount applied to the sale
    /// </summary>
    public decimal Discount { get; set; }

    /// <summary>
    /// The total amount for the sale item after applying the discount
    /// </summary>
    public decimal TotalAmount { get; set; }

    /// <summary>
    /// Indicates whether the sale was cancelled
    /// </summary>
    public bool IsCancelled { get; set; }
}