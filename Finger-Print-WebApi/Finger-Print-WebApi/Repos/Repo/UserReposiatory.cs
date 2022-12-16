using Finger_Print_WebApi.Data;
using Finger_Print_WebApi.Models.Domain;
using Finger_Print_WebApi.Models.DTO;
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

        public async Task<User> AddUser(User user)
        {
          var result = await fingerPrintDBContext.Users.AddAsync(user);
          await fingerPrintDBContext.SaveChangesAsync();
          return result.Entity;
        }
    }
}
