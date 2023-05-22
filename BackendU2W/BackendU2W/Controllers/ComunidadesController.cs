﻿using BackendU2W.DbContext;
using BackendU2W.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackendU2W.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComunidadesController : Controller
    {
        public readonly ApplicationDbContext _contexto;

        public ComunidadesController(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }

        // GET: api/<ComunidadesController>
        [HttpGet]
        public async Task<IEnumerable<Comunidades>> Get()
            => await _contexto.Comunidades.Where(comunidad => comunidad.delete_date == null).ToListAsync();

        // GET api/<ComunidadesController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Comunidades), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(int id)
        {
            List<Comunidades> comunidades = (_contexto.Comunidades
                .Where(r => r.delete_date == null && r.id_com == id)
                .Include(r => r.picture)
                .Include(r => r.banner)
                .ToList());
            return comunidades[0] == null || comunidades[0].delete_date != null ? NotFound() : Ok(comunidades[0]);
        }

        //PAGINADO
        [HttpGet("/api/comunidades/count")]
        public IActionResult GetCount()
        {
            return Ok(_contexto.Comunidades.Where(comunidad => comunidad.delete_date == null).Count());
        }

        [HttpGet("/api/comunidades/paginado/{pagina}/{pageSize}")]
        public IActionResult GetPaginado([FromRoute] int pagina, [FromRoute] int pageSize)
        {
            List<Comunidades> idiomas = (_contexto.Comunidades
                .Where(r => r.delete_date == null)
                .Skip(pagina * pageSize)
                .Include(r => r.picture)
                .Include(r => r.banner)
                .Take(pageSize)
                .ToList());

            return Ok(idiomas);
        }

        //[HttpGet("usuariosComunidad/{id}")]
        //[ProducesResponseType(typeof(ComunidadesUsuarios), StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //public async Task<IEnumerable<ComunidadesUsuarios>> GetByIdComunidad(int id)
        //    => await _contexto.ComunidadesUsuarios.Where(comunidadUsuarios => comunidadUsuarios.delete_date == null && comunidadUsuarios.id_com == id).ToListAsync();

        // POST api/<ComunidadesController>
        [HttpPost]
        public async Task<IActionResult> Post(Comunidades comunidad)
        {
            comunidad.create_date = DateTime.Now;
            await _contexto.Comunidades.AddAsync(comunidad);
            await _contexto.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = comunidad.id_com }, comunidad);
        }

        // PUT api/<ComunidadesController>/5
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Put(int id, Comunidades comunidad)
        {
            if (id != comunidad.id_com) return BadRequest();

            comunidad.last_modified = DateTime.Now;

            _contexto.Entry(comunidad).State = EntityState.Modified;
            await _contexto.SaveChangesAsync();

            return Ok(comunidad);
        }

        // DELETE api/<ComunidadesController>/5
        [HttpPut("{id}/delete")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var comunidadToDelete = await _contexto.Comunidades.FindAsync(id);

            if (comunidadToDelete == null) return NotFound();

            comunidadToDelete.delete_date = DateTime.Now;

            _contexto.Entry(comunidadToDelete).State = EntityState.Modified;
            await _contexto.SaveChangesAsync();

            return NoContent();
        }
    }
}
