using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SneakersApp.Data.Migrations
{
    public partial class Collectionmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Shoes");

            migrationBuilder.AddColumn<int>(
                name: "CollectionID",
                table: "Shoes",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Collections",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collections", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Shoes_CollectionID",
                table: "Shoes",
                column: "CollectionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Shoes_Collections_CollectionID",
                table: "Shoes",
                column: "CollectionID",
                principalTable: "Collections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shoes_Collections_CollectionID",
                table: "Shoes");

            migrationBuilder.DropTable(
                name: "Collections");

            migrationBuilder.DropIndex(
                name: "IX_Shoes_CollectionID",
                table: "Shoes");

            migrationBuilder.DropColumn(
                name: "CollectionID",
                table: "Shoes");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Shoes",
                nullable: true);
        }
    }
}
