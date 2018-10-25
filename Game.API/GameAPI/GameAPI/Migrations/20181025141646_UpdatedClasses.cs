using Microsoft.EntityFrameworkCore.Migrations;

namespace GameAPI.Migrations
{
    public partial class UpdatedClasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlayerId",
                table: "Towers");

            migrationBuilder.DropColumn(
                name: "PlayerId",
                table: "Baloons");

            migrationBuilder.AddColumn<bool>(
                name: "DefendPlayer1",
                table: "Towers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "DefendPlayer2",
                table: "Towers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "GameId",
                table: "Towers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Towers",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "AttackPlayer1",
                table: "Baloons",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AttackPlayer2",
                table: "Baloons",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "GameId",
                table: "Baloons",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Baloons",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Towers_GameId",
                table: "Towers",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_GameId",
                table: "Players",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Baloons_GameId",
                table: "Baloons",
                column: "GameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Baloons_Games_GameId",
                table: "Baloons",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Games_GameId",
                table: "Players",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Towers_Games_GameId",
                table: "Towers",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Baloons_Games_GameId",
                table: "Baloons");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_Games_GameId",
                table: "Players");

            migrationBuilder.DropForeignKey(
                name: "FK_Towers_Games_GameId",
                table: "Towers");

            migrationBuilder.DropIndex(
                name: "IX_Towers_GameId",
                table: "Towers");

            migrationBuilder.DropIndex(
                name: "IX_Players_GameId",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Baloons_GameId",
                table: "Baloons");

            migrationBuilder.DropColumn(
                name: "DefendPlayer1",
                table: "Towers");

            migrationBuilder.DropColumn(
                name: "DefendPlayer2",
                table: "Towers");

            migrationBuilder.DropColumn(
                name: "GameId",
                table: "Towers");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Towers");

            migrationBuilder.DropColumn(
                name: "AttackPlayer1",
                table: "Baloons");

            migrationBuilder.DropColumn(
                name: "AttackPlayer2",
                table: "Baloons");

            migrationBuilder.DropColumn(
                name: "GameId",
                table: "Baloons");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Baloons");

            migrationBuilder.AddColumn<int>(
                name: "PlayerId",
                table: "Towers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PlayerId",
                table: "Baloons",
                nullable: false,
                defaultValue: 0);
        }
    }
}
