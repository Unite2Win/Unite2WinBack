using BackendU2W.DbContext;
using BackendU2W.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackendU2W.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanesController : ControllerBase
    {
        public readonly ApplicationDbContext _contexto;

        public PlanesController(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }

        // GET: api/<PlanesController>
        [HttpGet]
        public async Task<IEnumerable<Planes>> Get()
            => await _contexto.Planes.Where(planes => planes.delete_date == null).ToListAsync();

        // GET api/<PlanesController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Planes), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(int id)
        {
            var planes = await _contexto.Planes.FindAsync(id);
            return planes == null ? NotFound() : Ok(planes);
        }

        // GET api/<PlanesController>/comunidadId/5
        [HttpGet("{id}/comunidadId")]
        [ProducesResponseType(typeof(Planes), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IEnumerable<Planes>> GetByIdComunidad(int id)
            => await _contexto.Planes.Where(plan => plan.id_com == id && plan.delete_date == null).ToListAsync();

        // POST api/<PlanesController>
        [HttpPost]
        public async Task<IActionResult> Post(Planes plan)
        {
            plan.create_date = DateTime.Now;
            await _contexto.Planes.AddAsync(plan);
            await _contexto.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = plan.id_plan }, plan);
        }

        // PUT api/<PlanesController>/5
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Put(int id, Planes plan)
        {
            if (id != plan.id_plan) return BadRequest();

            plan.last_modified = DateTime.Now;

            _contexto.Entry(plan).State = EntityState.Modified;
            await _contexto.SaveChangesAsync();

            return NoContent();
        }

        // PUT api/<PlanesController>/5/delete
        [HttpPut("{id}/delete")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var planToDelete = await _contexto.Planes.FindAsync(id);

            if (planToDelete == null) return NotFound();

            planToDelete.delete_date = DateTime.Now;

            _contexto.Entry(planToDelete).State = EntityState.Modified;
            await _contexto.SaveChangesAsync();

            return NoContent();
        }
    }
}
