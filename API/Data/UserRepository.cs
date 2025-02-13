using API.DTO;
using API.Entities;
using API.Interfaces;
using AutoMapper.QueryableExtensions;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data
{
    public class UserRepository(DataContext context, IMapper mapper) : IAppUserRepository
    {
        public async Task<UserDTO?> GetUserAsync(string username)
        {
            return await context.Users
                .Where(x => x.UserName == username)
                .ProjectTo<UserDTO>(mapper.ConfigurationProvider)
                .SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<UserDTO>> GetUsersAsync()
        {
            return await context.Users
                .ProjectTo<UserDTO>(mapper.ConfigurationProvider)
                .ToListAsync();
        }

        public async Task<AppUser?> GetUserById(int id)
        {
            return await context.Users
                .FindAsync(id);
        }

        public async Task<AppUser?> GetUserByUsernameAsync(string username)
        {
            return await context.Users
                .Include(x => x.Role)
                .SingleOrDefaultAsync<AppUser>(x => x.UserName == username);
        }

        public async Task<bool> SaveAllAsync()
        {

            return await context.SaveChangesAsync() > 0;
        }

        public void Update(AppUser user)
        {
            context.Entry(user).State = EntityState.Modified;

        }
    }

}
