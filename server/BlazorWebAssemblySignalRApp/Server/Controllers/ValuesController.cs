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

namespace BlazorWebAssemblySignalRApp.Server.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : Controller
    {
        private readonly DataBaseContext _context;

        public RegistrationController(DataBaseContext context)
        {
            _context = context;
        }

        // POST: api/Users
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User testUser)
        {
            var user = await _context.User.FindAsync(testUser.Id_user);

            if (testUser.Email == user.Email)
            {
                return NotFound();
            }
            return NoContent();
        }

    } т 
