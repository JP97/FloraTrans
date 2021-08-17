using Microsoft.EntityFrameworkCore.Migrations;

namespace FloraTrans.Migrations
{
    public partial class reworkedcontainer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Free",
                table: "Container",
                newName: "Available");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Available",
                table: "Container",
                newName: "Free");
        }
    }
}
