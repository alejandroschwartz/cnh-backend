using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiCNH.Context;
using ApiCNH.Models;

namespace ApiCNH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicionesController : ControllerBase
    {
        private readonly MedicionesContext _context;

        public MedicionesController(MedicionesContext context)
        {
            _context = context;
        }

        // GET: api/Mediciones
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Mediciones>>> GetMediciones()
        {
            return await _context.Mediciones.ToListAsync();
        }

        // GET: api/Mediciones/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Mediciones>> GetMediciones(long id)
        {
            var mediciones = await _context.Mediciones.FindAsync(id);

            if (mediciones == null)
            {
                return NotFound();
            }

            return mediciones;
        }

        // PUT: api/Mediciones/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMediciones(long id, Mediciones mediciones)
        {
            if (id != mediciones.Id)
            {
                return BadRequest();
            }

            _context.Entry(mediciones).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MedicionesExists(id))
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

        // POST: api/Mediciones
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Mediciones>> PostMediciones(Mediciones mediciones)
        {
            _context.Mediciones.Add(mediciones);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMediciones", new { id = mediciones.Id }, mediciones);
        }

        // DELETE: api/Mediciones/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMediciones(long id)
        {
            var mediciones = await _context.Mediciones.FindAsync(id);
            if (mediciones == null)
            {
                return NotFound();
            }

            _context.Mediciones.Remove(mediciones);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MedicionesExists(long id)
        {
            return _context.Mediciones.Any(e => e.Id == id);
        }
    }
}
