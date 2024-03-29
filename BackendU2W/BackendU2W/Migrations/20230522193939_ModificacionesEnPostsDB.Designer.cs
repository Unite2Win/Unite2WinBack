﻿// <auto-generated />
using System;
using BackendU2W.DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BackendU2W.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230522193939_ModificacionesEnPostsDB")]
    partial class ModificacionesEnPostsDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BackendU2W.Models.Comunidades", b =>
                {
                    b.Property<int>("id_com")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_com"));

                    b.Property<long?>("bannerid_doc")
                        .HasColumnType("bigint");

                    b.Property<string>("clave")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("create_date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("delete_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("descripcion")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime?>("last_modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("pictureid_doc")
                        .HasColumnType("bigint");

                    b.HasKey("id_com");

                    b.HasIndex("bannerid_doc");

                    b.HasIndex("pictureid_doc");

                    b.ToTable("Tbl_Comunidades");

                    b.HasData(
                        new
                        {
                            id_com = 1,
                            clave = "12345",
                            create_date = new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            descripcion = "Esta es al comunidad1",
                            nombre = "Comunidad1"
                        },
                        new
                        {
                            id_com = 2,
                            clave = "12345",
                            create_date = new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            descripcion = "Esta es al comunidad2",
                            nombre = "Comunidad2"
                        },
                        new
                        {
                            id_com = 3,
                            clave = "12345",
                            create_date = new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            nombre = "Comunidad3"
                        },
                        new
                        {
                            id_com = 4,
                            clave = "12345",
                            create_date = new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            descripcion = "Esta es al comunidad4",
                            nombre = "Comunidad4"
                        });
                });

            modelBuilder.Entity("BackendU2W.Models.ComunidadesUsuarios", b =>
                {
                    b.Property<int>("id_com_usu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_com_usu"));

                    b.Property<string>("apodo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<long?>("avatarid_doc")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("create_date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("delete_date")
                        .HasColumnType("datetime2");

                    b.Property<int>("id_com")
                        .HasColumnType("int");

                    b.Property<int>("id_usu")
                        .HasColumnType("int");

                    b.Property<DateTime?>("last_modified")
                        .HasColumnType("datetime2");

                    b.Property<int>("nivel")
                        .HasColumnType("int");

                    b.Property<int>("tipoUsuario")
                        .HasColumnType("int");

                    b.HasKey("id_com_usu");

                    b.HasAlternateKey("id_com", "id_usu")
                        .HasName("IX_UniqueFKs");

                    b.HasIndex("avatarid_doc");

                    b.HasIndex("id_usu");

                    b.ToTable("Tbl_ComunidadesUsuarios");

                    b.HasData(
                        new
                        {
                            id_com_usu = 1,
                            apodo = "Plan2",
                            create_date = new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            id_com = 2,
                            id_usu = 1,
                            nivel = 10,
                            tipoUsuario = 0
                        },
                        new
                        {
                            id_com_usu = 2,
                            apodo = "Plan1",
                            create_date = new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            id_com = 3,
                            id_usu = 2,
                            nivel = 0,
                            tipoUsuario = 1
                        },
                        new
                        {
                            id_com_usu = 3,
                            apodo = "Plan3",
                            create_date = new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            id_com = 2,
                            id_usu = 2,
                            nivel = 30,
                            tipoUsuario = 2
                        },
                        new
                        {
                            id_com_usu = 4,
                            apodo = "Plan4",
                            create_date = new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            id_com = 1,
                            id_usu = 3,
                            nivel = 0,
                            tipoUsuario = 2
                        });
                });

            modelBuilder.Entity("BackendU2W.Models.Documentos", b =>
                {
                    b.Property<long>("id_doc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id_doc"));

                    b.Property<DateTime>("create_date")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("data")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<DateTime?>("delete_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("extensionArchivo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("last_modified")
                        .HasColumnType("datetime2");

                    b.HasKey("id_doc");

                    b.ToTable("Tbl_Documentos");

                    b.HasData(
                        new
                        {
                            id_doc = 1L,
                            create_date = new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            data = new byte[] { 0 },
                            descripcion = "Descripcion del documento1"
                        },
                        new
                        {
                            id_doc = 2L,
                            create_date = new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            data = new byte[] { 0 }
                        },
                        new
                        {
                            id_doc = 3L,
                            create_date = new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            data = new byte[] { 0 },
                            descripcion = "Descripcion del documento3"
                        },
                        new
                        {
                            id_doc = 4L,
                            create_date = new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            data = new byte[] { 0 },
                            descripcion = "Descripcion del documento4"
                        });
                });

            modelBuilder.Entity("BackendU2W.Models.Eventos", b =>
                {
                    b.Property<int>("id_evento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_evento"));

                    b.Property<long?>("Imagenid_doc")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("create_date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("delete_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("descripcion")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime>("fechaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<int>("id_com")
                        .HasColumnType("int");

                    b.Property<DateTime?>("last_modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("titulo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ubicacion")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("id_evento");

                    b.HasIndex("Imagenid_doc");

                    b.HasIndex("id_com");

                    b.ToTable("Tbl_Eventos");

                    b.HasData(
                        new
                        {
                            id_evento = 1,
                            create_date = new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            descripcion = "Este es el evento 1",
                            fechaFin = new DateTime(2023, 6, 22, 21, 39, 39, 461, DateTimeKind.Local).AddTicks(8938),
                            fechaInicio = new DateTime(2023, 5, 22, 21, 39, 39, 461, DateTimeKind.Local).AddTicks(8935),
                            id_com = 3,
                            titulo = "Evento1"
                        },
                        new
                        {
                            id_evento = 2,
                            create_date = new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            descripcion = "Este es el evento 2",
                            fechaFin = new DateTime(2023, 6, 6, 21, 39, 39, 461, DateTimeKind.Local).AddTicks(8944),
                            fechaInicio = new DateTime(2023, 5, 22, 21, 39, 39, 461, DateTimeKind.Local).AddTicks(8943),
                            id_com = 2,
                            titulo = "Evento2"
                        },
                        new
                        {
                            id_evento = 3,
                            create_date = new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            fechaFin = new DateTime(2024, 5, 22, 21, 39, 39, 461, DateTimeKind.Local).AddTicks(8950),
                            fechaInicio = new DateTime(2023, 5, 22, 21, 39, 39, 461, DateTimeKind.Local).AddTicks(8948),
                            id_com = 2,
                            titulo = "Evento3"
                        },
                        new
                        {
                            id_evento = 4,
                            create_date = new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            descripcion = "Este es el evento 4",
                            fechaFin = new DateTime(2023, 5, 27, 21, 39, 39, 461, DateTimeKind.Local).AddTicks(8956),
                            fechaInicio = new DateTime(2023, 5, 22, 21, 39, 39, 461, DateTimeKind.Local).AddTicks(8955),
                            id_com = 1,
                            titulo = "Evento4"
                        });
                });

            modelBuilder.Entity("BackendU2W.Models.Objetivos", b =>
                {
                    b.Property<int>("id_obj")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_obj"));

                    b.Property<DateTime?>("complete_date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("create_date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("delete_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("descripcion")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("duracion")
                        .HasColumnType("int");

                    b.Property<int>("id_usu")
                        .HasColumnType("int");

                    b.Property<DateTime?>("last_modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id_obj");

                    b.HasIndex("id_usu");

                    b.ToTable("Tbl_Objetivos");

                    b.HasData(
                        new
                        {
                            id_obj = 1,
                            create_date = new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            descripcion = "Este es el objetivo1",
                            duracion = 0,
                            id_usu = 1,
                            nombre = "Objetivo1"
                        },
                        new
                        {
                            id_obj = 2,
                            create_date = new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            duracion = 0,
                            id_usu = 1,
                            nombre = "Objetivo2"
                        },
                        new
                        {
                            id_obj = 3,
                            create_date = new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            duracion = 1,
                            id_usu = 3,
                            nombre = "Objetivo3"
                        },
                        new
                        {
                            id_obj = 4,
                            create_date = new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            duracion = 2,
                            id_usu = 4,
                            nombre = "Objetivo4"
                        });
                });

            modelBuilder.Entity("BackendU2W.Models.Perfiles", b =>
                {
                    b.Property<int>("id_perfil")
                        .HasColumnType("int");

                    b.Property<long?>("borradoPorId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("create_date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("delete_date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("last_modified")
                        .HasColumnType("datetime2");

                    b.Property<long?>("modificadoPorId")
                        .HasColumnType("bigint");

                    b.HasKey("id_perfil");

                    b.ToTable("Tbl_Perfiles", (string)null);
                });

            modelBuilder.Entity("BackendU2W.Models.Posts", b =>
                {
                    b.Property<int>("id_post")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_post"));

                    b.Property<DateTime>("create_date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("delete_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("descripcion")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("id_com_usu")
                        .HasColumnType("int");

                    b.Property<long?>("imagenid_doc")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("last_modified")
                        .HasColumnType("datetime2");

                    b.Property<long>("likes")
                        .HasColumnType("bigint");

                    b.Property<string>("titulo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("id_post");

                    b.HasIndex("id_com_usu");

                    b.HasIndex("imagenid_doc");

                    b.ToTable("Tbl_Posts");

                    b.HasData(
                        new
                        {
                            id_post = 1,
                            create_date = new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            descripcion = "Descripcion del post 1",
                            id_com_usu = 2,
                            likes = 1L,
                            titulo = "Post 1"
                        },
                        new
                        {
                            id_post = 2,
                            create_date = new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            id_com_usu = 3,
                            likes = 1L,
                            titulo = "Post 2"
                        },
                        new
                        {
                            id_post = 3,
                            create_date = new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            descripcion = "Descripcion del post 3",
                            id_com_usu = 2,
                            likes = 1L,
                            titulo = "Post 3"
                        },
                        new
                        {
                            id_post = 4,
                            create_date = new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            descripcion = "Descripcion del post 4",
                            id_com_usu = 1,
                            likes = 1L,
                            titulo = "Post 4"
                        });
                });

            modelBuilder.Entity("BackendU2W.Models.Usuarios", b =>
                {
                    b.Property<int>("id_usu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_usu"));

                    b.Property<bool>("active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("create_date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("delete_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("last_login")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("last_modified")
                        .HasColumnType("datetime2");

                    b.Property<int?>("level")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nick")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<long?>("pictureid_doc")
                        .HasColumnType("bigint");

                    b.Property<string>("surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_usu");

                    b.HasIndex("pictureid_doc");

                    b.ToTable("Tbl_Usuarios", (string)null);

                    b.HasData(
                        new
                        {
                            id_usu = 1,
                            active = true,
                            create_date = new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            email = "usuario1@gmail.com",
                            name = "Usuario1",
                            nick = "Usuario1",
                            password = "12345",
                            surname = "Usuario1"
                        },
                        new
                        {
                            id_usu = 2,
                            active = false,
                            create_date = new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            email = "usuario2@gmail.com",
                            level = 10,
                            name = "Usuario2",
                            nick = "Usuario2",
                            password = "12345",
                            surname = "Usuario2"
                        },
                        new
                        {
                            id_usu = 3,
                            active = false,
                            create_date = new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            email = "usuario3@gmail.com",
                            level = 20,
                            name = "Usuario3",
                            nick = "Usuario3",
                            password = "12345",
                            surname = "Usuario3"
                        },
                        new
                        {
                            id_usu = 4,
                            active = true,
                            create_date = new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            delete_date = new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            email = "usuario4@gmail.com",
                            level = 30,
                            name = "Usuario4",
                            nick = "Usuario4",
                            password = "12345",
                            surname = "Usuario4"
                        },
                        new
                        {
                            id_usu = 5,
                            active = true,
                            create_date = new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            email = "admin@gmail.com",
                            level = 999,
                            name = "Admin",
                            nick = "admin",
                            password = "admin",
                            surname = "Admin"
                        });
                });

            modelBuilder.Entity("BackendU2W.Models.Comunidades", b =>
                {
                    b.HasOne("BackendU2W.Models.Documentos", "banner")
                        .WithMany()
                        .HasForeignKey("bannerid_doc");

                    b.HasOne("BackendU2W.Models.Documentos", "picture")
                        .WithMany()
                        .HasForeignKey("pictureid_doc");

                    b.Navigation("banner");

                    b.Navigation("picture");
                });

            modelBuilder.Entity("BackendU2W.Models.ComunidadesUsuarios", b =>
                {
                    b.HasOne("BackendU2W.Models.Documentos", "avatar")
                        .WithMany()
                        .HasForeignKey("avatarid_doc");

                    b.HasOne("BackendU2W.Models.Comunidades", "comunidad")
                        .WithMany("ComunidadesUsuarios")
                        .HasForeignKey("id_com")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BackendU2W.Models.Usuarios", "usuario")
                        .WithMany("ComunidadesUsuarios")
                        .HasForeignKey("id_usu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("avatar");

                    b.Navigation("comunidad");

                    b.Navigation("usuario");
                });

            modelBuilder.Entity("BackendU2W.Models.Eventos", b =>
                {
                    b.HasOne("BackendU2W.Models.Documentos", "Imagen")
                        .WithMany()
                        .HasForeignKey("Imagenid_doc");

                    b.HasOne("BackendU2W.Models.Comunidades", "comunidad")
                        .WithMany("Eventos")
                        .HasForeignKey("id_com")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Imagen");

                    b.Navigation("comunidad");
                });

            modelBuilder.Entity("BackendU2W.Models.Objetivos", b =>
                {
                    b.HasOne("BackendU2W.Models.Usuarios", "usuario")
                        .WithMany("Objetivos")
                        .HasForeignKey("id_usu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("usuario");
                });

            modelBuilder.Entity("BackendU2W.Models.Perfiles", b =>
                {
                    b.HasOne("BackendU2W.Models.Usuarios", "usuarioPropietario")
                        .WithOne("perfil")
                        .HasForeignKey("BackendU2W.Models.Perfiles", "id_perfil")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("usuarioPropietario");
                });

            modelBuilder.Entity("BackendU2W.Models.Posts", b =>
                {
                    b.HasOne("BackendU2W.Models.ComunidadesUsuarios", "comunidadesUsuarios")
                        .WithMany("Posts")
                        .HasForeignKey("id_com_usu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BackendU2W.Models.Documentos", "imagen")
                        .WithMany()
                        .HasForeignKey("imagenid_doc");

                    b.Navigation("comunidadesUsuarios");

                    b.Navigation("imagen");
                });

            modelBuilder.Entity("BackendU2W.Models.Usuarios", b =>
                {
                    b.HasOne("BackendU2W.Models.Documentos", "picture")
                        .WithMany()
                        .HasForeignKey("pictureid_doc");

                    b.Navigation("picture");
                });

            modelBuilder.Entity("BackendU2W.Models.Comunidades", b =>
                {
                    b.Navigation("ComunidadesUsuarios");

                    b.Navigation("Eventos");
                });

            modelBuilder.Entity("BackendU2W.Models.ComunidadesUsuarios", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("BackendU2W.Models.Usuarios", b =>
                {
                    b.Navigation("ComunidadesUsuarios");

                    b.Navigation("Objetivos");

                    b.Navigation("perfil");
                });
#pragma warning restore 612, 618
        }
    }
}
