using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController
    {
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers() => await _context.Users.ToListAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id) => await _context.Users.FindAsync(id);
    }
}
