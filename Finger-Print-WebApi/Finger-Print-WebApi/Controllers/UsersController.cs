using AutoMapper;
using Finger_Print_WebApi.Models.Domain;
using Finger_Print_WebApi.Models.DTO;
using Finger_Print_WebApi.Repos.IRepo;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult GetUsersAsync() 
        {
            return Ok(userRepositarory.GetUsersAsync().Result);
        }
        [HttpPost("AddUser")]
        public async Task<IActionResult> AddUser(User adduser)
        {
            var user = new Models.Domain.User()
            {
                name = adduser.name,
                password= adduser.password,
                authority= adduser.authority,
            };

            user = await userRepositarory.AddUser(user);

            var userdto = new Models.DTO.UserDto()
            {
                name= user.name,
                password = user.password,
                authority= user.authority,
            };

            return Ok("New User Created");

        }
        //[HttpDelete("DeleteUser")]
        //[HttpPut("UpdateUser")]
    }
}
