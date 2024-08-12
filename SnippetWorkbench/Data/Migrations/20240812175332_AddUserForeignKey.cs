using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SnippetWorkbench.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddUserForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Snippet",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Snippet_UserId",
                table: "Snippet",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Snippet_AspNetUsers_UserId",
                table: "Snippet",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Snippet_AspNetUsers_UserId",
                table: "Snippet");

            migrationBuilder.DropIndex(
                name: "IX_Snippet_UserId",
                table: "Snippet");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Snippet");
        }
    }
}
