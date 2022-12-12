using Finger_Print_WebApi.Data;
using Finger_Print_WebApi.Models.Domain;
using Finger_Print_WebApi.Repos.IRepo;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Finger_Print_WebApi.Repos.Repo
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly FingerPrintDBContext fingerPrintDBContext;

        public EmployeeRepository(FingerPrintDBContext fingerPrintDBContext)
        {
            this.fingerPrintDBContext = fingerPrintDBContext;
        }
        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            return await fingerPrintDBContext.Employees.ToListAsync();
        }

        public async Task<IQueryable<Models.DTO.EmployeeDepartmentDto>> GetDetailsAsync()
        {
             var employee = from e in fingerPrintDBContext.Employees
                             join d in fingerPrintDBContext.Departments
                             on e.Dept_id equals d.Id
                             join c in fingerPrintDBContext.Contracts
                             on e.Contract_id equals c.Id
                            where e.Dept_id == 1
                             select new Models.DTO.EmployeeDepartmentDto
                             {
                                 Employeename = e.name,
                                 Id = e.Id,
                                 DepartmentName = d.name,
                                 ContractType = c.type
                             };
            return employee;
            
        }
    }
}
