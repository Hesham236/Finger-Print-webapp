using AutoMapper;
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

        public async Task<User> AddUserAsync(UserDto user)
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

        public async Task<User> GetUserbyIDAsync(int id)
        {
            return await fingerPrintDBContext.Users.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<User> DeleteUserAsync(int id)
        {
            var user = await fingerPrintDBContext.Users.FirstOrDefaultAsync(x => x.Id == id);
            if (user ==null) return null;
            fingerPrintDBContext.Users.Remove(user);
            await fingerPrintDBContext.SaveChangesAsync();
            return user; 
        }

        public async Task<User> UpdateUserAsync(int id, User user)
        {
           var founduser = await fingerPrintDBContext.Users.FirstOrDefaultAsync(x =>x.Id == id);
           if (founduser == null) return null;

           founduser.name = user.name;
           founduser.password = user.password;
           founduser.authority = user.authority;

           await fingerPrintDBContext.SaveChangesAsync();
           return user;
        }
    }
}
