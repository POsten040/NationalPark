using Microsoft.EntityFrameworkCore.Migrations;

namespace NationalParkApi.Migrations
{
    public partial class SeedData3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "StateParks",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Region",
                table: "NationalParks",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "NationalParks",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "NationalParks",
                keyColumn: "NationalParkId",
                keyValue: 2,
                column: "Region",
                value: "Mid-West");

            migrationBuilder.UpdateData(
                table: "NationalParks",
                keyColumn: "NationalParkId",
                keyValue: 3,
                column: "Region",
                value: "East-Coast");

            migrationBuilder.UpdateData(
                table: "NationalParks",
                keyColumn: "NationalParkId",
                keyValue: 4,
                column: "Region",
                value: "East-Coast");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "StateParks",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Region",
                table: "NationalParks",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "NationalParks",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 60);

            migrationBuilder.UpdateData(
                table: "NationalParks",
                keyColumn: "NationalParkId",
                keyValue: 2,
                column: "Region",
                value: "South-West");

            migrationBuilder.UpdateData(
                table: "NationalParks",
                keyColumn: "NationalParkId",
                keyValue: 3,
                column: "Region",
                value: "East Coast");

            migrationBuilder.UpdateData(
                table: "NationalParks",
                keyColumn: "NationalParkId",
                keyValue: 4,
                column: "Region",
                value: "Moon");
        }
    }
}
