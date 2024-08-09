using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookLibraryAPI.Migrations
{
    /// <inheritdoc />
    public partial class DataFill3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
    table: "Category",
    columns: new[] { "Id", "Type" },
    values: new object[,]
    {
                    { 1,  "Scifi" },
                    { 2,  "Fantasy" },
                    { 3,  "Roman" },
                    { 4,  "History" },
                    { 5,  "Documentarne" }
    });
            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "FirstName", "LastName", "Age" },
                values: new object[,]
                {
                    { 1,  "Erik","Gregor",32},
                    { 2,  "Lubos", "Kralik", 64 },
                    { 3,  "Roman", "Radiator", 22},
                    { 4,  "Milos", "Kutil",88 },
                    { 5,  "Dusan", "Plantol",66 }
                });
            migrationBuilder.InsertData(
                table: "BookInfo",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Title", "Description" },
                values: new object[,]
                {
                                { 1, 2, 2, "Harry Potter 1", "Description"},
                                { 2, 1, 1, "Vetrelci 1", "Description"},
                                { 3, 1, 1, "Vetrelci 2", "Description"},
                                { 4, 1, 1, "Vetrelci 3", "Description"},
                                { 5, 3, 3, "Sever Proti juhu 1", "Description"},
                                { 6, 3, 4, "Sever Proti juhu 2", "Description"},
                                { 7, 4, 3, "Sever Proti juhu 3", "Description"},
                });
            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "EanCode", "BookInfoId", "ISO", "PublicationDate" },
                values: new object[,]
                {
                    { 1, "9780272", 1, "ISO01578", RandomDay()},
                    { 2, "2524552", 1, "ISO52485", RandomDay()},
                    { 3, "4554771", 2, "ISO57857", RandomDay()},
                    { 4, "5825135", 2, "ISO47525", RandomDay()},
                    { 5, "8452415", 3, "ISO78578", RandomDay()},
                    { 6, "5185142", 4, "ISO45856", RandomDay()},
                    { 7, "7535176", 5, "ISO47847", RandomDay()},
                    { 8, "4865488", 5, "ISO55845", RandomDay()},
                    { 9, "8524825", 6, "ISO47578", RandomDay()},
                    {10, "7521625", 6, "ISO51417", RandomDay()},
                    {11, "7566216", 7, "ISO47475", RandomDay()},
                    {12, "3259385", 7, "ISO25758", RandomDay()},
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }

        DateTime RandomDay()
        {
            Random gen = new Random();
            DateTime start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range));
        }
    }
}
