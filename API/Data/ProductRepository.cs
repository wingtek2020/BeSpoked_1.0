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
    public class ProductRepository(DataContext context) : IProductRepository
    {
        public Task<AppUser?> GetProduct(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Product?> GetProductAsync(int id)
        {
            return await context.Products
                .Where(x => x.Id == id)
                .SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await context.Products
                .ToListAsync();
        }
        public async Task<bool> SaveAllAsync()
        {

            return await context.SaveChangesAsync() > 0;
        }

        public void Update(Product product)
        {
            context.Entry(product).State = EntityState.Modified;

        }

        Task<IEnumerable<Product[]>> IProductRepository.GetProductsAsync()
        {
            throw new System.NotImplementedException();
        }
    }

}
