using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Data;
using API.Entities;
using API.Interfaces;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUsersController(IAppUserRepository userRepository) : ControllerBase
    {
        // GET: api/AppUsers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            var users = await userRepository.GetUsersAsync();

            return Ok(users);
        }

     
        // GET: api/AppUsers/5
        [HttpGet("{username}")]
        public async Task<ActionResult<AppUser>> GetAppUser(string username)
        {
            var appUser = await userRepository.GetUserByUsernameAsync(username);

            if (appUser == null)
            {
                return NotFound();
            }

            return Ok(appUser);
        }
       
    }
}
