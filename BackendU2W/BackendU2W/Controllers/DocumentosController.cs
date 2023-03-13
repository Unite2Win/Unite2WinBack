using BackendU2W.DbContext;
using BackendU2W.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackendU2W.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentosController : Controller
    {
        public readonly ApplicationDbContext _contexto;

        public DocumentosController(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }

        // GET: api/<DocumentosController>
        [HttpGet]
        public async Task<IEnumerable<Documentos>> Get()
            => await _contexto.Documentos.Where(doc => doc.delete_date == null).ToListAsync();

        // GET api/<DocumentosController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Documentos), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(long id)
        {
            var doc = await _contexto.Documentos.FindAsync(id);
            return doc == null || doc.delete_date != null ? NotFound() : Ok(doc);
        }

        // POST api/<DocumentosController>
        [HttpPost]
        public async Task<IActionResult> Post(Documentos doc)
        {
            doc.create_date = DateTime.Now;
            await _contexto.Documentos.AddAsync(doc);
            await _contexto.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = doc.id_doc }, doc);
        }

        // PUT api/<DocumentosController>/5
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Put(long id, Documentos doc)
        {
            if (id != doc.id_doc) return BadRequest();

            doc.last_modified = DateTime.Now;

            _contexto.Entry(doc).State = EntityState.Modified;
            await _contexto.SaveChangesAsync();

            return NoContent();
        }

        // DELETE api/<DocumentosController>/5
        [HttpPut("{id}/delete")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(long id)
        {
            var docToDelete = await _contexto.Documentos.FindAsync(id);

            if (docToDelete == null) return NotFound();

            docToDelete.delete_date = DateTime.Now;

            _contexto.Entry(docToDelete).State = EntityState.Modified;
            await _contexto.SaveChangesAsync();

            return NoContent();
        }
    }
}
