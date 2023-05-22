using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendU2W.Migrations
{
    /// <inheritdoc />
    public partial class ModificacionesEnPostsDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "imagenid_doc",
                table: "Tbl_Posts",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "likes",
                table: "Tbl_Posts",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "Tbl_Eventos",
                keyColumn: "id_evento",
                keyValue: 1,
                columns: new[] { "fechaFin", "fechaInicio" },
                values: new object[] { new DateTime(2023, 6, 22, 21, 39, 39, 461, DateTimeKind.Local).AddTicks(8938), new DateTime(2023, 5, 22, 21, 39, 39, 461, DateTimeKind.Local).AddTicks(8935) });

            migrationBuilder.UpdateData(
                table: "Tbl_Eventos",
                keyColumn: "id_evento",
                keyValue: 2,
                columns: new[] { "fechaFin", "fechaInicio" },
                values: new object[] { new DateTime(2023, 6, 6, 21, 39, 39, 461, DateTimeKind.Local).AddTicks(8944), new DateTime(2023, 5, 22, 21, 39, 39, 461, DateTimeKind.Local).AddTicks(8943) });

            migrationBuilder.UpdateData(
                table: "Tbl_Eventos",
                keyColumn: "id_evento",
                keyValue: 3,
                columns: new[] { "fechaFin", "fechaInicio" },
                values: new object[] { new DateTime(2024, 5, 22, 21, 39, 39, 461, DateTimeKind.Local).AddTicks(8950), new DateTime(2023, 5, 22, 21, 39, 39, 461, DateTimeKind.Local).AddTicks(8948) });

            migrationBuilder.UpdateData(
                table: "Tbl_Eventos",
                keyColumn: "id_evento",
                keyValue: 4,
                columns: new[] { "fechaFin", "fechaInicio" },
                values: new object[] { new DateTime(2023, 5, 27, 21, 39, 39, 461, DateTimeKind.Local).AddTicks(8956), new DateTime(2023, 5, 22, 21, 39, 39, 461, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "Tbl_Posts",
                keyColumn: "id_post",
                keyValue: 1,
                columns: new[] { "descripcion", "imagenid_doc", "likes", "titulo" },
                values: new object[] { "Descripcion del post 1", null, 1L, "Post 1" });

            migrationBuilder.UpdateData(
                table: "Tbl_Posts",
                keyColumn: "id_post",
                keyValue: 2,
                columns: new[] { "imagenid_doc", "likes", "titulo" },
                values: new object[] { null, 1L, "Post 2" });

            migrationBuilder.UpdateData(
                table: "Tbl_Posts",
                keyColumn: "id_post",
                keyValue: 3,
                columns: new[] { "descripcion", "imagenid_doc", "likes", "titulo" },
                values: new object[] { "Descripcion del post 3", null, 1L, "Post 3" });

            migrationBuilder.UpdateData(
                table: "Tbl_Posts",
                keyColumn: "id_post",
                keyValue: 4,
                columns: new[] { "descripcion", "imagenid_doc", "likes", "titulo" },
                values: new object[] { "Descripcion del post 4", null, 1L, "Post 4" });

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Posts_imagenid_doc",
                table: "Tbl_Posts",
                column: "imagenid_doc");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Posts_Tbl_Documentos_imagenid_doc",
                table: "Tbl_Posts",
                column: "imagenid_doc",
                principalTable: "Tbl_Documentos",
                principalColumn: "id_doc");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Posts_Tbl_Documentos_imagenid_doc",
                table: "Tbl_Posts");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_Posts_imagenid_doc",
                table: "Tbl_Posts");

            migrationBuilder.DropColumn(
                name: "imagenid_doc",
                table: "Tbl_Posts");

            migrationBuilder.DropColumn(
                name: "likes",
                table: "Tbl_Posts");

            migrationBuilder.UpdateData(
                table: "Tbl_Eventos",
                keyColumn: "id_evento",
                keyValue: 1,
                columns: new[] { "fechaFin", "fechaInicio" },
                values: new object[] { new DateTime(2023, 6, 22, 21, 24, 36, 720, DateTimeKind.Local).AddTicks(1634), new DateTime(2023, 5, 22, 21, 24, 36, 720, DateTimeKind.Local).AddTicks(1632) });

            migrationBuilder.UpdateData(
                table: "Tbl_Eventos",
                keyColumn: "id_evento",
                keyValue: 2,
                columns: new[] { "fechaFin", "fechaInicio" },
                values: new object[] { new DateTime(2023, 6, 6, 21, 24, 36, 720, DateTimeKind.Local).AddTicks(1641), new DateTime(2023, 5, 22, 21, 24, 36, 720, DateTimeKind.Local).AddTicks(1639) });

            migrationBuilder.UpdateData(
                table: "Tbl_Eventos",
                keyColumn: "id_evento",
                keyValue: 3,
                columns: new[] { "fechaFin", "fechaInicio" },
                values: new object[] { new DateTime(2024, 5, 22, 21, 24, 36, 720, DateTimeKind.Local).AddTicks(1647), new DateTime(2023, 5, 22, 21, 24, 36, 720, DateTimeKind.Local).AddTicks(1646) });

            migrationBuilder.UpdateData(
                table: "Tbl_Eventos",
                keyColumn: "id_evento",
                keyValue: 4,
                columns: new[] { "fechaFin", "fechaInicio" },
                values: new object[] { new DateTime(2023, 5, 27, 21, 24, 36, 720, DateTimeKind.Local).AddTicks(1653), new DateTime(2023, 5, 22, 21, 24, 36, 720, DateTimeKind.Local).AddTicks(1651) });

            migrationBuilder.UpdateData(
                table: "Tbl_Posts",
                keyColumn: "id_post",
                keyValue: 1,
                columns: new[] { "descripcion", "titulo" },
                values: new object[] { "Descripcion del post1", "Plan2" });

            migrationBuilder.UpdateData(
                table: "Tbl_Posts",
                keyColumn: "id_post",
                keyValue: 2,
                column: "titulo",
                value: "Plan1");

            migrationBuilder.UpdateData(
                table: "Tbl_Posts",
                keyColumn: "id_post",
                keyValue: 3,
                columns: new[] { "descripcion", "titulo" },
                values: new object[] { "Descripcion del post3", "Plan3" });

            migrationBuilder.UpdateData(
                table: "Tbl_Posts",
                keyColumn: "id_post",
                keyValue: 4,
                columns: new[] { "descripcion", "titulo" },
                values: new object[] { "Descripcion del post4", "Plan4" });
        }
    }
}
