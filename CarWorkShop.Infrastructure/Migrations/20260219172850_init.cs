using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarWorkShop.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarWorkShops",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EncodedName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarWorkShops", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarWorkShopContactDetails",
                columns: table => new
                {
                    CarWorkShopId = table.Column<int>(type: "int", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarWorkShopContactDetails", x => x.CarWorkShopId);
                    table.ForeignKey(
                        name: "FK_CarWorkShopContactDetails_CarWorkShops_CarWorkShopId",
                        column: x => x.CarWorkShopId,
                        principalTable: "CarWorkShops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarWorkShopContactDetails");

            migrationBuilder.DropTable(
                name: "CarWorkShops");
        }
    }
}
