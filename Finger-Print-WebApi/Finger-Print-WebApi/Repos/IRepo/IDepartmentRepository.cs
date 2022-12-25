using Finger_Print_WebApi.Models.Domain;
using Finger_Print_WebApi.Models.DTO.DepartmentDto;

namespace Finger_Print_WebApi.Repos.IRepo
{
    public interface IDepartmentRepository
    {
        Task<Department> AddDepartmentAsync(DepartmentsDto departmentsDto);
        Task<IEnumerable<Department>> GetAllDepartmentsAsync();
        Task<Department> DeleteDepartmentAsync(int id);
    }
}
