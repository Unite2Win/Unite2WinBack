using BackendU2W.DbContext;
using BackendU2W.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackendU2W.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObjetivosController : ControllerBase
    {
        public readonly ApplicationDbContext _contexto;

        public ObjetivosController(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }

        // GET: api/<ObjetivosController>
        [HttpGet]
        public async Task<IEnumerable<Objetivos>> Get()
            => await _contexto.Objetivos.Where(objetivo => objetivo.delete_date == null).ToListAsync();

        // GET api/<ObjetivosController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Objetivos), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(int id)
        {
            var objetivo = await _contexto.Objetivos.FindAsync(id);
            return objetivo == null || objetivo.delete_date != null ? NotFound() : Ok(objetivo);
        }

        // GET api/<ObjetivosController>/usuarioId/5
        [HttpGet("{id}/usuarioId")]
        [ProducesResponseType(typeof(Objetivos), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IEnumerable<Objetivos>> GetByIdUsuario(int id)
            => await _contexto.Objetivos.Where(objetivo => objetivo.id_usu == id && objetivo.delete_date == null).ToListAsync();

        // POST api/<ObjetivosController>
        [HttpPost("API/post")]
            public async Task<IActionResult> Post([FromBody]Objetivos objetivo)
        {
            objetivo.create_date = DateTime.Now;
            await _contexto.Objetivos.AddAsync(objetivo);
            await _contexto.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = objetivo.id_obj }, objetivo);
        }

        // PUT api/<ObjetivosController>/5
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Put(int id, Objetivos objetivo)
        {
            if (id != objetivo.id_obj) return BadRequest();

            objetivo.last_modified = DateTime.Now;

            _contexto.Entry(objetivo).State = EntityState.Modified;
            await _contexto.SaveChangesAsync();

            return NoContent();
        }

        // PUT api/<ObjetivosController>/5/delete
        [HttpPut("delete")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete([FromBody]int id)
        {
            var objetivoToDelete = await _contexto.Objetivos.FindAsync(id);

            if (objetivoToDelete == null) return NotFound();

            objetivoToDelete.delete_date = DateTime.Now;

            _contexto.Entry(objetivoToDelete).State = EntityState.Modified;
            await _contexto.SaveChangesAsync();

            return NoContent();
        }
    }
}
