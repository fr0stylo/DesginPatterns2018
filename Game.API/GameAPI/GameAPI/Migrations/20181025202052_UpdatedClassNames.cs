using Microsoft.EntityFrameworkCore.Migrations;

namespace GameAPI.Migrations
{
    public partial class UpdatedClassNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Players",
                newName: "PlayerId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Games",
                newName: "GameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PlayerId",
                table: "Players",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "GameId",
                table: "Games",
                newName: "Id");
        }
    }
}
