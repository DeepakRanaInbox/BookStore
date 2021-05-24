using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStoreMvcCoreWebApp.Migrations
{
    public partial class Update2NewFieldsInBook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "TbBooks",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedOn",
                table: "TbBooks",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "TbBooks");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "TbBooks");
        }
    }
}
