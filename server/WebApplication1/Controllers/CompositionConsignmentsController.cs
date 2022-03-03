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
    public class CompositionConsignmentsController : ControllerBase
    {
        private readonly DataBaseContext _context;

        public CompositionConsignmentsController(DataBaseContext context)
        {
            _context = context;
        }

        // GET: api/CompositionConsignments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CompositionConsignment>>> GetcompositionConsignment()
        {
            return await _context.compositionConsignment.ToListAsync();
        }

        // GET: api/CompositionConsignments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CompositionConsignment>> GetCompositionConsignment(int id)
        {
            var compositionConsignment = await _context.compositionConsignment.FindAsync(id);

            if (compositionConsignment == null)
            {
                return NotFound();
            }

            return compositionConsignment;
        }

        // PUT: api/CompositionConsignments/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCompositionConsignment(int id, CompositionConsignment compositionConsignment)
        {
            if (id != compositionConsignment.Id)
            {
                return BadRequest();
            }

            _context.Entry(compositionConsignment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CompositionConsignmentExists(id))
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

        // POST: api/CompositionConsignments
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CompositionConsignment>> PostCompositionConsignment(CompositionConsignment compositionConsignment)
        {
            _context.compositionConsignment.Add(compositionConsignment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCompositionConsignment", new { id = compositionConsignment.Id }, compositionConsignment);
        }

        // DELETE: api/CompositionConsignments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompositionConsignment(int id)
        {
            var compositionConsignment = await _context.compositionConsignment.FindAsync(id);
            if (compositionConsignment == null)
            {
                return NotFound();
            }

            _context.compositionConsignment.Remove(compositionConsignment);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CompositionConsignmentExists(int id)
        {
            return _context.compositionConsignment.Any(e => e.Id == id);
        }
    }
}
