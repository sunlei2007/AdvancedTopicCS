using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab3.Migrations
{
    /// <inheritdoc />
    public partial class create1703 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Routes",
                columns: table => new
                {
                    Number = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direction = table.Column<int>(type: "int", nullable: false),
                    RampAccessible = table.Column<bool>(type: "bit", nullable: false),
                    BicycleAccessible = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routes", x => x.Number);
                });

            migrationBuilder.CreateTable(
                name: "Stops",
                columns: table => new
                {
                    Number = table.Column<int>(type: "int", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direction = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stops", x => x.Number);
                });

            migrationBuilder.CreateTable(
                name: "StopSchedule",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StopNumber = table.Column<int>(type: "int", nullable: false),
                    RouteNumber = table.Column<int>(type: "int", nullable: false),
                    ScheduledArrival = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StopSchedule", x => x.ID);
                    table.ForeignKey(
                        name: "FK_StopSchedule_Routes_RouteNumber",
                        column: x => x.RouteNumber,
                        principalTable: "Routes",
                        principalColumn: "Number",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StopSchedule_Stops_StopNumber",
                        column: x => x.StopNumber,
                        principalTable: "Stops",
                        principalColumn: "Number",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StopSchedule_RouteNumber",
                table: "StopSchedule",
                column: "RouteNumber");

            migrationBuilder.CreateIndex(
                name: "IX_StopSchedule_StopNumber",
                table: "StopSchedule",
                column: "StopNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StopSchedule");

            migrationBuilder.DropTable(
                name: "Routes");

            migrationBuilder.DropTable(
                name: "Stops");
        }
    }
}
