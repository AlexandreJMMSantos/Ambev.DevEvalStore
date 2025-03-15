using Ambev.DeveloperEvaluation.Domain.Validation;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Sales.UpdateSale;

/// <summary>
/// Validator for UpdateSaleCommand that defines validation rules for sale update command.
/// </summary>
public class UpdateSaleCommandValidator : AbstractValidator<UpdateSaleCommand>
{
    /// <summary>
    /// Initializes a new instance of the UpdateSaleCommandValidator with defined validation rules.
    /// </summary>
    /// <remarks>
    /// Validation rules include:
    /// - SaleId: Required (Guid)
    /// - SaleNumber: Required, must be between 3 and 50 characters
    /// - UserId: Required (Guid)
    /// - ProductId: Required (Guid)
    /// - Quantity: Must be greater than 0
    /// - UnitPrice: Must be greater than 0
    /// - Discount: Must be 0 or greater
    /// </remarks>
    public UpdateSaleCommandValidator()
    {
        RuleFor(sale => sale.Id).NotEmpty();
        RuleFor(sale => sale.SaleNumber).NotEmpty().Length(3, 50);
        RuleFor(sale => sale.ChartId).NotEmpty();
        RuleFor(sale => sale.UserId).NotEmpty();
        RuleFor(sale => sale.ProductId).NotEmpty();
        RuleFor(sale => sale.Quantity).GreaterThan(0);
        RuleFor(sale => sale.UnitPrice).GreaterThan(0);
        RuleFor(sale => sale.Discount).GreaterThanOrEqualTo(0);
    }
}
