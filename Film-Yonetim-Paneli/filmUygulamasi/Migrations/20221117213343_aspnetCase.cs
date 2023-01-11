using Microsoft.EntityFrameworkCore.Migrations;

namespace filmUygulamasi.Migrations
{
    public partial class aspnetCase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "films",
                columns: table => new
                {
                    filmID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    filmAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    filmYapimYil = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_films", x => x.filmID);
                });

            migrationBuilder.CreateTable(
                name: "salons",
                columns: table => new
                {
                    salonID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    salonAd = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_salons", x => x.salonID);
                });

            migrationBuilder.CreateTable(
                name: "filmSalons",
                columns: table => new
                {
                    filmSalonID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    filmID = table.Column<int>(type: "int", nullable: false),
                    salonID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_filmSalons", x => x.filmSalonID);
                    table.ForeignKey(
                        name: "FK_filmSalons_films_filmID",
                        column: x => x.filmID,
                        principalTable: "films",
                        principalColumn: "filmID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_filmSalons_salons_salonID",
                        column: x => x.salonID,
                        principalTable: "salons",
                        principalColumn: "salonID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_filmSalons_filmID",
                table: "filmSalons",
                column: "filmID");

            migrationBuilder.CreateIndex(
                name: "IX_filmSalons_salonID",
                table: "filmSalons",
                column: "salonID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "filmSalons");

            migrationBuilder.DropTable(
                name: "films");

            migrationBuilder.DropTable(
                name: "salons");
        }
    }
}
