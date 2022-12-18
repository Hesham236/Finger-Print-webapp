﻿using AutoMapper;
using Finger_Print_WebApi.Data;
using Finger_Print_WebApi.Models.Domain;
using Finger_Print_WebApi.Models.DTO.UserDto;
using Finger_Print_WebApi.Repos.IRepo;
using Microsoft.EntityFrameworkCore;

namespace Finger_Print_WebApi.Repos.Repo
{
    public class UserReposiatory : IUserRepositarory
    {
        private readonly FingerPrintDBContext fingerPrintDBContext;

        public UserReposiatory(FingerPrintDBContext fingerPrintDBContext)
        {
            this.fingerPrintDBContext = fingerPrintDBContext;
        }


        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            return await fingerPrintDBContext.Users.ToListAsync();
        }

        public async Task<User> AddUser(UserDto user)
        {
          var userdto = new Models.Domain.User()
          {
                name = user.name,
                password = user.password,
                authority = user.authority,
          };
          var result = await fingerPrintDBContext.Users.AddAsync(userdto);
          await fingerPrintDBContext.SaveChangesAsync();
          return userdto;
        }

        public async Task<User> GetUserbyID(int id)
        {
            return await fingerPrintDBContext.Users.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
