using BackendU2W.DbContext;
using BackendU2W.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

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
        [HttpGet()]
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

        // GET api/<ComunidadesController>/5
        [HttpGet("comunidadUsuario/usuario/{id}")]
        [ProducesResponseType(typeof(ComunidadesUsuarios), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IEnumerable<ComunidadesUsuarios>> GetByIdUsuario(int id)
        {
            int id_usu = id;
            return await _contexto.ComunidadesUsuarios.Where(comunidadUsuarios => comunidadUsuarios.delete_date == null && comunidadUsuarios.id_usu == id_usu).ToListAsync();
        }

        // GET api/<ComunidadesController>/5
        [HttpGet("comunidadUsuario/comunidad/{id}")]
        [ProducesResponseType(typeof(ComunidadesUsuarios), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IEnumerable<ComunidadesUsuarios>> GetByIdComunidad(int id)
        {
            int id_com = id;
            return await _contexto.ComunidadesUsuarios.Where(comunidadUsuarios => comunidadUsuarios.delete_date == null && comunidadUsuarios.id_com == id_com).ToListAsync();
        }

        //PAGINADO
        [HttpGet("/api/comunidadUsuario/count/comunidad/{comunidadId}")]
        public IActionResult GetCountByComunidad(int comunidadId)
        {
            return Ok(_contexto.ComunidadesUsuarios.Where(comunidadusuario => comunidadusuario.delete_date == null && comunidadusuario.id_com == comunidadId).Count());
        }

        [HttpGet("/api/comunidadUsuario/count/ismiembro/{comunidadId}/{usuarioId}")]
        public IActionResult GetIsMiembro(int comunidadId, int usuarioId)
        {
            var comunidadUsuario = _contexto.ComunidadesUsuarios.Where(comunidadusuario => comunidadusuario.delete_date == null && comunidadusuario.id_com == comunidadId && comunidadusuario.id_usu == usuarioId).FirstOrDefault();
            if (comunidadUsuario == null)
            {
                return Ok(false);
            }
            else
            {
                return Ok(true);
            }
        }

        [HttpGet("/api/comunidadUsuario/{comunidadId}/{usuarioId}")]
        public IActionResult GetByComunidadYUsuario(int comunidadId, int usuarioId)
        {
            var comunidadUsuario = _contexto.ComunidadesUsuarios.Where(comunidadusuario => comunidadusuario.delete_date == null && comunidadusuario.id_com == comunidadId && comunidadusuario.id_usu == usuarioId).FirstOrDefault();
            if (comunidadUsuario == null) return NotFound();
            else return Ok(comunidadUsuario);
        }

        // POST api/<ComunidadesController>
        [HttpPost]
        public async Task<IActionResult> Post(ComunidadesUsuarios comunidadUsuarios)
        {
            comunidadUsuarios.create_date = DateTime.Now;
            await _contexto.ComunidadesUsuarios.AddAsync(comunidadUsuarios);
            await _contexto.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = comunidadUsuarios.id_com_usu }, comunidadUsuarios);
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

            //Vamos a eliminar todos los posts de ese usuario:
            List<Posts> postsUsuarioComunidadToDelete = await _contexto.Posts.Where(postsUsuarioComunidad => postsUsuarioComunidad.delete_date == null && postsUsuarioComunidad.id_com_usu == id).ToListAsync();

            foreach (var item in postsUsuarioComunidadToDelete)
            {
                item.delete_date = DateTime.Now;
            }

            await _contexto.SaveChangesAsync();
            ///Hecho

            return NoContent();
        }
    }
}
