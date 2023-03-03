using BackendU2W.Models;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace BackendU2W.DbContext
{
    public class ApplicationDbContext: Microsoft.EntityFrameworkCore.DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opciones) : base(opciones) { }

        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Objetivos> Objetivos { get; set; }
        public DbSet<Planes> Planes { get; set; }
        public DbSet<Comunidades> Comunidades { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var usuario1 = new Usuarios() { id_usu = 1, nick = "Usuario1", password = "12345", picture = "a", active = true, create_date = DateTime.Today };
            var usuario2 = new Usuarios() { id_usu = 2, nick = "Usuario2", password = "12345", picture = "a", level = 10, create_date = DateTime.Today };
            var usuario3 = new Usuarios() { id_usu = 3, nick = "Usuario3", password = "12345", picture = "a", level = 20, active = false, create_date = DateTime.Today };
            var usuario4 = new Usuarios() { id_usu = 4, nick = "Usuario4", password = "12345", picture = "a", level = 30, active = true, create_date = DateTime.Today, delete_date = new DateTime(2023, 01, 23) };
            
            modelBuilder.Entity<Usuarios>().HasData(new Usuarios[] { usuario1, usuario2, usuario3, usuario4});

            var objetivo1 = new Objetivos() { id_obj = 1, id_usu = 1, nombre = "Objetivo1", descripcion = "Este es el objetivo1", duracion = DuracionObjetivos.Dia, create_date = DateTime.Today };
            var objetivo2 = new Objetivos() { id_obj = 2, id_usu = 1, nombre = "Objetivo2", duracion = DuracionObjetivos.Semana, create_date = DateTime.Today };
            var objetivo3 = new Objetivos() { id_obj = 3, id_usu = 3, nombre = "Objetivo3", duracion = DuracionObjetivos.Semana, create_date = DateTime.Today };
            var objetivo4 = new Objetivos() { id_obj = 4, id_usu = 4, nombre = "Objetivo4", duracion = DuracionObjetivos.Mes, create_date = DateTime.Today };

            modelBuilder.Entity<Objetivos>().HasData(new Objetivos[] { objetivo1, objetivo2, objetivo3, objetivo4});

            var comunidad1 = new Comunidades() { id_com = 1, nombre = "Comunidad1", descripcion = "Esta es al comunidad1", clave = "12345", picture = "imagen1", banner = "banner1", create_date = DateTime.Today };
            var comunidad2 = new Comunidades() { id_com = 2, nombre = "Comunidad2", descripcion = "Esta es al comunidad2", clave = "12345", picture = "imagen2", banner = "banner2", create_date = DateTime.Today };
            var comunidad3 = new Comunidades() { id_com = 3, nombre = "Comunidad3", clave = "12345", picture = "imagen3", banner = "banner3", create_date = DateTime.Today };
            var comunidad4 = new Comunidades() { id_com = 4, nombre = "Comunidad4", descripcion = "Esta es al comunidad4", clave = "12345", picture = "imagen4", banner = "banner4", create_date = DateTime.Today };

            modelBuilder.Entity<Comunidades>().HasData(new Comunidades[] { comunidad1, comunidad2, comunidad3, comunidad4 });

            var plan2 = new Planes() { id_plan = 2, id_com = 2, nombre = "Plan2", descripcion = "Este es el plan2", duracion = DuracionPlanes.Semana, create_date = DateTime.Today };
            var plan1 = new Planes() { id_plan = 1, id_com = 3, nombre = "Plan1", descripcion = "Este es el plan1", duracion = DuracionPlanes.Semana, create_date = DateTime.Today };
            var plan3 = new Planes() { id_plan = 3, id_com = 2, nombre = "Plan3", create_date = DateTime.Today };
            var plan4 = new Planes() { id_plan = 4, id_com = 1, nombre = "Plan4", descripcion = "Este es el plan4", duracion = DuracionPlanes.Mes, create_date = DateTime.Today };

            modelBuilder.Entity<Planes>().HasData(new Planes[] { plan1, plan2, plan3, plan4 });

            base.OnModelCreating(modelBuilder);
        }
        //Cuando crear migraciones (buenas practicas)
        // 1- Cuando se crea una nueva clase (nueva tabla en la bd)
        // 2- Cuando agregue una nueva propiedad (crar un campo nuevo en la bd)
        // 3- Modifique un valor de campo en la clase (modificar campo en bd)

    }
}
