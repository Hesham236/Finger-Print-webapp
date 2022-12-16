using Finger_Print_WebApi.Models.Domain;
using Finger_Print_WebApi.Models.DTO;

namespace Finger_Print_WebApi.Repos.IRepo
{
    public interface IUserRepositarory
    {
        Task<IEnumerable<User>> GetUsersAsync();
        Task<User> AddUser(User user);
    }
}
