#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppkication1.data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConterpartiesController : ControllerBase
    {
        private readonly DataBaseContext _context;

        public ConterpartiesController(DataBaseContext context)
        {
            _context = context;
        }

        // GET: api/Conterparties
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Conterparty>>> GetConterparty()
        {
            return await _context.Conterparty.ToListAsync();
        }

        // GET: api/Conterparties/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Conterparty>> GetConterparty(int id)
        {
            var conterparty = await _context.Conterparty.FindAsync(id);

            if (conterparty == null)
            {
                return NotFound();
            }

            return conterparty;
        }

        // PUT: api/Conterparties/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConterparty(int id, Conterparty conterparty)
        {
            if (id != conterparty.Id)
            {
                return BadRequest();
            }

            _context.Entry(conterparty).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConterpartyExists(id))
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

        // POST: api/Conterparties
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Conterparty>> PostConterparty(Conterparty conterparty)
        {
            _context.Conterparty.Add(conterparty);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetConterparty", new { id = conterparty.Id }, conterparty);
        }

        // DELETE: api/Conterparties/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConterparty(int id)
        {
            var conterparty = await _context.Conterparty.FindAsync(id);
            if (conterparty == null)
            {
                return NotFound();
            }

            _context.Conterparty.Remove(conterparty);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ConterpartyExists(int id)
        {
            return _context.Conterparty.Any(e => e.Id == id);
        }
    }
}
