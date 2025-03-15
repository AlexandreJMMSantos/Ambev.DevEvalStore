using Ambev.DeveloperEvaluation.Domain.Validation;
using FluentValidation;
using FluentValidation.Validators;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.UpdateSale;

/// <summary>
/// Validator for UpdateSaleRequest that defines validation rules for sale updates.
/// </summary>
public class UpdateSaleRequestValidator : AbstractValidator<UpdateSaleRequest>
{
    /// <summary>
    /// Initializes a new instance of the UpdateSaleRequestValidator with defined validation rules.
    /// </summary>
    /// <remarks>
    /// Validation rules include:
    /// - SaleId: Required (Guid)
    /// - SaleNumber: Required, length between 3 and 50 characters
    /// - UserId: Required (Guid)
    /// - ProductId: Required (Guid)
    /// - Quantity: Must be greater than zero
    /// - UnitPrice: Must be greater than zero
    /// - Discount: Must be zero or greater
    /// </remarks>
    public UpdateSaleRequestValidator()
    {
        RuleFor(sale => sale.Id)
            .NotEmpty().WithMessage("Id is required.");

        RuleFor(sale => sale.SaleNumber)
            .NotEmpty()
            .Length(3, 50);

        RuleFor(sale => sale.UserId)
            .NotEmpty().WithMessage("UserId is required.");

        RuleFor(sale => sale.ProductId)
            .NotEmpty().WithMessage("ProductId is required.");

        RuleFor(sale => sale.Quantity)
            .GreaterThan(0).WithMessage("Quantity must be greater than zero.");

        RuleFor(sale => sale.UnitPrice)
            .GreaterThan(0).WithMessage("UnitPrice must be greater than zero.");

        RuleFor(sale => sale.Discount)
            .GreaterThanOrEqualTo(0).WithMessage("Discount must be zero or greater.");
    }
}