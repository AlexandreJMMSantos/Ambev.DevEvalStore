using AutoMapper;
using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Application.Users.GetUserByEmail;

/// <summary>
/// Profile for mapping between User entity and GetUserByEmailResponse
/// </summary>
public class GetUserByEmailProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for GetUserByEmail operation
    /// </summary>
    public GetUserByEmailProfile()
    {
        CreateMap<User, GetUserByEmailResult>();
    }
}
