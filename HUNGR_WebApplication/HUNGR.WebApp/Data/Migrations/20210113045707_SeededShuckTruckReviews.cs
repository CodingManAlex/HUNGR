using Microsoft.EntityFrameworkCore.Migrations;

namespace HUNGR.WebApp.Data.Migrations
{
    public partial class SeededShuckTruckReviews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Body", "FoodTruckId", "Rating", "Title", "UserId" },
                values: new object[] { 1, "This was an oyster experience unlink any Ive had before! These guys really know what they're doing! I'll be stopping by again very shortly!", "7ce48b1b-2e9d-4c80-8253-94bad98fce8c", 5, "Shucking Great", "8e378249-d83b-468b-b0ca-397174f18d1c" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Body", "FoodTruckId", "Rating", "Title", "UserId" },
                values: new object[] { 2, "These guys really know what they're doing! These were the best oysters I've ever had. Go show these boys some love!", "7ce48b1b-2e9d-4c80-8253-94bad98fce8c", 5, "Great Oyster", "bf3b32f9-332b-45fb-b5ee-da51fe3df482" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
