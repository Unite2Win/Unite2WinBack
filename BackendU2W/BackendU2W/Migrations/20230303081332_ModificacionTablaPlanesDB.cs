using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackendU2W.Migrations
{
    /// <inheritdoc />
    public partial class ModificacionTablaPlanesDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "Tbl_Planes",
                newName: "nombre");

            migrationBuilder.InsertData(
                table: "Tbl_Planes",
                columns: new[] { "id_plan", "create_date", "delete_date", "descripcion", "duracion", "id_com", "last_modified", "nombre" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Local), null, "Este es el plan1", 1, 3, null, "Plan1" },
                    { 2, new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Local), null, "Este es el plan2", 1, 2, null, "Plan2" },
                    { 3, new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Local), null, null, 0, 2, null, "Plan3" },
                    { 4, new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Local), null, "Este es el plan4", 2, 1, null, "Plan4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tbl_Planes",
                keyColumn: "id_plan",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tbl_Planes",
                keyColumn: "id_plan",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tbl_Planes",
                keyColumn: "id_plan",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tbl_Planes",
                keyColumn: "id_plan",
                keyValue: 4);

            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "Tbl_Planes",
                newName: "name");
        }
    }
}
