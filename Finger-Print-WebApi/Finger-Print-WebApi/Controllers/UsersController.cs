﻿using AutoMapper;
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
            await userRepositarory.AddUser(adduser);
            return Ok("New User Created");
        }

        [HttpGet("GetUserbyID/")]
        public async Task<IActionResult> GetUserByIdAsync(int id)
        {
            var user = await userRepositarory.GetUserbyID(id);
            if(user == null) return NotFound();
            var userdto = mapper.Map<Models.DTO.UserDto.UserDto>(user);
            return Ok(userdto);
        }

        [HttpDelete("DeleteUser")]
        public async Task<IActionResult> DeleteUserAsync([FromRoute]int id)
        {
            await userRepositarory.DeleteUser(id);
            return Ok("User Deleted");
        }
        
        [HttpPut("UpdateUser")]
        public async Task<IActionResult> UpdateUserAsync([FromRoute] int id, [FromBody] UserDto userDto)
        {
            var user = new Models.Domain.User()
            {
                name = userDto.name,
                password= userDto.password,
                authority= userDto.authority,
            };

            if(user == null) return NotFound();

            user = await userRepositarory.UpdateUser(id,user);

            var userdt = new Models.DTO.UserDto.FullUserDto()
            {
                id = user.Id,
                name = user.name,
                password = user.password,
                authority= user.authority,
            };

            return Ok("User Updated");
        }
    }
}
