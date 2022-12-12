using AutoMapper;

namespace Finger_Print_WebApi.Models.Profiles
{
    public class DepartmentProfile : Profile
    {
        public DepartmentProfile()
        {
            CreateMap<Models.Domain.Department,Models.DTO.DepartmentsDto>();
            CreateMap < Models.Domain.Department,Models.DTO.EmployeeDepartmentDto>();

        }
    }
}
