using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class add_new_class_notifcation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notifcations",
                columns: table => new
                {
                    NotifcationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NotifcationType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NotifcationTypeSymbol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NotifcationDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NotifcationStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifcations", x => x.NotifcationID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notifcations");
        }
    }
}
