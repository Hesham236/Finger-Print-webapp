using AutoMapper;
using Finger_Print_WebApi.Models.DTO.DepartmentDto;
using Finger_Print_WebApi.Models.DTO.EmployeeDto;

namespace Finger_Print_WebApi.Models.Profiles
{
    public class DepartmentProfile : Profile
    {
        public DepartmentProfile()
        {
            CreateMap<Models.Domain.Department,DepartmentsDto>();
            CreateMap < Models.Domain.Department,EmployeeDepartmentDto>();

        }
    }
}
