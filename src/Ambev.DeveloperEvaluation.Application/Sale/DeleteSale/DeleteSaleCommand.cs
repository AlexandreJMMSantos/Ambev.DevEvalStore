using Ambev.DeveloperEvaluation.Application.Sales.DeleteSale;
using Ambev.DeveloperEvaluation.Common.Validation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sales.DeleteSale;

/// <summary>
/// Command for deleting a sale.
/// </summary>
/// <remarks>
/// This command is used to capture the required data for deleting a sale
/// by its unique identifier.
/// </remarks>
public class DeleteSaleCommand : IRequest<DeleteSaleResponse>
{
    /// <summary>
    /// Gets or sets the unique identifier of the sale to be deleted.
    /// </summary>
    public Guid Id { get; set; }

    public ValidationResultDetail Validate()
    {
        var validator = new DeleteSaleValidator();
        var result = validator.Validate(this);
        return new ValidationResultDetail
        {
            IsValid = result.IsValid,
            Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
        };
    }
}