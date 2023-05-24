using BackendU2W.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace BackendU2W.DbContext
{
    public class ApplicationDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opciones) : base(opciones) { }

        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Objetivos> Objetivos { get; set; }
        //public DbSet<ObjetivoPost> ObjetivoPost { get; set; }
        public DbSet<Eventos> Eventos { get; set; }
        public DbSet<Comunidades> Comunidades { get; set; }
        public DbSet<ComunidadesUsuarios> ComunidadesUsuarios { get; set; }
        public DbSet<Posts> Posts { get; set; }
        public DbSet<Documentos> Documentos { get; set; }
        public DbSet<Perfiles> Perfiles { get; set; }
        //public DbSet<ConfiguracionPerfil> Configuracion { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var usuario1 = new Usuarios() { id_usu = 1, nick = "Usuario1", name = "Usuario1", surname = "Usuario1", email = "usuario1@gmail.com", password = "12345", active = true, create_date = DateTime.Today };
            var usuario2 = new Usuarios() { id_usu = 2, nick = "Usuario2", name = "Usuario2", surname = "Usuario2", email = "usuario2@gmail.com", password = "12345", level = 10, create_date = DateTime.Today };
            var usuario3 = new Usuarios() { id_usu = 3, nick = "Usuario3", name = "Usuario3", surname = "Usuario3", email = "usuario3@gmail.com", password = "12345", level = 20, active = false, create_date = DateTime.Today };
            var usuario4 = new Usuarios() { id_usu = 4, nick = "Usuario4", name = "Usuario4", surname = "Usuario4", email = "usuario4@gmail.com", password = "12345", level = 30, active = true, create_date = DateTime.Today, delete_date = new DateTime(2023, 01, 23) };
            var usuarioAdmin = new Usuarios() { id_usu = 5, nick = "admin", name = "Admin", surname = "Admin", email = "admin@gmail.com", password = "admin", level = 999, active = true, create_date = DateTime.Today };

            modelBuilder.Entity<Usuarios>().HasData(new Usuarios[] { usuario1, usuario2, usuario3, usuario4, usuarioAdmin });

            var objetivo1 = new Objetivos() { id_obj = 1, id_usu = 1, nombre = "Objetivo1", descripcion = "Este es el objetivo1", duracion = DuracionObjetivos.Dia, create_date = DateTime.Today };
            var objetivo2 = new Objetivos() { id_obj = 2, id_usu = 1, nombre = "Objetivo2", duracion = DuracionObjetivos.Dia, create_date = DateTime.Today };
            var objetivo3 = new Objetivos() { id_obj = 3, id_usu = 3, nombre = "Objetivo3", duracion = DuracionObjetivos.Semana, create_date = DateTime.Today };
            var objetivo4 = new Objetivos() { id_obj = 4, id_usu = 4, nombre = "Objetivo4", duracion = DuracionObjetivos.Mes, create_date = DateTime.Today };

            modelBuilder.Entity<Objetivos>().HasData(new Objetivos[] { objetivo1, objetivo2, objetivo3, objetivo4 });

            var comunidad1 = new Comunidades() { id_com = 1, nombre = "Comunidad1", descripcion = "Esta es al comunidad1", clave = "12345", create_date = DateTime.Today };
            var comunidad2 = new Comunidades() { id_com = 2, nombre = "Comunidad2", descripcion = "Esta es al comunidad2", clave = "12345", create_date = DateTime.Today };
            var comunidad3 = new Comunidades() { id_com = 3, nombre = "Comunidad3", clave = "12345", create_date = DateTime.Today };
            var comunidad4 = new Comunidades() { id_com = 4, nombre = "Comunidad4", descripcion = "Esta es al comunidad4", clave = "12345", create_date = DateTime.Today };

            modelBuilder.Entity<Comunidades>().HasData(new Comunidades[] { comunidad1, comunidad2, comunidad3, comunidad4 });

            var plan1 = new Eventos() { id_evento = 1, id_com = 3, titulo = "Evento1", descripcion = "Este es el evento 1", fechaInicio = DateTime.Now, fechaFin = DateTime.Now.AddMonths(1), create_date = DateTime.Today };
            var plan2 = new Eventos() { id_evento = 2, id_com = 2, titulo = "Evento2", descripcion = "Este es el evento 2", fechaInicio = DateTime.Now, fechaFin = DateTime.Now.AddDays(15), create_date = DateTime.Today };
            var plan3 = new Eventos() { id_evento = 3, id_com = 2, titulo = "Evento3", fechaInicio = DateTime.Now, fechaFin = DateTime.Now.AddMonths(12), create_date = DateTime.Today };
            var plan4 = new Eventos() { id_evento = 4, id_com = 1, titulo = "Evento4", descripcion = "Este es el evento 4", fechaInicio = DateTime.Now, fechaFin = DateTime.Now.AddDays(5), create_date = DateTime.Today };

            modelBuilder.Entity<Eventos>().HasData(new Eventos[] { plan1, plan2, plan3, plan4 });

            var comunidades_usuarios1 = new ComunidadesUsuarios() { id_com_usu = 1, id_com = 2, id_usu = 1, apodo = "Plan2", nivel = 10, tipoUsuario = tipo_usuario.Admin, create_date = DateTime.Today };
            var comunidades_usuarios2 = new ComunidadesUsuarios() { id_com_usu = 2, id_com = 3, id_usu = 2, apodo = "Plan1", tipoUsuario = tipo_usuario.Mod, create_date = DateTime.Today };
            var comunidades_usuarios3 = new ComunidadesUsuarios() { id_com_usu = 3, id_com = 2, id_usu = 2, apodo = "Plan3", nivel = 30, tipoUsuario = tipo_usuario.Miembro, create_date = DateTime.Today };
            var comunidades_usuarios4 = new ComunidadesUsuarios() { id_com_usu = 4, id_com = 1, id_usu = 3, apodo = "Plan4", tipoUsuario = tipo_usuario.Miembro, create_date = DateTime.Today };

            modelBuilder.Entity<ComunidadesUsuarios>().HasData(new ComunidadesUsuarios[] { comunidades_usuarios1, comunidades_usuarios2, comunidades_usuarios3, comunidades_usuarios4 });

            var post1 = new Posts() { id_post = 1, id_com_usu = 2, titulo = "Post 1", descripcion = "Descripcion del post 1", likes = 1, create_date = DateTime.Today };
            var post2 = new Posts() { id_post = 2, id_com_usu = 3, titulo = "Post 2", likes = 1, create_date = DateTime.Today };
            var post3 = new Posts() { id_post = 3, id_com_usu = 2, titulo = "Post 3", descripcion = "Descripcion del post 3", likes = 1, create_date = DateTime.Today };
            var post4 = new Posts() { id_post = 4, id_com_usu = 1, titulo = "Post 4", descripcion = "Descripcion del post 4", likes = 1, create_date = DateTime.Today };

            modelBuilder.Entity<Posts>().HasData(new Posts[] { post1, post2, post3, post4 });

            var documento1 = new Documentos() { id_doc = 1, data = new byte[1], descripcion = "Descripcion del documento1", create_date = DateTime.Today };
            var documento2 = new Documentos() { id_doc = 2, data = new byte[1], create_date = DateTime.Today };
            var documento3 = new Documentos() { id_doc = 3, data = new byte[1], descripcion = "Descripcion del documento3", create_date = DateTime.Today };
            var documento4 = new Documentos() { id_doc = 4, data = new byte[1], descripcion = "Descripcion del documento4", create_date = DateTime.Today };

            modelBuilder.Entity<Documentos>().HasData(new Documentos[] { documento1, documento2, documento3, documento4 });

            //var perfil1 = new Perfiles() { id_perfil = 1, usuarioPropietario = usuario1, create_date = DateTime.Today };
            //var perfil2 = new Perfiles() { id_perfil = 2, usuarioPropietario = usuario2, create_date = DateTime.Today };
            //var perfil3 = new Perfiles() { id_perfil = 3, usuarioPropietario = usuario3, create_date = DateTime.Today };
            //var perfil4 = new Perfiles() { id_perfil = 4, usuarioPropietario = usuario4, create_date = DateTime.Today };

            //modelBuilder.Entity<Perfiles>().HasData(new Perfiles[] { perfil1, perfil2, perfil3, perfil4 });

            //modelBuilder.Entity<ComunidadesUsuarios>().HasAlternateKey(c => new { c.id_com, c.id_usu }).HasName("IX_UniqueFKs");

            modelBuilder.Entity<Usuarios>()
                .HasMany(e => e.ComunidadesUsuarios)
                .WithOne(e => e.usuario)
                .HasForeignKey(e => e.id_usu)
                .HasPrincipalKey(e => e.id_usu);

            modelBuilder.Entity<Comunidades>()
                .HasMany(e => e.ComunidadesUsuarios)
                .WithOne(e => e.comunidad)
                .HasForeignKey(e => e.id_com)
                .HasPrincipalKey(e => e.id_com);

            modelBuilder.Entity<Posts>()
                .HasOne(e => e.comunidadesUsuarios)
                .WithMany(e => e.Posts)
                .HasForeignKey(e => e.id_com_usu)
                .HasPrincipalKey(e => e.id_com_usu);

            modelBuilder.Entity<Usuarios>()
                .HasOne(a => a.perfil).WithOne(b => b.usuarioPropietario)
                .HasForeignKey<Perfiles>(e => e.id_perfil);
            modelBuilder.Entity<Usuarios>().ToTable("Tbl_Usuarios");
            modelBuilder.Entity<Perfiles>().ToTable("Tbl_Perfiles");

            base.OnModelCreating(modelBuilder);
        }
        //Cuando crear migraciones (buenas practicas)
        // 1- Cuando se crea una nueva clase (nueva tabla en la bd)
        // 2- Cuando agregue una nueva propiedad (crar un campo nuevo en la bd)
        // 3- Modifique un valor de campo en la clase (modificar campo en bd)

    }
}
