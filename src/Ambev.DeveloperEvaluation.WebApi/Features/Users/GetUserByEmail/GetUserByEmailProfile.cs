using Ambev.DeveloperEvaluation.Application.Users.GetUserByEmail;
using Ambev.DeveloperEvaluation.WebApi.Features.Users.GetUser;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Users.GetUserByEmail
{
    /// <summary>
    /// Mapping profile for GetUserByEmail feature
    /// </summary>
    public class GetUserByEmailProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserByEmailProfile"/> class.
        /// </summary>
        public GetUserByEmailProfile()
        {
            CreateMap<GetUserByEmailRequest, GetUserByEmailCommand>();
            CreateMap<GetUserByEmailResult, GetUserByEmailResponse>();
            CreateMap<GetUserByEmailResult, GetUserResponse>();
        }
    }
}
