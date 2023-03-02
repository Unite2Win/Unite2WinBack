using BackendU2W.Models;
using Microsoft.EntityFrameworkCore;

namespace BackendU2W.DbContext
{
    public class ApplicationDbContext: Microsoft.EntityFrameworkCore.DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opciones) : base(opciones) { }

        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Objetivos> Objetivos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var usuario1 = new Usuarios() { id_usu = 1, nick = "Usuario1", password = "12345", picture = "a", active = true, create_date = DateTime.Today };
            var usuario2 = new Usuarios() { id_usu = 2, nick = "Usuario2", password = "12345", picture = "a", level = 10, create_date = DateTime.Today };
            var usuario3 = new Usuarios() { id_usu = 3, nick = "Usuario3", password = "12345", picture = "a", level = 20, active = false, create_date = DateTime.Today };
            var usuario4 = new Usuarios() { id_usu = 4, nick = "Usuario4", password = "12345", picture = "a", level = 30, active = true, create_date = DateTime.Today, delete_date = new DateTime(2023, 01, 23) };
            
            modelBuilder.Entity<Usuarios>().HasData(new Usuarios[] { usuario1, usuario2, usuario3, usuario4});

            var objetivo1 = new Objetivos() { id_obj = 1, id_usu = 1, nombre = "Objetivo1", descripcion = "Este es el objetivo1", duracion = Duracion.Dia, create_date = DateTime.Today };
            var objetivo2 = new Objetivos() { id_obj = 2, id_usu = 1, nombre = "Objetivo2", duracion = Duracion.Semana, create_date = DateTime.Today };
            var objetivo3 = new Objetivos() { id_obj = 3, id_usu = 3, nombre = "Objetivo3", duracion = Duracion.Semana, create_date = DateTime.Today };
            var objetivo4 = new Objetivos() { id_obj = 4, id_usu = 4, nombre = "Objetivo4", duracion = Duracion.Mes, create_date = DateTime.Today };

            modelBuilder.Entity<Objetivos>().HasData(new Objetivos[] { objetivo1, objetivo2, objetivo3, objetivo4});

            base.OnModelCreating(modelBuilder);
        }
        //Cuando crear migraciones (buenas practicas)
        // 1- Cuando se crea una nueva clase (nueva tabla en la bd)
        // 2- Cuando agregue una nueva propiedad (crar un campo nuevo en la bd)
        // 3- Modifique un valor de campo en la clase (modificar campo en bd)

    }
}
