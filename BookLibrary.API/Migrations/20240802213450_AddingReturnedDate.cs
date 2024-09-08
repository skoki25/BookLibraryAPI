using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookLibraryAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddingReturnedDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ReturnedDated",
                table: "BookBorrow",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReturnedDated",
                table: "BookBorrow");
        }
    }
}
