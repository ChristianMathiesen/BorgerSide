using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BorgerSide.Data.Migrations
{
    public partial class sløjfning : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ansoegning",
                table: "OlietankFormular");

            migrationBuilder.RenameColumn(
                name: "Stoerrelse",
                table: "OlietankFormular",
                newName: "Telefonnummer");

            migrationBuilder.RenameColumn(
                name: "Sloejfningsmetode",
                table: "OlietankFormular",
                newName: "Sløjfningsmetode");

            migrationBuilder.RenameColumn(
                name: "Sloejfningsdato",
                table: "OlietankFormular",
                newName: "Sløjfningsdato");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "OlietankFormular",
                newName: "Adresse");

            migrationBuilder.AddColumn<int>(
                name: "Størrelse",
                table: "OlietankFormular",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Størrelse",
                table: "OlietankFormular");

            migrationBuilder.RenameColumn(
                name: "Telefonnummer",
                table: "OlietankFormular",
                newName: "Stoerrelse");

            migrationBuilder.RenameColumn(
                name: "Sløjfningsmetode",
                table: "OlietankFormular",
                newName: "Sloejfningsmetode");

            migrationBuilder.RenameColumn(
                name: "Sløjfningsdato",
                table: "OlietankFormular",
                newName: "Sloejfningsdato");

            migrationBuilder.RenameColumn(
                name: "Adresse",
                table: "OlietankFormular",
                newName: "Email");

            migrationBuilder.AddColumn<string>(
                name: "Ansoegning",
                table: "OlietankFormular",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
