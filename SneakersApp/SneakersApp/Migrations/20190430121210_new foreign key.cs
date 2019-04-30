using Microsoft.EntityFrameworkCore.Migrations;

namespace SneakersApp.Migrations
{
    public partial class newforeignkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Collections_AspNetUsers_UserID",
                table: "Collections");

            migrationBuilder.DropForeignKey(
                name: "FK_Shoes_AspNetUsers_UserID",
                table: "Shoes");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Shoes",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Shoes_UserID",
                table: "Shoes",
                newName: "IX_Shoes_UserId");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Collections",
                newName: "UserId1");

            migrationBuilder.RenameIndex(
                name: "IX_Collections_UserID",
                table: "Collections",
                newName: "IX_Collections_UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Collections_AspNetUsers_UserId1",
                table: "Collections",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Shoes_AspNetUsers_UserId",
                table: "Shoes",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Collections_AspNetUsers_UserId1",
                table: "Collections");

            migrationBuilder.DropForeignKey(
                name: "FK_Shoes_AspNetUsers_UserId",
                table: "Shoes");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Shoes",
                newName: "UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Shoes_UserId",
                table: "Shoes",
                newName: "IX_Shoes_UserID");

            migrationBuilder.RenameColumn(
                name: "UserId1",
                table: "Collections",
                newName: "UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Collections_UserId1",
                table: "Collections",
                newName: "IX_Collections_UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Collections_AspNetUsers_UserID",
                table: "Collections",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Shoes_AspNetUsers_UserID",
                table: "Shoes",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
