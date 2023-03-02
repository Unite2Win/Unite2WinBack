using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackendU2W.Migrations
{
    /// <inheritdoc />
    public partial class CreacionTablaObjetivosDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_Objetivos",
                columns: table => new
                {
                    id_obj = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
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

            migrationBuilder.InsertData(
                table: "Tbl_Objetivos",
                columns: new[] { "id_obj", "create_date", "delete_date", "descripcion", "duracion", "id_usu", "last_modified", "nombre" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 2, 0, 0, 0, 0, DateTimeKind.Local), null, "Este es el objetivo1", 0, 1, null, "Objetivo1" },
                    { 2, new DateTime(2023, 3, 2, 0, 0, 0, 0, DateTimeKind.Local), null, null, 1, 1, null, "Objetivo2" },
                    { 3, new DateTime(2023, 3, 2, 0, 0, 0, 0, DateTimeKind.Local), null, null, 1, 3, null, "Objetivo3" },
                    { 4, new DateTime(2023, 3, 2, 0, 0, 0, 0, DateTimeKind.Local), null, null, 2, 4, null, "Objetivo4" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Objetivos_id_usu",
                table: "Tbl_Objetivos",
                column: "id_usu");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_Objetivos");
        }
    }
}
