using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BorgerSide.Data.Migrations
{
    public partial class addPrægeplade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Prægeplade",
                table: "OlietankFormular",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Prægeplade",
                table: "OlietankFormular");
        }
    }
}
