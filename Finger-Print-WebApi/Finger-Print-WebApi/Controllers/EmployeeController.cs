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
            return Ok(employeeRepository.GetAllAsync().Result);
        }
        [HttpGet("GetEmployeeDepartment")]
        public async Task<IActionResult> GetDetailedEmployeesAsync()
        {
            return Ok(employeeRepository.GetDetailsAsync().Result);
        }

    }
}
