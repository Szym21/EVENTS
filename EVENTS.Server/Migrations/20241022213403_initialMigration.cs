using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EventsAPI.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Events");

            migrationBuilder.CreateTable(
                name: "Event",
                schema: "Events",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EVENT_TYPE = table.Column<int>(type: "integer", nullable: false),
                    DATE = table.Column<DateOnly>(type: "date", nullable: false),
                    TIME = table.Column<TimeOnly>(type: "time without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EventType",
                schema: "Events",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NAME = table.Column<string>(type: "varchar(200)", nullable: false),
                    CAPACITY = table.Column<int>(type: "integer", nullable: false),
                    ARCHIVE = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EventUser",
                schema: "Events",
                columns: table => new
                {
                    USER_ID = table.Column<int>(type: "integer", nullable: false),
                    EVENT_ID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "User",
                schema: "Events",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FIRST_NAME = table.Column<string>(type: "varchar(50)", nullable: true),
                    LAST_NAME = table.Column<string>(type: "varchar(50)", nullable: true),
                    EMAIL = table.Column<string>(type: "varchar(50)", nullable: false),
                    PASSWORD = table.Column<string>(type: "varchar(50)", nullable: false),
                    ROLE = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventUser_USER_ID_EVENT_ID",
                schema: "Events",
                table: "EventUser",
                columns: new[] { "USER_ID", "EVENT_ID" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Event",
                schema: "Events");

            migrationBuilder.DropTable(
                name: "EventType",
                schema: "Events");

            migrationBuilder.DropTable(
                name: "EventUser",
                schema: "Events");

            migrationBuilder.DropTable(
                name: "User",
                schema: "Events");
        }
    }
}
