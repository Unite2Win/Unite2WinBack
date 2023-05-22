using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackendU2W.Migrations
{
    /// <inheritdoc />
    public partial class CambioPlanesAEventosDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_Planes");

            migrationBuilder.CreateTable(
                name: "Tbl_Eventos",
                columns: table => new
                {
                    id_evento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_com = table.Column<int>(type: "int", nullable: false),
                    titulo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    ubicacion = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    fechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fechaFin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Imagenid_doc = table.Column<long>(type: "bigint", nullable: true),
                    create_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    last_modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    delete_date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Eventos", x => x.id_evento);
                    table.ForeignKey(
                        name: "FK_Tbl_Eventos_Tbl_Comunidades_id_com",
                        column: x => x.id_com,
                        principalTable: "Tbl_Comunidades",
                        principalColumn: "id_com",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tbl_Eventos_Tbl_Documentos_Imagenid_doc",
                        column: x => x.Imagenid_doc,
                        principalTable: "Tbl_Documentos",
                        principalColumn: "id_doc");
                });

            migrationBuilder.UpdateData(
                table: "Tbl_Comunidades",
                keyColumn: "id_com",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Comunidades",
                keyColumn: "id_com",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Comunidades",
                keyColumn: "id_com",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Comunidades",
                keyColumn: "id_com",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_ComunidadesUsuarios",
                keyColumn: "id_com_usu",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_ComunidadesUsuarios",
                keyColumn: "id_com_usu",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_ComunidadesUsuarios",
                keyColumn: "id_com_usu",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_ComunidadesUsuarios",
                keyColumn: "id_com_usu",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Documentos",
                keyColumn: "id_doc",
                keyValue: 1L,
                column: "create_date",
                value: new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Documentos",
                keyColumn: "id_doc",
                keyValue: 2L,
                column: "create_date",
                value: new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Documentos",
                keyColumn: "id_doc",
                keyValue: 3L,
                column: "create_date",
                value: new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Documentos",
                keyColumn: "id_doc",
                keyValue: 4L,
                column: "create_date",
                value: new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "Tbl_Eventos",
                columns: new[] { "id_evento", "Imagenid_doc", "create_date", "delete_date", "descripcion", "fechaFin", "fechaInicio", "id_com", "last_modified", "titulo", "ubicacion" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Este es el evento 1", new DateTime(2023, 6, 22, 21, 24, 36, 720, DateTimeKind.Local).AddTicks(1634), new DateTime(2023, 5, 22, 21, 24, 36, 720, DateTimeKind.Local).AddTicks(1632), 3, null, "Evento1", null },
                    { 2, null, new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Este es el evento 2", new DateTime(2023, 6, 6, 21, 24, 36, 720, DateTimeKind.Local).AddTicks(1641), new DateTime(2023, 5, 22, 21, 24, 36, 720, DateTimeKind.Local).AddTicks(1639), 2, null, "Evento2", null },
                    { 3, null, new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local), null, null, new DateTime(2024, 5, 22, 21, 24, 36, 720, DateTimeKind.Local).AddTicks(1647), new DateTime(2023, 5, 22, 21, 24, 36, 720, DateTimeKind.Local).AddTicks(1646), 2, null, "Evento3", null },
                    { 4, null, new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Este es el evento 4", new DateTime(2023, 5, 27, 21, 24, 36, 720, DateTimeKind.Local).AddTicks(1653), new DateTime(2023, 5, 22, 21, 24, 36, 720, DateTimeKind.Local).AddTicks(1651), 1, null, "Evento4", null }
                });

            migrationBuilder.UpdateData(
                table: "Tbl_Objetivos",
                keyColumn: "id_obj",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Objetivos",
                keyColumn: "id_obj",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Objetivos",
                keyColumn: "id_obj",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Objetivos",
                keyColumn: "id_obj",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Posts",
                keyColumn: "id_post",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Posts",
                keyColumn: "id_post",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Posts",
                keyColumn: "id_post",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Posts",
                keyColumn: "id_post",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 5,
                column: "create_date",
                value: new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Eventos_id_com",
                table: "Tbl_Eventos",
                column: "id_com");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Eventos_Imagenid_doc",
                table: "Tbl_Eventos",
                column: "Imagenid_doc");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_Eventos");

            migrationBuilder.CreateTable(
                name: "Tbl_Planes",
                columns: table => new
                {
                    id_plan = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_com = table.Column<int>(type: "int", nullable: false),
                    create_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    delete_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    descripcion = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    duracion = table.Column<int>(type: "int", nullable: false),
                    last_modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
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

            migrationBuilder.UpdateData(
                table: "Tbl_Comunidades",
                keyColumn: "id_com",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Comunidades",
                keyColumn: "id_com",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Comunidades",
                keyColumn: "id_com",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Comunidades",
                keyColumn: "id_com",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_ComunidadesUsuarios",
                keyColumn: "id_com_usu",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_ComunidadesUsuarios",
                keyColumn: "id_com_usu",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_ComunidadesUsuarios",
                keyColumn: "id_com_usu",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_ComunidadesUsuarios",
                keyColumn: "id_com_usu",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Documentos",
                keyColumn: "id_doc",
                keyValue: 1L,
                column: "create_date",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Documentos",
                keyColumn: "id_doc",
                keyValue: 2L,
                column: "create_date",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Documentos",
                keyColumn: "id_doc",
                keyValue: 3L,
                column: "create_date",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Documentos",
                keyColumn: "id_doc",
                keyValue: 4L,
                column: "create_date",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Objetivos",
                keyColumn: "id_obj",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Objetivos",
                keyColumn: "id_obj",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Objetivos",
                keyColumn: "id_obj",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Objetivos",
                keyColumn: "id_obj",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "Tbl_Planes",
                columns: new[] { "id_plan", "create_date", "delete_date", "descripcion", "duracion", "id_com", "last_modified", "nombre" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local), null, "Este es el plan1", 1, 3, null, "Plan1" },
                    { 2, new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local), null, "Este es el plan2", 1, 2, null, "Plan2" },
                    { 3, new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local), null, null, 0, 2, null, "Plan3" },
                    { 4, new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local), null, "Este es el plan4", 2, 1, null, "Plan4" }
                });

            migrationBuilder.UpdateData(
                table: "Tbl_Posts",
                keyColumn: "id_post",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Posts",
                keyColumn: "id_post",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Posts",
                keyColumn: "id_post",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Posts",
                keyColumn: "id_post",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tbl_Usuarios",
                keyColumn: "id_usu",
                keyValue: 5,
                column: "create_date",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Planes_id_com",
                table: "Tbl_Planes",
                column: "id_com");
        }
    }
}
