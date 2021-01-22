using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NationalParkApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StateParks",
                columns: table => new
                {
                    StateParkId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Free = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateParks", x => x.StateParkId);
                });

            migrationBuilder.InsertData(
                table: "NationalParks",
                columns: new[] { "NationalParkId", "Name", "Region" },
                values: new object[,]
                {
                    { 1, "YellowStone", "Mid-West" },
                    { 2, "Zion", "South-West" },
                    { 3, "Blue Ridge", "East Coast" },
                    { 4, "Patrick's Park", "Moon" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StateParks");

            migrationBuilder.DeleteData(
                table: "NationalParks",
                keyColumn: "NationalParkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "NationalParks",
                keyColumn: "NationalParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "NationalParks",
                keyColumn: "NationalParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "NationalParks",
                keyColumn: "NationalParkId",
                keyValue: 4);
        }
    }
}
