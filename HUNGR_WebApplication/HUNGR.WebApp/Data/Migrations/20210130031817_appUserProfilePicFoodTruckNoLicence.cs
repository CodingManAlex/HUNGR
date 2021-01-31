using Microsoft.EntityFrameworkCore.Migrations;

namespace HUNGR.WebApp.Data.Migrations
{
    public partial class appUserProfilePicFoodTruckNoLicence : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Licence",
                table: "FoodTrucks");

            migrationBuilder.AddColumn<string>(
                name: "ProfileImage",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfileImage",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "Licence",
                table: "FoodTrucks",
                type: "int",
                nullable: true);
        }
    }
}
