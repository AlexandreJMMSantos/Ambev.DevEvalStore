using Ambev.DeveloperEvaluation.Domain.Validation;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Products.CreateProduct;

/// <summary>
/// Validator for CreateProductCommand that defines validation rules for product creation command.
/// </summary>
public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
{
    /// <summary>
    /// Initializes a new instance of the CreateProductCommandValidator with defined validation rules.
    /// </summary>
    /// <remarks>
    /// Validation rules include:
    /// - Title: Required, must be between 3 and 100 characters
    /// - Price: Must be greater than 0
    /// - Description: Required, must be between 10 and 500 characters
    /// - Category: Required, must be between 3 and 50 characters
    /// - Image: Must be a valid URL
    /// - Rating Rate: Must be between 0 and 5
    /// - Rating Count: Must be 0 or greater
    /// </remarks>
    public CreateProductCommandValidator()
    {
        RuleFor(product => product.Title).NotEmpty().Length(3, 100);
        RuleFor(product => product.Price).GreaterThan(0);
        RuleFor(product => product.Description).NotEmpty().Length(10, 500);
        RuleFor(product => product.Category).NotEmpty().Length(3, 50);
        RuleFor(product => product.Rating.Rate).InclusiveBetween(0, 5);
        RuleFor(product => product.Rating.Count).GreaterThanOrEqualTo(0);
    }
}