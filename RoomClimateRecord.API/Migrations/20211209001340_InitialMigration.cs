using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoomClimateRecord.API.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "records",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Stamp = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Motion = table.Column<bool>(type: "boolean", nullable: false),
                    Temperature = table.Column<short>(type: "smallint", nullable: false),
                    Humidity = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_records", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "records");
        }
    }
}
