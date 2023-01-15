using Finger_Print_WebApi.Models.Domain;
using Finger_Print_WebApi.Models.DTO.EmployeeDto;

namespace Finger_Print_WebApi.Repos.IRepo
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAllAsync();
        Task<IQueryable<EmployeeDepartmentDto>> GetDetailsAsync();
        Task<Employee> AddEmployeeAsync(EmpFullDataDto empFullDataDto);
        Task<Employee> GetEmployeeByIDAsync(int id);
        Task<Employee> DeleteEmployeeAsync(int id);
        Task<Employee> UpdateEmployeeAsync(int id, Employee employee);
        Task<IQueryable<EmployeeDepartmentDto>> GetEmployeeByDepartmentAsync(int dept_id);
        Task<IQueryable<Employee>> GetEmployeeVacationsAsync(int id);
        
    }
}
