using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext(DbContextOptions options) : DbContext(options)
    {
        public required DbSet<AppUser> Users { get; set; }
        public required DbSet<Role> Roles { get; set; }
        public required DbSet<Product> Products { get; set; }
        public required DbSet<UserCommission> UserCommissions { get; set; }
    }

}
