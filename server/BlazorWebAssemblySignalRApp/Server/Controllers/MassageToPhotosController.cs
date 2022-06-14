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
    public class MassageToPhotosController : ControllerBase
    {
        private readonly DataBaseContext _context;

        public MassageToPhotosController(DataBaseContext context)
        {
            _context = context;
        }

        // GET: api/MassageToPhotos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MassageToPhotos>>> GetMassageToPhotos()
        {
            return await _context.MassageToPhotos.ToListAsync();
        }

        // GET: api/MassageToPhotos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MassageToPhotos>> GetMassageToPhotos(int id)
        {
            var massageToPhotos = await _context.MassageToPhotos.FindAsync(id);

            if (massageToPhotos == null)
            {
                return NotFound();
            }

            return massageToPhotos;
        }

        // PUT: api/MassageToPhotos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMassageToPhotos(int id, MassageToPhotos massageToPhotos)
        {
            if (id != massageToPhotos.Photo_id)
            {
                return BadRequest();
            }

            _context.Entry(massageToPhotos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MassageToPhotosExists(id))
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

        // POST: api/MassageToPhotos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MassageToPhotos>> PostMassageToPhotos(MassageToPhotos massageToPhotos)
        {
            _context.MassageToPhotos.Add(massageToPhotos);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (MassageToPhotosExists(massageToPhotos.Photo_id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetMassageToPhotos", new { id = massageToPhotos.Photo_id }, massageToPhotos);
        }

        // DELETE: api/MassageToPhotos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMassageToPhotos(int id)
        {
            var massageToPhotos = await _context.MassageToPhotos.FindAsync(id);
            if (massageToPhotos == null)
            {
                return NotFound();
            }

            _context.MassageToPhotos.Remove(massageToPhotos);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MassageToPhotosExists(int id)
        {
            return _context.MassageToPhotos.Any(e => e.Photo_id == id);
        }
    }
}
