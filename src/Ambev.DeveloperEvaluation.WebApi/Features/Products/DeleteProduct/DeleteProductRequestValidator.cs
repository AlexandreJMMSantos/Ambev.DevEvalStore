using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.DeleteProduct
{
    public class DeleteProductRequestValidator : AbstractValidator<DeleteProductRequest>
    {
        /// <summary>
        /// Initializes a new instance of the DeleteProductRequestValidator with defined validation rules.
        /// </summary>
        public DeleteProductRequestValidator()
        {
            RuleFor(request => request.Id)
                .NotEmpty().WithMessage("ProductId is required.");
        }
    }
}
