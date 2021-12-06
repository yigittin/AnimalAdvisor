using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalAdvisor.Data.Migrations
{
    public partial class categoryFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Species",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Species_CategoryId",
                table: "Species",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Species_Categories_CategoryId",
                table: "Species",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Species_Categories_CategoryId",
                table: "Species");

            migrationBuilder.DropIndex(
                name: "IX_Species_CategoryId",
                table: "Species");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Species");
        }
    }
}
