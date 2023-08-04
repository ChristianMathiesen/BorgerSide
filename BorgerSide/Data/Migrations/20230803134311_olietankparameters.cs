using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BorgerSide.Data.Migrations
{
    public partial class olietankparameters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ansoegning",
                table: "OlietankFormular",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Fabrikationsår",
                table: "OlietankFormular",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Registreringsnummer",
                table: "OlietankFormular",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Sloejfningsdato",
                table: "OlietankFormular",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Sloejfningsmetode",
                table: "OlietankFormular",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Stoerrelse",
                table: "OlietankFormular",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Typegodkendelsesnummer",
                table: "OlietankFormular",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ansoegning",
                table: "OlietankFormular");

            migrationBuilder.DropColumn(
                name: "Fabrikationsår",
                table: "OlietankFormular");

            migrationBuilder.DropColumn(
                name: "Registreringsnummer",
                table: "OlietankFormular");

            migrationBuilder.DropColumn(
                name: "Sloejfningsdato",
                table: "OlietankFormular");

            migrationBuilder.DropColumn(
                name: "Sloejfningsmetode",
                table: "OlietankFormular");

            migrationBuilder.DropColumn(
                name: "Stoerrelse",
                table: "OlietankFormular");

            migrationBuilder.DropColumn(
                name: "Typegodkendelsesnummer",
                table: "OlietankFormular");
        }
    }
}
