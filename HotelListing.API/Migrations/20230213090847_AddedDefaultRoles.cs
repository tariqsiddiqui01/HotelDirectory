using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelListing.API.Migrations
{
    public partial class AddedDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9052be12-a090-4c52-86c2-eaa103123ada", "3d7ca07d-0baf-4474-be80-616da0e59958", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "140c3c6b-9f27-4259-b82b-940623ee488e", "6cc6aaf7-93e2-4474-a9e1-df4746e0882a", "user", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "140c3c6b-9f27-4259-b82b-940623ee488e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9052be12-a090-4c52-86c2-eaa103123ada");
        }
    }
}
