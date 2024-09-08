using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookLibraryAPI.Migrations
{
    /// <inheritdoc />
    public partial class addUniq2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ISO",
                table: "Book",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "EanCode",
                table: "Book",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Book_EanCode",
                table: "Book",
                column: "EanCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Book_ISO",
                table: "Book",
                column: "ISO",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Book_EanCode",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_Book_ISO",
                table: "Book");

            migrationBuilder.AlterColumn<string>(
                name: "ISO",
                table: "Book",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "EanCode",
                table: "Book",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
