using AutoMapper;
using Finger_Print_WebApi.Repos.IRepo;
using Microsoft.AspNetCore.Mvc;

namespace Finger_Print_WebApi.Controllers
{
    [ApiController]
    [Route("Employees")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository employeeRepository;
        private readonly IMapper mapper;
        public EmployeeController(IEmployeeRepository employeeRepository,IMapper mapper)
        {
            this.employeeRepository = employeeRepository;
            this.mapper = mapper;
        }

        // Routes
       
        [HttpGet("GetAllEmployees")]
        public async Task<IActionResult> GetAllEmployees()
        {
            var employees = await employeeRepository.GetAllAsync();
            var employeesDto = mapper.Map<List<Models.DTO.EmpFullDataDto>>(employees);
            return Ok(employeesDto);
        }
        [HttpGet("GetDetailedEmployee")]
        public async Task<IActionResult> GetDetailedEmployeesAsync()
        {
            var employees = await employeeRepository.GetDetailsAsync();
            var empdeptDto=mapper.Map<List<Models.DTO.EmployeeDepartmentDto>>(employees);
            return Ok(empdeptDto);
        }

    }
}
