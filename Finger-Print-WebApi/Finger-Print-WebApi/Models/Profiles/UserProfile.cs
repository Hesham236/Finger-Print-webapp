using AutoMapper;

namespace Finger_Print_WebApi.Models.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile() 
        {
            CreateMap<Models.Domain.User, Models.DTO.UserDto>();
            CreateMap<Models.Domain.User, Models.DTO.LoginRequest>();
        }
    }
}
