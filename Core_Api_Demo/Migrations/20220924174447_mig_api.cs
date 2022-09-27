using Microsoft.EntityFrameworkCore.Migrations;

namespace Core_Api_Demo.Migrations
{
    public partial class mig_api : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Iscilers",
                columns: table => new
                {
                    IsciID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsciAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsciSoyad = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iscilers", x => x.IsciID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Iscilers");
        }
    }
}
