using API.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text.Json;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace API.Data
{
    public class SeedData
    {
        public static async Task SeedRoles(DataContext context)
        {
            if (await context.Roles.AnyAsync()) return;
            var roles = new List<Role>
            {
                new Role { Name = "Admin" },
                new Role { Name = "Customer" },
                new Role { Name = "SalesRep" }
            };

            foreach (var role in roles)
            {
                context.Roles.Add(role);
            }
            await context.SaveChangesAsync();
        }

        public static async Task SeedUsers(DataContext context)
        {
            if (await context.Users.AnyAsync()) return;
            var userData = await File.ReadAllTextAsync("Data/UserSeedData.json");
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var users = JsonSerializer.Deserialize<List<AppUser>>(userData, options);
            if (users == null) return;
            foreach (var user in users)
            {
                
                user.UserName = user.UserName.ToLower();
                context.Users.Add(user);

            }
            await context.SaveChangesAsync();

        }

        public static async Task SeedProducts(DataContext context)
        {
            if (await context.Products.AnyAsync()) return;
            var productData = await File.ReadAllTextAsync("Data/ProductSeedData.json");
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var products = JsonSerializer.Deserialize<List<Product>>(productData, options);
            if (products == null) return;
            foreach (var product in products)
            {
                context.Products.Add(product);
            }
            await context.SaveChangesAsync();
        }


    }
}
