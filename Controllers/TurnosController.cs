using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SalonTurnos.Api.Data;
using SalonTurnos.Api.Models;

namespace SalonTurnos.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurnosController : ControllerBase
    {
        private readonly SalonTurnosContext _context;

        public TurnosController(SalonTurnosContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Turno>>> GetTurnos()
        {
            var turnos = await _context.Turnos.ToListAsync();
            return Ok(turnos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Turno>> GetTurno(int id)
        {
            var turno = await _context.Turnos.FindAsync(id);

            if (turno == null)
                return NotFound();

            return turno;
        }

        [HttpPost]
        public async Task<ActionResult<Turno>> PostTurno(Turno turno)
        {
            if(turno == null)
                return BadRequest();

            _context.Turnos.Add(turno);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTurno), new {id = turno.Id }, turno);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutTurno(int id, Turno turno)
        {
            if (id != turno.Id)
                return BadRequest();

            _context.Entry(turno).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTurno(int id)
        {
            var turno = await _context.Turnos.FindAsync(id);

            if (turno == null)
                return NotFound();

            _context.Turnos.Remove(turno);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
