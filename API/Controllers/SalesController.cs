using API.Entities;
using API.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController(ISalesRepository salesRepository) : ControllerBase
    {
        // GET: api/Sales
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sale>>> GetSales()
        {
            var sales = await salesRepository.GetSalesAsync();

            return Ok(sales);
        }



        [HttpGet("{id}")]
        public async Task<ActionResult<Sale>> GetSale(int id)
        {
            var sale = await salesRepository.GetSale(id);

            if (sale == null)
            {
                return NotFound();
            }

            return Ok(sale);
        }

    }
}
