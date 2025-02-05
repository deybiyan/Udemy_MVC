using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Udemy_MVC.Migrations
{
    /// <inheritdoc />
    public partial class PopuMem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          
        
            migrationBuilder.RenameColumn(
                name: "MembershipTypeId",
                table: "MembershipType",
                newName: "Id");
        
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
