using Microsoft.EntityFrameworkCore.Migrations;

namespace HUNGR.WebApp.Data.Migrations
{
    public partial class eventParticipantFoodTruckOnDelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventParticipants_FoodTrucks_FoodTruckId",
                table: "EventParticipants");

            migrationBuilder.AddForeignKey(
                name: "FK_EventParticipants_FoodTrucks_FoodTruckId",
                table: "EventParticipants",
                column: "FoodTruckId",
                principalTable: "FoodTrucks",
                principalColumn: "FoodTruckId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventParticipants_FoodTrucks_FoodTruckId",
                table: "EventParticipants");

            migrationBuilder.AddForeignKey(
                name: "FK_EventParticipants_FoodTrucks_FoodTruckId",
                table: "EventParticipants",
                column: "FoodTruckId",
                principalTable: "FoodTrucks",
                principalColumn: "FoodTruckId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
