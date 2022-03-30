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
    public class MassagesController : ControllerBase
    {
        private readonly DataBaseContext _context;

        public MassagesController(DataBaseContext context)
        {
            _context = context;
        }

        // GET: api/Massages
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Massages>>> GetMassages()
        {
            return await _context.Massages.ToListAsync();
        }

        // GET: api/Massages/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Massages>> GetMassages(int id)
        {
            var massages = await _context.Massages.FindAsync(id);

            if (massages == null)
            {
                return NotFound();
            }

            return massages;
        }

        // PUT: api/Massages/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMassages(int id, Massages massages)
        {
            if (id != massages.Id_massages)
            {
                return BadRequest();
            }

            _context.Entry(massages).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MassagesExists(id))
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

        // POST: api/Massages
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Massages>> PostMassages(Massages massages)
        {
            _context.Massages.Add(massages);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMassages", new { id = massages.Id_massages }, massages);
        }

        // DELETE: api/Massages/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMassages(int id)
        {
            var massages = await _context.Massages.FindAsync(id);
            if (massages == null)
            {
                return NotFound();
            }

            _context.Massages.Remove(massages);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MassagesExists(int id)
        {
            return _context.Massages.Any(e => e.Id_massages == id);
        }
    }
}
