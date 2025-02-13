using API.DTO;
using API.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Interfaces
{
    public interface IAppUserRepository
    {
        void Update(AppUser user);
        Task<bool> SaveAllAsync();
        Task<IEnumerable<UserDTO>> GetUsersAsync();
        Task<AppUser?> GetUserById(int id);
        Task<AppUser?> GetUserByUsernameAsync(string username);
        Task<UserDTO?> GetUserAsync(string username);
    }
}
