using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelListing.API.Migrations
{
    public partial class SeedingDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Rating",
                table: "Hotels",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryName", "ShortName" },
                values: new object[] { 1, "India", "IN" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryName", "ShortName" },
                values: new object[] { 2, "USA", "US" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryName", "ShortName" },
                values: new object[] { 3, "China", "CH" });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "CountryId", "Name", "Rating" },
                values: new object[,]
                {
                    { 7, "New Delhi", 1, "Leela Palace", 4.0999999999999996 },
                    { 8, "Udaipur", 1, "Fateh Collection", 3.7000000000000002 },
                    { 1, "New York", 2, "Baccarat Hotel", 5.0 },
                    { 2, "Washington", 2, "MayFlower Resorts", 4.0 },
                    { 3, "Bluffton", 2, "Montage Palmetto", 3.5 },
                    { 4, "Beijing", 3, "Fairmont Beijing", 3.0 },
                    { 5, "Guilin", 3, "Guilin Sapphire", 1.0 },
                    { 6, "Jiangsu", 3, "Grand Park Hotel Wuxi", 3.7000000000000002 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<string>(
                name: "Rating",
                table: "Hotels",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(double));
        }
    }
}
