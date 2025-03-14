using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Users.GetUserByEmail;

/// <summary>
/// Command for retrieving a user by their email
/// </summary>
public record GetUserByEmailCommand : IRequest<GetUserByEmailResult>
{
    /// <summary>
    /// The email of the user to retrieve
    /// </summary>
    public string Email { get; }

    /// <summary>
    /// Initializes a new instance of GetUserByEmailCommand
    /// </summary>
    /// <param name="email">The email of the user to retrieve</param>
    public GetUserByEmailCommand(string email)
    {
        Email = email;
    }
}
