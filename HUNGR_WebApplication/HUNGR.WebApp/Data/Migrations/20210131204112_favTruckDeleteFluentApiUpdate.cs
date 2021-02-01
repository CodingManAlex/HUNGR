using Microsoft.EntityFrameworkCore.Migrations;

namespace HUNGR.WebApp.Data.Migrations
{
    public partial class favTruckDeleteFluentApiUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserFavouriteTrucks_FoodTrucks_FoodTruckId",
                table: "UserFavouriteTrucks");

            migrationBuilder.AddForeignKey(
                name: "FK_UserFavouriteTrucks_FoodTrucks_FoodTruckId",
                table: "UserFavouriteTrucks",
                column: "FoodTruckId",
                principalTable: "FoodTrucks",
                principalColumn: "FoodTruckId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserFavouriteTrucks_FoodTrucks_FoodTruckId",
                table: "UserFavouriteTrucks");

            migrationBuilder.AddForeignKey(
                name: "FK_UserFavouriteTrucks_FoodTrucks_FoodTruckId",
                table: "UserFavouriteTrucks",
                column: "FoodTruckId",
                principalTable: "FoodTrucks",
                principalColumn: "FoodTruckId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
