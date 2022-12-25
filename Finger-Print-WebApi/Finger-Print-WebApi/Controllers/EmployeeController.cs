using AutoMapper;
using Finger_Print_WebApi.Models.Domain;
using Finger_Print_WebApi.Models.DTO.EmployeeDto;
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
        public async Task<IActionResult> GetAllEmployeesAsync()
        {
            return Ok(await employeeRepository.GetAllAsync());
        }
        [HttpGet("GetEmployeeDepartment")]
        public async Task<IActionResult> GetDetailedEmployeesAsync()
        {
            return Ok(await employeeRepository.GetDetailsAsync());
        }
        [HttpPost("AddEmployee")]
        public async Task<IActionResult> AddEmployeeAsync(EmpFullDataDto empFullDataDto)
        {
            await employeeRepository.AddEmployeeAsync(empFullDataDto);
            return Ok("User Created");
        }
        [HttpGet("GetEmployeeByID/{id:int}")]
        public async Task<IActionResult> GetUserByIdAsync(int id)
        {
            var emp = await employeeRepository.GetEmployeeByIDAsync(id);
            if(emp == null) return NotFound();
            var empdto = mapper.Map<Models.DTO.EmployeeDto.EmpFullDataDto>(emp);
            return Ok(empdto);
        }
        [HttpDelete("DeleteEmployee/{id:int}")]
        public async Task<IActionResult> DeleteEmployeeAsync(int id)
        {
            await employeeRepository.DeleteEmployeeAsync(id);
            return Ok("Employee: " + id.ToString() + " deleted succesfully");
        }
        [HttpPut("UpdateEmployee/{id:int}")]
        public async Task<IActionResult> UpdateEmployeeAsync([FromRoute] int id,[FromBody] EmpFullDataDto empFullDataDto)
        {
            var emp = mapper.Map<Employee>(empFullDataDto);
            if (emp == null) return NotFound();
            emp = await employeeRepository.UpdateEmployeeAsync(id, emp);
            var empdt = mapper.Map<EmpFullDataDto>(emp);
            return Ok("employee Updated");
        }

    }
}
