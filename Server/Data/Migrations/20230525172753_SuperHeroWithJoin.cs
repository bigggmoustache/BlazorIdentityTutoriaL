using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorIdentityTutoriaL.Server.Data.Migrations
{
    public partial class SuperHeroWithJoin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "SuperHeroes",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SuperHeroes_ApplicationUserId",
                table: "SuperHeroes",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_SuperHeroes_AspNetUsers_ApplicationUserId",
                table: "SuperHeroes",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SuperHeroes_AspNetUsers_ApplicationUserId",
                table: "SuperHeroes");

            migrationBuilder.DropIndex(
                name: "IX_SuperHeroes_ApplicationUserId",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "SuperHeroes");
        }
    }
}
