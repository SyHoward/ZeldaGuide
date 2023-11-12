using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZeldaGuide.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddToDoFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OwnerId",
                table: "ToDos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ToDos_OwnerId",
                table: "ToDos",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_ToDos_Users_OwnerId",
                table: "ToDos",
                column: "OwnerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ToDos_Users_OwnerId",
                table: "ToDos");

            migrationBuilder.DropIndex(
                name: "IX_ToDos_OwnerId",
                table: "ToDos");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "ToDos");
        }
    }
}
