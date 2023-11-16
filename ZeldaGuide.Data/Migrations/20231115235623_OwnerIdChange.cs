using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZeldaGuide.Data.Migrations
{
    /// <inheritdoc />
    public partial class OwnerIdChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ToDos_Users_OwnerId",
                table: "ToDos");

            migrationBuilder.RenameColumn(
                name: "OwnerId",
                table: "ToDos",
                newName: "Owner");

            migrationBuilder.RenameIndex(
                name: "IX_ToDos_OwnerId",
                table: "ToDos",
                newName: "IX_ToDos_Owner");

            migrationBuilder.AddForeignKey(
                name: "FK_ToDos_Users_Owner",
                table: "ToDos",
                column: "Owner",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ToDos_Users_Owner",
                table: "ToDos");

            migrationBuilder.RenameColumn(
                name: "Owner",
                table: "ToDos",
                newName: "OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_ToDos_Owner",
                table: "ToDos",
                newName: "IX_ToDos_OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_ToDos_Users_OwnerId",
                table: "ToDos",
                column: "OwnerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
