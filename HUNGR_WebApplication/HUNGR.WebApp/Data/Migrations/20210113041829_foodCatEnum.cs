using Microsoft.EntityFrameworkCore.Migrations;

namespace HUNGR.WebApp.Data.Migrations
{
    public partial class foodCatEnum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserFavouriteFoods",
                table: "UserFavouriteFoods");

            migrationBuilder.AlterColumn<string>(
                name: "FoodCategoryId",
                table: "UserFavouriteFoods",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "FoodCat",
                table: "UserFavouriteFoods",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FoodCat",
                table: "FoodTrucks",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserFavouriteFoods",
                table: "UserFavouriteFoods",
                columns: new[] { "Id", "FoodCat" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserFavouriteFoods",
                table: "UserFavouriteFoods");

            migrationBuilder.DropColumn(
                name: "FoodCat",
                table: "UserFavouriteFoods");

            migrationBuilder.DropColumn(
                name: "FoodCat",
                table: "FoodTrucks");

            migrationBuilder.AlterColumn<string>(
                name: "FoodCategoryId",
                table: "UserFavouriteFoods",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserFavouriteFoods",
                table: "UserFavouriteFoods",
                columns: new[] { "Id", "FoodCategoryId" });
        }
    }
}
