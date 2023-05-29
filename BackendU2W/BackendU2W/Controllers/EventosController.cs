using BackendU2W.DbContext;
using BackendU2W.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackendU2W.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventosController : ControllerBase
    {
        public readonly ApplicationDbContext _contexto;

        public EventosController(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }

        // GET: api/<EventosController>
        [HttpGet]
        public async Task<IEnumerable<Eventos>> Get()
            => await _contexto.Eventos.Where(eventos => eventos.delete_date == null).OrderByDescending(x => x.fechaInicio).ToListAsync();

        // GET api/<EventosController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Eventos), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(int id)
        {
            var eventos = await _contexto.Eventos.FindAsync(id);
            return eventos == null || eventos.delete_date != null ? NotFound() : Ok(eventos);
        }

        [HttpGet("/api/eventos/count/comunidadId/{id}")]
        public async Task<IActionResult> GetCountByComunidadId(int id)
        {
            return Ok(_contexto.Eventos.Where(evento => evento.delete_date == null && evento.id_com == id).Count());
        }

        [HttpGet("/api/eventos/count")]
        public IActionResult GetCount()
        {
            return Ok(_contexto.Eventos.Where(evento => evento.delete_date == null).Count());
        }

        [HttpGet("/api/eventos/paginado/{pagina}/{pageSize}")]
        public IActionResult GetPaginado([FromRoute] int pagina, [FromRoute] int pageSize)
        {
            List<Eventos> eventos = (_contexto.Eventos
                .Where(r => r.delete_date == null)
                .Skip(pagina * pageSize)
                .Include(r => r.Imagen)
                .Include(r => r.comunidad)
                .Take(pageSize)
                .ToList());

            return Ok(eventos);
        }

        // GET: api/<EventosController>
        [HttpGet("/api/eventos/proximosXdias/porComunidad/{numDias}/{comunidadId}")]
        public IActionResult GetProximosXDias([FromRoute] int numDias, [FromRoute] int comunidadId)
        {
            DateTime fechaProximosXDias = DateTime.Now.AddDays(numDias);

            List<Eventos> eventos = (_contexto.Eventos
                .Where(r => r.delete_date == null && r.id_com == comunidadId && r.fechaInicio <= fechaProximosXDias)
                .Include(r => r.Imagen)
                .ToList());

            if (eventos.Count > 0)
                return Ok(eventos.OrderByDescending(x => x.fechaInicio));
            else
                return NotFound();
        }

        // GET: api/<EventosController>
        [HttpGet("/api/eventos/enCurso/porComunidad/{comunidadId}")]
        public IActionResult GetEventosEnCurso([FromRoute] int comunidadId)
        {
            DateTime fechaActual = DateTime.Now;

            List<Eventos> eventos = (_contexto.Eventos
                .Where(r => r.delete_date == null && r.id_com == comunidadId && r.fechaInicio <= fechaActual && r.fechaFin > fechaActual)
                .Include(r => r.Imagen)
                .ToList());

            if (eventos.Count > 0)
                return Ok(eventos.OrderByDescending(x => x.fechaInicio));
            else
                return NotFound();
        }

        // GET api/<EventosController>/comunidadId/5
        [HttpGet("{id}/comunidadId")]
        [ProducesResponseType(typeof(Eventos), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IEnumerable<Eventos>> GetByIdComunidad(int id)
            => await _contexto.Eventos.Where(evento => evento.id_com == id && evento.delete_date == null).Include(r => r.Imagen).ToListAsync();

        // POST api/<EventosController>
        [HttpPost]
        public async Task<IActionResult> Post(Eventos evento)
        {
            evento.create_date = DateTime.Now;
            await _contexto.Eventos.AddAsync(evento);
            await _contexto.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = evento.id_evento }, evento);
        }

        // PUT api/<EventosController>/5
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Put(int id, Eventos evento)
        {
            if (id != evento.id_evento) return BadRequest();

            evento.last_modified = DateTime.Now;

            _contexto.Entry(evento).State = EntityState.Modified;
            await _contexto.SaveChangesAsync();

            return NoContent();
        }

        // PUT api/<EventosController>/5/delete
        [HttpPut("{id}/delete")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var eventoToDelete = await _contexto.Eventos.FindAsync(id);

            if (eventoToDelete == null) return NotFound();

            eventoToDelete.delete_date = DateTime.Now;

            _contexto.Entry(eventoToDelete).State = EntityState.Modified;
            await _contexto.SaveChangesAsync();

            return NoContent();
        }
    }
}
