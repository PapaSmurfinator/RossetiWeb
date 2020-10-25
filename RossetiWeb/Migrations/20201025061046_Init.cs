using Microsoft.EntityFrameworkCore.Migrations;

namespace RossetiWeb.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AscillogramCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AscillogramCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ascillograms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Time = table.Column<double>(nullable: false),
                    Value = table.Column<double>(nullable: false),
                    AscillogramCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ascillograms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ascillograms_AscillogramCategories_AscillogramCategoryId",
                        column: x => x.AscillogramCategoryId,
                        principalTable: "AscillogramCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ascillograms_AscillogramCategoryId",
                table: "Ascillograms",
                column: "AscillogramCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ascillograms");

            migrationBuilder.DropTable(
                name: "AscillogramCategories");
        }
    }
}
