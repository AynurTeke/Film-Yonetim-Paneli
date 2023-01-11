using Microsoft.EntityFrameworkCore.Migrations;

namespace filmUygulamasi.Migrations
{
    public partial class arrangement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "salonAd",
                table: "salons",
                type: "nchar(250)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "filmAd",
                table: "films",
                type: "nchar(250)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "salonAd",
                table: "salons",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nchar(250)");

            migrationBuilder.AlterColumn<string>(
                name: "filmAd",
                table: "films",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nchar(250)");
        }
    }
}
