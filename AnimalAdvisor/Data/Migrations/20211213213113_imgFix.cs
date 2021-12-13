using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalAdvisor.Data.Migrations
{
    public partial class imgFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SpeciesPhoto",
                table: "Species",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SpeciesPhoto",
                table: "Species");
        }
    }
}
