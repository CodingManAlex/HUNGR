using Microsoft.EntityFrameworkCore.Migrations;

namespace HUNGR.WebApp.Data.Migrations
{
    public partial class userPic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserProfileImage",
                table: "Reviews",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserProfileImage",
                table: "Reviews");
        }
    }
}
