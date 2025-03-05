using Ambev.DeveloperEvaluation.Application.Users.UpdateUser;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Users.UpdateUser
{
    /// <summary>
    /// Profile for mapping UpdateUser feature requests to commands
    /// </summary>
    public class UpdateUserProfile : Profile
    {
        public UpdateUserProfile()
        {
            CreateMap<UpdateUserRequest, UpdateUserCommand>();
            CreateMap<UpdateUserResult, UpdateUserResponse>();
        }
    }
}
