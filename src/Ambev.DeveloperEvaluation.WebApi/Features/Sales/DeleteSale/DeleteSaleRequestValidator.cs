using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.DeleteSale
{
    public class DeleteSaleRequestValidator : AbstractValidator<DeleteSaleRequest>
    {
        /// <summary>
        /// Initializes a new instance of the DeleteSaleRequestValidator with defined validation rules.
        /// </summary>
        public DeleteSaleRequestValidator()
        {
            RuleFor(request => request.Id)
                .NotEmpty().WithMessage("SaleId is required.");
        }
    }
}