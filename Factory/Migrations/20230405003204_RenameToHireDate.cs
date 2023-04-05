using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Factory.Migrations
{
    public partial class RenameToHireDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EngineerDetails",
                table: "Engineers",
                newName: "HireDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
             migrationBuilder.RenameColumn(
                name: "HireDate",
                table: "Engineers",
                newName: "EngineerDetails");
        }
    }
}
