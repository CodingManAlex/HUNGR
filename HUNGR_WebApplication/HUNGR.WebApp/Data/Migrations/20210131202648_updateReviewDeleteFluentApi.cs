using Microsoft.EntityFrameworkCore.Migrations;

namespace HUNGR.WebApp.Data.Migrations
{
    public partial class updateReviewDeleteFluentApi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_FoodTrucks_FoodTruckId",
                table: "Reviews");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_FoodTrucks_FoodTruckId",
                table: "Reviews",
                column: "FoodTruckId",
                principalTable: "FoodTrucks",
                principalColumn: "FoodTruckId",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_FoodTrucks_FoodTruckId",
                table: "Reviews");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_FoodTrucks_FoodTruckId",
                table: "Reviews",
                column: "FoodTruckId",
                principalTable: "FoodTrucks",
                principalColumn: "FoodTruckId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
