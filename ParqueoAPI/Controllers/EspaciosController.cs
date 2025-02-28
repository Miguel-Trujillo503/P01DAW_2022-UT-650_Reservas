using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParqueoAPI.Data;
using ParqueoAPI.Models;

namespace ParqueoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EspaciosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EspaciosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Espacios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EspacioParqueo>>> GetEspaciosParqueo()
        {
            return await _context.EspaciosParqueo.ToListAsync();
        }

        // GET: api/Espacios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EspacioParqueo>> GetEspacioParqueo(int id)
        {
            var espacioParqueo = await _context.EspaciosParqueo.FindAsync(id);

            if (espacioParqueo == null)
            {
                return NotFound();
            }

            return espacioParqueo;
        }

        // PUT: api/Espacios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEspacioParqueo(int id, EspacioParqueo espacioParqueo)
        {
            if (id != espacioParqueo.Id)
            {
                return BadRequest();
            }

            _context.Entry(espacioParqueo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EspacioParqueoExists(id))
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

        // POST: api/Espacios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EspacioParqueo>> PostEspacioParqueo(EspacioParqueo espacioParqueo)
        {
            _context.EspaciosParqueo.Add(espacioParqueo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEspacioParqueo", new { id = espacioParqueo.Id }, espacioParqueo);
        }

        // DELETE: api/Espacios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEspacioParqueo(int id)
        {
            var espacioParqueo = await _context.EspaciosParqueo.FindAsync(id);
            if (espacioParqueo == null)
            {
                return NotFound();
            }

            _context.EspaciosParqueo.Remove(espacioParqueo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EspacioParqueoExists(int id)
        {
            return _context.EspaciosParqueo.Any(e => e.Id == id);
        }
    }
}
