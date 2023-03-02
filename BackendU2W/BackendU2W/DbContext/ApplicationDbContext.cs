using BackendU2W.Models;
using Microsoft.EntityFrameworkCore;

namespace BackendU2W.DbContext
{
    public class ApplicationDbContext: Microsoft.EntityFrameworkCore.DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opciones) : base(opciones) { }

        public DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var usuario1 = new Usuarios() { id_usu = 1, nick = "Usuario1", password = "12345", picture = "a", active = true, create_date = DateTime.Today };
            var usuario2 = new Usuarios() { id_usu = 2, nick = "Usuario2", password = "12345", picture = "a", level = 10, create_date = DateTime.Today };
            var usuario3 = new Usuarios() { id_usu = 3, nick = "Usuario3", password = "12345", picture = "a", level = 20, active = false, create_date = DateTime.Today };
            var usuario4 = new Usuarios() { id_usu = 4, nick = "Usuario4", password = "12345", picture = "a", level = 30, active = true, create_date = DateTime.Today, delete_date = new DateTime(2023, 01, 23) };
            
            modelBuilder.Entity<Usuarios>().HasData(new Usuarios[] {usuario1,usuario2,usuario3,usuario4});

            base.OnModelCreating(modelBuilder);
        }
        //Cuando crear migraciones (buenas practicas)
        // 1- Cuando se crea una nueva clase (nueva tabla en la bd)
        // 2- Cuando agregue una nueva propiedad (crar un campo nuevo en la bd)
        // 3- Modifique un valor de campo en la clase (modificar campo en bd)

    }
}
