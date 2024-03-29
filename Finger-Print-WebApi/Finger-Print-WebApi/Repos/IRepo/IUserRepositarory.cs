﻿using Finger_Print_WebApi.Models.Domain;
using Finger_Print_WebApi.Models.DTO.UserDto;

namespace Finger_Print_WebApi.Repos.IRepo
{
    public interface IUserRepositarory
    {
        Task<IEnumerable<User>> GetUsersAsync();
        Task<User> AddUserAsync(UserDto user);
        Task<User> GetUserbyIDAsync(int id);
        Task<User> DeleteUserAsync(int id);
        Task<User> UpdateUserAsync(int id , User user);
    }
}
