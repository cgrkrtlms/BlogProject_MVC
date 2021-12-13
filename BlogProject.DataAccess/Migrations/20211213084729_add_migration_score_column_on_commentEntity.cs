using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogProject.DataAccess.Migrations
{
    public partial class add_migration_score_column_on_commentEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArticleScore",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArticleScore",
                table: "Comments");
        }
    }
}
