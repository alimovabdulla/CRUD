using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tests.Migrations
{
    public partial class NewColumsCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Text",
                table: "names",
                newName: "Soyad");

            migrationBuilder.AddColumn<string>(
                name: "Ad",
                table: "names",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ad",
                table: "names");

            migrationBuilder.RenameColumn(
                name: "Soyad",
                table: "names",
                newName: "Text");
        }
    }
}
