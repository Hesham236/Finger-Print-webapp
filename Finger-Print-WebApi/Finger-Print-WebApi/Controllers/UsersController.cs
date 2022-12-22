using AutoMapper;
using Finger_Print_WebApi.Models.Domain;
using Finger_Print_WebApi.Models.DTO.UserDto;
using Finger_Print_WebApi.Repos.IRepo;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;

namespace Finger_Print_WebApi.Controllers
{
    [ApiController]
    [Route("Users")]
    public class UsersController : Controller
    {
        private readonly IUserRepositarory userRepositarory;
        private readonly IMapper mapper;

        public UsersController(IUserRepositarory userRepositarory,IMapper mapper)
        {
            this.userRepositarory = userRepositarory;
            this.mapper = mapper;
        }

        //Routes
        [HttpGet("GetAllUsers")]
        public async Task<IActionResult> GetUsersAsync() 
        {
            return Ok(await userRepositarory.GetUsersAsync());
        }

        [HttpPost("AddUser")]
        public async Task<IActionResult> AddUserAsync(UserDto adduser)
        {
            await userRepositarory.AddUserAsync(adduser);
            return Ok("New User Created");
        }

        [HttpGet("GetUserbyID/{id:int}")]
        public async Task<IActionResult> GetUserByIdAsync(int id)
        {
            var user = await userRepositarory.GetUserbyIDAsync(id);
            if(user == null) return NotFound();
            var userdto = mapper.Map<Models.DTO.UserDto.UserDto>(user);
            return Ok(userdto);
        }

        [HttpDelete("DeleteUser/{id:int}")]
        public async Task<IActionResult> DeleteUserAsync([FromRoute]int id)
        {
            await userRepositarory.DeleteUserAsync(id);
            return Ok("User Deleted");
        }
        
        [HttpPut("UpdateUser/{id:int}")]
        public async Task<IActionResult> UpdateUserAsync([FromRoute] int id, [FromBody] UserDto userDto)
        {
            var user = mapper.Map<User>(userDto);
            if (user == null) return NotFound();
            user = await userRepositarory.UpdateUserAsync(id,user);
            var userdt = mapper.Map<UserDto>(user);
            return Ok("User Updated");
        }
    }
}
