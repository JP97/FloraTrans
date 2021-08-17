using Microsoft.EntityFrameworkCore.Migrations;

namespace FloraTrans.Migrations
{
    public partial class revertmanytomany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientID1",
                table: "Container",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Container_ClientID1",
                table: "Container",
                column: "ClientID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Container_Clients_ClientID1",
                table: "Container",
                column: "ClientID1",
                principalTable: "Clients",
                principalColumn: "ClientID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Container_Clients_ClientID1",
                table: "Container");

            migrationBuilder.DropIndex(
                name: "IX_Container_ClientID1",
                table: "Container");

            migrationBuilder.DropColumn(
                name: "ClientID1",
                table: "Container");
        }
    }
}
