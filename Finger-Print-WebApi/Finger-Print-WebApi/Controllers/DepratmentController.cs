using AutoMapper;
using Finger_Print_WebApi.Models.DTO.DepartmentDto;
using Finger_Print_WebApi.Repos.IRepo;
using Microsoft.AspNetCore.Mvc;

namespace Finger_Print_WebApi.Controllers
{
    [ApiController]
    [Route("Department")]
    public class DepratmentController : Controller
    {
        private readonly IDepartmentRepository departmentRepository;
        private readonly IMapper mapper;

        public DepratmentController(IDepartmentRepository departmentRepository,IMapper mapper)
        {
            this.departmentRepository = departmentRepository;
            this.mapper = mapper;
        }

        //Routes
        [HttpPost("AddDepartment")]
        public async Task<IActionResult> AddDepartmentAsync(DepartmentsDto departmentsDto)
        {
            await departmentRepository.AddDepartmentAsync(departmentsDto);
            return Ok("Department Created");
        }
        [HttpGet("GetAllDepartments")]
        public async Task<IActionResult> GetAllDepartementsAsync()
        {
            return Ok(await departmentRepository.GetAllDepartmentsAsync());
        }
        [HttpDelete("DeleteDepartment/{id:int}")]
        public async Task<IActionResult> DeleteDepartmentAsync(int id)
        {
            await departmentRepository.DeleteDepartmentAsync(id);
            return Ok("Department Deleted");
        }


    }
}
