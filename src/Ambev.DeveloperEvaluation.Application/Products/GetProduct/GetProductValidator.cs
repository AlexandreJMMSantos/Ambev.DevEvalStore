using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Products.GetProduct;

/// <summary>
/// Validator for GetProductCommand that defines validation rules for product retrieval command.
/// </summary>
public class GetProductCommandValidator : AbstractValidator<GetProductCommand>
{
    /// <summary>
    /// Initializes a new instance of the GetProductCommandValidator with defined validation rules.
    /// </summary>
    /// <remarks>
    /// Validation rules include:
    /// - Id: Must not be empty
    /// </remarks>
    public GetProductCommandValidator()
    {
        RuleFor(product => product.Id).NotEmpty().WithMessage("Product ID is required");
    }
}
