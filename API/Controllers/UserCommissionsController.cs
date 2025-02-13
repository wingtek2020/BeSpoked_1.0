using API.Entities;
using API.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserCommissionController(ICommissionRepository commissionRepository) : ControllerBase
    {
        // GET: api/Sales
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserCommission>>> GetSales()
        {
            var comm = await commissionRepository.GetUserCommissionsAsync();

            return Ok(comm);
        }



        [HttpGet("{id}")]
        public async Task<ActionResult<UserCommission>> GetUserCommission(int id)
        {
            var comm = await commissionRepository.GetUserCommission(id);

            if (comm == null)
            {
                return NotFound();
            }

            return Ok(comm);
        }

    }
}
