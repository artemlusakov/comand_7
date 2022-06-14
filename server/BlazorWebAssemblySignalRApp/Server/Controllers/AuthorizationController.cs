using Microsoft.AspNetCore.Mvc;
#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using BlazorWebAssemblySignalRApp.Data;
using BlazorWebAssemblySignalRApp.Models;
using BlazorWebAssemblySignalRApp.Server.Valudation;

namespace BlazorWebAssemblySignalRApp.Server.Controllers

{
 [Route("api/[controller]")]
    [ApiController]
public class AuthorizationController : Controller
    {
        private readonly DataBaseContext _context;
        private readonly EmailValidation _validation;

        public AuthorizationController(DataBaseContext context)
        {
            _validation = new EmailValidation();
            _context = context;

        }

        // POST: api/Users
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User testUser)
        {
            if (!_validation.IsValid(testUser.Email))
            {
                return Problem("Incorrect Email");
            }


            var user = await _context.User.FindAsync(testUser.Id_user);

            if (user == null && testUser.Email == user.Email && testUser.Password == user.Password)
            {
                return NotFound();
            }
            return NoContent();
        }

    }
}
