using Microsoft.EntityFrameworkCore.Migrations;

namespace SamverkandeAPI.Migrations.AnnonsDb
{
    public partial class Annonser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ads",
                columns: table => new
                {
                    Ad_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad_Annonsor = table.Column<int>(type: "int", nullable: false),
                    Ad_Rubrik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ad_Innehall = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ad_VaransPris = table.Column<int>(type: "int", nullable: false),
                    Ad_AnnonsPris = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ads", x => x.Ad_Id);
                });

            migrationBuilder.CreateTable(
                name: "Annonsorer",
                columns: table => new
                {
                    An_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    An_Fornamn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    An_Efternamn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    An_Foretagsnamn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    An_Organisationsnummer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    An_Utdelningsadress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    An_UPostnummer = table.Column<int>(type: "int", nullable: false),
                    An_UOrt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fakturaadress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    An_FPostnummer = table.Column<int>(type: "int", nullable: false),
                    An_FOrt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    An_Epost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    An_Mobil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    An_Personnummer = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Annonsorer", x => x.An_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ads");

            migrationBuilder.DropTable(
                name: "Annonsorer");
        }
    }
}
