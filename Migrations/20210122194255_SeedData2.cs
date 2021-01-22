using Microsoft.EntityFrameworkCore.Migrations;

namespace NationalParkApi.Migrations
{
    public partial class SeedData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "StateParks",
                columns: new[] { "StateParkId", "Free", "Name" },
                values: new object[,]
                {
                    { 1, true, "Hammock" },
                    { 2, false, "Fort Pierce" },
                    { 3, false, "Bear Creek" },
                    { 4, false, "Patrick's Other Park" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StateParks",
                keyColumn: "StateParkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StateParks",
                keyColumn: "StateParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StateParks",
                keyColumn: "StateParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StateParks",
                keyColumn: "StateParkId",
                keyValue: 4);
        }
    }
}
