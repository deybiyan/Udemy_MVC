using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Udemy_MVC.Migrations
{
    /// <inheritdoc />
    public partial class AddIsSubcribe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsSubscribeToNewsLetter",
                table: "Customers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSubscribeToNewsLetter",
                table: "Customers");
        }
    }
}
