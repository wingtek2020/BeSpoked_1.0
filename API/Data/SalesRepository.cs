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
    public class SalesRepository(DataContext context, IMapper mapper) : ISalesRepository
    {
        public Task<Sale?> GetSale(int id)
        {
            throw new System.NotImplementedException();
        }

       
        public async Task<IEnumerable<SalesDTO>> GetSalesAsync()
        {
            return await context.Sales
               .ProjectTo<SalesDTO>(mapper.ConfigurationProvider)
               .ToListAsync();
        }
        public async Task<bool> SaveAllAsync()
        {

            return await context.SaveChangesAsync() > 0;
        }

        public void Update(Sale sale)
        {
            context.Entry(sale).State = EntityState.Modified;

        }
    }

}
