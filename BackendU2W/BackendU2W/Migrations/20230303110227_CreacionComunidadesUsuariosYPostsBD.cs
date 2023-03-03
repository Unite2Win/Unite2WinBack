using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackendU2W.Migrations
{
    /// <inheritdoc />
    public partial class CreacionComunidadesUsuariosYPostsBD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ComunidadesUsuarios",
                columns: table => new
                {
                    id_com_usu = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_ComunidadesUsuarios", x => new { x.id_com_usu, x.id_com, x.id_usu });
                    table.UniqueConstraint("AK_ComunidadesUsuarios_id_com_usu", x => x.id_com_usu);
                    table.ForeignKey(
                        name: "FK_ComunidadesUsuarios_Tbl_Comunidades_id_com",
                        column: x => x.id_com,
                        principalTable: "Tbl_Comunidades",
                        principalColumn: "id_com",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComunidadesUsuarios_Tbl_Usuarios_id_usu",
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
                        name: "FK_Tbl_Posts_ComunidadesUsuarios_id_com_usu",
                        column: x => x.id_com_usu,
                        principalTable: "ComunidadesUsuarios",
                        principalColumn: "id_com_usu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ComunidadesUsuarios",
                columns: new[] { "id_com", "id_com_usu", "id_usu", "apodo", "avatar", "create_date", "delete_date", "last_modified", "nivel", "tipoUsuario" },
                values: new object[,]
                {
                    { 2, 1, 1, "Plan2", "avatar1", new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Local), null, null, 10, 0 },
                    { 3, 2, 2, "Plan1", "avatar2", new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Local), null, null, 0, 1 },
                    { 2, 3, 2, "Plan3", null, new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Local), null, null, 30, 2 },
                    { 1, 4, 3, "Plan4", null, new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Local), null, null, 0, 2 }
                });

            migrationBuilder.InsertData(
                table: "Tbl_Posts",
                columns: new[] { "id_post", "create_date", "delete_date", "descripcion", "id_com_usu", "last_modified", "titulo" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Local), null, "Descripcion del post1", 2, null, "Plan2" },
                    { 2, new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Local), null, null, 3, null, "Plan1" },
                    { 3, new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Local), null, "Descripcion del post3", 2, null, "Plan3" },
                    { 4, new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Local), null, "Descripcion del post4", 1, null, "Plan4" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComunidadesUsuarios_id_com",
                table: "ComunidadesUsuarios",
                column: "id_com");

            migrationBuilder.CreateIndex(
                name: "IX_ComunidadesUsuarios_id_usu",
                table: "ComunidadesUsuarios",
                column: "id_usu");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Posts_id_com_usu",
                table: "Tbl_Posts",
                column: "id_com_usu");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_Posts");

            migrationBuilder.DropTable(
                name: "ComunidadesUsuarios");
        }
    }
}
