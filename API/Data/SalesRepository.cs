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

       
        public async Task<IEnumerable<SaleDTO>> GetSalesAsync()
        {
            var sales = await context.Sales
                .ProjectTo<SaleDTO>(mapper.ConfigurationProvider)
                .ToListAsync();

            foreach (var sale in sales)
            {
                var username = sale.SalesRepName;
                //get commission rate from sales rep
                var salesRepId = context.Users
                    .Where(x => x.UserName == username)
                    .Select(x => x.AppUserId)
                    .FirstOrDefault();

                var comm = context.UserCommissions
                        .Where(x => x.Active == true)
                        .Where(x => x.SalesRepId == salesRepId).FirstOrDefault();
                if (comm != null)
                {
                    sale.Commission = comm.CommissionPercentage * sale.ProductSoldPrice;
                }

            };

            return sales;

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
