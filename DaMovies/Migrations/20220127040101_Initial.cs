using Microsoft.EntityFrameworkCore.Migrations;

namespace DaMovies.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "reponse",
                columns: new[] { "MovieID", "Category", "Director", "Edited", "Lent_To", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Action", "Christopher Nolan", false, "Jacob Marley", "na", "PG-13", "The Dark Knight", 2012 });

            migrationBuilder.InsertData(
                table: "reponse",
                columns: new[] { "MovieID", "Category", "Director", "Edited", "Lent_To", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Romance", "Anne Fletcher", false, "na", "na", "PG-13", "The Proposal", 2009 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "reponse",
                keyColumn: "MovieID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "reponse",
                keyColumn: "MovieID",
                keyValue: 3);
        }
    }
}
