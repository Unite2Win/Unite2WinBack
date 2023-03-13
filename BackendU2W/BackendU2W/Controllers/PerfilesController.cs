using BackendU2W.DbContext;
using BackendU2W.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackendU2W.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerfilesController : Controller
    {
        public readonly ApplicationDbContext _contexto;

        public PerfilesController(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }

        // GET: api/<PerfilesController>
        [HttpGet]
        public async Task<IEnumerable<Perfiles>> Get()
            => await _contexto.Perfiles.Where(perfil => perfil.delete_date == null).ToListAsync();

        // GET api/<PerfilesController>/usuarioId/5
        //[HttpGet("/usuarioId")]
        //[ProducesResponseType(typeof(Perfiles), StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //public async Task<IActionResult> GetUserById(Perfiles perfil)
        //{
        //    var usuario = await _contexto.Usuarios.FindAsync(perfil.usuarioPropietario.id_usu);
        //    return usuario == null || usuario.delete_date != null ? NotFound() : Ok(usuario);
        //}

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Perfiles), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(int id)
        {
            var perfil = await _contexto.Perfiles.FindAsync(id);
            return perfil == null || perfil.delete_date != null ? NotFound() : Ok(perfil);
        }

        // POST api/<PerfilesController>
        [HttpPost]
        public async Task<IActionResult> Post(Perfiles perfil)
        {
            perfil.create_date = DateTime.Now;
            await _contexto.Perfiles.AddAsync(perfil);
            await _contexto.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = perfil.id_perfil }, perfil);
        }

        // PUT api/<PerfilesController>/5
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Put(int id, Perfiles perfil)
        {
            if (id != perfil.id_perfil) return BadRequest();

            perfil.last_modified = DateTime.Now;

            _contexto.Entry(perfil).State = EntityState.Modified;
            await _contexto.SaveChangesAsync();

            return NoContent();
        }

        // DELETE api/<PerfilesController>/5
        [HttpPut("{id}/delete")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var perfilToDelete = await _contexto.Perfiles.FindAsync(id);

            if (perfilToDelete == null) return NotFound();

            perfilToDelete.delete_date = DateTime.Now;

            _contexto.Entry(perfilToDelete).State = EntityState.Modified;
            await _contexto.SaveChangesAsync();

            return NoContent();
        }
    }
}
