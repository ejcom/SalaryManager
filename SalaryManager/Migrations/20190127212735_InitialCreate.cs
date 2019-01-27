using Microsoft.EntityFrameworkCore.Migrations;

namespace SalaryManager.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Chiefs",
                columns: table => new
                {
                    ChiefId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chiefs", x => x.ChiefId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EmployeeName = table.Column<string>(nullable: true),
                    EmployeeDateOfEmployment = table.Column<string>(nullable: true),
                    EmployeeBaseSalaryRate = table.Column<int>(nullable: false),
                    ChiefId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employees_Chiefs_ChiefId",
                        column: x => x.ChiefId,
                        principalTable: "Chiefs",
                        principalColumn: "ChiefId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeGroups",
                columns: table => new
                {
                    EmployeeGroupId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EmployeeGroupName = table.Column<string>(nullable: true),
                    EmployeeId = table.Column<int>(nullable: false),
                    ChiefId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeGroups", x => x.EmployeeGroupId);
                    table.ForeignKey(
                        name: "FK_EmployeeGroups_Chiefs_ChiefId",
                        column: x => x.ChiefId,
                        principalTable: "Chiefs",
                        principalColumn: "ChiefId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeGroups_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeGroups_ChiefId",
                table: "EmployeeGroups",
                column: "ChiefId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeGroups_EmployeeId",
                table: "EmployeeGroups",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ChiefId",
                table: "Employees",
                column: "ChiefId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeGroups");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Chiefs");
        }
    }
}
