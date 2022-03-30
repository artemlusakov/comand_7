#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlazorWebAssemblySignalRApp.Data;
using BlazorWebAssemblySignalRApp.Models;

namespace BlazorWebAssemblySignalRApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserToDialogsController : ControllerBase
    {
        private readonly DataBaseContext _context;

        public UserToDialogsController(DataBaseContext context)
        {
            _context = context;
        }

        // GET: api/UserToDialogs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserToDialogs>>> GetUserToDialogs()
        {
            return await _context.UserToDialogs.ToListAsync();
        }

        // GET: api/UserToDialogs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserToDialogs>> GetUserToDialogs(int id)
        {
            var userToDialogs = await _context.UserToDialogs.FindAsync(id);

            if (userToDialogs == null)
            {
                return NotFound();
            }

            return userToDialogs;
        }

        // PUT: api/UserToDialogs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserToDialogs(int id, UserToDialogs userToDialogs)
        {
            if (id != userToDialogs.Id_user_to_dialogs)
            {
                return BadRequest();
            }

            _context.Entry(userToDialogs).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserToDialogsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/UserToDialogs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UserToDialogs>> PostUserToDialogs(UserToDialogs userToDialogs)
        {
            _context.UserToDialogs.Add(userToDialogs);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserToDialogs", new { id = userToDialogs.Id_user_to_dialogs }, userToDialogs);
        }

        // DELETE: api/UserToDialogs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserToDialogs(int id)
        {
            var userToDialogs = await _context.UserToDialogs.FindAsync(id);
            if (userToDialogs == null)
            {
                return NotFound();
            }

            _context.UserToDialogs.Remove(userToDialogs);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserToDialogsExists(int id)
        {
            return _context.UserToDialogs.Any(e => e.Id_user_to_dialogs == id);
        }
    }
}
