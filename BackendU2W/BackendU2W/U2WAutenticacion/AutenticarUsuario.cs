using BackendU2W.DbContext;
using BackendU2W.Models;
using Microsoft.EntityFrameworkCore;

namespace U2WAutenticacion
{
    public static class AutenticarUsuario
    {
        public static async Task<bool> UsuarioAutenticadoAsync(String userName, String password, ApplicationDbContext context)
        {
            var user = await GetUserAsync(userName, password, context);
            if (user == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static async Task<Usuarios> GetUserAsync(string userName, string password, ApplicationDbContext context)
        {
            return await context.Usuarios.FirstOrDefaultAsync(u => u.nick == userName && u.password == password);
        }
    }
}