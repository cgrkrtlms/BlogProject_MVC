using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogProject.DataAccess.Migrations
{
    public partial class v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Articles_ArticleID",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_ArticleID",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "ArticleID",
                table: "Articles");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArticleID",
                table: "Articles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Articles_ArticleID",
                table: "Articles",
                column: "ArticleID");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Articles_ArticleID",
                table: "Articles",
                column: "ArticleID",
                principalTable: "Articles",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
