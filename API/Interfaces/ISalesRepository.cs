using API.DTO;
using API.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Interfaces
{
    public interface ISalesRepository
    {
        void Update(Sale sale);
        Task<bool> SaveAllAsync();
        Task<IEnumerable<SaleDTO>> GetSalesAsync();
        Task<Sale?> GetSale(int id);
    }
}
