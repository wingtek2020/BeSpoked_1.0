using API.DTO;
using API.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Interfaces
{
    public interface IProductRepository
    {
        void Update(Product product);
        Task<bool> SaveAllAsync();
        Task<IEnumerable<Product[]>> GetProductsAsync();
        Task<AppUser?> GetProduct(int id);
    }
}
