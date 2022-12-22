using AutoMapper;
using Finger_Print_WebApi.Models.DTO.UserDto;
using Finger_Print_WebApi.Models.Domain;

namespace Finger_Print_WebApi.Models.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile() 
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
            CreateMap<User, LoginRequest>();
        }
    }
}
