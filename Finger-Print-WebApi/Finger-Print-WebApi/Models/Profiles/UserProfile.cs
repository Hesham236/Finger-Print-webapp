using AutoMapper;
using Finger_Print_WebApi.Models.DTO.UserDto;

namespace Finger_Print_WebApi.Models.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile() 
        {
            CreateMap<Models.Domain.User, UserDto>();
            CreateMap<Models.Domain.User, LoginRequest>();
        }
    }
}
