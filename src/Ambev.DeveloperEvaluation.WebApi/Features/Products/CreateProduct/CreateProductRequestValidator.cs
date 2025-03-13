using Ambev.DeveloperEvaluation.Domain.Validation;
using FluentValidation;
using FluentValidation.Validators;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.CreateProduct;

/// <summary>
/// Validator for CreateProductRequest that defines validation rules for product creation.
/// </summary>
public class CreateProductRequestValidator : AbstractValidator<CreateProductRequest>
{
    /// <summary>
    /// Initializes a new instance of the CreateProductRequestValidator with defined validation rules.
    /// </summary>
    /// <remarks>
    /// Validation rules include:
    /// - Title: Required, length between 3 and 100 characters
    /// - Description: Required, length between 10 and 500 characters
    /// - Price: Must be greater than zero
    /// - Category: Required, length between 3 and 50 characters
    /// - Image: Must be a valid URL
    /// - Rating: Rate between 0 and 5, Count must be greater than or equal to zero
    /// </remarks>
    public CreateProductRequestValidator()
    {
        RuleFor(product => product.Title)
            .NotEmpty()
            .Length(3, 100);

        RuleFor(product => product.Description)
            .NotEmpty()
            .Length(10, 500);

        RuleFor(product => product.Price)
            .GreaterThan(0);

        RuleFor(product => product.Category)
            .NotEmpty()
            .Length(3, 50);

        RuleFor(product => product.Rating)
            .NotNull().WithMessage("Rating is required.");

        RuleFor(product => product.Rating.Rate)
            .InclusiveBetween(0, 5).WithMessage("Rate must be between 0 and 5.");

        RuleFor(product => product.Rating.Count)
            .GreaterThanOrEqualTo(0).WithMessage("Count must be zero or greater.");
    }
}
