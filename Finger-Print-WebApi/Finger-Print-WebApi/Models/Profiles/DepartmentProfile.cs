using AutoMapper;
using Finger_Print_WebApi.Models.Domain;
using Finger_Print_WebApi.Models.DTO.DepartmentDto;
using Finger_Print_WebApi.Models.DTO.EmployeeDto;

namespace Finger_Print_WebApi.Models.Profiles
{
    public class DepartmentProfile : Profile
    {
        public DepartmentProfile()
        {
            CreateMap <Department,DepartmentsDto>();
            CreateMap<DepartmentsDto,Department>()
                .ForMember(m => m.Id, e => e.Ignore());
            CreateMap <Department,EmployeeDepartmentDto>();

        }
    }
}
