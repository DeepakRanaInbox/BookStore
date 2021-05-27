using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStoreMvcCoreWebApp.Migrations
{
    public partial class addlanguagetable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MstLanguagesID",
                table: "TbBooks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MstLanguages",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    vName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vDiscription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MstLanguages", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TbBooks_MstLanguagesID",
                table: "TbBooks",
                column: "MstLanguagesID");

            migrationBuilder.AddForeignKey(
                name: "FK_TbBooks_MstLanguages_MstLanguagesID",
                table: "TbBooks",
                column: "MstLanguagesID",
                principalTable: "MstLanguages",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TbBooks_MstLanguages_MstLanguagesID",
                table: "TbBooks");

            migrationBuilder.DropTable(
                name: "MstLanguages");

            migrationBuilder.DropIndex(
                name: "IX_TbBooks_MstLanguagesID",
                table: "TbBooks");

            migrationBuilder.DropColumn(
                name: "MstLanguagesID",
                table: "TbBooks");
        }
    }
}
