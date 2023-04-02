using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Factory.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Engineers_Machines_MachineId",
                table: "Engineers");

            migrationBuilder.DropIndex(
                name: "IX_Engineers_MachineId",
                table: "Engineers");

            migrationBuilder.DropColumn(
                name: "MachineId",
                table: "Engineers");

            migrationBuilder.CreateTable(
                name: "EngineerMachine",
                columns: table => new
                {
                    EngineersEngineerId = table.Column<int>(type: "int", nullable: false),
                    MachinesMachineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EngineerMachine", x => new { x.EngineersEngineerId, x.MachinesMachineId });
                    table.ForeignKey(
                        name: "FK_EngineerMachine_Engineers_EngineersEngineerId",
                        column: x => x.EngineersEngineerId,
                        principalTable: "Engineers",
                        principalColumn: "EngineerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EngineerMachine_Machines_MachinesMachineId",
                        column: x => x.MachinesMachineId,
                        principalTable: "Machines",
                        principalColumn: "MachineId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_EngineerMachine_MachinesMachineId",
                table: "EngineerMachine",
                column: "MachinesMachineId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EngineerMachine");

            migrationBuilder.AddColumn<int>(
                name: "MachineId",
                table: "Engineers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Engineers_MachineId",
                table: "Engineers",
                column: "MachineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Engineers_Machines_MachineId",
                table: "Engineers",
                column: "MachineId",
                principalTable: "Machines",
                principalColumn: "MachineId");
        }
    }
}
