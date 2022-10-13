using Microsoft.EntityFrameworkCore.Migrations;

namespace UploadStreamMusic.Data.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "path",
                table: "Music",
                newName: "Path");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Music",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "image",
                table: "Music",
                newName: "Image");

            migrationBuilder.RenameColumn(
                name: "author",
                table: "Music",
                newName: "Author");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Music",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Path",
                table: "Music",
                newName: "path");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Music",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Music",
                newName: "image");

            migrationBuilder.RenameColumn(
                name: "Author",
                table: "Music",
                newName: "author");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Music",
                newName: "id");
        }
    }
}
