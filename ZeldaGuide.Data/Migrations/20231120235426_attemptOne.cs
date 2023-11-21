using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZeldaGuide.Data.Migrations
{
    /// <inheritdoc />
    public partial class attemptOne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "QuestId",
                table: "MainQuests",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "MainQuests",
                newName: "QuestId");
        }
    }
}
