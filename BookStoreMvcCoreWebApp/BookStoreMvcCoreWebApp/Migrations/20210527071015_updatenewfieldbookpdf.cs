using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStoreMvcCoreWebApp.Migrations
{
    public partial class updatenewfieldbookpdf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "bookpdfurl",
                table: "TbBooks",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "bookpdfurl",
                table: "TbBooks");
        }
    }
}
