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
    public class ProductRepository(DataContext context, IMapper mapper) : IProductRepository
    {
        public Task<AppUser?> GetProduct(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Product?> GetProductAsync(int id)
        {
            return await context.Products
                .Where(x => x.ProductId == id)
                .SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<ProductDTO>> GetProductsAsync()
        {
            return await context.Products
               .Where(x => x.Active)
               .ProjectTo<ProductDTO>(mapper.ConfigurationProvider)
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
    }

}
