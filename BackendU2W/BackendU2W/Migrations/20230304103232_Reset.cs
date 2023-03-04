using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackendU2W.Migrations
{
    /// <inheritdoc />
    public partial class Reset : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_Comunidades",
                columns: table => new
                {
                    id_com = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    clave = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    picture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    banner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    create_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    last_modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    delete_date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Comunidades", x => x.id_com);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Usuarios",
                columns: table => new
                {
                    id_usu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nick = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    picture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    level = table.Column<int>(type: "int", nullable: false),
                    active = table.Column<bool>(type: "bit", nullable: false),
                    last_login = table.Column<DateTime>(type: "datetime2", nullable: true),
                    create_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    last_modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    delete_date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Usuarios", x => x.id_usu);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Planes",
                columns: table => new
                {
                    id_plan = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_com = table.Column<int>(type: "int", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    duracion = table.Column<int>(type: "int", nullable: false),
                    create_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    last_modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    delete_date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Planes", x => x.id_plan);
                    table.ForeignKey(
                        name: "FK_Tbl_Planes_Tbl_Comunidades_id_com",
                        column: x => x.id_com,
                        principalTable: "Tbl_Comunidades",
                        principalColumn: "id_com",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_ComunidadesUsuarios",
                columns: table => new
                {
                    id_com_usu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_com = table.Column<int>(type: "int", nullable: false),
                    id_usu = table.Column<int>(type: "int", nullable: false),
                    apodo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    nivel = table.Column<int>(type: "int", nullable: false),
                    avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tipoUsuario = table.Column<int>(type: "int", nullable: false),
                    create_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    last_modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    delete_date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_ComunidadesUsuarios", x => x.id_com_usu);
                    table.UniqueConstraint("IX_UniqueFKs", x => new { x.id_com, x.id_usu });
                    table.ForeignKey(
                        name: "FK_Tbl_ComunidadesUsuarios_Tbl_Comunidades_id_com",
                        column: x => x.id_com,
                        principalTable: "Tbl_Comunidades",
                        principalColumn: "id_com",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tbl_ComunidadesUsuarios_Tbl_Usuarios_id_usu",
                        column: x => x.id_usu,
                        principalTable: "Tbl_Usuarios",
                        principalColumn: "id_usu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Objetivos",
                columns: table => new
                {
                    id_obj = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    duracion = table.Column<int>(type: "int", nullable: false),
                    create_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    last_modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    delete_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    id_usu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Objetivos", x => x.id_obj);
                    table.ForeignKey(
                        name: "FK_Tbl_Objetivos_Tbl_Usuarios_id_usu",
                        column: x => x.id_usu,
                        principalTable: "Tbl_Usuarios",
                        principalColumn: "id_usu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Posts",
                columns: table => new
                {
                    id_post = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_com_usu = table.Column<int>(type: "int", nullable: false),
                    titulo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    create_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    last_modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    delete_date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Posts", x => x.id_post);
                    table.ForeignKey(
                        name: "FK_Tbl_Posts_Tbl_ComunidadesUsuarios_id_com_usu",
                        column: x => x.id_com_usu,
                        principalTable: "Tbl_ComunidadesUsuarios",
                        principalColumn: "id_com_usu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Tbl_Comunidades",
                columns: new[] { "id_com", "banner", "clave", "create_date", "delete_date", "descripcion", "last_modified", "nombre", "picture" },
                values: new object[,]
                {
                    { 1, "banner1", "12345", new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local), null, "Esta es al comunidad1", null, "Comunidad1", "imagen1" },
                    { 2, "banner2", "12345", new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local), null, "Esta es al comunidad2", null, "Comunidad2", "imagen2" },
                    { 3, "banner3", "12345", new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local), null, null, null, "Comunidad3", "imagen3" },
                    { 4, "banner4", "12345", new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local), null, "Esta es al comunidad4", null, "Comunidad4", "imagen4" }
                });

            migrationBuilder.InsertData(
                table: "Tbl_Usuarios",
                columns: new[] { "id_usu", "active", "create_date", "delete_date", "last_login", "last_modified", "level", "nick", "password", "picture" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local), null, null, null, 0, "Usuario1", "12345", "a" },
                    { 2, false, new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local), null, null, null, 10, "Usuario2", "12345", "a" },
                    { 3, false, new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local), null, null, null, 20, "Usuario3", "12345", "a" },
                    { 4, true, new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 30, "Usuario4", "12345", "a" }
                });

            migrationBuilder.InsertData(
                table: "Tbl_ComunidadesUsuarios",
                columns: new[] { "id_com_usu", "apodo", "avatar", "create_date", "delete_date", "id_com", "id_usu", "last_modified", "nivel", "tipoUsuario" },
                values: new object[,]
                {
                    { 1, "Plan2", "avatar1", new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local), null, 2, 1, null, 10, 0 },
                    { 2, "Plan1", "avatar2", new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local), null, 3, 2, null, 0, 1 },
                    { 3, "Plan3", null, new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local), null, 2, 2, null, 30, 2 },
                    { 4, "Plan4", null, new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local), null, 1, 3, null, 0, 2 }
                });

            migrationBuilder.InsertData(
                table: "Tbl_Objetivos",
                columns: new[] { "id_obj", "create_date", "delete_date", "descripcion", "duracion", "id_usu", "last_modified", "nombre" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local), null, "Este es el objetivo1", 0, 1, null, "Objetivo1" },
                    { 2, new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local), null, null, 1, 1, null, "Objetivo2" },
                    { 3, new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local), null, null, 1, 3, null, "Objetivo3" },
                    { 4, new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local), null, null, 2, 4, null, "Objetivo4" }
                });

            migrationBuilder.InsertData(
                table: "Tbl_Planes",
                columns: new[] { "id_plan", "create_date", "delete_date", "descripcion", "duracion", "id_com", "last_modified", "nombre" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local), null, "Este es el plan1", 1, 3, null, "Plan1" },
                    { 2, new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local), null, "Este es el plan2", 1, 2, null, "Plan2" },
                    { 3, new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local), null, null, 0, 2, null, "Plan3" },
                    { 4, new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local), null, "Este es el plan4", 2, 1, null, "Plan4" }
                });

            migrationBuilder.InsertData(
                table: "Tbl_Posts",
                columns: new[] { "id_post", "create_date", "delete_date", "descripcion", "id_com_usu", "last_modified", "titulo" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local), null, "Descripcion del post1", 2, null, "Plan2" },
                    { 2, new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local), null, null, 3, null, "Plan1" },
                    { 3, new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local), null, "Descripcion del post3", 2, null, "Plan3" },
                    { 4, new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local), null, "Descripcion del post4", 1, null, "Plan4" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_ComunidadesUsuarios_id_usu",
                table: "Tbl_ComunidadesUsuarios",
                column: "id_usu");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Objetivos_id_usu",
                table: "Tbl_Objetivos",
                column: "id_usu");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Planes_id_com",
                table: "Tbl_Planes",
                column: "id_com");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Posts_id_com_usu",
                table: "Tbl_Posts",
                column: "id_com_usu");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_Objetivos");

            migrationBuilder.DropTable(
                name: "Tbl_Planes");

            migrationBuilder.DropTable(
                name: "Tbl_Posts");

            migrationBuilder.DropTable(
                name: "Tbl_ComunidadesUsuarios");

            migrationBuilder.DropTable(
                name: "Tbl_Comunidades");

            migrationBuilder.DropTable(
                name: "Tbl_Usuarios");
        }
    }
}
