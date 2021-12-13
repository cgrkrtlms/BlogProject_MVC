using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogProject.DataAccess.Migrations
{
    public partial class add_migration_ArticleRayting_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ArticleRaytings",
                columns: table => new
                {
                    ArticleRaytingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArticleID = table.Column<int>(type: "int", nullable: false),
                    ArticleTotalScore = table.Column<int>(type: "int", nullable: false),
                    ArticleRaytingCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleRaytings", x => x.ArticleRaytingID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleRaytings");
        }
    }
}
