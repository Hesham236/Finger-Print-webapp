using AutoMapper;

namespace Finger_Print_WebApi.Models.Profiles
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Models.Domain.Employee, Models.DTO.EmpFullDataDto>();
        }

    }
}
