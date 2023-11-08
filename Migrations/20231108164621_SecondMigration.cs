using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kanoo.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HotelName",
                table: "Stays",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "Cars",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<int>(
                name: "RegionId",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cars_RegionId",
                table: "Cars",
                column: "RegionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Destinations_RegionId",
                table: "Cars",
                column: "RegionId",
                principalTable: "Destinations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Destinations_RegionId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_RegionId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "HotelName",
                table: "Stays");

            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "RegionId",
                table: "Cars");
        }
    }
}
