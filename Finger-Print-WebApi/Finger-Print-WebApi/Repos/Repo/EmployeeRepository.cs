using AutoMapper;
using Finger_Print_WebApi.Data;
using Finger_Print_WebApi.Models.Domain;
using Finger_Print_WebApi.Models.DTO.EmployeeDto;
using Finger_Print_WebApi.Repos.IRepo;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Finger_Print_WebApi.Repos.Repo
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly FingerPrintDBContext fingerPrintDBContext;
        private readonly IMapper mapper;

        public EmployeeRepository(FingerPrintDBContext fingerPrintDBContext,IMapper mapper)
        {
            this.fingerPrintDBContext = fingerPrintDBContext;
            this.mapper = mapper;
        }


        //Routes
        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            return await fingerPrintDBContext.Employees.ToListAsync();
        }
        public async Task<IQueryable<EmployeeDepartmentDto>> GetDetailsAsync()
        {
             var employee = from e in fingerPrintDBContext.Employees
                             join d in fingerPrintDBContext.Departments
                             on e.Dept_id equals d.Id
                             join c in fingerPrintDBContext.Contracts
                             on e.Contract_id equals c.Id
                           // where e.Dept_id == 1
                             select new Models.DTO.EmployeeDto.EmployeeDepartmentDto
                             {
                                 Employeename = e.name,
                                 Id = e.Id,
                                 DepartmentName = d.name,
                                 ContractType = c.type
                             };
            return employee;
            
        }
        public async Task<Employee> AddEmployeeAsync(EmpFullDataDto empFullDataDto )
        {
            var user = mapper.Map<Employee>(empFullDataDto);
            await fingerPrintDBContext.AddAsync( user );
            fingerPrintDBContext.SaveChanges();
            return user;
        }
        public async Task<Employee> GetEmployeeByIDAsync(int id)
        {
            return await fingerPrintDBContext.Employees.FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<Employee> DeleteEmployeeAsync(int id)
        {
            var emp = await fingerPrintDBContext.Employees.FirstOrDefaultAsync(x=>x.Id == id);
            if (emp == null) return null;
            fingerPrintDBContext.Remove(emp);
            await fingerPrintDBContext.SaveChangesAsync();
            return emp;
        }
        public async Task<Employee> UpdateEmployeeAsync(int id, EmpFullDataDto empFullDataDto)
        {
            var emp = await fingerPrintDBContext.Employees.FirstOrDefaultAsync(x=>x.Id == id);
            if (emp == null) return null;
            var empdto = mapper.Map<Employee>(empFullDataDto);
            await fingerPrintDBContext.SaveChangesAsync();
            return empdto;
        }
    }
}
