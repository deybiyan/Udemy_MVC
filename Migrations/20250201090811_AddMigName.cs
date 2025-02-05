using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Udemy_MVC.Migrations
{
    /// <inheritdoc />
    public partial class AddMigName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.UpdateData(
                table: "MembershipType",
                keyColumn: "Id",
                keyValues: [1, 2, 3, 4],
                column: "Name",
                values: new object[] {
                    "Pay as you go",
                    "Monthly",
                    "Quarterly",
                    "Yearly" });
               
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
