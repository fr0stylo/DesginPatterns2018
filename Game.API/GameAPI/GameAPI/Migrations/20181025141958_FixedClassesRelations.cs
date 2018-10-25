using Microsoft.EntityFrameworkCore.Migrations;

namespace GameAPI.Migrations
{
    public partial class FixedClassesRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Baloons_Games_GameId",
                table: "Baloons");

            migrationBuilder.DropForeignKey(
                name: "FK_Towers_Games_GameId",
                table: "Towers");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Towers",
                newName: "TowerId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Baloons",
                newName: "BaloonId");

            migrationBuilder.AlterColumn<int>(
                name: "GameId",
                table: "Towers",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GameId",
                table: "Baloons",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Baloons_Games_GameId",
                table: "Baloons",
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
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Baloons_Games_GameId",
                table: "Baloons");

            migrationBuilder.DropForeignKey(
                name: "FK_Towers_Games_GameId",
                table: "Towers");

            migrationBuilder.RenameColumn(
                name: "TowerId",
                table: "Towers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "BaloonId",
                table: "Baloons",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "GameId",
                table: "Towers",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "GameId",
                table: "Baloons",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Baloons_Games_GameId",
                table: "Baloons",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Towers_Games_GameId",
                table: "Towers",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
