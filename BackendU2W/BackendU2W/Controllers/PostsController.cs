using BackendU2W.DbContext;
using BackendU2W.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackendU2W.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : Controller
    {
        public readonly ApplicationDbContext _contexto;

        public PostsController(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }

        // GET: api/<PostsController>
        [HttpGet]
        public async Task<IEnumerable<Posts>> Get()
            => await _contexto.Posts.Where(post => post.delete_date == null).ToListAsync();

        // GET api/<PostsController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Posts), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(int id)
        {
            var post = await _contexto.Posts.FindAsync(id);
            return post == null || post.delete_date != null ? NotFound() : Ok(post);
        }

        [HttpPost("posts/getbyid/comunidadesUsuarios/array")]
        public async Task<IActionResult> GetByIdArrayCU([FromBody] int[] listaIds)
        {
            List<Posts> posts = new List<Posts>();
            foreach (int id in listaIds)
            {
                List<Posts> postsAux = await _contexto.Posts.Include(post => post.imagen).Where(u => u.id_com_usu == id && u.delete_date == null).ToListAsync();
                if (postsAux.Any())
                    postsAux.ForEach(post => posts.Add(post));
            }

            if (posts.Count <= 0)
                return NotFound();
            else
                return Ok(posts.OrderByDescending(x => x.create_date).Take(20));
        }

        [HttpPost("posts/getbyid/comunidadesUsuarios/array/multimedia")]
        public async Task<IActionResult> GetByIdArrayCUMultimedia([FromBody] int[] listaIds)
        {
            List<Posts> posts = new List<Posts>();
            foreach (int id in listaIds)
            {
                List<Posts> postsAux = await _contexto.Posts.Include(post => post.imagen).Where(u => u.id_com_usu == id && u.delete_date == null && u.imagen != null).ToListAsync();
                if (postsAux.Any())
                    postsAux.ForEach(post => posts.Add(post));
            }

            if (posts.Count <= 0)
                return NotFound();
            else
                return Ok(posts.OrderByDescending(x => x.create_date).Take(20));
        }

        [HttpGet("{id}/comunidadUsuariosId")]
        [ProducesResponseType(typeof(Posts), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IEnumerable<Posts>> GetByIdPost(int id)
            => await _contexto.Posts.Where(post => post.id_com_usu == id && post.delete_date == null).ToListAsync();

        // POST api/<PostsController>
        [HttpPost]
        public async Task<IActionResult> Post(Posts post)
        {
            post.create_date = DateTime.Now;
            await _contexto.Posts.AddAsync(post);
            await _contexto.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = post.id_post }, post);
        }

        // PUT api/<PostsController>/5
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Put(int id, Posts post)
        {
            if (id != post.id_post) return BadRequest();

            post.last_modified = DateTime.Now;

            _contexto.Entry(post).State = EntityState.Modified;
            await _contexto.SaveChangesAsync();

            return NoContent();
        }

        // DELETE api/<PostsController>/5
        [HttpPut("{id}/delete")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var postToDelete = await _contexto.Posts.FindAsync(id);

            if (postToDelete == null) return NotFound();

            postToDelete.delete_date = DateTime.Now;

            _contexto.Entry(postToDelete).State = EntityState.Modified;
            await _contexto.SaveChangesAsync();

            return NoContent();
        }
    }
}
