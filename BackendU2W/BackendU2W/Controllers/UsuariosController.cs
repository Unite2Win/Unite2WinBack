using BackendU2W.DbContext;
using BackendU2W.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackendU2W.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        public readonly ApplicationDbContext _contexto;

        public UsuariosController(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }

        // GET: api/<UsuariosController>
        [HttpGet]
        public async Task<IEnumerable<Usuarios>> Get()
            => await _contexto.Usuarios.Where(usuario => usuario.delete_date == null).ToListAsync();

        // GET api/<UsuariosController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Usuarios), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(int id)
        {
            var usuario = await _contexto.Usuarios.FindAsync(id);
            return usuario == null || usuario.delete_date != null ? NotFound() : Ok(usuario);
        }

        //[HttpGet("comunidadesUsuario/{id}")]
        //[ProducesResponseType(typeof(ComunidadesUsuarios), StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //public async Task<IEnumerable<ComunidadesUsuarios>> GetByIdUsuario(int id)
        //    => await _contexto.ComunidadesUsuarios.Where(comunidadUsuarios => comunidadUsuarios.delete_date == null && comunidadUsuarios.id_usu == id).ToListAsync();

        // POST api/<UsuariosController>
        [HttpPost]
        public async Task<IActionResult> Post(Usuarios usuario)
        {
            usuario.create_date = DateTime.Now;
            await _contexto.Usuarios.AddAsync(usuario);
            await _contexto.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = usuario.id_usu }, usuario);
        }

        // PUT api/<UsuariosController>/5
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Put(int id, Usuarios usuario)
        {
            if (id != usuario.id_usu) return BadRequest();

            usuario.last_modified = DateTime.Now;

            _contexto.Entry(usuario).State = EntityState.Modified;
            await _contexto.SaveChangesAsync();

            return NoContent();
        }

        // DELETE api/<UsuariosController>/5
        [HttpPut("{id}/delete")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var usuarioToDelete = await _contexto.Usuarios.FindAsync(id);
            
            if (usuarioToDelete == null) return NotFound();

            usuarioToDelete.delete_date = DateTime.Now;

            _contexto.Entry(usuarioToDelete).State = EntityState.Modified;
            await _contexto.SaveChangesAsync();

            return NoContent();
        }
    }
}
