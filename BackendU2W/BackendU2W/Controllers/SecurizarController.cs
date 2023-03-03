using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.EntityFrameworkCore;
using BackendU2W.DbContext;
using BackendU2W.Models;
using U2WAutenticacion;

namespace APIReservas.Controllers
{
    [Route("api/seguridad")]
    [ApiController]
    public class SecurizarController : ControllerBase
    {
        public IConfiguration _configuration;
        private readonly ApplicationDbContext _context;


        public SecurizarController(ApplicationDbContext context, IConfiguration config)
        {
            _context = context;
            _configuration = config;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Usuarios _userData)
        {
            if (_userData != null && _userData.nick != null && _userData.password != null)
            {

                if (AutenticarUsuario.UsuarioAutenticadoAsync(_userData.nick, _userData.password, _context).Result)
                {
                    var userCompleto = await _context.Usuarios.FirstOrDefaultAsync(u => u.nick == _userData.nick && u.password == _userData.password);

                    var claims = new[] {
                        new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                        new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                        new Claim("UserId", userCompleto.id_usu.ToString()),
                        new Claim("DisplayName", userCompleto.nick),
                        new Claim("Nivel", userCompleto.level.ToString()),
                        new Claim("Activo", userCompleto.active.ToString())

                    };

                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
                    var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                    var token = new JwtSecurityToken(
                        _configuration["Jwt:Issuer"],
                        _configuration["Jwt:Audience"],
                        claims,
                        expires: DateTime.UtcNow.AddMinutes(60),
                        signingCredentials: signIn);

                    var tokenString = new JwtSecurityTokenHandler().WriteToken(token);

                    return Ok(new JwtSecurityTokenHandler().WriteToken(token));
                    //return Ok(new AuthenticatedResponse { User_ID = Convert.ToString(userCompleto.id_usu) ,Token = tokenString });
                    //return Ok(token);
                }
                else
                {
                    return Unauthorized();
                }

            }
            else
            {
                return BadRequest("No user info found");
            }
        }
    }

    public class Response
    {
        public long id { get; set; }
        public int expiresIn { get; set; }
        public JwtSecurityTokenHandler? token {get; set;}
    }
}
