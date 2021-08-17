using Microsoft.EntityFrameworkCore.Migrations;

namespace FloraTrans.Migrations
{
    public partial class currentclient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CurrentClient",
                table: "Container",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentClient",
                table: "Container");
        }
    }
}
