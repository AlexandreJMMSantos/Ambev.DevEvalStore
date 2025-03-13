using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Products.DeleteProduct;

/// <summary>
/// Validator for DeleteProductCommand that defines validation rules for product deletion command.
/// </summary>
public class DeleteProductValidator : AbstractValidator<DeleteProductCommand>
{
    /// <summary>
    /// Initializes a new instance of the DeleteProductCommandValidator with defined validation rules.
    /// </summary>
    /// <remarks>
    /// Validation rules include:
    /// - Id: Must not be empty
    /// </remarks>
    public DeleteProductValidator()
    {
        RuleFor(product => product.Id).NotEmpty().WithMessage("Product ID is required");
    }
}
