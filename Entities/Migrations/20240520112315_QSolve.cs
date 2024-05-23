using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entities.Migrations
{
    /// <inheritdoc />
    public partial class QSolve : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WEATHER",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    DATETIME = table.Column<DateTime>(type: "date", nullable: false),
                    TEMPERATURE_C = table.Column<double>(type: "double", nullable: false),
                    TEMPERATURE_F = table.Column<double>(type: "double", nullable: false),
                    SUMMARY = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false),
                    LATITUDE = table.Column<double>(type: "double", nullable: false),
                    LONGITUDE = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WEATHER", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WEATHER");
        }
    }
}
