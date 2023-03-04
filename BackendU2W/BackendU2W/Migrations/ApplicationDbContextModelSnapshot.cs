﻿// <auto-generated />
using System;
using BackendU2W.DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BackendU2W.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("banner")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("picture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_com");

                    b.ToTable("Tbl_Comunidades");

                    b.HasData(
                        new
                        {
                            id_com = 1,
                            banner = "banner1",
                            clave = "12345",
                            create_date = new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            descripcion = "Esta es al comunidad1",
                            nombre = "Comunidad1",
                            picture = "imagen1"
                        },
                        new
                        {
                            id_com = 2,
                            banner = "banner2",
                            clave = "12345",
                            create_date = new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            descripcion = "Esta es al comunidad2",
                            nombre = "Comunidad2",
                            picture = "imagen2"
                        },
                        new
                        {
                            id_com = 3,
                            banner = "banner3",
                            clave = "12345",
                            create_date = new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            nombre = "Comunidad3",
                            picture = "imagen3"
                        },
                        new
                        {
                            id_com = 4,
                            banner = "banner4",
                            clave = "12345",
                            create_date = new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            descripcion = "Esta es al comunidad4",
                            nombre = "Comunidad4",
                            picture = "imagen4"
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

                    b.Property<string>("avatar")
                        .HasColumnType("nvarchar(max)");

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

                    b.HasIndex("id_usu");

                    b.ToTable("Tbl_ComunidadesUsuarios");

                    b.HasData(
                        new
                        {
                            id_com_usu = 1,
                            apodo = "Plan2",
                            avatar = "avatar1",
                            create_date = new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            id_com = 2,
                            id_usu = 1,
                            nivel = 10,
                            tipoUsuario = 0
                        },
                        new
                        {
                            id_com_usu = 2,
                            apodo = "Plan1",
                            avatar = "avatar2",
                            create_date = new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            id_com = 3,
                            id_usu = 2,
                            nivel = 0,
                            tipoUsuario = 1
                        },
                        new
                        {
                            id_com_usu = 3,
                            apodo = "Plan3",
                            create_date = new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            id_com = 2,
                            id_usu = 2,
                            nivel = 30,
                            tipoUsuario = 2
                        },
                        new
                        {
                            id_com_usu = 4,
                            apodo = "Plan4",
                            create_date = new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            id_com = 1,
                            id_usu = 3,
                            nivel = 0,
                            tipoUsuario = 2
                        });
                });

            modelBuilder.Entity("BackendU2W.Models.Objetivos", b =>
                {
                    b.Property<int>("id_obj")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_obj"));

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
                            create_date = new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            descripcion = "Este es el objetivo1",
                            duracion = 0,
                            id_usu = 1,
                            nombre = "Objetivo1"
                        },
                        new
                        {
                            id_obj = 2,
                            create_date = new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            duracion = 1,
                            id_usu = 1,
                            nombre = "Objetivo2"
                        },
                        new
                        {
                            id_obj = 3,
                            create_date = new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            duracion = 1,
                            id_usu = 3,
                            nombre = "Objetivo3"
                        },
                        new
                        {
                            id_obj = 4,
                            create_date = new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            duracion = 2,
                            id_usu = 4,
                            nombre = "Objetivo4"
                        });
                });

            modelBuilder.Entity("BackendU2W.Models.Planes", b =>
                {
                    b.Property<int>("id_plan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_plan"));

                    b.Property<DateTime>("create_date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("delete_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("descripcion")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("duracion")
                        .HasColumnType("int");

                    b.Property<int>("id_com")
                        .HasColumnType("int");

                    b.Property<DateTime?>("last_modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id_plan");

                    b.HasIndex("id_com");

                    b.ToTable("Tbl_Planes");

                    b.HasData(
                        new
                        {
                            id_plan = 1,
                            create_date = new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            descripcion = "Este es el plan1",
                            duracion = 1,
                            id_com = 3,
                            nombre = "Plan1"
                        },
                        new
                        {
                            id_plan = 2,
                            create_date = new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            descripcion = "Este es el plan2",
                            duracion = 1,
                            id_com = 2,
                            nombre = "Plan2"
                        },
                        new
                        {
                            id_plan = 3,
                            create_date = new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            duracion = 0,
                            id_com = 2,
                            nombre = "Plan3"
                        },
                        new
                        {
                            id_plan = 4,
                            create_date = new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            descripcion = "Este es el plan4",
                            duracion = 2,
                            id_com = 1,
                            nombre = "Plan4"
                        });
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

                    b.Property<DateTime?>("last_modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("titulo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("id_post");

                    b.HasIndex("id_com_usu");

                    b.ToTable("Tbl_Posts");

                    b.HasData(
                        new
                        {
                            id_post = 1,
                            create_date = new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            descripcion = "Descripcion del post1",
                            id_com_usu = 2,
                            titulo = "Plan2"
                        },
                        new
                        {
                            id_post = 2,
                            create_date = new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            id_com_usu = 3,
                            titulo = "Plan1"
                        },
                        new
                        {
                            id_post = 3,
                            create_date = new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            descripcion = "Descripcion del post3",
                            id_com_usu = 2,
                            titulo = "Plan3"
                        },
                        new
                        {
                            id_post = 4,
                            create_date = new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            descripcion = "Descripcion del post4",
                            id_com_usu = 1,
                            titulo = "Plan4"
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

                    b.Property<DateTime?>("last_login")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("last_modified")
                        .HasColumnType("datetime2");

                    b.Property<int>("level")
                        .HasColumnType("int");

                    b.Property<string>("nick")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("picture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_usu");

                    b.ToTable("Tbl_Usuarios");

                    b.HasData(
                        new
                        {
                            id_usu = 1,
                            active = true,
                            create_date = new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            level = 0,
                            nick = "Usuario1",
                            password = "12345",
                            picture = "a"
                        },
                        new
                        {
                            id_usu = 2,
                            active = false,
                            create_date = new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            level = 10,
                            nick = "Usuario2",
                            password = "12345",
                            picture = "a"
                        },
                        new
                        {
                            id_usu = 3,
                            active = false,
                            create_date = new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            level = 20,
                            nick = "Usuario3",
                            password = "12345",
                            picture = "a"
                        },
                        new
                        {
                            id_usu = 4,
                            active = true,
                            create_date = new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            delete_date = new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            level = 30,
                            nick = "Usuario4",
                            password = "12345",
                            picture = "a"
                        });
                });

            modelBuilder.Entity("BackendU2W.Models.ComunidadesUsuarios", b =>
                {
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

                    b.Navigation("comunidad");

                    b.Navigation("usuario");
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

            modelBuilder.Entity("BackendU2W.Models.Planes", b =>
                {
                    b.HasOne("BackendU2W.Models.Comunidades", "comunidad")
                        .WithMany("Planes")
                        .HasForeignKey("id_com")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("comunidad");
                });

            modelBuilder.Entity("BackendU2W.Models.Posts", b =>
                {
                    b.HasOne("BackendU2W.Models.ComunidadesUsuarios", "comunidadesUsuarios")
                        .WithMany("Posts")
                        .HasForeignKey("id_com_usu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("comunidadesUsuarios");
                });

            modelBuilder.Entity("BackendU2W.Models.Comunidades", b =>
                {
                    b.Navigation("ComunidadesUsuarios");

                    b.Navigation("Planes");
                });

            modelBuilder.Entity("BackendU2W.Models.ComunidadesUsuarios", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("BackendU2W.Models.Usuarios", b =>
                {
                    b.Navigation("ComunidadesUsuarios");

                    b.Navigation("Objetivos");
                });
#pragma warning restore 612, 618
        }
    }
}
