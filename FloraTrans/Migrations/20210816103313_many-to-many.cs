using Microsoft.EntityFrameworkCore.Migrations;

namespace FloraTrans.Migrations
{
    public partial class manytomany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Client_Contact_ContactID",
                table: "Client");

            migrationBuilder.DropForeignKey(
                name: "FK_Container_Client_ClientID",
                table: "Container");

            migrationBuilder.DropForeignKey(
                name: "FK_Container_Client_ClientID1",
                table: "Container");

            migrationBuilder.DropIndex(
                name: "IX_Container_ClientID1",
                table: "Container");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Warehouse",
                table: "Warehouse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contact",
                table: "Contact");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Client",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "ClientID1",
                table: "Container");

            migrationBuilder.RenameTable(
                name: "Warehouse",
                newName: "Warhouse");

            migrationBuilder.RenameTable(
                name: "Contact",
                newName: "Contacts");

            migrationBuilder.RenameTable(
                name: "Client",
                newName: "Clients");

            migrationBuilder.RenameIndex(
                name: "IX_Client_ContactID",
                table: "Clients",
                newName: "IX_Clients_ContactID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Warhouse",
                table: "Warhouse",
                column: "WareHouseID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contacts",
                table: "Contacts",
                column: "ContactID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clients",
                table: "Clients",
                column: "ClientID");

            migrationBuilder.CreateTable(
                name: "ContainerAssignment",
                columns: table => new
                {
                    ContainerID = table.Column<int>(type: "int", nullable: false),
                    ClientID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContainerAssignment", x => new { x.ContainerID, x.ClientID });
                    table.ForeignKey(
                        name: "FK_ContainerAssignment_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContainerAssignment_Container_ContainerID",
                        column: x => x.ContainerID,
                        principalTable: "Container",
                        principalColumn: "CCTag",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContainerAssignment_ClientID",
                table: "ContainerAssignment",
                column: "ClientID");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Contacts_ContactID",
                table: "Clients",
                column: "ContactID",
                principalTable: "Contacts",
                principalColumn: "ContactID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Container_Clients_ClientID",
                table: "Container",
                column: "ClientID",
                principalTable: "Clients",
                principalColumn: "ClientID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Contacts_ContactID",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Container_Clients_ClientID",
                table: "Container");

            migrationBuilder.DropTable(
                name: "ContainerAssignment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Warhouse",
                table: "Warhouse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contacts",
                table: "Contacts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clients",
                table: "Clients");

            migrationBuilder.RenameTable(
                name: "Warhouse",
                newName: "Warehouse");

            migrationBuilder.RenameTable(
                name: "Contacts",
                newName: "Contact");

            migrationBuilder.RenameTable(
                name: "Clients",
                newName: "Client");

            migrationBuilder.RenameIndex(
                name: "IX_Clients_ContactID",
                table: "Client",
                newName: "IX_Client_ContactID");

            migrationBuilder.AddColumn<int>(
                name: "ClientID1",
                table: "Container",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Warehouse",
                table: "Warehouse",
                column: "WareHouseID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contact",
                table: "Contact",
                column: "ContactID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Client",
                table: "Client",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_Container_ClientID1",
                table: "Container",
                column: "ClientID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Client_Contact_ContactID",
                table: "Client",
                column: "ContactID",
                principalTable: "Contact",
                principalColumn: "ContactID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Container_Client_ClientID",
                table: "Container",
                column: "ClientID",
                principalTable: "Client",
                principalColumn: "ClientID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Container_Client_ClientID1",
                table: "Container",
                column: "ClientID1",
                principalTable: "Client",
                principalColumn: "ClientID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
