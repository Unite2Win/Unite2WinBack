using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendU2W.Migrations
{
    /// <inheritdoc />
    public partial class ComunidadPublicaYVisibleDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isPublica",
                table: "Tbl_Comunidades",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isVisible",
                table: "Tbl_Comunidades",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Tbl_Comunidades",
                keyColumn: "id_com",
                keyValue: 1,
                columns: new[] { "isPublica", "isVisible" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tbl_Comunidades",
                keyColumn: "id_com",
                keyValue: 2,
                columns: new[] { "isPublica", "isVisible" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tbl_Comunidades",
                keyColumn: "id_com",
                keyValue: 3,
                columns: new[] { "isPublica", "isVisible" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tbl_Comunidades",
                keyColumn: "id_com",
                keyValue: 4,
                columns: new[] { "isPublica", "isVisible" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tbl_Eventos",
                keyColumn: "id_evento",
                keyValue: 1,
                columns: new[] { "fechaFin", "fechaInicio" },
                values: new object[] { new DateTime(2023, 6, 24, 17, 21, 59, 233, DateTimeKind.Local).AddTicks(1592), new DateTime(2023, 5, 24, 17, 21, 59, 233, DateTimeKind.Local).AddTicks(1590) });

            migrationBuilder.UpdateData(
                table: "Tbl_Eventos",
                keyColumn: "id_evento",
                keyValue: 2,
                columns: new[] { "fechaFin", "fechaInicio" },
                values: new object[] { new DateTime(2023, 6, 8, 17, 21, 59, 233, DateTimeKind.Local).AddTicks(1599), new DateTime(2023, 5, 24, 17, 21, 59, 233, DateTimeKind.Local).AddTicks(1597) });

            migrationBuilder.UpdateData(
                table: "Tbl_Eventos",
                keyColumn: "id_evento",
                keyValue: 3,
                columns: new[] { "fechaFin", "fechaInicio" },
                values: new object[] { new DateTime(2024, 5, 24, 17, 21, 59, 233, DateTimeKind.Local).AddTicks(1605), new DateTime(2023, 5, 24, 17, 21, 59, 233, DateTimeKind.Local).AddTicks(1604) });

            migrationBuilder.UpdateData(
                table: "Tbl_Eventos",
                keyColumn: "id_evento",
                keyValue: 4,
                columns: new[] { "fechaFin", "fechaInicio" },
                values: new object[] { new DateTime(2023, 5, 29, 17, 21, 59, 233, DateTimeKind.Local).AddTicks(1611), new DateTime(2023, 5, 24, 17, 21, 59, 233, DateTimeKind.Local).AddTicks(1609) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isPublica",
                table: "Tbl_Comunidades");

            migrationBuilder.DropColumn(
                name: "isVisible",
                table: "Tbl_Comunidades");

            migrationBuilder.UpdateData(
                table: "Tbl_Eventos",
                keyColumn: "id_evento",
                keyValue: 1,
                columns: new[] { "fechaFin", "fechaInicio" },
                values: new object[] { new DateTime(2023, 6, 24, 4, 26, 10, 216, DateTimeKind.Local).AddTicks(6334), new DateTime(2023, 5, 24, 4, 26, 10, 216, DateTimeKind.Local).AddTicks(6332) });

            migrationBuilder.UpdateData(
                table: "Tbl_Eventos",
                keyColumn: "id_evento",
                keyValue: 2,
                columns: new[] { "fechaFin", "fechaInicio" },
                values: new object[] { new DateTime(2023, 6, 8, 4, 26, 10, 216, DateTimeKind.Local).AddTicks(6341), new DateTime(2023, 5, 24, 4, 26, 10, 216, DateTimeKind.Local).AddTicks(6339) });

            migrationBuilder.UpdateData(
                table: "Tbl_Eventos",
                keyColumn: "id_evento",
                keyValue: 3,
                columns: new[] { "fechaFin", "fechaInicio" },
                values: new object[] { new DateTime(2024, 5, 24, 4, 26, 10, 216, DateTimeKind.Local).AddTicks(6347), new DateTime(2023, 5, 24, 4, 26, 10, 216, DateTimeKind.Local).AddTicks(6345) });

            migrationBuilder.UpdateData(
                table: "Tbl_Eventos",
                keyColumn: "id_evento",
                keyValue: 4,
                columns: new[] { "fechaFin", "fechaInicio" },
                values: new object[] { new DateTime(2023, 5, 29, 4, 26, 10, 216, DateTimeKind.Local).AddTicks(6352), new DateTime(2023, 5, 24, 4, 26, 10, 216, DateTimeKind.Local).AddTicks(6351) });
        }
    }
}
