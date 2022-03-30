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
    public class DialogsController : ControllerBase
    {
        private readonly DataBaseContext _context;

        public DialogsController(DataBaseContext context)
        {
            _context = context;
        }

        // GET: api/Dialogs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Dialogs>>> GetDialogs()
        {
            return await _context.Dialogs.ToListAsync();
        }

        // GET: api/Dialogs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Dialogs>> GetDialogs(int id)
        {
            var dialogs = await _context.Dialogs.FindAsync(id);

            if (dialogs == null)
            {
                return NotFound();
            }

            return dialogs;
        }

        // PUT: api/Dialogs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDialogs(int id, Dialogs dialogs)
        {
            if (id != dialogs.Id)
            {
                return BadRequest();
            }

            _context.Entry(dialogs).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DialogsExists(id))
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

        // POST: api/Dialogs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Dialogs>> PostDialogs(Dialogs dialogs)
        {
            _context.Dialogs.Add(dialogs);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDialogs", new { id = dialogs.Id }, dialogs);
        }

        // DELETE: api/Dialogs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDialogs(int id)
        {
            var dialogs = await _context.Dialogs.FindAsync(id);
            if (dialogs == null)
            {
                return NotFound();
            }

            _context.Dialogs.Remove(dialogs);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DialogsExists(int id)
        {
            return _context.Dialogs.Any(e => e.Id == id);
        }
    }
}
