using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Users.GetUserByEmail;

/// <summary>
/// Validator for GetUserByEmailRequest
/// </summary>
public class GetUserByEmailRequestValidator : AbstractValidator<GetUserByEmailRequest>
{
    /// <summary>
    /// Initializes validation rules for GetUserByEmailRequest
    /// </summary>
    public GetUserByEmailRequestValidator()
    {
        RuleFor(x => x.Email)
            .NotEmpty()
            .WithMessage("Email is required")
            .EmailAddress()
            .WithMessage("Invalid email format");
    }
}
