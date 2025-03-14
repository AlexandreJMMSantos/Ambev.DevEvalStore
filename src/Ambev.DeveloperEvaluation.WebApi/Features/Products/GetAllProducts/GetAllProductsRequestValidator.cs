using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.GetAllProducts;

/// <summary>
/// Validator for GetAllProductsRequest
/// </summary>
public class GetAllProductsRequestValidator : AbstractValidator<GetAllProductsRequest>
{
    /// <summary>
    /// Initializes validation rules for GetAllProductsRequest
    /// </summary>
    public GetAllProductsRequestValidator()
    {
        // No specific validation needed as this request does not take parameters
    }
}
