using AutoMapper;
using Finger_Print_WebApi.Models.DTO.EmployeeDto;

namespace Finger_Print_WebApi.Models.Profiles
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Models.Domain.Employee, EmpFullDataDto>();
            CreateMap<Models.Domain.Employee, EmployeeDepartmentDto>();
        }

    }
}
