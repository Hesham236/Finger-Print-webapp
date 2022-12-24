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
        public async Task<Employee> UpdateEmployeeAsync(int id, Employee employee)
        {
            var emp = await fingerPrintDBContext.Employees.FirstOrDefaultAsync(x=>x.Id == id);
            if (emp == null) return null;

            emp.name = employee.name;
            emp.milatary_service_status = employee.milatary_service_status;
            emp.national_id= employee.national_id;
            emp.dob= employee.dob;
            emp.government = employee.government;
            emp.address= employee.address;
            emp.martial_status= employee.martial_status;
            emp.num_children= employee.num_children;
            emp.social_insurance= employee.social_insurance;
            emp.phone_number= employee.phone_number;
            emp.religion= employee.religion;
            emp.education= employee.education;
            emp.job_description= employee.job_description;
            emp.photo= employee.photo;
            emp.Dept_id = employee.Dept_id;
            emp.Contract_id= employee.Contract_id;

            await fingerPrintDBContext.SaveChangesAsync();
            return emp;
        }
    }
}
