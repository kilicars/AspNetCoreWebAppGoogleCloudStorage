using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCoreWebApp.Migrations
{
    public partial class ImageFile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "TvShow",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "ImageStorageName",
                table: "TvShow",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageStorageName",
                table: "TvShow");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "TvShow",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
