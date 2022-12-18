using Finger_Print_WebApi.Models.Domain;
using Finger_Print_WebApi.Models.DTO.EmployeeDto;

namespace Finger_Print_WebApi.Repos.IRepo
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAllAsync();
        Task<IQueryable<EmployeeDepartmentDto>> GetDetailsAsync();
    }
}
