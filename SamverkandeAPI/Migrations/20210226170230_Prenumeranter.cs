using Microsoft.EntityFrameworkCore.Migrations;

namespace SamverkandeAPI.Migrations
{
    public partial class Prenumeranter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prenumeranter",
                columns: table => new
                {
                    Pr_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pr_Fornamn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pr_Efternamn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pr_Utdelningsadress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pr_Postnummer = table.Column<int>(type: "int", nullable: false),
                    Pr_Ort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pr_Epost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pr_Mobil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pr_Personnummer = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prenumeranter", x => x.Pr_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prenumeranter");
        }
    }
}
