using AutoMapper;
using Finger_Print_WebApi.Models.Domain;
using Finger_Print_WebApi.Models.DTO.EmployeeDto;

namespace Finger_Print_WebApi.Models.Profiles
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, EmpFullDataDto>();
            CreateMap<EmpFullDataDto, Employee>()
                .ForMember(m => m.Id, e => e.Ignore());
            CreateMap<Employee, EmployeeDepartmentDto>();
        }

    }
}
