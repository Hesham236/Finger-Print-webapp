using Finger_Print_WebApi.Models.Domain;
using Finger_Print_WebApi.Models.DTO.UserDto;

namespace Finger_Print_WebApi.Repos.IRepo
{
    public interface IUserRepositarory
    {
        Task<IEnumerable<User>> GetUsersAsync();
        Task<User> AddUser(UserDto user);
        Task<User> GetUserbyID(int id);
        Task<User> DeleteUser(int id);
        Task<User> UpdateUser(int id , User user);
    }
}
