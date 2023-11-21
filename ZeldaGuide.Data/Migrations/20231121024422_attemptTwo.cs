using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZeldaGuide.Data.Migrations
{
    /// <inheritdoc />
    public partial class attemptTwo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ToDos_MainQuests_MainQuestId",
                table: "ToDos");

            migrationBuilder.RenameColumn(
                name: "MainQuestId",
                table: "ToDos",
                newName: "QuestId");

            migrationBuilder.RenameIndex(
                name: "IX_ToDos_MainQuestId",
                table: "ToDos",
                newName: "IX_ToDos_QuestId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "SideAdventures",
                newName: "AdventureId");

            migrationBuilder.AddForeignKey(
                name: "FK_ToDos_MainQuests_QuestId",
                table: "ToDos",
                column: "QuestId",
                principalTable: "MainQuests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ToDos_MainQuests_QuestId",
                table: "ToDos");

            migrationBuilder.RenameColumn(
                name: "QuestId",
                table: "ToDos",
                newName: "MainQuestId");

            migrationBuilder.RenameIndex(
                name: "IX_ToDos_QuestId",
                table: "ToDos",
                newName: "IX_ToDos_MainQuestId");

            migrationBuilder.RenameColumn(
                name: "AdventureId",
                table: "SideAdventures",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ToDos_MainQuests_MainQuestId",
                table: "ToDos",
                column: "MainQuestId",
                principalTable: "MainQuests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
