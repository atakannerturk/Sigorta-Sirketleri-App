using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class passwordupdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Parola",
                table: "KullanıcıBilgis",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Parola",
                table: "KullanıcıBilgis");
        }
    }
}
