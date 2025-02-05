using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Udemy_MVC.Migrations
{
    /// <inheritdoc />
    public partial class Correction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "MembershipType",
                newName: "MembershipTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MembershipTypeId",
                table: "MembershipType",
                newName: "Id");
        }
    }
}
