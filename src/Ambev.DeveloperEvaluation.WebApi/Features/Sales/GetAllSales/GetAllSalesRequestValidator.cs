using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetAllSales;

/// <summary>
/// Validator for GetAllSalesRequest
/// </summary>
public class GetAllSalesRequestValidator : AbstractValidator<GetAllSalesRequest>
{
    /// <summary>
    /// Initializes validation rules for GetAllSalesRequest
    /// </summary>
    public GetAllSalesRequestValidator()
    {
        // No specific validation needed as this request does not take parameters
    }
}