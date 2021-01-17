using Microsoft.EntityFrameworkCore.Migrations;

namespace HUNGR.WebApp.Data.Migrations
{
    public partial class AddFavouriteTruckData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "UserFavouriteTrucks",
                columns: new[] { "Id", "FoodTruckId" },
                values: new object[] { "8e378249-d83b-468b-b0ca-397174f18d1c", "7ce48b1b-2e9d-4c80-8253-94bad98fce8c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserFavouriteTrucks",
                keyColumns: new[] { "Id", "FoodTruckId" },
                keyValues: new object[] { "8e378249-d83b-468b-b0ca-397174f18d1c", "7ce48b1b-2e9d-4c80-8253-94bad98fce8c" });
        }
    }
}
