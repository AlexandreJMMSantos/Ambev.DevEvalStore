namespace Ambev.DeveloperEvaluation.WebApi.Features.Users.GetUserByEmail;

/// <summary>
/// Request model for getting a user by email
/// </summary>
public class GetUserByEmailRequest
{
    /// <summary>
    /// The email of the user to retrieve
    /// </summary>
    public string Email { get; set; } = string.Empty;
}
