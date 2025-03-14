using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Users.GetUserByEmail;

/// <summary>
/// Validator for GetUserByEmailCommand
/// </summary>
public class GetUserByEmailValidator : AbstractValidator<GetUserByEmailCommand>
{
    /// <summary>
    /// Initializes validation rules for GetUserByEmailCommand
    /// </summary>
    public GetUserByEmailValidator()
    {
        RuleFor(x => x.Email)
            .NotEmpty()
            .WithMessage("Email is required")
            .EmailAddress()
            .WithMessage("Invalid email format");
    }
}
