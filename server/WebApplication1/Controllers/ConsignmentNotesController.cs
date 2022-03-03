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
    public class ConsignmentNotesController : ControllerBase
    {
        private readonly DataBaseContext _context;

        public ConsignmentNotesController(DataBaseContext context)
        {
            _context = context;
        }

        // GET: api/ConsignmentNotes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ConsignmentNote>>> GetConsignmentNote()
        {
            return await _context.ConsignmentNote.ToListAsync();
        }

        // GET: api/ConsignmentNotes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ConsignmentNote>> GetConsignmentNote(int id)
        {
            var consignmentNote = await _context.ConsignmentNote.FindAsync(id);

            if (consignmentNote == null)
            {
                return NotFound();
            }

            return consignmentNote;
        }

        // PUT: api/ConsignmentNotes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConsignmentNote(int id, ConsignmentNote consignmentNote)
        {
            if (id != consignmentNote.Id)
            {
                return BadRequest();
            }

            _context.Entry(consignmentNote).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConsignmentNoteExists(id))
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

        // POST: api/ConsignmentNotes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ConsignmentNote>> PostConsignmentNote(ConsignmentNote consignmentNote)
        {
            _context.ConsignmentNote.Add(consignmentNote);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetConsignmentNote", new { id = consignmentNote.Id }, consignmentNote);
        }

        // DELETE: api/ConsignmentNotes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConsignmentNote(int id)
        {
            var consignmentNote = await _context.ConsignmentNote.FindAsync(id);
            if (consignmentNote == null)
            {
                return NotFound();
            }

            _context.ConsignmentNote.Remove(consignmentNote);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ConsignmentNoteExists(int id)
        {
            return _context.ConsignmentNote.Any(e => e.Id == id);
        }
    }
}
