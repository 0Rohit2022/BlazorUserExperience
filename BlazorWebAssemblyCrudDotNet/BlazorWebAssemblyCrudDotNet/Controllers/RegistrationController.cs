using BlazorWebAssemblyCrudDotNet.Data;
using BlazorWebAssemblyCrudDotNet8.Shared.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BCrypt.Net;
using System;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace BlazorWebAssemblyCrudDotNet.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        private readonly DataContext _context;

        public RegistrationController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Registration>>> GetAllUsersAsync()
        {
            return await _context.Registration.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Registration>> AddUserAsync(Registration newUser)
        {
            _context.Add(newUser);
            await _context.SaveChangesAsync();
            return Ok(newUser);
        }

        [HttpPost("login")]
        public IActionResult Login(Registration model)
        {
            var user = _context.Registration.FirstOrDefault(u => u.Email == model.Email);
            if (user != null && BCrypt.Net.BCrypt.Verify(model.Password, user.Password))
            {
                return Ok("Success");
            }
            else
            {
                return Unauthorized();
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Registration>> GetUserByIdAsync(int Id)
        {
            var user = await _context.Registration.FindAsync(Id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteUserAsync(int id)
        {
            var user = await _context.Registration.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.Registration.Remove(user);
            await _context.SaveChangesAsync();

            return Ok("User deleted successfully.");
        }




    }
}
