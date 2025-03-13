using Ambev.DeveloperEvaluation.Common.Validation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Products.DeleteProduct;

/// <summary>
/// Command for deleting a product.
/// </summary>
/// <remarks>
/// This command is used to capture the required data for deleting a product
/// by its unique identifier.
/// </remarks>
public class DeleteProductCommand : IRequest<DeleteProductResponse>
{
    /// <summary>
    /// Gets or sets the unique identifier of the product to be deleted.
    /// </summary>
    public Guid Id { get; set; }

    public ValidationResultDetail Validate()
    {
        var validator = new DeleteProductValidator();
        var result = validator.Validate(this);
        return new ValidationResultDetail
        {
            IsValid = result.IsValid,
            Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
        };
    }
}