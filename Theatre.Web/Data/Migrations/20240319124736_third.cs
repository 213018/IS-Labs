using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Theatre.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_AspNetUsers_TicketUserId",
                table: "Tickets");

            migrationBuilder.RenameColumn(
                name: "TicketUserId",
                table: "Tickets",
                newName: "UserId1");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_TicketUserId",
                table: "Tickets",
                newName: "IX_Tickets_UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_AspNetUsers_UserId1",
                table: "Tickets",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_AspNetUsers_UserId1",
                table: "Tickets");

            migrationBuilder.RenameColumn(
                name: "UserId1",
                table: "Tickets",
                newName: "TicketUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_UserId1",
                table: "Tickets",
                newName: "IX_Tickets_TicketUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_AspNetUsers_TicketUserId",
                table: "Tickets",
                column: "TicketUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
