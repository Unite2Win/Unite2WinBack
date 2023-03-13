using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendU2W.Migrations
{
    /// <inheritdoc />
    public partial class AniadirTablaPerfilesDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Perfiles_create_date",
                table: "Tbl_Usuarios");

            migrationBuilder.DropColumn(
                name: "Perfiles_delete_date",
                table: "Tbl_Usuarios");

            migrationBuilder.DropColumn(
                name: "Perfiles_last_modified",
                table: "Tbl_Usuarios");

            migrationBuilder.DropColumn(
                name: "borradoPorId",
                table: "Tbl_Usuarios");

            migrationBuilder.DropColumn(
                name: "modificadoPorId",
                table: "Tbl_Usuarios");

            migrationBuilder.CreateTable(
                name: "Tbl_Perfiles",
                columns: table => new
                {
                    id_perfil = table.Column<int>(type: "int", nullable: false),
                    modificadoPorId = table.Column<long>(type: "bigint", nullable: true),
                    borradoPorId = table.Column<long>(type: "bigint", nullable: true),
                    create_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    last_modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    delete_date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Perfiles", x => x.id_perfil);
                    table.ForeignKey(
                        name: "FK_Tbl_Perfiles_Tbl_Usuarios_id_perfil",
                        column: x => x.id_perfil,
                        principalTable: "Tbl_Usuarios",
                        principalColumn: "id_usu",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_Perfiles");

            migrationBuilder.AddColumn<DateTime>(
                name: "Perfiles_create_date",
                table: "Tbl_Usuarios",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Perfiles_delete_date",
                table: "Tbl_Usuarios",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Perfiles_last_modified",
                table: "Tbl_Usuarios",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "borradoPorId",
                table: "Tbl_Usuarios",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "modificadoPorId",
                table: "Tbl_Usuarios",
                type: "bigint",
                nullable: true);
        }
    }
}
