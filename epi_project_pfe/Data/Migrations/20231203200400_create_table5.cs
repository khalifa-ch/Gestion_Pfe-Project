using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace epi_project_pfe.Data.Migrations
{
    public partial class create_table5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Soutenance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Heure",
                table: "Soutenance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateD",
                table: "PFE",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateF",
                table: "PFE",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateNaiss",
                table: "Etudiant",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Soutenance");

            migrationBuilder.DropColumn(
                name: "Heure",
                table: "Soutenance");

            migrationBuilder.DropColumn(
                name: "DateD",
                table: "PFE");

            migrationBuilder.DropColumn(
                name: "DateF",
                table: "PFE");

            migrationBuilder.DropColumn(
                name: "DateNaiss",
                table: "Etudiant");
        }
    }
}
