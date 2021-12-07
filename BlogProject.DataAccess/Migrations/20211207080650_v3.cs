using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogProject.DataAccess.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArticleID",
                table: "Articles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WriterID",
                table: "Articles",
                type: "int",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Articles_ArticleID",
                table: "Articles",
                column: "ArticleID");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_WriterID",
                table: "Articles",
                column: "WriterID");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Articles_ArticleID",
                table: "Articles",
                column: "ArticleID",
                principalTable: "Articles",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Writers_WriterID",
                table: "Articles",
                column: "WriterID",
                principalTable: "Writers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Articles_ArticleID",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Writers_WriterID",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_ArticleID",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_WriterID",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "ArticleID",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "WriterID",
                table: "Articles");
        }
    }
}
