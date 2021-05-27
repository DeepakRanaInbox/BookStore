using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStoreMvcCoreWebApp.Migrations
{
    public partial class addnewtablegallery : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TbBooks_MstLanguages_MstLanguagesID",
                table: "TbBooks");

            migrationBuilder.AlterColumn<int>(
                name: "MstLanguagesID",
                table: "TbBooks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "BookGallery",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BooksID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookGallery", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BookGallery_TbBooks_BooksID",
                        column: x => x.BooksID,
                        principalTable: "TbBooks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookGallery_BooksID",
                table: "BookGallery",
                column: "BooksID");

            migrationBuilder.AddForeignKey(
                name: "FK_TbBooks_MstLanguages_MstLanguagesID",
                table: "TbBooks",
                column: "MstLanguagesID",
                principalTable: "MstLanguages",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TbBooks_MstLanguages_MstLanguagesID",
                table: "TbBooks");

            migrationBuilder.DropTable(
                name: "BookGallery");

            migrationBuilder.AlterColumn<int>(
                name: "MstLanguagesID",
                table: "TbBooks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_TbBooks_MstLanguages_MstLanguagesID",
                table: "TbBooks",
                column: "MstLanguagesID",
                principalTable: "MstLanguages",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
