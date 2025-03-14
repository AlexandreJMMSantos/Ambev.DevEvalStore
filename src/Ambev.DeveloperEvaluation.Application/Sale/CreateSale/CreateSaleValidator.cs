using Ambev.DeveloperEvaluation.Domain.Validation;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale;

/// <summary>
/// Validator for CreateSaleCommand that defines validation rules for sale creation command.
/// </summary>
public class CreateSaleCommandValidator : AbstractValidator<CreateSaleCommand>
{
    /// <summary>
    /// Initializes a new instance of the CreateSaleCommandValidator with defined validation rules.
    /// </summary>
    /// <remarks>
    /// Validation rules include:
    /// - SaleNumber: Required, must be between 3 and 50 characters
    /// - UserId: Required (Guid)
    /// - ProductId: Required (Guid)
    /// - Quantity: Must be greater than 0
    /// - UnitPrice: Must be greater than 0
    /// - Discount: Must be 0 or greater
    /// </remarks>
    public CreateSaleCommandValidator()
    {
        RuleFor(sale => sale.SaleNumber).NotEmpty().Length(3, 50);
        RuleFor(sale => sale.ChartId).NotEmpty();
        RuleFor(sale => sale.UserId).NotEmpty();
        RuleFor(sale => sale.ProductId).NotEmpty();
        RuleFor(sale => sale.Quantity).GreaterThan(0);
        RuleFor(sale => sale.UnitPrice).GreaterThan(0);
        RuleFor(sale => sale.Discount).GreaterThanOrEqualTo(0);
    }
}