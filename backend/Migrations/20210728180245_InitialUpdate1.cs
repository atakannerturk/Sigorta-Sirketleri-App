using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class InitialUpdate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Polices",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullanıcıID = table.Column<int>(type: "int", nullable: true),
                    policeturu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Polices", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Polices_KullanıcıBilgis_KullanıcıID",
                        column: x => x.KullanıcıID,
                        principalTable: "KullanıcıBilgis",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Polices_KullanıcıID",
                table: "Polices",
                column: "KullanıcıID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Polices");
        }
    }
}
