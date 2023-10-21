using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace Kanoo.Migrations
{
    /// <inheritdoc />
    public partial class TestMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Api",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    year = table.Column<int>(type: "int", nullable: false),
                    month = table.Column<int>(type: "int", nullable: false),
                    day = table.Column<int>(type: "int", nullable: false),
                    hour = table.Column<int>(type: "int", nullable: false),
                    minute = table.Column<int>(type: "int", nullable: false),
                    seconds = table.Column<int>(type: "int", nullable: false),
                    milliSeconds = table.Column<int>(type: "int", nullable: false),
                    dateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    date = table.Column<string>(type: "longtext", nullable: false),
                    time = table.Column<string>(type: "longtext", nullable: false),
                    timeZone = table.Column<string>(type: "longtext", nullable: false),
                    dayOfWeek = table.Column<string>(type: "longtext", nullable: false),
                    dstActive = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Api", x => x.id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Api");
        }
    }
}
