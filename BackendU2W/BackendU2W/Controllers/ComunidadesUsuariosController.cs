using BackendU2W.DbContext;
using BackendU2W.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackendU2W.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComunidadesUsuariosController : ControllerBase
    {
        public readonly ApplicationDbContext _contexto;

        public ComunidadesUsuariosController(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }

        // GET: api/<ComunidadesController>
        [HttpGet]
        public async Task<IEnumerable<ComunidadesUsuarios>> Get()
            => await _contexto.ComunidadesUsuarios.Where(comunidadUsuarios => comunidadUsuarios.delete_date == null).ToListAsync();

        // GET api/<ComunidadesController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ComunidadesUsuarios), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(int id)
        {
            var comunidadUsuarios = await _contexto.ComunidadesUsuarios.FindAsync(id);
            return comunidadUsuarios == null || comunidadUsuarios.delete_date != null ? NotFound() : Ok(comunidadUsuarios);
        }

        // POST api/<ComunidadesController>
        [HttpPost]
        public async Task<IActionResult> Post(ComunidadesUsuarios comunidadUsuarios)
        {
            comunidadUsuarios.create_date = DateTime.Now;
            await _contexto.ComunidadesUsuarios.AddAsync(comunidadUsuarios);
            await _contexto.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = comunidadUsuarios.id_com }, comunidadUsuarios);
        }

        // PUT api/<ComunidadesController>/5
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Put(int id, ComunidadesUsuarios comunidadUsuarios)
        {
            if (id != comunidadUsuarios.id_com_usu) return BadRequest();

            comunidadUsuarios.last_modified = DateTime.Now;

            _contexto.Entry(comunidadUsuarios).State = EntityState.Modified;
            await _contexto.SaveChangesAsync();

            return NoContent();
        }

        // DELETE api/<ComunidadesController>/5
        [HttpPut("{id}/delete")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var comunidadUsuariosToDelete = await _contexto.ComunidadesUsuarios.FindAsync(id);

            if (comunidadUsuariosToDelete == null) return NotFound();

            comunidadUsuariosToDelete.delete_date = DateTime.Now;

            _contexto.Entry(comunidadUsuariosToDelete).State = EntityState.Modified;
            await _contexto.SaveChangesAsync();

            return NoContent();
        }
    }
}
