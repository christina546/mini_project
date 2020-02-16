using Microsoft.EntityFrameworkCore.Migrations;

namespace MiniProject.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    vehicleType = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    make = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    model = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    engine = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    numDoors = table.Column<int>(type: "bigint", nullable: false),
                    numWheels = table.Column<int>(type: "bigint", nullable: false),
                    bodyType = table.Column<string>(type: "nvarchar(250)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
